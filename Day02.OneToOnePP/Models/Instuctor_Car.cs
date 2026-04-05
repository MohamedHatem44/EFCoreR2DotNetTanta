using System.ComponentModel.DataAnnotations.Schema;

namespace Day02.OneToOnePP.Models
{
    public class Instuctor_Car
    {
        /*------------------------------------------------------------------*/
        // Relation With Instructor
        [ForeignKey("Instructor")]
        //[ForeignKey(nameof(Instructor))]
        public int InstructorId { get; set; }
        public virtual Instructor? Instructor { get; set; }
        /*------------------------------------------------------------------*/
        // Relation With Car
        [ForeignKey("Car")]
        //[ForeignKey(nameof(Car))]
        public int CarId { get; set; }
        public virtual Car? Car { get; set; }
        /*------------------------------------------------------------------*/
    }
}
