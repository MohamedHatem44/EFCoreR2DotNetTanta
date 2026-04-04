namespace Day01.DbMigrations.Models
{
    public class Department
    {
        /*------------------------------------------------------------------*/
        public int Id { get; set; }
        public string DeptName { get; set; }
        /*------------------------------------------------------------------*/
        public virtual ICollection<Employee> Employees { get; set; }
        = new HashSet<Employee>();
        /*------------------------------------------------------------------*/
        public override string ToString()
        {
            return $"Department Id: {Id}, Department Name: {DeptName}";
        }
        /*------------------------------------------------------------------*/
    }
}
