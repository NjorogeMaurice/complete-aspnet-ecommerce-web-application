using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShoppingApp.Data;

namespace ShoppingApp.Controllers
{
    public class TableController : Controller
    {
        private readonly AppDbContext _context;

        public TableController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(string value, string value2, string type)
        {
            TempData["data"] = value;
            TempData["type"] = type;
            TempData["data2"] = value2;
            
            var data = _context.Tables.Include(n => n.Category).ToList();
            return View(data);
        }
    }
}
