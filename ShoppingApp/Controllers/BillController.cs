using Microsoft.AspNetCore.Mvc;
using ShoppingApp.Data.Services;
using ShoppingApp.Models;

namespace ShoppingApp.Controllers
{
    public class BillController : Controller
    {
        private readonly IBillService _service;

        public BillController(IBillService service) 
        {
            _service = service;
        }
        public IActionResult Index(Bill bill,string detail)
        {
            if (ModelState.IsValid) 
            {
                _service.Add(bill);
                return View(bill);
            }
            return Redirect("/");
            
        }
    }
}
