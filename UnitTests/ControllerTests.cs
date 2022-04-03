using CodeFirstDb;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using WebApiCodeFirst.Controllers;
using Xunit;

namespace UnitTests;

public class ControllerTests
{
    [Fact]
    public void InstructorGetTests()
    {
        InstructorsController instructorsController = new InstructorsController(new CourseContext(new DbContextOptions<CourseContext>()));
        instructorsController.GetInstructors().Count.Should().Be(3);
    }
    
    [Fact]
    public void StudentsGetTests()
    {
        StudentsController studentsController = new StudentsController(new CourseContext(new DbContextOptions<CourseContext>()));
        studentsController.GetStudents("E").Count.Should().Be(1);
        studentsController.StudentByAddress("G").Count.Should().Be(1);
    }
    
    [Fact]
    public void CourseGetTests()
    {
        CourseController courseController = new CourseController(new CourseContext(new DbContextOptions<CourseContext>()));
        courseController.GetCourse(1).CourseName.Should().Be("POS");
        courseController.GetCourses().Count.Should().Be(3);
        courseController.GetCourseClasses(2).Count.Should().Be(1);
    }
    
    [Fact]
    public void SectionGetTests()
    {
        SectionsController sectionsController = new SectionsController(new CourseContext(new DbContextOptions<CourseContext>()));
        sectionsController.GetSections().Count.Should().Be(3);
        sectionsController.GetSectionClasses(3).Count.Should().Be(1);
    }
}