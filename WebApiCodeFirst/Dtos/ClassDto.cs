using CodeFirstDb;

namespace WebApiCodeFirst.Dtos;

public class ClassDto
{
    public int ClassId { get; set; }
    public string ClassName { get; set; }
    public DateTime ClassDateTime { get; set; }
    public string CourseName { get; set; }

    public ClassDto ToDto(Class from)
    {
        ClassId = from.ClassId;
        ClassName = from.ClassName;
        ClassDateTime = from.ClassDateTime;
        CourseName = from.Course.CourseName;
        return this;
    }
}