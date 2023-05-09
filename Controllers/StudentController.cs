using Microsoft.AspNetCore.Mvc;

namespace WebTaskLayout.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Student()
        {
            return View();
        }
    }
}
