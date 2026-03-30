using Assignment1.Models;

namespace Assignment1.Repositories
{
    public class BookRepo
    {
        //In-memory data store and ID counter
        private static List<Book> _books = new List<Book>();
        private static int _nextId = 1;

        //List all Books
        public List<Book> GetAll()
        {
            return _books;
        }

        //Get Book by ID
        public Book? GetById(int id)
        {
            return _books.FirstOrDefault(b => b.Id == id);
        }

        //Add Book to library
        public void Add(Book book)
        {
            book.Id = _nextId++;
            _books.Add(book);
        }

        //Update Book details
        public void Update(Book book)
        {
            var existing = _books.FirstOrDefault(b => b.Id == book.Id);
            if (existing != null)
            {
                existing.Title = book.Title;
                existing.Author = book.Author;
                existing.ISBN = book.ISBN;
                existing.Genre = book.Genre;
                existing.YearPublished = book.YearPublished;
                existing.IsAvailable = book.IsAvailable;
            }
        }

        //Delete Book
        public void Delete(int id)
        {
            var book = _books.FirstOrDefault(b => b.Id == id);
            if (book != null)
            {
                _books.Remove(book);
            }
        }
    }
}
