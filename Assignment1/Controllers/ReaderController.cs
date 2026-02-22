using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReaderController : ControllerBase
    {
        [HttpGet]
        public string GetAllReaders()
        {
            return "These are all the readers!";
        }

        [HttpGet("{id}")]
        public string GetReader(int id)
        {
            return $"This reader is ID# {id}.";
        }

        [HttpPost]
        public string CreateReader()
        {
            return "This is a reader post request!";
        }

        [HttpPut("{id}")]
        public string UpdateReader(int id)
        {
            return $"Reader ID# {id} has been updated.";
        }

        [HttpDelete("{id}")]
        public string DeleteReader(int id)
        {
            return $"Reader ID# {id} has been deleted.";
        }
    }
}