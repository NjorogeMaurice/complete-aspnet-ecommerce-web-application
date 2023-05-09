using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShoppingApp.Data;

namespace ShoppingApp.Controllers
{
    public class ChairController : Controller
    {
        private readonly AppDbContext _context;

        public ChairController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(string value, string value2, string type)
        {
            TempData["data"] = value;
            TempData["type"] = type;
            TempData["data2"] = value2;
            var data = _context.Chairs.Include(n => n.Category).ToList();
            return View(data);
        }
    }
}
