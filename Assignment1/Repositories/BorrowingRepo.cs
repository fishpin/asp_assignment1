using Assignment1.Models;

namespace Assignment1.Repositories
{
    public class BorrowingRepo
    {
        //In-memory data store and ID counter
        private static List<Borrowing> _borrowings = new List<Borrowing>();
        private static int _nextId = 1;

        //List all Borrowings
        public List<Borrowing> GetAll()
        {
            return _borrowings;
        }

        //Get Borrowing by ID
        public Borrowing? GetById(int id)
        {
            return _borrowings.FirstOrDefault(b => b.Id == id);
        }

        //Add Borrowing to library
        public void Add(Borrowing borrowing)
        {
            borrowing.Id = _nextId++;
            _borrowings.Add(borrowing);
        }

        //Update existing Borrowing
        public void Update(Borrowing borrowing)
        {
            var existing = _borrowings.FirstOrDefault(b => b.Id == borrowing.Id);
            if (existing != null)
            {
                existing.BookId = borrowing.BookId;
                existing.ReaderId = borrowing.ReaderId;
                existing.BorrowDate = borrowing.BorrowDate;
                existing.DueDate = borrowing.DueDate;
                existing.ReturnDate = borrowing.ReturnDate;
            }
        }

        //Delete Borrowing
        public void Delete(int id)
        {
            var borrowing = _borrowings.FirstOrDefault(b => b.Id == id);
            if (borrowing != null)
            {
                _borrowings.Remove(borrowing);
            }
        }
    }
}
