using System.ComponentModel.DataAnnotations.Schema;

namespace Day02.Project.Models
{
    public class Car
    {
        /*------------------------------------------------------------------*/
        // EF Convention Configuration
        /*------------------------------------------------------------------*/
        public int Id { get; set; }
        public string Model { get; set; }
        public string Number { get; set; }
        /*------------------------------------------------------------------*/
        public int InstructorId { get; set; }
        public virtual Instructor? Instructor { get; set; }
        /*------------------------------------------------------------------*/
    }
}
