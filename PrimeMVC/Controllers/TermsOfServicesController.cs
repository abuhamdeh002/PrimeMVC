using Microsoft.AspNetCore.Mvc;

namespace PrimeMVC.Controllers
{
    public class TermsOfServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
