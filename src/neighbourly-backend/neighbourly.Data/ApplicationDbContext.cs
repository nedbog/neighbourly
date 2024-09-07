using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using neighbourly.Core.Neighbourhood.Domain;

namespace neighbourly.Web.Data;
public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<Neighbourhood> Neighbourhood { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Neighbourhood>().HasKey(neighbourhood => neighbourhood.Id);
        builder.Entity<Neighbourhood>().Property(neighbourhood => neighbourhood.Name).IsRequired();
        base.OnModelCreating(builder);
    }
}
