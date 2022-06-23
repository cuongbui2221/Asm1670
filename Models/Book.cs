using System.ComponentModel.DataAnnotations;

namespace Asm2.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [MinLength(5)]
        [MaxLength(99)]
        public string Title { get; set; }

        public int CustomerId { get; set; }
        public int AuthorId { get; set; }

        public Customer Customer { get; set; }
        public Author Author { get; set; }

    }
}
