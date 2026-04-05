namespace Day02.MMV01.Models
{
    public class Course
    {
        /*------------------------------------------------------------------*/
        public int Id { get; set; }
        public string Crs_Name { get; set; }
        /*------------------------------------------------------------------*/
        public virtual ICollection<Instructor> Instructors { get; set; }
        = new HashSet<Instructor>();
        /*------------------------------------------------------------------*/
    }
}
