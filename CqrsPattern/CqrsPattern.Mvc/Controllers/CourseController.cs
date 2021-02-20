using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CqrsPattern.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CqrsPattern.Mvc.Controllers
{
    public class CourseController : Controller
    {
        public ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public IActionResult Index()
        {
            var courseModelView = _courseService.GetCourses();

            return View(courseModelView);
        }
    }
}
