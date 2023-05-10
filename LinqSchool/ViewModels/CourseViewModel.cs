using LinqSchool.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace LinqSchool.ViewModels
{
    public class CourseViewModel
    {
        public int CourseId { get; set; }
        [DisplayName("Course Name")]
        public string CourseName { get; set; }
        [DisplayName("Course Description")]
        public string CourseDescription { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("First Name")]
        public int TeacherId { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
    }
}
