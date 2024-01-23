using Microsoft.AspNetCore.Mvc;
using MVC_EFCodeFirst.Context;
using MVC_EFCodeFirst.Models;

namespace MVC_EFCodeFirst.Controllers
{
    public class CourseController : Controller
    {
        CourseDbContext _context;
        public CourseController(CourseDbContext context)
        {
            _context = context; 
        }

        public IActionResult Index()
        {
            var list = _context.Courses.ToList();
            if (list.Count == 0)
            {
                ViewBag.msg = "No rec";
                return View();
            }
            else
            {
                return View(_context.Courses.ToList());
            }
        }

        public IActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Create(Course course)
        {

            _context.Courses.Add(course);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int? id)
        {
            return View(_context.Courses.Where(c => c.Id == id).FirstOrDefault());   
        }

        public IActionResult Edit(int? id)
        {
            return View(_context.Courses.Where(c => c.Id == id).FirstOrDefault());

        }
        [HttpPost]
        public IActionResult Edit(Course course)
        {
            var temp = _context.Courses.FirstOrDefault(x=>x.Id==course.Id);
            if (temp != null)
            {
                temp = course;
                _context.SaveChanges();

            }
            return RedirectToAction("Index");

        }
        
    }
}
