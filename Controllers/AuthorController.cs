using Asm2.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Asm2.Controllers
{
    public class AuthorController : Controller
    {
        private readonly ApplicationDbContext context;
        public AuthorController(ApplicationDbContext demoContext)
        {
            this.context = demoContext;
        }
        public IActionResult Index()
        {
            var author = context.Authors.ToList();
            return View(author);
        }
    }
}
