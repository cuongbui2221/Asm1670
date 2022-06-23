using Asm2.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Asm2.Controllers
{
    public class BookController : Controller
    {
        private readonly ApplicationDbContext context;
        public BookController(ApplicationDbContext DemoContext)
        {
           context = DemoContext;
        }
        public IActionResult Index()
        {
            var books = context.Books.ToList();
            return View(books); 
        }
    }
}
