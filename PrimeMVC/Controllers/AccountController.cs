using Microsoft.AspNetCore.Mvc;

namespace PrimeMVC.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }
        public IActionResult Logout()
        {
            return View();
        }
    }
}
