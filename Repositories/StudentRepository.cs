using Data;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Repositories;

public class StudentRepository : IStudentRepository
{
    private readonly ApplicationDbContext _dbContext;

    public StudentRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

public async Task<IEnumerable<Students>> GetAllAsync()
{
    List<Students> studentsList = await _dbContext.Students.ToListAsync();
    return studentsList;
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
