using Microsoft.AspNetCore.Mvc;

namespace MVC_Intro.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
