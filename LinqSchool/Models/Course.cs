using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LinqSchool.Models
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId { get; set; }
        [StringLength(50)]
        [DisplayName("Course")]
        public string CourseName { get; set; }
        [DisplayName("Course Description")]
        [StringLength(200)]
        public string CourseDescription { get; set; }
        [ForeignKey("Teachers")]
        [DisplayName("Teacher")]
        public int FK_TeacherId { get; set; }
        public virtual Teacher Teachers { get; set; }
    }
}
