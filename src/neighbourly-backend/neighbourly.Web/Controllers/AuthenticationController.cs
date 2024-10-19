using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Neighbourly.Web.Controllers.Models;

namespace neighbourly.Web.Controllers;

[Route("[controller]")]
public class AuthenticationController(SignInManager<IdentityUser> signInManager, IConfiguration configuration) : ControllerBase
{
    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequestModel model)
    {
        var result = await signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, lockoutOnFailure: false);

        if (result.Succeeded)
        {
            var token = GenerateJwtToken(model);
            return Ok(new { token });
        }
 
        return Unauthorized();
    }

    [Authorize]
    [HttpGet("has-access")]
    public IActionResult HasAccess()
    {
        return Ok(true);
    }

    private string GenerateJwtToken(LoginRequestModel model)
    {
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Authentication:JwtBearer:SecurityKey"]));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

        var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, model.Email),
            new Claim(JwtRegisteredClaimNames.Email, model.Email),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };
        
        var token = new JwtSecurityToken(claims: claims, expires: DateTime.Now.AddMinutes(120), signingCredentials: credentials);

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}
