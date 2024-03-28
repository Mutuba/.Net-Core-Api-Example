using Data.Entities;
using Repositories;

namespace Services;
public class StudentService(IStudentRepository repository)
{
    private readonly IStudentRepository _repository = repository;

    public Task<IEnumerable<Students>> GetAllAsync()
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

