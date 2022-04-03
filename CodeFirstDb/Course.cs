using System.ComponentModel.DataAnnotations;

namespace CodeFirstDb;

public class Course
{
    [Key] public int CourseNumber { get; set; }
    public string CourseName { get; set; }
    public int InstructorId { get; set; }
    public Instructor Instructor { get; set; }
    public List<Student> Students { get; set; }
    public List<Class> Classes { get; set; }
}