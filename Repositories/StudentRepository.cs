using Data;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
namespace Repositories;
public class StudentRepository(ApplicationDbContext dbContext)
{
    private readonly ApplicationDbContext _dbContext = dbContext;

    public Task<List<Students>> GetAllAsync()
    {
        return _dbContext.Students.ToListAsync();
    }

    public Task<Students?> GetByIdAsync(int id)
    {
        return _dbContext.Students.FindAsync(id).AsTask();
    }

    public void Add(Students student)
    {
        _dbContext.Students.Add(student);
    }

    public void Update(Students student)
    {
        _dbContext.Students.Update(student);
    }

    public void Delete(Students student)
    {
        _dbContext.Students.Remove(student);
    }

    public Task SaveChangesAsync()
    {
        return _dbContext.SaveChangesAsync();
    }
}
