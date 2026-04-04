using Day01.DbMigrations.Context;
using Day01.DbMigrations.Models;

namespace Day01.DbMigrations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*------------------------------------------------------------------*/
            #region Context
            AppDbContext db = new AppDbContext();
            #endregion
            /*------------------------------------------------------------------*/
            #region GetAllDepartments
            //// Generic Repository Pattern
            //var departments = db.Set<Department>().ToList();
            #endregion
            /*------------------------------------------------------------------*/
            #region Migration
            // Add-Migration <MigrationName>
            // Add-Migration <V01>
            // Add-Migration <FirstCreate>

            // Updates the database to the last migration or to a specified migration.
            // Update-Database

            // Used To Delete The Last Migration That Was Added To The Project
            // Remove-Migration
            #endregion
            /*------------------------------------------------------------------*/
            #region Create Departments
            //Department d1 = new Department { DeptName = "IT" };
            //Department d2 = new Department { DeptName = "HR" };
            //Department d3 = new Department { DeptName = "SD" };
            //Department d4 = new Department { DeptName = "UI" };
            //Department d5 = new Department { DeptName = "UX" };
            ////db.AddRange(new Department[] { d1, d2, d3, d4, d5 });
            //db.AddRange(d1, d2, d3, d4, d5);
            //db.SaveChanges();
            #endregion
            /*------------------------------------------------------------------*/
            #region Create Employees
            //Employee e1 = new Employee { Name = "John Doe", Age = 30, Salary = 50000, DepartmentId = 1 };
            //Employee e2 = new Employee { Name = "Jane Smith", Age = 25, Salary = 45000, DepartmentId = 2 };
            //Employee e3 = new Employee { Name = "Bob Johnson", Age = 35, Salary = 55000, DepartmentId = 3 };
            //Employee e4 = new Employee { Name = "Alice Brown", Age = 28, Salary = 48000, DepartmentId = 4 };
            //Employee e5 = new Employee { Name = "Charlie Davis", Age = 32, Salary = 52000, DepartmentId = 5 };
            //db.AddRange(e1, e2, e3, e4, e5);
            //db.SaveChanges();
            #endregion
            /*------------------------------------------------------------------*/
            #region Guid
            //// 1F00D6E6-9C91-4B05-B163-08DE925A1692
            //TestGuid testGuid1 = new TestGuid { Name = "Test Guid 1" };
            //db.Add(testGuid1);
            //db.SaveChanges();

            //TestGuid testGuid2 = new TestGuid
            //{ 
            //    //Id = Guid.Parse("1F00D6E6-9C91-4B05-B163-08DE925A1692"),
            //    Id = Guid.NewGuid(),
            //    Name = "Test Guid 2"
            //};
            //db.Add(testGuid2);
            //db.SaveChanges();
            #endregion
            /*------------------------------------------------------------------*/
        }
    }
}
