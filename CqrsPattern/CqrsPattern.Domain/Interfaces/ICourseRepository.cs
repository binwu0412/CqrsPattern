using CqrsPattern.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CqrsPattern.Domain.Interfaces
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
    }
}
