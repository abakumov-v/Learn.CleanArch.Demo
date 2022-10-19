using CleanArch.Application.Abstract;
using CleanArch.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly ICourseService _courseService;

        public CourseController(ILogger<CourseController> logger, 
            ICourseService courseService)
        {
            _logger = logger;
            _courseService = courseService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CourseViewModel model)
        {
            _courseService.Create(model);
            return Ok(model);
        }
    }
}