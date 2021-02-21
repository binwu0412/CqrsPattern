using Cqrs.Infra.Data.Context;
using Cqrs.Infra.Data.Repositories;
using CqrsPattern.Application.Interfaces;
using CqrsPattern.Application.Services;
using CqrsPattern.Domain.CommandHandlers;
using CqrsPattern.Domain.Commands;
using CqrsPattern.Domain.Core.Bus;
using CqrsPattern.Domain.Interfaces;
using CqrsPattern.Infra.Bus;
using MediatR;
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
            // Domain Layer
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            services.AddScoped<IRequestHandler<CreateCourseCommand, bool>, CourseCommandHandler>();

            // Application Layer
            services.AddScoped<ICourseService, CourseService>();

            // Infra.Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<UniversityDbContext>();
        }
    }
}
