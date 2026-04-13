using Assignment1.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment1.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Reader> Readers { get; set; }
        public DbSet<Borrowing> Borrowings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Borrowing belongs to a Book
            modelBuilder.Entity<Borrowing>()
                .HasOne<Book>()
                .WithMany()
                .HasForeignKey(b => b.BookId);

            // Borrowing belongs to a Reader
            modelBuilder.Entity<Borrowing>()
                .HasOne<Reader>()
                .WithMany()
                .HasForeignKey(b => b.ReaderId);
        }
    }
}