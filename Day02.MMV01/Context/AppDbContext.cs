using Day02.MMV01.Models;
using Microsoft.EntityFrameworkCore;

namespace Day02.MMV01.Context
{
    public class AppDbContext : DbContext
    {
        /*------------------------------------------------------------------*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=MOHAMED-HATEM\\SQLEXPRESS;DataBase=TantaD02MMV01;Trusted_Connection=true;TrustServerCertificate=true";
            optionsBuilder.UseSqlServer(connectionString);
        }
        /*------------------------------------------------------------------*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Instructor>()
            //    .HasMany(e => e.Courses)
            //    .WithMany(e => e.Instructors)
            //    .UsingEntity(
            //        "CourseInstructor",
            //        r => r.HasOne(typeof(Course)).WithMany().HasForeignKey("CourseId").HasPrincipalKey(nameof(Course.Id)),
            //        l => l.HasOne(typeof(Instructor)).WithMany().HasForeignKey("InstructorId").HasPrincipalKey(nameof(Instructor.Id)),
            //        j => j.HasKey("CourseId", "InstructorId"));
            base.OnModelCreating(modelBuilder);
        }
        /*------------------------------------------------------------------*/
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        /*------------------------------------------------------------------*/
    }
}
