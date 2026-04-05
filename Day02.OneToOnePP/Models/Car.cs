namespace Day02.OneToOnePP.Models
{
    public class Car
    {
        /*------------------------------------------------------------------*/
        public int Id { get; set; }
        public string Model { get; set; }
        public string Number { get; set; }
        /*------------------------------------------------------------------*/
        public virtual Instuctor_Car? Instuctor_Car { get; set; }
        /*------------------------------------------------------------------*/
    }
}
