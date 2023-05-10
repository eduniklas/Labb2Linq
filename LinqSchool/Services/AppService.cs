using LinqSchool.Data;
using LinqSchool.ViewModels;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Linq;
using System.Threading.Tasks.Dataflow;

namespace LinqSchool.Services
{
    public class AppService : IAppService
    {
        private readonly ApplicationDbContext _context;
        public AppService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<CourseViewModel>> GetCoursesAsync()
        {
            var courses = await (from c in _context.Courses
                          join e in _context.Teachers on c.FK_TeacherId equals e.TeacherId
                          join s in _context.ActiveCourses on c.CourseId equals s.FK_CourseId
                          orderby c.CourseId
                          select new
                          {
                              c.CourseId,
                              c.CourseName,
                              c.CourseDescription,
                              e.FirstName,
                              e.LastName,
                              s.FK_StudentId,
                              s.Students
                          }).ToListAsync();
            List<CourseViewModel> model = new();
            foreach (var item in courses)
            {
                var listitem = new CourseViewModel
                {
                    CourseId = item.CourseId,
                    CourseName = item.CourseName,
                    CourseDescription = item.CourseDescription,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    StudentId = item.FK_StudentId,
                    Student = item.Students
                };
                model.Add(listitem);
            }

            return model;
        }
    }
}
