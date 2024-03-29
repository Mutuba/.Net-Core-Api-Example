using Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace Data;
 
public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityUserContext<IdentityUser>(options)
{
    // Entity class in code to be mapped to database table
    public DbSet<Student> Students { get; set; }
}
