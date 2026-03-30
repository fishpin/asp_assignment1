using Assignment1.Models;
using Assignment1.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepo _bookRepo;

        public BookController()
        {
            _bookRepo = new BookRepo();
        }

        // GET: /book
        public IActionResult Index()
        {
            var books = _bookRepo.GetAll();
            return View(books);
        }

        //GET: /book/details/(id)
        public IActionResult Details(int id)
        {
            var book = _bookRepo.GetById(id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        //GET: /book/create
        public IActionResult Create()
        {
            return View();
        }

        //POST: /book/create
        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                _bookRepo.Add(book);
                return RedirectToAction("Index");
            }
            return View(book);
        }

        // GET: /book/edit/(id)
        public IActionResult Edit(int id)
        {
            var book = _bookRepo.GetById(id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        // POST: /book/edit/(id)
        [HttpPost]
        public IActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                _bookRepo.Update(book);
                return RedirectToAction("Index");
            }
            return View(book);
        }

        // GET: /Book/Delete/id
        public IActionResult Delete(int id)
        {
            var book = _bookRepo.GetById(id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        // POST: /Book/Delete/id
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _bookRepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}