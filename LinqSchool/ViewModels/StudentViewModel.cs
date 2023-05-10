using LinqSchool.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LinqSchool.ViewModels
{
    public class StudentViewModel
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public Teacher Teacher { get; set; }
        public int FK_CourseId { get; set; }
        [DisplayName("Courses")]
        public string CourseName { get; set; }
        [DisplayName("Course Description")]
        public string CourseDescription { get; set; }
        public int FK_ClassId { get; set; }
        [DisplayName("Class")]
        public string ClassName { get; set; }
        public int FK_TeacherId { get; set; }


    }
}
