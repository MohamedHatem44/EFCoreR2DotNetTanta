namespace Day02.MMV02.Models
{
    public class Student
    {
        /*------------------------------------------------------------------*/
        public int Id { get; set; }
        public string St_Name { get; set; }
        /*------------------------------------------------------------------*/
        // Relation With Student_Course
        public virtual ICollection<Student_Course> Student_Courses { get; set; }
        = new HashSet<Student_Course>();
        /*------------------------------------------------------------------*/
    }
}
