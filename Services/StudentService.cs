using Data.Entities;
using Repositories;
namespace Services;
public class StudentService(StudentRepository repository)
{
    private readonly StudentRepository _repository = repository;

    public Task<List<Students>> GetAllAsync()
    {
        return _repository.GetAllAsync();
    }

    public Task<Students?> GetByIdAsync(int id)
    {
        return _repository.GetByIdAsync(id);
    }

    public async Task<Students> AddAsync(Students student)
    {
        _repository.Add(student);
        await _repository.SaveChangesAsync();
        return student;
    }

    public async Task UpdateAsync(Students student)
    {
        _repository.Update(student);
        await _repository.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var student = await _repository.GetByIdAsync(id);
        if (student != null)
        {
            _repository.Delete(student);
            await _repository.SaveChangesAsync();
        }
    }
}
