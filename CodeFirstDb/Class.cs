using System.Reflection.Metadata.Ecma335;

namespace CodeFirstDb;

public class Class
{
    public int ClassId { get; set; }
    public string ClassName { get; set; }
    public int NumRegistered { get; set; }
    public DateTime ClassDateTime { get; set; }
    public int SectionId { get; set; }
    public Section Section { get; set; }
    public int CourseId { get; set; }
    public Course Course { get; set; }
}