using CodeFirstDb;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiCodeFirst.Dtos;

namespace WebApiCodeFirst.Controllers;

[ApiController]
[Route("[controller]")]
public class CourseController : ControllerBase
{
    private CourseContext _db;
    
    public CourseController(CourseContext db)
    {
        _db = db;
    }


    [HttpGet("/Courses/[action]")]
    public List<CourseDto> GetCourses() {
        Console.WriteLine($"GetCourses");
        return _db.Courses.Include(x => x.Students).Include(x => x.Classes)
            .Include(x => x.Instructor)
            .Select(x => new CourseDto().ToDto(x)).ToList();
    }

    [HttpGet("/Courses/[action]/{id}")]
    public CourseDto? GetCourse(int id) {
        Console.WriteLine($"GetCourse id={id}");
        return _db.Courses.Include(x => x.Students)
            .Include(x => x.Classes)
            .Include(x => x.Instructor)
            .Select(x => new CourseDto().ToDto(x))
            .ToList()
            .FirstOrDefault(x => x.CourseNumber == id);
    }
    
    [HttpGet("/Courses/{id}/Classes")]
    public List<ClassDto> GetCourseClasses(int id) {
        Console.WriteLine($"GetCourseClasses id={id}");
        return _db.Classes
            .Include(x => x.Course)
            .Include(x => x.Section)
            .Where(x => x.CourseId == id)
            .Select(x => new ClassDto().ToDto(x))
            .ToList();
    }
}