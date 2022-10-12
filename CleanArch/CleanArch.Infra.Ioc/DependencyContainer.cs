using CleanArch.Application.Abstract;
using CleanArch.Application.Services;
using CleanArch.Domain.Abstract;
using CleanArch.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Ioc
{
    public static class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Application layer
            services.AddScoped<ICourseService, CourseService>();

            // Infra.Data layer
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
