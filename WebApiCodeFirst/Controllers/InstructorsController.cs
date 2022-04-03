using CodeFirstDb;
using Microsoft.AspNetCore.Mvc;
using WebApiCodeFirst.Dtos;

namespace WebApiCodeFirst.Controllers;
[ApiController]
[Route("[controller]")]
public class InstructorsController : ControllerBase
{
    private CourseContext _db;
    
    public InstructorsController(CourseContext db)
    {
        _db = db;
    }
    
    [HttpGet("/Instroctor/[action]")]
    public List<InstructorDto> GetInstructors() {
        Console.WriteLine($"GetInstructors");
        return _db.Instructors.Select(x => new InstructorDto().ToDto(x)).ToList();
    }
}