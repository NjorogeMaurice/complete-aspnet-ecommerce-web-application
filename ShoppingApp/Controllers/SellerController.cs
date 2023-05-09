using Microsoft.AspNetCore.Mvc;
using ShoppingApp.Data.Services;
using ShoppingApp.Models;
using System;

namespace ShoppingApp.Controllers
{
    public class SellerController : Controller
    {

        public readonly ISellerService _service;

        public SellerController(ISellerService service)
        {
            _service = service;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login([Bind("Phone,Password")] Seller seller)
        {
            var result = _service.GetSellerById(seller.Phone);
            if (result.Result == null) 
            {
                TempData["error"] = "User not Found";
                return Redirect("/Seller"); }
            else
            {
                bool isValid = BCrypt.Net.BCrypt.Verify(seller.Password, result.Result.Password);
                if (isValid)
                {
                    TempData["type"] = "seller";
                    TempData["data"] = seller.Phone;
                    TempData["type2"] = "seller";
                    return Redirect("/Product/Create");
                }
                TempData["error1"] = "Invalid password";
                return Redirect("/Seller");
            }
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Phone,Password", "ConfirmPwd")] Seller seller)
        {
            if (!ModelState.IsValid)
            {
                return View(seller);
            }

            // hash password
            string hashedpassword = BCrypt.Net.BCrypt.HashPassword(seller.Password);
            seller.Password = hashedpassword;
            _service.AddSeller(seller);
            TempData["type"] = "seller";
            TempData["data"] = seller.Phone;
            TempData["type2"] = "seller";
            return Redirect("/Product/Create");

        }
    }
}
