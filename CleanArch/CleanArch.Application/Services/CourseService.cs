using AutoMapper;
using AutoMapper.QueryableExtensions;
using CleanArch.Application.Abstract;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Abstract;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _mapper;

        public CourseService(
            ICourseRepository courseRepository, 
            IMediatorHandler bus, 
            IMapper mapper)
        {
            _courseRepository = courseRepository;
            _bus = bus;
            _mapper = mapper;
        }

        public void Create(CourseViewModel courseViewModel)
        {
            /* Before AutoMapper:
            var createCourseCommand = new CreateCourseCommand(
                courseViewModel.Name,
                courseViewModel.Description, 
                courseViewModel.ImageUrl);
            */
            var createCourseCommand = _mapper.Map<CreateCourseCommand>(courseViewModel);

            _bus.SendCommand(createCourseCommand);
        }

        public IEnumerable<CourseViewModel> GetCourses()
        {
            return _courseRepository.GetCourses()
                .ProjectTo<CourseViewModel>(_mapper.ConfigurationProvider);
        }
    }
}
