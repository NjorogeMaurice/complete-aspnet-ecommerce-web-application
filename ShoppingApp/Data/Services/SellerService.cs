using Microsoft.EntityFrameworkCore;
using ShoppingApp.Models;

namespace ShoppingApp.Data.Services
{
    public class SellerService:ISellerService
    {
        private readonly AppDbContext _context;

        //constructor
        public SellerService(AppDbContext context)
        {
            _context = context;
        }

        public void AddSeller(Seller seller)
        {
            _context.Sellers.Add(seller);
            _context.SaveChanges();
        }

        public async Task<Seller> GetSellerById(int id)
        {
            var result = await _context.Sellers.FirstOrDefaultAsync(n => n.Phone == id);
            return result;
        }

        public Seller UpdateSeller(int id, Seller seller)
        {
            throw new NotImplementedException();
        }
    }
}
