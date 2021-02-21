using Cqrs.Infra.Data.Context;
using CqrsPattern.Domain.Interfaces;
using CqrsPattern.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cqrs.Infra.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        protected readonly UniversityDbContext _dbContext;

        public CourseRepository(UniversityDbContext dbContext) 
        {
            _dbContext = dbContext; 
        }

        public void Add(Course course)
        {
            _dbContext.Courses.Add(course);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Course> GetCourses()
        {
            return _dbContext.Courses;
        }
    }
}
