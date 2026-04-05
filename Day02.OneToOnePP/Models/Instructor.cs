namespace Day02.OneToOnePP.Models
{
    public class Instructor
    {
        /*------------------------------------------------------------------*/
        public int Id { get; set; }
        public string Name { get; set; }
        /*------------------------------------------------------------------*/
        public virtual Instuctor_Car? Instuctor_Car { get; set; }
        /*------------------------------------------------------------------*/
    }
}
