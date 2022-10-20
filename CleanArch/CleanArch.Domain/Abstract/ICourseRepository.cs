using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Abstract
{
    public interface ICourseRepository
    {
        void Add(Course course);
        IQueryable<Course> GetCourses();
    }
}
