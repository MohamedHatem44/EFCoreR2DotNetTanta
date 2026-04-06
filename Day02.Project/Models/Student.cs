namespace Day02.Project.Models
{
    public class Student
    {
        /*------------------------------------------------------------------*/
        // External Class Configuration
        /*------------------------------------------------------------------*/
        public int StdId { get; set; }
        public string StdName { get; set; }
        public int Age { get; set; }
        public DateOnly DOF { get; set; }
        public string Email { get; set; }
        /*------------------------------------------------------------------*/
        // Relation With Department Class   
        public int DeptId { get; set; }
        public virtual Department? Department { get; set; }
        /*------------------------------------------------------------------*/
        // Relation With Student_Course Class
        public virtual ICollection<Student_Course> Student_Courses { get; set; }
        = new HashSet<Student_Course>();
        /*------------------------------------------------------------------*/

        //public bool IsDeleted { get; set; }
    }
}
