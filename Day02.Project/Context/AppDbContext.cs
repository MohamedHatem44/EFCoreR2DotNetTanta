using Day02.Project.Configuration;
using Day02.Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Day02.Project.Context
{
    public class AppDbContext : DbContext
    {
        /*------------------------------------------------------------------*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=MOHAMED-HATEM\\SQLEXPRESS;DataBase=TantaD02Project;Trusted_Connection=true;TrustServerCertificate=true";
            optionsBuilder.UseSqlServer(connectionString);
        }
        /*------------------------------------------------------------------*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student_Course>().HasKey(sc => new { sc.StudentId, sc.CourseId });

            #region Course Old
            //modelBuilder.Entity<Course>()
            //    .HasKey(c => c.Crs_Id);

            //modelBuilder.Entity<Course>()
            //    .Property(c => c.Crs_Name)
            //    .HasColumnName("CourseName")
            //    .HasMaxLength(100)
            //    .IsRequired();

            //modelBuilder.Entity<Course>()
            //    .Property(c => c.Crs_Description)
            //    .HasColumnName("CourseDescription")
            //    .HasMaxLength(500)
            //    .IsRequired(false);
            #endregion

            #region Course New
            modelBuilder.Entity<Course>(c =>
            {
                c.HasKey(c => c.Crs_Id);

                c.Property(c => c.Crs_Name)
                    .HasColumnName("CourseName")
                    .HasMaxLength(100)
                    .IsRequired();

                c.Property(c => c.Crs_Description)
                    .HasColumnName("CourseDescription")
                    .HasMaxLength(500)
                    .IsRequired(false);
            });
            #endregion

            // Configration Files
            //modelBuilder.ApplyConfiguration(new StudentConfigration());
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
        /*------------------------------------------------------------------*/
        // Tables
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Student_Course> Student_Courses { get; set; }
        /*------------------------------------------------------------------*/
    }
}
