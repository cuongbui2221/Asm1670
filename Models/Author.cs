using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Asm2.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        [MinLength(3)]
        [MaxLength(10)]
        public string Name { get; set; }
        [Range(15,99)]
        public int Age { get; set; }


        public ICollection<Book> Book { get; set; }
    }
}
