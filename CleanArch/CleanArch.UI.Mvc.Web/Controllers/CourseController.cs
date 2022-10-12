using CleanArch.Application.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.UI.Mvc.Web.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public IActionResult Index()
        {
            var model = _courseService.GetCourses();
            return View(model);
        }
    }
}
