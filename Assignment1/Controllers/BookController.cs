using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        [HttpGet]
        public string GetAllBooks()
        {
            return "These are all the books!";
        }

        [HttpGet("{id}")]
        public string GetBook(int id)
        {
            return $"This book is ID# {id}.";
        }

        [HttpPost]
        public string CreateBook()
        {
            return "This is a book post request!";
        }

        [HttpPut("{id}")]
        public string UpdateBook(int id)
        {
            return $"Book ID# {id} has been updated.";
        }

        [HttpDelete("{id}")]
        public string DeleteBook(int id)
        {
            return $"Book ID# {id} has been deleted.";
        }
    }
}