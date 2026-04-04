namespace Day01.DbMigrations.Models
{
    public class Employee
    {
        /*------------------------------------------------------------------*/
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public int HRCode { get; set; }
        //public string Address1 { get; set; }
        //public string Address2 { get; set; }
        //public string Address3 { get; set; }
        public decimal Salary { get; set; }
        /*------------------------------------------------------------------*/
        public int DepartmentId { get; set; }
        // Navigation property to Department
        // References the Department object associated with this Employee
        // Assosiation
        public virtual Department? Department { get; set; }
        /*------------------------------------------------------------------*/
        override public string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}, Salary: {Salary}, DeptId: {DepartmentId}, Department: => {Department} <=";
        }
        /*------------------------------------------------------------------*/
    }
}
