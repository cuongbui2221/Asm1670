using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Asm2.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [MinLength(3)]
        [MaxLength(10)]
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string Phone { get; set; }
        public string Address { get; set; }


        public ICollection<Book> Book { get; set; }

    }
}
