using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LinqSchool.Models
{
    public class ActiveCourse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ActiveCourseId { get; set; }
        [ForeignKey("Courses")]
        [DisplayName("Course")]
        public int FK_CourseId { get; set; }
        public virtual Course Courses { get; set; }
        [ForeignKey("Students")]
        [DisplayName("Student")]
        public int FK_StudentId { get; set; }
        public virtual Student Students { get; set; }
    }
}
