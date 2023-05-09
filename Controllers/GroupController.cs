using Microsoft.AspNetCore.Mvc;

namespace WebTaskLayout.Controllers
{
    public class GroupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
