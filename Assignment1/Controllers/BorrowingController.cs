using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BorrowingController : ControllerBase
    {
        [HttpGet]
        public string GetAllBorrowings()
        {
            return "These are all the borrowings!";
        }

        [HttpGet("{id}")]
        public string GetBorrowing(int id)
        {
            return $"This borrowing is ID# {id}.";
        }

        [HttpPost]
        public string CreateBorrowing()
        {
            return "This is a borrowings post request!";
        }

        [HttpPut("{id}")]
        public string UpdateBorrowing(int id)
        {
            return $"Borrowing ID# {id} has been updated.";
        }

        [HttpDelete("{id}")]
        public string DeleteBorrowing(int id)
        {
            return $"Borrowing ID# {id} has been deleted.";
        }
    }
}
