using Microsoft.AspNetCore.Mvc;

namespace MVC_EFCodeFirst.Controllers
{
    public class CourseController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
