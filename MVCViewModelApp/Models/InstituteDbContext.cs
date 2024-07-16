using Microsoft.EntityFrameworkCore;

namespace MVCViewModelApp.Models
{
    public class InstituteDbContext : DbContext
    {
        public DbSet<Student> students { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<StudentCourseEnrollment> studentCourseEnrollments { get; set; }

        public InstituteDbContext(DbContextOptions<InstituteDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Data Source=DESKTOP-I46N7EU\\SQLEXPRESS;Initial Catalog=TestDb;Integrated Security=True;Trust Server Certificate=True";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}