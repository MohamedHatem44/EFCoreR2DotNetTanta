using Day01.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace Day01.Context
{
    public class AppDbContext : DbContext
    {
        /*------------------------------------------------------------------*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=MOHAMED-HATEM\\SQLEXPRESS;DataBase=TantaD01;Trusted_Connection=true;TrustServerCertificate=true";
            optionsBuilder.UseSqlServer(connectionString).UseLazyLoadingProxies();
        }
        /*------------------------------------------------------------------*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Employee>()
            //    .HasOne(e => e.Department)
            //    .WithMany(d => d.Employees)
            //    .HasForeignKey(e => e.DepartmentId)
            //    .IsRequired(false)
            //    .OnDelete(DeleteBehavior.NoAction);

            //modelBuilder.Entity<Department>()
            //    .HasMany(d => d.Employees)
            //    .WithOne(e => e.Department)
            //    .HasForeignKey(e => e.DepartmentId)
            //    .IsRequired(false)
            //    .OnDelete(DeleteBehavior.NoAction);
            // Keep
            base.OnModelCreating(modelBuilder);
        }
        /*------------------------------------------------------------------*/
        // Configure Models That Map To Database Tables
        // Local Containers That Represent Database Tables
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        /*------------------------------------------------------------------*/
    }
}
