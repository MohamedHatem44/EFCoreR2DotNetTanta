namespace Day02.Project.Models
{
    public class Department
    {
        /*------------------------------------------------------------------*/
        // EF Convention Configuration
        /*------------------------------------------------------------------*/
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentDescription { get; set; }
        /*------------------------------------------------------------------*/
        // Relation With Student Class
        public virtual ICollection<Student> Students { get; set; }
        = new HashSet<Student>();
        /*------------------------------------------------------------------*/
        // Relation With Instructor Class
        public virtual ICollection<Instructor> Instructors { get; set; }
        = new HashSet<Instructor>();
        /*------------------------------------------------------------------*/
    }
}
