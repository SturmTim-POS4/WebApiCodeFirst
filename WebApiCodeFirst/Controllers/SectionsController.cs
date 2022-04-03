using CodeFirstDb;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiCodeFirst.Dtos;

namespace WebApiCodeFirst.Controllers;
[ApiController]
[Route("[controller]")]
public class SectionsController : ControllerBase
{
    private CourseContext _db;
    
    public SectionsController(CourseContext db)
    {
        _db = db;
    }
    
    [HttpGet("/Section/{id}/Classes")]
    public List<ClassDto> GetSectionClasses(int id) {
        Console.WriteLine($"GetSections");
        return _db.Classes
            .Include(x => x.Course)
            .Include(x => x.Section)
            .Where(x => x.SectionId == id)
            .Select(x => new ClassDto().ToDto(x))
            .ToList();
    }
    
    [HttpGet("/Section/[action]")]
    public List<SectionDto> GetSections() {
        Console.WriteLine($"GetSections");
        return _db.Sections
            .Include(x => x.Professor)
            .Select(x => new SectionDto().ToDto(x)).ToList();
    }
}