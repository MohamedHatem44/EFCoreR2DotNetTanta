namespace Day02.OneToOneTP.Models
{
    public class Instructor
    {
        /*------------------------------------------------------------------*/
        public int Id { get; set; }
        public string Name { get; set; }
        /*------------------------------------------------------------------*/
        public virtual Car? Car { get; set; }
        /*------------------------------------------------------------------*/
    }
}
