using Data.Entities;

namespace Repositories;
public interface IStudentRepository
{
    Task<IEnumerable<Student>> GetAllAsync();
    Task<Student?> GetByIdAsync(int id);
    void Add(Student student);
    void Update(Student student);
    void Delete(Student student);
    Task SaveChangesAsync();
}

