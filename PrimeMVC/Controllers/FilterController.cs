using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PrimeMVC.Data;
using PrimeMVC.Models;

public class FilterController(ApplicationDbContext db) : Controller
{
    // GET: Books
    public ActionResult Index(string genre, string author, int? publicationYear)
    {
        var books = db.Books.AsQueryable();

        if (!string.IsNullOrEmpty(genre))
        {
            books = books.Where(b => b.Genre.Contains(genre));
        }

        if (!string.IsNullOrEmpty(author))
        {
            books = books.Where(b => b.Author.Contains(author));
        }

        if (publicationYear != null)
        {
            books = books.Where(b => b.PublicationYear == publicationYear);
        }

        var model = books.OrderBy(b => b.Genre).ToList();

        return View(model);
    }
}
