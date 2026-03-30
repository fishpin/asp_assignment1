using Assignment1.Models;

namespace Assignment1.Repositories
{
    public class ReaderRepo
    {
        //In-memory data store and ID counter
        private static List<Reader> _readers = new List<Reader>();
        private static int _nextId = 1;

        //List all Readers
        public List<Reader> GetAll()
        {
            return _readers;
        }

        //Get Reader by ID
        public Reader? GetById(int id)
        {
            return _readers.FirstOrDefault(b => b.Id == id);
        }

        //Add new Reader
        public void Add(Reader reader)
        {
            reader.Id = _nextId++;
            _readers.Add(reader);
        }

        //Update existing Reader
        public void Update(Reader reader)
        {
            var existing = _readers.FirstOrDefault(b => b.Id == reader.Id);
            if (existing != null)
            {
                existing.FullName = reader.FullName;
                existing.Email = reader.Email;
                existing.PhoneNumber = reader.PhoneNumber;
                existing.Address = reader.Address;
            }
        }

        //Delete Reader
        public void Delete(int id)
        {
            var reader = _readers.FirstOrDefault(r => r.Id == id);
            if (reader!= null)
            {
                _readers.Remove(reader);
            }
        }

    }
}
