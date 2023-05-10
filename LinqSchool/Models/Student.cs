using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LinqSchool.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }
        [Required]
        [StringLength(40)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(40)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [StringLength(25)]
        public string Address { get; set; }
        [StringLength(25)]
        public string City { get; set; }
        [ForeignKey("Class")]
        [DisplayName("Class")]
        public int FK_ClassId { get; set; }
        public virtual Class Class { get; set; }
        public virtual ICollection<ActiveCourse> ActiveCourses { get; set; }
    }
}
