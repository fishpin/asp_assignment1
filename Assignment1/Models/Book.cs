using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [Required]
        [StringLength(100)]
        public string Author { get; set; }

        [Required]
        [StringLength(13)]
        public string ISBN { get; set; }

        [Required]
        [StringLength(50)]
        public string Genre { get; set; }

        [Range(1455, 2026)]
        public int YearPublished { get; set; }

        public bool IsAvailable { get; set; } = true;
    }
}
