using System.ComponentModel.DataAnnotations;

namespace CodeFirstDb;

public class Instructor
{
    [Key] public int InstructorNo { get; set; }
    public string InstructorName { get; set; }
    public string InstructorFaculty { get; set; }
    public List<Course> Courses { get; set; }
}