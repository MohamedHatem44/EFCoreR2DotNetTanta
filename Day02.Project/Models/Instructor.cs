using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day02.Project.Models
{
    //[Table("ITI_Instructors")] // The name of the table the class is mapped to.
    // Fluent API => ToTable("ITI_Instructors") => The name of the table the class is mapped to.
    public class Instructor
    {
        /*------------------------------------------------------------------*/
        // DataAnnotation Configuration
        /*------------------------------------------------------------------*/
        [Key]
        public int Ins_Id { get; set; }

        //[RegularExpression]
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Ins_FirstName { get; set; }

        [Required]
        [MinLength(3)] // DataAnnotation => MinimumLength => Validation
        [MaxLength(50)]
        public string Ins_LastName { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(250)]
        public string Ins_Description { get; set; }

        [Range(1000, 5000)]
        [Column(TypeName = "decimal(8,2)")] // => Total 8 123456.78
        public decimal Salary { get; set; }

        [MinLength(3)]
        [MaxLength(50)]
        [EmailAddress]
        public string Email { get; set; }
        /*------------------------------------------------------------------*/
        // Fluent API => Ignore
        [NotMapped]
        public int NoOfCourses { get; set; }

        [NotMapped]
        public string FullName { get; set; }
        /*------------------------------------------------------------------*/
        // Relation With Department Class
        [ForeignKey("Department")]
        public int DeptId { get; set; }
        public virtual Department? Department { get; set; }
        /*------------------------------------------------------------------*/
        // Relation With Car
        public virtual Car? Car { get; set; }
        /*------------------------------------------------------------------*/
        public virtual ICollection<Course> Courses { get; set; }
        = new HashSet<Course>();
        /*------------------------------------------------------------------*/
    }
}
