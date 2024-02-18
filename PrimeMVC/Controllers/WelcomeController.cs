using Microsoft.AspNetCore.Mvc;

namespace PrimeMVC.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

