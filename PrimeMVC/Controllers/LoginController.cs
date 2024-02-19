using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using PrimeMVC.Data;
using PrimeMVC.Models;

namespace PrimeMVC.Controllers
{
    public class LoginController(ApplicationDbContext db) : Controller
    {
        public IActionResult Index()
        {
            List<string> quotes = new List<string>
            {
                "The more that you read, the more things you will know. The more that you learn, the more places you'll go. - Dr. Seuss",
                "A room without books is like a body without a soul. - Marcus Tullius Cicero",
                "Books are the quietest and most constant of friends; they are the most accessible and wisest of counselors, and the most patient of teachers. - Charles William Eliot",
                "Education is not the filling of a pail, but the lighting of a fire. - William Butler Yeats",
                "The only true wisdom is in knowing you know nothing. - Socrates",
                "Live as if you were to die tomorrow. Learn as if you were to live forever. - Mahatma Gandhi",
                "Learning never exhausts the mind. - Leonardo da Vinci",
                "Books are the mirrors of the soul. - Virginia Woolf",
                "The beautiful thing about learning is that no one can take it away from you. - B.B. King",
                "The journey of a thousand miles begins with a single step. - Lao Tzu",
                "Reading is to the mind what exercise is to the body. - Joseph Addison",
                "The capacity to learn is a gift; the ability to learn is a skill; the willingness to learn is a choice. - Brian Herbert",
                "In learning you will teach, and in teaching you will learn. - Phil Collins",
                "You don't have to be great to start, but you have to start to be great. - Zig Ziglar",
                "Education is the passport to the future, for tomorrow belongs to those who prepare for it today. - Malcolm X",
            };
            Random random = new Random();
            int index = random.Next(quotes.Count);
            ViewBag.Quote = quotes[index];


            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Test()
        {
            //if (string.IsNullOrEmpty(email))
            //{
            //    return BadRequest("The Email is required");
            //}

            //if (string.IsNullOrEmpty(password))
            //{
            //    return BadRequest("The password is required");
            //}

            //var user = await db.Users.FirstAsync(user => user.Email == email);
            
            //if (user == null)
            //{
            //    return NotFound("The User not found");
            //}

            //if(user.PasswordHash != password) {

            //    return BadRequest("Invalid Email Or password"); 
            //}


            return Redirect("index");
        }
    }
}