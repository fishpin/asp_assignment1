using Assignment1.Data;
using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    public class BorrowingController : Controller
    {
        private readonly LibraryContext _context;

        public BorrowingController(LibraryContext context)
        {
            _context = context;
        }

        // GET: /Borrowing
        public IActionResult Index()
        {
            var borrowings = _context.Borrowings.ToList();
            return View(borrowings);
        }

        // GET: /Borrowing/Details/id
        public IActionResult Details(int id)
        {
            var borrowing = _context.Borrowings.FirstOrDefault(b => b.Id == id);
            if (borrowing == null)
            {
                return NotFound();
            }
            return View(borrowing);
        }

        // GET: /Borrowing/Create
        public IActionResult Create()
        {
            ViewBag.Books = _context.Books.ToList();
            ViewBag.Readers = _context.Readers.ToList();
            return View();
        }

        // POST: /Borrowing/Create
        [HttpPost]
        public IActionResult Create(Borrowing borrowing)
        {
            if (ModelState.IsValid)
            {
                _context.Borrowings.Add(borrowing);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Books = _context.Books.ToList();
            ViewBag.Readers = _context.Readers.ToList();
            return View(borrowing);
        }

        // GET: /Borrowing/Edit/id
        public IActionResult Edit(int id)
        {
            var borrowing = _context.Borrowings.FirstOrDefault(b => b.Id == id);
            if (borrowing == null)
            {
                return NotFound();
            }
            ViewBag.Books = _context.Books.ToList();
            ViewBag.Readers = _context.Readers.ToList();
            return View(borrowing);
        }

        // POST: /Borrowing/Edit/id
        [HttpPost]
        public IActionResult Edit(Borrowing borrowing)
        {
            if (ModelState.IsValid)
            {
                _context.Borrowings.Update(borrowing);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Books = _context.Books.ToList();
            ViewBag.Readers = _context.Readers.ToList();
            return View(borrowing);
        }

        // GET: /Borrowing/Delete/id
        public IActionResult Delete(int id)
        {
            var borrowing = _context.Borrowings.FirstOrDefault(b => b.Id == id);
            if (borrowing == null)
            {
                return NotFound();
            }
            return View(borrowing);
        }

        // POST: /Borrowing/Delete/id
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var borrowing = _context.Borrowings.FirstOrDefault(b => b.Id == id);
            if (borrowing != null)
            {
                _context.Borrowings.Remove(borrowing);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        // GET: /Borrowing/Search
        public IActionResult Search(string query)
        {
            var borrowings = _context.Borrowings
                .Where(b => b.BookId.ToString().Contains(query) ||
                            b.ReaderId.ToString().Contains(query))
                .ToList();
            return View(borrowings);
        }
    }


}