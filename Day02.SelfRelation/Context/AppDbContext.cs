using Day02.SelfRelation.Models;
using Microsoft.EntityFrameworkCore;

namespace Day02.SelfRelation.Context
{
    public class AppDbContext : DbContext
    {
        /*------------------------------------------------------------------*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=MOHAMED-HATEM\\SQLEXPRESS;DataBase=TantaD02Self;Trusted_Connection=true;TrustServerCertificate=true";
            optionsBuilder.UseSqlServer(connectionString);
        }
        /*------------------------------------------------------------------*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        /*------------------------------------------------------------------*/
        public virtual DbSet<Employee> Employees { get; set; }
        /*------------------------------------------------------------------*/
    }
}
