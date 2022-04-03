using CodeFirstDb;

namespace WebApiCodeFirst.Dtos;

public class SectionDto
{
    public int SectionNumber { get; set; }
    public string ProfessorName { get; set; }
    
    public SectionDto ToDto(Section from)
    {
        SectionNumber = from.SectionNumber;
        ProfessorName = from.Professor.ProfessorName;
        return this;
    }
}