using Assignment1.Models;
using Assignment1.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    public class BorrowingController : Controller
    {
        private readonly BorrowingRepo _borrowingRepo;
        private readonly ReaderRepo _readerRepo;
        private readonly BookRepo _bookRepo;

        public BorrowingController()
        {
            _borrowingRepo = new BorrowingRepo();
            _readerRepo = new ReaderRepo();
            _bookRepo = new BookRepo();
        }

        // GET: /borrowing
        public IActionResult Index()
        {
            var borrowing = _borrowingRepo.GetAll();
            return View(borrowing);
        }

        //GET: /borrowing/details/(id)
        public IActionResult Details(int id)
        {
            var borrowing = _borrowingRepo.GetById(id);
            if (borrowing == null)
            {
                return NotFound();
            }
            return View(borrowing);
        }

        //GET: /borrowing/create
        public IActionResult Create()
        {
            ViewBag.Books = _bookRepo.GetAll();
            ViewBag.Readers = _readerRepo.GetAll();
            return View();
        }

        //POST: /borrowing/create
        [HttpPost]
        public IActionResult Create(Borrowing borrowing)
        {
            if (ModelState.IsValid)
            {
                _borrowingRepo.Add(borrowing);
                return RedirectToAction("Index");
            }
            ViewBag.Books = _bookRepo.GetAll();
            ViewBag.Readers = _readerRepo.GetAll();
            return View(borrowing);
        }

        // GET: /borrowing/edit/(id)
        public IActionResult Edit(int id)
        {
            var borrowing = _borrowingRepo.GetById(id);
            if (borrowing == null)
            {
                return NotFound();
            }
            ViewBag.Books = _bookRepo.GetAll();
            ViewBag.Readers = _readerRepo.GetAll();
            return View(borrowing);
        }

        // POST: /borrowing/edit/(id)
        [HttpPost]
        public IActionResult Edit(Borrowing borrowing)
        {
            if (ModelState.IsValid)
            {
                _borrowingRepo.Update(borrowing);
                return RedirectToAction("Index");
            }
            ViewBag.Books = _bookRepo.GetAll();
            ViewBag.Readers = _readerRepo.GetAll();
            return View(borrowing);
        }
        

        // GET: /borrowing/delete/id
        public IActionResult Delete(int id)
        {
            var borrowing = _borrowingRepo.GetById(id);
            if (borrowing == null)
            {
                return NotFound();
            }
            return View(borrowing);
        }

        // POST: /borrowing/delete/id
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _borrowingRepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
