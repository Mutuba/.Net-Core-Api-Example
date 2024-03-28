using Data.Entities;

namespace Repositories;
public interface IStudentRepository
{
    Task<IEnumerable<Students>> GetAllAsync();
    Task<Students?> GetByIdAsync(int id);
    void Add(Students student);
    void Update(Students student);
    void Delete(Students student);
    Task SaveChangesAsync();
}

