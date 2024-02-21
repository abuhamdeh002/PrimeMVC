using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PrimeMVC.Data;
using PrimeMVC.Models;

namespace PrimeMVC.Controllers;
[Authorize(Roles = "Admin")]
public class BookController : Controller
{
    private readonly ApplicationDbContext _db;

    public BookController(ApplicationDbContext db)
    {
        _db = db;
    }

    public IActionResult Index()
    {
        IEnumerable<Book> objBookList = _db.Books;
        return View(objBookList);
    }

    //GET
    public IActionResult Create()
    {
        return View();
    }

    //POST
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Book obj)
    {
        if (ModelState.IsValid)
        {
            _db.Books.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        return View(obj);
    }

    //GET
    public IActionResult Edit(int? BookID)
    {
        if (BookID == null || BookID == 0)
        {
            return NotFound();
        }
        var bookFromDb = _db.Books.Find(BookID);

        if (bookFromDb == null)
        {
            return NotFound();
        }
        return View(bookFromDb);
    }

    //POST
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(Book obj)
    {
        if (ModelState.IsValid)
        {
            _db.Books.Update(obj);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        return View(obj);
    }

    //GET
    public IActionResult Delete(int? BookID)
    {
        if (BookID == null || BookID == 0)
        {
            return NotFound();
        }

        var bookFromDb = _db.Books.Find(BookID);
        if (bookFromDb == null)
        {
            return NotFound();
        }

        return View(bookFromDb);
    }

    //POST
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteBook(int? BookID)
    {
        var obj = _db.Books.Find(BookID);
        if (obj == null)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            _db.Books.Remove(obj);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        return View(BookID);
    }
}