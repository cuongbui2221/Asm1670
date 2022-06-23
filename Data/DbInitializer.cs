using Asm2.Models;
using System.Linq;

namespace Asm2.Data
{
    public class DbInitializer
    {
        public static void Initializer(ApplicationDbContext context)
        {
            //dam bao da tao DB
            context.Database.EnsureCreated();
            //kt xem co du lieu trong bang hay chua, neu chua co thi tao
            if (context.Customers.Any())
            {
                return;
            }
            //tao du lieu moi cho bang Customer, tao array list
            var customers = new Customer[]
            {
                new Customer {CustomerId = 1, Name = "Cuong", Email = "cuongbuiqqq",Phone="012345678"},
                new Customer {CustomerId = 2, Name = "Cuong", Email = "cuongbuiqqq",Phone="012345678"},
                new Customer {CustomerId = 3, Name = "Cuong", Email = "cuongbuiqqq",Phone="012345678"},
                new Customer {CustomerId = 4, Name = "Cuong", Email = "cuongbuiqqq",Phone="012345678"},
                new Customer {CustomerId = 5, Name = "Cuong", Email = "cuongbuiqqq",Phone="012345678"},
            };
            //add du lieu vao DB
            foreach (Customer a in customers)
            {
                context.Customers.Add(a);
            }
            //luu thay doi trong DB
            context.SaveChanges();





            //tuong tu cac buoc tren
            var authors = new Author[]
            {
                new Author {AuthorId = 1, Name = "Cuong", Age=18},
                new Author {AuthorId = 2, Name = "Cuong", Age=18},
                new Author {AuthorId = 3, Name = "Cuong", Age=18},

            };
            //add du lieu vao DB
            foreach (Author a in authors)
            {
                context.Authors.Add(a);
            }
            //luu thay doi trong DB
            context.SaveChanges();




            var books = new Book[]
            {
                new Book {BookId = 1, AuthorId = 1, CustomerId=1,Title="EmVaTrinh"},
                new Book {BookId = 2, AuthorId = 2, CustomerId=2,Title="EmVaTrinh"},
                new Book {BookId = 3, AuthorId = 3, CustomerId=3,Title="EmVaTrinh"},
            };
            //add du lieu vao DB
            foreach (Book a in books)
            {
                context.Books.Add(a);
            }
            //luu thay doi trong DB
            context.SaveChanges();


        }
    }
}
