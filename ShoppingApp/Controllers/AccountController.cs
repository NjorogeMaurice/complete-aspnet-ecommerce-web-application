using Microsoft.AspNetCore.Mvc;
using ShoppingApp.Data.Services;
using ShoppingApp.Models;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;
using BCrypt.Net;

namespace ShoppingApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _service;

        public AccountController(IAccountService service)
        {
            _service = service;
        }
        //GET : Accounts
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login([Bind("Phone,Password")] Buyer buyer)
        {
            var result = _service.GetBuyerById(buyer.Phone);
            if(result.Result == null) {
                TempData["error"] = "User not Found";
                return Redirect("/Account"); }
            else
            { 
                bool isValid = BCrypt.Net.BCrypt.Verify(buyer.Password,result.Result.Password);
                if (isValid)
                {
                    TempData["type"] = "buyer";
                    TempData["data"] = buyer.Phone.ToString();
                    return Redirect("/Product");
                }
                TempData["error1"] = "Invalid password";
                return Redirect("/Account");
            }
        }
        [HttpGet]
        public ActionResult Index()
        {

            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Phone,Password","ConfirmPwd")] Buyer buyer)
        {
            if (!ModelState.IsValid)
            {
                return View(buyer);
            }

            // hash password
            string hashedpassword = BCrypt.Net.BCrypt.HashPassword(buyer.Password);
            buyer.Password = hashedpassword;
            _service.AddBuyer(buyer);
            TempData["type"] = "buyer";
            TempData["data"] = buyer.Phone.ToString();
            return Redirect("/Product");

        }
        public ActionResult Logout()
        {
            return View();
        }
    }
}
