using Microsoft.EntityFrameworkCore;

namespace CodeFirstDb;

public class CourseContext : DbContext
{
    protected CourseContext()
    {
    }

    public CourseContext(DbContextOptions<CourseContext> options) : base(options)
    {
    }
    
    public DbSet<Class> Classes { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Instructor> Instructors { get; set; }
    public DbSet<Professor> Professors { get; set; }
    public DbSet<Section> Sections { get; set; }
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            string connectionString = @"server=(LocalDB)\mssqllocaldb;attachdbfilename=C:\Temp\CodeFirstDb.mdf;database=Students;integrated security=True;MultipleActiveResultSets=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Seed();
    }
}