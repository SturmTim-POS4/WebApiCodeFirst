namespace CodeFirstDb;

public class Student
{
    public int StudentId { get; set; }
    public string StudentName { get; set; }
    public string StudentAddress { get; set; }
    public List<Course> Courses { get; set; }
}