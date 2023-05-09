using Microsoft.AspNetCore.Mvc;
using ShoppingApp.Data.Services;
using ShoppingApp.Models;

namespace ShoppingApp.Controllers
{
   
    public class PurchaseController : Controller
    {
        private readonly IPurchaseService _service;

        public PurchaseController(IPurchaseService service)
        {
            _service = service;
        }

        public IActionResult Create(Product product,int Quantity)
        {
            
            return View();
        }
        public async Task<IActionResult> Index(Product product,int ProductId,string productName,double price,int Quantity,int detail,string info)
        {
            if(detail != 0)
            {
                _service.Add(ProductId, productName, price, Quantity);
                TempData["data2"] = detail;
                TempData["type2"] = info;
                return View(await _service.GetAll());
            }
            else
            {
                return Redirect("/Account/Create");
            }
            
        }

        public async Task<IActionResult> Update(string detail,int Id) 
        {
            await _service.Remove(Id);
            TempData["data2"] = detail;
            return View(await _service.GetAll());
        }
    }
}
