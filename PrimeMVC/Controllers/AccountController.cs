using Microsoft.AspNetCore.Mvc;
using PrimeMVC.Models;

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
        public IActionResult UserManagement()
        {
            return View();
        }
    }
}
