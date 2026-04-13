using Assignment1.Data;
using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    public class ReaderController : Controller
    {
        private readonly LibraryContext _context;

        public ReaderController(LibraryContext context)
        {
            _context = context;
        }

        // GET: /Reader
        public IActionResult Index()
        {
            var readers = _context.Readers.ToList();
            return View(readers);
        }

        // GET: /Reader/Details/id
        public IActionResult Details(int id)
        {
            var reader = _context.Readers.FirstOrDefault(r => r.Id == id);
            if (reader == null)
            {
                return NotFound();
            }
            return View(reader);
        }

        // GET: /Reader/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Reader/Create
        [HttpPost]
        public IActionResult Create(Reader reader)
        {
            if (ModelState.IsValid)
            {
                _context.Readers.Add(reader);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(reader);
        }

        // GET: /Reader/Edit/id
        public IActionResult Edit(int id)
        {
            var reader = _context.Readers.FirstOrDefault(r => r.Id == id);
            if (reader == null)
            {
                return NotFound();
            }
            return View(reader);
        }

        // POST: /Reader/Edit/id
        [HttpPost]
        public IActionResult Edit(Reader reader)
        {
            if (ModelState.IsValid)
            {
                _context.Readers.Update(reader);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(reader);
        }

        // GET: /Reader/Delete/id
        public IActionResult Delete(int id)
        {
            var reader = _context.Readers.FirstOrDefault(r => r.Id == id);
            if (reader == null)
            {
                return NotFound();
            }
            return View(reader);
        }

        // POST: /Reader/Delete/id
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var reader = _context.Readers.FirstOrDefault(r => r.Id == id);
            if (reader != null)
            {
                _context.Readers.Remove(reader);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        // GET: /Reader/Search
        public IActionResult Search(string query)
        {
            var readers = _context.Readers
                .Where(r => r.FullName.Contains(query) ||
                            r.Email.Contains(query) ||
                            r.Address.Contains(query))
                .ToList();
            return View(readers);
        }
    }
}