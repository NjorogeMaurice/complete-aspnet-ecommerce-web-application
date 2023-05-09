using Microsoft.EntityFrameworkCore;
using ShoppingApp.Models;

namespace ShoppingApp.Data.Services
{
    public class AccountService : IAccountService
    {
        private readonly AppDbContext _context;

        //constructor
        public AccountService(AppDbContext context)
        {
            _context = context;
        }
        public void AddBuyer(Buyer buyer)
        {
            _context.Buyers.Add(buyer);
            _context.SaveChanges();
        }

        public async Task<Buyer> GetBuyerById(int id)
        {
            var result = await _context.Buyers.FirstOrDefaultAsync(n => n.Phone == id);
            return result;
        }

        public Buyer UpdateBuyer(int id, Buyer buyer)
        {
            throw new NotImplementedException();
        }
    }
}
