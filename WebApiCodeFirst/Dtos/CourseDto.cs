using CodeFirstDb;

namespace WebApiCodeFirst.Dtos;

public class CourseDto
{
    public int CourseNumber { get; set; }
    public string CourseName { get; set; }
    public int NrClasses { get; set; }
    public int NrStudents { get; set; }
    public string InstructorName { get; set; }
    
    public CourseDto ToDto(Course from)
    {
        CourseNumber = from.CourseNumber;
        CourseName = from.CourseName;
        NrClasses = from.Classes.Count;
        InstructorName = from.Instructor.InstructorName;
        NrStudents = from.Students.Count;
        return this;
    }
}