using Day02.Project.Context;
using Microsoft.EntityFrameworkCore;

namespace Day02.Project
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
            #region Ignore Query Filter
            //var stds = db.Students.IgnoreQueryFilters().ToList();
            #endregion
            /*------------------------------------------------------------------*/
        }
    }
}
