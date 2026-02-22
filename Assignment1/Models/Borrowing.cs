using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class Borrowing
    {
        public int Id { get; set; }

        [Required]
        public int BookId { get; set; }

        [Required]
        public int ReaderId { get; set; }

        [Required]
        public DateTime BorrowDate { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        public DateTime? ReturnDate { get; set; }

        public bool IsOverdue => ReturnDate == null && DueDate < DateTime.Now;

        [Range(0, double.MaxValue)]
        public double OverdueFee { get; set; } = 0;
    }
}
