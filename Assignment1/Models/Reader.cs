using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class Reader
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        public string Address { get; set; }

        public DateTime MemberSince { get; set; } = DateTime.Now;
    }
}
