namespace Neighbourly.Web.Controllers.Models;

public record LoginRequestModel(string Email, string Password, bool RememberMe);
