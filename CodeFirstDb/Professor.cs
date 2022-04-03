namespace CodeFirstDb;

public class Professor
{
    public int Id { get; set; }
    public string ProfessorName { get; set; }
    public string ProfessorFaculty { get; set; }
    public List<Section> Sections { get; set; }
}