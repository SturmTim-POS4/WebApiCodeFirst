using Microsoft.EntityFrameworkCore;

namespace CodeFirstDb;

public static class DbSeederExtension
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        SeedInstructor(modelBuilder);
        SeedProfessors(modelBuilder);
        SeedStudents(modelBuilder);
        SeedSections(modelBuilder);
        SeedCourse(modelBuilder);
        SeedClass(modelBuilder);
    }
    
    private static void SeedInstructor(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Instructor>().HasData(new Instructor()
        {
            InstructorNo = 1,
            InstructorName = "Tim",
            InstructorFaculty = "Htl"
        });
        modelBuilder.Entity<Instructor>().HasData(new Instructor()
        {
            InstructorNo = 2,
            InstructorName = "Fabian",
            InstructorFaculty = "Htl"
        });
        modelBuilder.Entity<Instructor>().HasData(new Instructor()
        {
            InstructorNo = 3,
            InstructorName = "Tamara",
            InstructorFaculty = "Htl"
        });
    }
    
    private static void SeedProfessors(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Professor>().HasData(new Professor()
        {
            Id = 1,
            ProfessorName = "Franz",
            ProfessorFaculty = "Htl"
        });
        modelBuilder.Entity<Professor>().HasData(new Professor()
        {
            Id = 2,
            ProfessorName = "Simon",
            ProfessorFaculty = "Htl",
        });
        modelBuilder.Entity<Professor>().HasData(new Professor()
        {
            Id = 3,
            ProfessorName = "Klaus",
            ProfessorFaculty = "Htl",
        });
    }

    private static void SeedSections(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Section>().HasData(new Section()
        {
            SectionNumber = 1,
            ProfessorId = 1
        });
        modelBuilder.Entity<Section>().HasData(new Section()
        {
            SectionNumber = 2,
            ProfessorId = 1
        });
        modelBuilder.Entity<Section>().HasData(new Section()
        {
            SectionNumber = 3,
            ProfessorId = 3
        });
    }
    
    private static void SeedStudents(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>().HasData(new Student()
        {
            StudentId = 1,
            StudentAddress = "Granatstraße",
            StudentName = "Emma"
        });
        modelBuilder.Entity<Student>().HasData(new Student()
        {
            StudentId = 2,
            StudentAddress = "Linz",
            StudentName = "Marcel"
        });
    }

    private static void SeedCourse(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>().HasData(new Course()
        {
            CourseNumber = 1,
            InstructorId = 1,
            CourseName = "POS"
        });
        modelBuilder.Entity<Course>().HasData(new Course()
        {
            CourseNumber = 2,
            InstructorId = 2,
            CourseName = "DBI"
        });
        modelBuilder.Entity<Course>().HasData(new Course()
        {
            CourseNumber = 3,
            InstructorId = 1,
            CourseName = "GD"
        });
    }

    private static void SeedClass(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Class>().HasData(new Class()
        {
            ClassId = 1,
            ClassName = "1A",
            CourseId = 2,
            ClassDateTime = DateTime.Now,
            SectionId = 1,
            NumRegistered = 2
        });
        modelBuilder.Entity<Class>().HasData(new Class()
        {
            ClassId = 2,
            ClassName = "3A",
            CourseId = 3,
            ClassDateTime = DateTime.Parse("21.11.2003"),
            SectionId = 3,
            NumRegistered = 0
        });
    }
}