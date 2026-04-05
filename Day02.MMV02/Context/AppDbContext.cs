using Day02.MMV02.Models;
using Microsoft.EntityFrameworkCore;

namespace Day02.MMV02.Context
{
    public class AppDbContext : DbContext
    {
        /*------------------------------------------------------------------*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=MOHAMED-HATEM\\SQLEXPRESS;DataBase=TantaD02MMV02;Trusted_Connection=true;TrustServerCertificate=true";
            optionsBuilder.UseSqlServer(connectionString);
        }
        /*------------------------------------------------------------------*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student_Course>()
                .HasKey(sc => new { sc.StudentId, sc.CourseId });

            // Identity => Asp.Identity
            // AppDbContext : IdentityDbContext (7) : DbContext
            //base.OnModelCreating(modelBuilder);
        }
        /*------------------------------------------------------------------*/
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Student_Course> Student_Courses { get; set; }
        /*------------------------------------------------------------------*/
    }
}
