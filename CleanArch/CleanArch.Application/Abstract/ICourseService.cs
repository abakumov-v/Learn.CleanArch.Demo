using CleanArch.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Abstract
{
    public interface ICourseService
    {
        IEnumerable<CourseViewModel> GetCourses();
    }
}
