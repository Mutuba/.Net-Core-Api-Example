using Data.Entities;
using Microsoft.EntityFrameworkCore;
namespace Data;
 
public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Students> Students { get; set; }
}
