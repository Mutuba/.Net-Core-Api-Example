using Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Services;
namespace Controllers;

[ApiController]
[Route("[controller]")]
public class StudentsController(StudentService service) : ControllerBase
{
    private readonly StudentService _service = service;

    [HttpGet]
    public async Task<ActionResult<Students>> GetStudents()
    {
        var students = await _service.GetAllAsync();
        return Ok(students);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Students>> GetStudentById(int id)
    {
        var student = await _service.GetByIdAsync(id);
        return student != null ? Ok(student) : NotFound();
    }

    [HttpPost]
    public async Task<ActionResult<Students>> CreateStudent(Students student)
    {
        var createdStudent = await _service.AddAsync(student);
        return CreatedAtAction(nameof(GetStudentById), new { id = createdStudent.Id }, createdStudent);
    }

    [HttpPut]
    public async Task<ActionResult<Students>> UpdateStudent(Students student)
    {
        await _service.UpdateAsync(student);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<Students>> DeleteStudent(int id)
    {
        await _service.DeleteAsync(id);
        return NoContent();
    }
}
