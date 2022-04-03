using CodeFirstDb;

namespace WebApiCodeFirst.Dtos;

public class StudentDto
{
    public int StudentId { get; set; }
    public string StudentName { get; set; }
    public string StudentAddress { get; set; }
    
    public StudentDto ToDto(Student from)
    {
        StudentId = from.StudentId;
        StudentName = from.StudentName;
        StudentAddress = from.StudentAddress;
        return this;
    }
}