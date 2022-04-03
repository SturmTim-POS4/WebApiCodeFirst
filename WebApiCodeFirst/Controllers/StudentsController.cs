using CodeFirstDb;
using Microsoft.AspNetCore.Mvc;
using WebApiCodeFirst.Dtos;

namespace WebApiCodeFirst.Controllers;
[ApiController]
[Route("[controller]")]
public class StudentsController : ControllerBase
{
    private CourseContext _db;
    
    public StudentsController(CourseContext db)
    {
        _db = db;
    }
    
    [HttpGet("/Students/[action]")]
    public List<StudentDto> GetStudents(string name) {
        Console.WriteLine($"GetSections");
        return _db.Students.Select(x => new StudentDto().ToDto(x))
            .ToList()
            .Where(x => x.StudentName.Contains(name))
            .ToList();
    }
    
    [HttpGet("/Students/[action]")]
    public List<StudentDto> StudentByAddress(string q) {
        Console.WriteLine($"GetSections");
        return _db.Students.Select(x => new StudentDto().ToDto(x))
            .ToList()
            .Where(x => x.StudentAddress.Contains(q))
            .ToList();
    }
}