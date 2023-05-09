using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShoppingApp.Data;
using System;

namespace ShoppingApp.Controllers
{
    public class BedController : Controller
    {
        private readonly AppDbContext _context;

        public BedController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(string value, string value2, string type)
        {
            TempData["data"] = value;
            TempData["type"] = type;
            TempData["data2"] = value2;
            var data = _context.Beds.Include(n => n.Category).ToList();
            return View(data);
        }
    }
}
