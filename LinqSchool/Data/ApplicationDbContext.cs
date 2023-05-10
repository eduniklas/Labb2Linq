using LinqSchool.Models;
using Microsoft.EntityFrameworkCore;

namespace LinqSchool.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<ActiveCourse> ActiveCourses { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Teacher>().HasData(
                new Teacher
                {
                    TeacherId = 1,
                    FirstName = "Reidar",
                    LastName = "Reidarson",
                    Address = "Norrland 1",
                    City = "Skogton"
                },
                new Teacher
                {
                    TeacherId = 2,
                    FirstName = "Tobias",
                    LastName = "Tobiasson",
                    Address = "Midland 1",
                    City = "Staden"
                },
                new Teacher
                {
                    TeacherId = 3,
                    FirstName = "Gunn",
                    LastName = "Gunnarson",
                    Address = "Norrland 15",
                    City = "Skogton"
                },
                new Teacher
                {
                    TeacherId = 4,
                    FirstName = "Sven",
                    LastName = "Svensson",
                    Address = "Skåneland 1",
                    City = "Stranden"
                });
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    StudentId = 1,
                    FirstName = "Niklas",
                    LastName = "Niklasson",
                    Address = "Midland 42",
                    City = "Stad",
                    FK_ClassId = 1
                },
                new Student
                {
                    StudentId = 2,
                    FirstName = "Sten",
                    LastName = "Stensson",
                    Address = "Midland 3",
                    City = "Stad",
                    FK_ClassId = 2
                },
                new Student
                {
                    StudentId = 3,
                    FirstName = "Rick",
                    LastName = "Ricksson",
                    Address = "Skåneland 22",
                    City = "Stranden",
                    FK_ClassId = 2
                },
                new Student
                {
                    StudentId = 4,
                    FirstName = "Morty",
                    LastName = "Mortson",
                    Address = "Norrland 35",
                    City = "Skogen",
                    FK_ClassId = 1
                });
            modelBuilder.Entity<Class>().HasData(
                new Class
                {
                    ClassId = 1,
                    ClassName = "3A"
                },
                new Class
                {
                    ClassId = 2,
                    ClassName = "2A"
                },
                new Class
                {
                    ClassId = 3,
                    ClassName = "3B"
                },
                new Class
                {
                    ClassId = 4,
                    ClassName = "2B"
                });
            modelBuilder.Entity<ActiveCourse>().HasData(
                new ActiveCourse
                {
                    ActiveCourseId = 1,
                    FK_CourseId = 1,
                    FK_StudentId = 1,
                },
                new ActiveCourse
                {
                    ActiveCourseId = 2,
                    FK_CourseId = 1,
                    FK_StudentId = 3,
                },
                new ActiveCourse
                {
                    ActiveCourseId = 3,
                    FK_CourseId = 2,
                    FK_StudentId = 2,
                },
                new ActiveCourse
                {
                    ActiveCourseId = 4,
                    FK_CourseId = 4,
                    FK_StudentId = 4
                },
                new ActiveCourse
                {
                    ActiveCourseId = 5,
                    FK_CourseId = 2,
                    FK_StudentId = 3
                },
                new ActiveCourse
                {
                    ActiveCourseId = 6,
                    FK_CourseId = 3,
                    FK_StudentId = 1
                },
                new ActiveCourse
                {
                    ActiveCourseId = 7,
                    FK_CourseId = 3,
                    FK_StudentId = 2
                },
                new ActiveCourse
                {
                    ActiveCourseId = 8,
                    FK_CourseId = 1,
                    FK_StudentId = 4
                });
            modelBuilder.Entity<Course>().HasData(
                new Course
                {
                    CourseId = 1,
                    CourseName = "Programmering 1",
                    CourseDescription = "Simpel programmering",
                    FK_TeacherId = 1,
                },
                new Course
                {
                    CourseId = 2,
                    CourseName = "Programmering 2",
                    CourseDescription = "Svårare programmering",
                    FK_TeacherId = 3,
                },
                new Course
                {
                    CourseId = 3,
                    CourseName = "Idrott",
                    CourseDescription = "Fysisk aktivitet",
                    FK_TeacherId = 4,
                },
                new Course
                {
                    CourseId = 4,
                    CourseName = "Matematik",
                    CourseDescription = "Räkna räkna räkna",
                    FK_TeacherId = 2,
                });
        }
    }
}
