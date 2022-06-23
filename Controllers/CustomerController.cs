using Asm2.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Asm2.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CustomerController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var customers = _context.Customers.ToList();
            var total = _context.Customers.ToList();
            ViewData["total"] = total;
            return View(customers);
        }
    }
}
