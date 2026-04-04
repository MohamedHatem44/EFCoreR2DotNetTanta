using Azure;
using Day01.Context;
using Day01.Models;
using Microsoft.EntityFrameworkCore;

namespace Day01
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
            #region Db Creation Strategy
            //// 1- EnsureCreated
            //// 2- Migration

            //// Dev Only
            //// EnsureDeleted
            //// ensures that the database for the context does not exist.
            //// If it does not exist, no action is taken.
            //// If it does exist then the database is deleted.
            //db.Database.EnsureDeleted();

            //// EnsureCreated
            //// • If the database exists and has any tables, then no action is taken. Nothing
            //// is done to ensure the database schema is compatible with the Entity Framework
            //// model.
            //// • If the database exists but does not have any tables, then the Entity Framework
            //// model is used to create the database schema.
            //// • If the database does not exist, then the database is created and the Entity
            //// Framework model is used to create the database schema.
            //db.Database.EnsureCreated();
            #endregion
            /*------------------------------------------------------------------*/
            #region Employee
            //// 1- Create Employee 
            //Employee employee = new Employee
            //{
            //    Name = "John Doe",
            //    Age = 30,
            //    Salary = 50000,
            //};

            //// 2- Add Employee To Local Container
            ////db.Employees.Add(employee);
            //db.Add(employee);

            //// 3- Sync Local Container With Database
            //db.SaveChanges();
            #endregion
            /*------------------------------------------------------------------*/
            #region Department
            //Department department = new Department
            //{
            //    DeptName = "IT"
            //};
            ////db.Departments.Add(department);
            //db.Add(department);
            //db.SaveChanges();
            #endregion
            /*------------------------------------------------------------------*/
            #region Relation Between Employee Department 
            //db.Database.EnsureDeleted();
            //db.Database.EnsureCreated();

            //Department department = new Department
            //{
            //    DeptName = "IT"
            //};
            //db.Add(department);
            //db.SaveChanges();

            //// V01
            //Employee employee1 = new Employee
            //{
            //    Name = "John Doe",
            //    Age = 30,
            //    Salary = 50000,
            //    DepartmentId = 1
            //};
            //db.Add(employee1);
            //db.SaveChanges();

            //// V02
            //Department department = db.Departments.FirstOrDefault();
            //Employee employee2 = new Employee
            //{
            //    Name = "John Doe",
            //    Age = 30,
            //    Salary = 50000,
            //    Department = department
            //};
            //db.Add(employee2);
            //db.SaveChanges();
            #endregion
            /*------------------------------------------------------------------*/
            #region Relation Between Employee Department shadow foreign key
            //db.Database.EnsureDeleted();
            //db.Database.EnsureCreated();

            //Department department = new Department
            //{
            //    DeptName = "IT"
            //};
            //db.Add(department);
            //db.SaveChanges();

            //Employee employee1 = new Employee
            //{
            //    Name = "John Doe",
            //    Age = 30,
            //    Salary = 50000,
            //    Department = db.Departments.FirstOrDefault()
            //};
            //db.Add(employee1);
            //db.SaveChanges();
            #endregion
            /*------------------------------------------------------------------*/
            #region Crud Operations
            //db.Database.EnsureDeleted();
            //db.Database.EnsureCreated();

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

            #region Create Employees
            //Employee e1 = new Employee { Name = "John Doe", Age = 30, Salary = 50000, DepartmentId = 1 };
            //Employee e2 = new Employee { Name = "Jane Smith", Age = 25, Salary = 45000, DepartmentId = 2 };
            //Employee e3 = new Employee { Name = "Bob Johnson", Age = 35, Salary = 55000, DepartmentId = 3 };
            //Employee e4 = new Employee { Name = "Alice Brown", Age = 28, Salary = 48000, DepartmentId = 4 };
            //Employee e5 = new Employee { Name = "Charlie Davis", Age = 32, Salary = 52000, DepartmentId = 5 };
            //db.AddRange(e1, e2, e3, e4, e5);
            //db.SaveChanges();
            #endregion

            #region Get Employees
            ////SELECT [e].[Id], [e].[Age], [e].[DepartmentId], [e].[Name], [e].[Salary]
            ////FROM[Employees] AS[e]
            //var allEmployees = db.Employees.ToList();
            //foreach (var item in allEmployees)
            //{
            //    Console.WriteLine(item);
            //}

            ////SELECT TOP(1) [e].[Id], [e].[Age], [e].[DepartmentId], [e].[Name], [e].[Salary]
            ////FROM[Employees] AS[e]
            ////WHERE[e].[Id] = 1
            //var employee = db.Employees.FirstOrDefault(e => e.Id == 1);
            //if (employee != null)
            //{
            //    Console.WriteLine(employee);
            //}

            //// EagerLoading
            ////SELECT[e].[Id], [e].[Age], [e].[DepartmentId], [e].[Name], [e].[Salary], [d].[Id], [d].[DeptName]
            ////FROM[Employees] AS[e]
            ////INNER JOIN[Departments] AS[d] ON[e].[DepartmentId] = [d].[Id]
            //var allEmployees = db.Employees.Include(e => e.Department).ToList();
            //foreach (var item in allEmployees)
            //{
            //    Console.WriteLine(item);
            //}

            //// N + 1 Problem
            //var allEmployees = db.Employees.ToList();
            //foreach (var item in allEmployees)
            //{
            //    Console.WriteLine(item.Department);
            //}
            #endregion

            #region Update Employee
            //// V01 => Recommended
            //// 1- Catch Employee From Database
            //var employeeToUpdate1 = db.Employees.FirstOrDefault(e => e.Id == 1);
            //if (employeeToUpdate1 != null)
            //{
            //    // Update Employee Name
            //    employeeToUpdate1.Name = "Updated Name";
            //    db.SaveChanges();
            //}

            //// V02
            //var employeeToUpdate2 = new Employee      
            //{
            //    Id = 1,
            //    Name = "Updated 2",
            //    DepartmentId = 1
            //};
            //db.Update(employeeToUpdate2);
            //db.SaveChanges();
            #endregion

            #region Delete Employee
            //// 1- Catch Employee From Database
            //var employeeToDelete = db.Employees.FirstOrDefault(e => e.Id == 1);
            //if (employeeToDelete != null)
            //{
            //    db.Remove(employeeToDelete);
            //    db.SaveChanges();
            //}
            #endregion
            #endregion
            /*------------------------------------------------------------------*/
        }
    }
}
