using Day01.DbMigrations.Models;
using Microsoft.EntityFrameworkCore;

namespace Day01.DbMigrations.Context
{
    public class AppDbContext : DbContext
    {
        /*------------------------------------------------------------------*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=MOHAMED-HATEM\\SQLEXPRESS;DataBase=TantaD01Migration;Trusted_Connection=true;TrustServerCertificate=true";
            optionsBuilder.UseSqlServer(connectionString);
        }
        /*------------------------------------------------------------------*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var departments = new Department[]
            {
                new Department { Id = 1, DeptName = "IT" },
                new Department { Id = 2, DeptName = "HR" },
                new Department { Id = 3, DeptName = "SD" },
                new Department { Id = 4, DeptName = "UI" },
                new Department { Id = 5, DeptName = "UX" }
            };

            var employees = new Employee[]
            {
                new Employee { Id = 1, Name = "John Doe", Age = 30, Salary = 50000, DepartmentId = 1 },
                new Employee { Id = 2, Name = "Jane Smith", Age = 25, Salary = 45000, DepartmentId = 2 },
                new Employee { Id = 3, Name = "Bob Johnson", Age = 35, Salary = 55000, DepartmentId = 3 },
                new Employee { Id = 4, Name = "Alice Brown", Age = 28, Salary = 48000, DepartmentId = 4 },
                new Employee { Id = 5, Name = "Charlie Davis", Age = 32, Salary = 52000, DepartmentId = 5 }
            };

            modelBuilder.Entity<Department>().HasData(departments);
            modelBuilder.Entity<Employee>().HasData(employees);

            base.OnModelCreating(modelBuilder);
        }
        /*------------------------------------------------------------------*/
        // Configure Models That Map To Database Tables
        // Local Containers That Represent Database Tables
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<TestGuid> TestGuids { get; set; }
        /*------------------------------------------------------------------*/
    }
}
