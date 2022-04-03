using System.ComponentModel.DataAnnotations;

namespace CodeFirstDb;

public class Section
{
    [Key] public int SectionNumber { get; set; }
    public int ProfessorId { get; set; }
    public Professor Professor { get; set; }
    public List<Class> Classes { get; set; }
}