using CodeFirstDb;

namespace WebApiCodeFirst.Dtos;

public class InstructorDto
{
    public int InstructorNo { get; set; }
    public string InstructorName { get; set; }
    
    public InstructorDto ToDto(Instructor from)
    {
        InstructorNo = from.InstructorNo;
        InstructorName = from.InstructorName;
        return this;
    }
}