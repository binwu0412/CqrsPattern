using Cqrs.Infra.Data.Repositories;
using CqrsPattern.Application.Interfaces;
using CqrsPattern.Application.Services;
using CqrsPattern.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CqrsPattern.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Application Layer
            services.AddScoped<ICourseService, CourseService>();

            // Infra.Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
