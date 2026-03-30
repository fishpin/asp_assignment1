using Assignment1.Models;
using Assignment1.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    public class ReaderController : Controller
    {
        private readonly ReaderRepo _readerRepo;

        public ReaderController()
        {
            _readerRepo = new ReaderRepo();
        }

        // GET: /reader
        public IActionResult Index()
        {
            var readers = _readerRepo.GetAll();
            return View(readers);
        }

        //GET: /reader/details/(id)
        public IActionResult Details(int id)
        {
            var reader = _readerRepo.GetById(id);
            if (reader == null)
            {
                return NotFound();
            }
            return View(reader);
        }

        //GET: /reader/create
        public IActionResult Create()
        {
            return View();
        }

        //POST: /reader/create
        [HttpPost]
        public IActionResult Create(Reader reader)
        {
            if (ModelState.IsValid)
            {
                _readerRepo.Add(reader);
                return RedirectToAction("Index");
            }
            return View(reader);
        }

        // GET: /reader/edit/(id)
        public IActionResult Edit(int id)
        {
            var reader = _readerRepo.GetById(id);
            if (reader == null)
            {
                return NotFound();
            }
            return View(reader);
        }

        // POST: /reader/edit/(id)
        [HttpPost]
        public IActionResult Edit(Reader reader)
        {
            if (ModelState.IsValid)
            {
                _readerRepo.Update(reader);
                return RedirectToAction("Index");
            }
            return View(reader);
        }

        // GET: /reader/delete/id
        public IActionResult Delete(int id)
        {
            var reader = _readerRepo.GetById(id);
            if (reader == null)
            {
                return NotFound();
            }
            return View(reader);
        }

        // POST: /reader/delete/id
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _readerRepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}