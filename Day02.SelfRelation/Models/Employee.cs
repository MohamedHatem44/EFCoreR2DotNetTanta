namespace Day02.SelfRelation.Models
{
    public class Employee
    {
        /*------------------------------------------------------------------*/
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public decimal Salary { get; set; }
        /*------------------------------------------------------------------*/
        #region Manager
        public int? ManagerId { get; set; }
        public Employee? Manager { get; set; }
        #endregion
        /*------------------------------------------------------------------*/
        #region Collection
        public virtual ICollection<Employee> Employees { get; set; }
        = new HashSet<Employee>(); 
        #endregion
        /*------------------------------------------------------------------*/
    }
    //public class Manager
    //{
    //    public virtual ICollection<Employee> Employees { get; set; }
    //    = new HashSet<Employee>();
    //}
}
