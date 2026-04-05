namespace Day02.Project.Models
{
    public class Course
    {
        /*------------------------------------------------------------------*/
        // Fluent API
        /*------------------------------------------------------------------*/
        public int Crs_Id { get; set; }
        public string Crs_Name { get; set; }
        public string? Crs_Description { get; set; }
        /*------------------------------------------------------------------*/
        // Relation With Instructor
        public virtual ICollection<Instructor> Instructors { get; set; }
        = new HashSet<Instructor>();
        /*------------------------------------------------------------------*/
        // Relation With Student_Course Class
        public virtual ICollection<Student_Course> Student_Courses { get; set; }
        = new HashSet<Student_Course>();
        /*------------------------------------------------------------------*/
    }
}
