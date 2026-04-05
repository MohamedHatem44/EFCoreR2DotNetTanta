namespace Day02.MMV01.Models
{
    public class Instructor
    {
        /*------------------------------------------------------------------*/
        public int Id { get; set; }
        public string Name { get; set; }
        /*------------------------------------------------------------------*/
        public virtual ICollection<Course> Courses { get; set; }
        = new HashSet<Course>();
        /*------------------------------------------------------------------*/
    }
}
