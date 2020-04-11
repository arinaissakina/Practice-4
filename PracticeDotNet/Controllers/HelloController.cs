using Microsoft.AspNetCore.Mvc;

namespace PracticeDotNet.Controllers
{
    public class HelloController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}