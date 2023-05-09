using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using ShoppingApp.Data;
using ShoppingApp.Data.Services;
using ShoppingApp.Models;

namespace ShoppingApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _service;

        public ProductController(IProductService service) 
        {
            _service = service;
        }
        public async Task<IActionResult> Index(string detail)
        {
            var data = await _service.GetAll();
            TempData["data2"] = detail;
            return View(data);
        }

        // Get : /Product/create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Create([Bind("ProductImageURL,ProductName,Description,StockStatus,Price,CategoryId")]Product product,string detail) 
        {
          
                if (ModelState.IsValid)
                {
                    return View(product);
                }
             _service.Add(product);
            return RedirectToAction(nameof(Index));
            

        }
    }
}
