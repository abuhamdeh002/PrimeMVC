using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using PrimeMVC.Models;
using System.Data;

namespace PrimeMVC.Controllers
{
    public class SignUpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }   
    }
}