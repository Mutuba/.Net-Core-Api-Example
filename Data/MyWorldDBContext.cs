using Data.Entities;
using Microsoft.EntityFrameworkCore;
namespace Data;
 
public class MyWorldDbContext(DbContextOptions<MyWorldDbContext> context) : DbContext(context)
{
    public DbSet<Students> Students { get; set; }
}
