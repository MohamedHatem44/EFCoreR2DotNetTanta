using Day02.OneToOnePP.Models;
using Microsoft.EntityFrameworkCore;

namespace Day02.OneToOnePP.Context
{
    public class AppDbContext : DbContext
    {
        /*------------------------------------------------------------------*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=MOHAMED-HATEM\\SQLEXPRESS;DataBase=TantaD02OneToOnePP;Trusted_Connection=true;TrustServerCertificate=true";
            optionsBuilder.UseSqlServer(connectionString);
        }
        /*------------------------------------------------------------------*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Instuctor_Car>()
                .HasKey(ic => new { ic.InstructorId, ic.CarId });
            //modelBuilder.Entity<Instructor>()
            //    .HasOne(i => i.Instuctor_Car)
            //    .WithOne(c => c.Instructor)
            //    .HasForeignKey<Instuctor_Car>(c => c.InstructorId)
            //    .IsRequired()
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Car>()
            //    .HasOne(i => i.Instuctor_Car)
            //    .WithOne(c => c.Car)
            //    .HasForeignKey<Instuctor_Car>(c => c.CarId)
            //    .IsRequired()
            //    .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }
        /*------------------------------------------------------------------*/
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Instuctor_Car> Instuctor_Cars { get; set; }
        /*------------------------------------------------------------------*/
    }
}
