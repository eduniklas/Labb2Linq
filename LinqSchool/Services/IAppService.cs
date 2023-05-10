using LinqSchool.ViewModels;

namespace LinqSchool.Services
{
    public interface IAppService
    {
        Task<List<CourseViewModel>> GetCoursesAsync();
    }
}
