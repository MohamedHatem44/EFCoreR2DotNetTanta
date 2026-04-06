using Day03.DbFirstProject.Context;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Day03.DbFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*------------------------------------------------------------------*/
            #region Context
            PubsDbContext db = new PubsDbContext();
            #endregion
            /*------------------------------------------------------------------*/
            #region Employees
            //var employees = context.Employees.ToList();
            //foreach (var employee in employees)
            //{
            //    Console.WriteLine(employee.Fname + " " + employee.Lname);
            //}
            //Console.WriteLine(employees.Count()); 
            #endregion
            /*------------------------------------------------------------------*/
            #region Tracking
            //// EF By Default Track record that retrive from database 
            //// and save it into memory called Local
            //// Detect changes on tracked records and update the database
            //// when SaveChanges() is called
            //// Use Local to access the tracked records in memory
            //// Reduce Db OverHead and improve performance

            //var employee = db.Employees.FirstOrDefault();
            //Console.WriteLine(employee.Lname);
            ////db.ChangeTracker.Clear();
            //employee.Lname = "New Name";
            //db.SaveChanges();

            //Console.WriteLine("-------------------------------------------");
            //Console.WriteLine(db.Employees.Count()); // 43
            //Console.WriteLine("-------------------------------------------");
            //Console.WriteLine(db.Employees.Local.Count()); // 0
            //var employees = db.Employees;
            //Console.WriteLine(db.Employees.Local.Count()); // 0
            //Console.WriteLine("-------------------------------------------");
            //Console.WriteLine(db.Employees.Local.Count()); // 0
            //var employees = db.Employees.ToList();
            //Console.WriteLine(db.Employees.Local.Count()); // 0
            //Console.WriteLine("-------------------------------------------");
            //var employees1 = db.Employees.Where(e => e.JobLvl < 100).ToList();
            //Console.WriteLine(employees1.Count()); // 12
            //Console.WriteLine(db.Employees.Local.Count()); // 12
            //Console.WriteLine("-------------------------------------------");
            //var employees2 = db.Employees.Where(e => e.JobLvl >= 100).ToList();
            //Console.WriteLine(employees2.Count());  // 31
            //Console.WriteLine(db.Employees.Local.Count()); // 43
            //Console.WriteLine("-------------------------------------------");

            //db.ChangeTracker.Clear();
            //Console.WriteLine(db.Employees.Local.Count());

            // GetAll => Landing Page => No Tracking
            // GetById => Details Page => Tracking

            //Console.WriteLine("-------------------------------------------");
            //var employees3 = db.Employees.ToList();
            //Console.WriteLine(db.Employees.Local.Count());
            //Console.WriteLine("-------------------------------------------");
            //var employees4 = db.Employees.AsNoTracking().ToList();
            //Console.WriteLine(db.Employees.Local.Count());
            //Console.WriteLine("-------------------------------------------");
            #endregion
            /*------------------------------------------------------------------*/
            #region Find
            //// Find() method is used to find an entity by its primary key value
            //// Find(PK[])
            //// By Default
            //// Search in Local Memory first If Found Return it
            //// If Not Found Search in Database and Return it and Track it
            //// If Not Found Return Null


            ////SELECT[e].[emp_id], [e].[fname], [e].[hire_date],
            ////[e].[job_id], [e].[job_lvl], [e].[lname], [e].[minit], [e].[pub_id]
            ////FROM[employee] AS[e]
            //var employees = db.Employees.AsNoTracking().ToList();
            //var id = "PMA42628Mss";
            ////exec sp_executesql N'SELECT TOP(1) [e].[emp_id], [e].[fname],
            ////[e].[hire_date], [e].[job_id], [e].[job_lvl], [e].[lname],
            ////[e].[minit], [e].[pub_id]
            ////FROM[employee] AS[e]
            ////WHERE[e].[emp_id] = @__p_0',N'@__p_0 char(9)',@__p_0='PMA42628M'
            //var employee1 = db.Employees.Find(id);
            //if (employee1 is null)
            //{
            //    Console.WriteLine("Not Found");
            //}
            //else
            //{
            //    Console.WriteLine(employee1.Fname);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region Explicit Loading
            //// Load Data in First Request into Memory
            //Console.WriteLine(db.Employees.Local.Count()); // 0

            //db.Employees.Local.Clear();
            //db.Employees.Load();
            //db.Employees.Local.Clear();

            //Console.WriteLine(db.Employees.Local.Count()); // 43
            #endregion
            /*------------------------------------------------------------------*/
            #region AsEnumerable vs AsQueryable
            // AsQueryable
            // Execute Query in Database and Return the Result to Memory
            // Filter In DataBase Level
            // System.Linq.Queryable

            // AsEnumerable
            // Filter Data in Memory Level
            // System.Collections.Generic.IEnumerable

            //Console.WriteLine("--------------------------------------------");
            ////SELECT[e].[emp_id], [e].[fname], [e].[hire_date],
            ////[e].[job_id], [e].[job_lvl], [e].[lname], [e].[minit], [e].[pub_id]
            ////FROM[employee] AS[e]
            //var q1 = db.Employees.AsEnumerable();
            //var q1_ = q1.Where(e => e.JobLvl < 100).ToList();
            //foreach (var item in q1_)
            //{
            //    Console.WriteLine(item.Fname);
            //}
            //Console.WriteLine("--------------------------------------------");
            ////SELECT[e].[emp_id], [e].[fname], [e].[hire_date], [e].[job_id],
            ////[e].[job_lvl], [e].[lname], [e].[minit], [e].[pub_id]
            ////FROM[employee] AS[e]
            ////WHERE[e].[job_lvl] < CAST(100 AS tinyint)
            //var q2 = db.Employees.AsQueryable();
            //var q2_ = q2.Where(e => e.JobLvl < 100).ToList();
            //foreach (var item in q2_)
            //{
            //    Console.WriteLine(item.Fname);
            //}
            //Console.WriteLine("--------------------------------------------");
            // var query = db.Products.AsQueryable();
            // If(category != null)
            // {
            //     query = query.Where(p => p.Category == category);
            // }
            // If(brand != null)
            // {
            //     query = query.Where(p => p.brand == brand);
            // }
            #endregion
            /*------------------------------------------------------------------*/
            #region Bulk Update and Bulk Delete
            //// Bulk Update
            //db.Employees
            //    .Where(e => e.JobLvl < 100)
            //    .ExecuteUpdate(s =>
            //    s.SetProperty(e => e.JobLvl, e => e.JobLvl + 10)
            //    //.SetProperty().SetProperty
            //    );

            //db.Employees.Local.Clear();
            //db.Employees.Load();

            //// Bulk Delete
            //db.Employees
            //    .Where(e => e.JobLvl >= 100)
            //    .ExecuteDelete();
            #endregion
            /*------------------------------------------------------------------*/
            #region Sql Query
            //// Select * from authors
            //var q1 = db.Authors.FromSqlRaw("SELECT * FROM authors").ToList();
            //var q2 = db.Authors.FromSqlRaw("SELECT * FROM authors").OrderBy(a => a.AuFname).ToList();

            //var id = "172-32-1176";
            //// SELECT * FROM authors where au_id = '172-32-1176'
            //var q3 = db.Authors.FromSqlRaw($"SELECT * FROM authors where au_id = '{id}'").ToList();

            //// exec sp_executesql N'SELECT * FROM authors where au_id = @id
            ////',N'@id nvarchar(11)',@id=N'172 - 32 - 1176'
            //var q4 = db.Authors.FromSqlRaw($"SELECT * FROM authors where au_id = @id", new SqlParameter("@id", id)).ToList();

            //// exec sp_executesql N'SELECT * FROM authors where au_id = @p0
            ////',N'@p0 nvarchar(4000)',@p0=N'172 - 32 - 1176'
            //var q5 = db.Authors.FromSqlInterpolated($"SELECT * FROM authors where au_id = {id}").ToList();

            //// exec GetAllAuthors
            //var q6 = db.Authors.FromSqlRaw("exec GetAllAuthors").ToList();
            //var q6_1 = q6.OrderBy(a => a.AuFname).ToList();

            //// SP Can't Encapsulate into another query
            //var q7 = db.Authors.FromSqlRaw("exec GetAllAuthors").OrderBy(a => a.AuFname).ToList();
            //foreach (var item in q7)
            //{
            //    Console.WriteLine(item.AuFname);
            //}
            #endregion
            /*------------------------------------------------------------------*/
        }
    }
}
