using Microsoft.EntityFrameworkCore;
using ShoppingApp.Models;


namespace ShoppingApp.Data.Services
{
    public class PurchaseService : IPurchaseService
    {
        private readonly AppDbContext _context;

        //constructor
        public PurchaseService(AppDbContext context)
        {
            _context = context;
        }
        Purchase purchase = new Purchase();
        List<Purchase> mypurchases = new();
        public void Add(int ProductId, string productName, double price, int Quantity)
        {
            
            purchase.ProductId = ProductId;
            purchase.ProductName = productName;
            purchase.Price = price;
            purchase.Quantity = Quantity;
            _context.Purchases.Add(purchase);
            _context.SaveChanges();
        }

        public async Task<IEnumerable<Purchase>> GetAll()
        {
            var result = await _context.Purchases.Include(n => n.Product).ToListAsync();
            return result;
        }

        public async Task Remove(int Id)
        {
            var results = await _context.Purchases.FirstOrDefaultAsync(n => n.Id == Id);
            if(results!=null) _context.Purchases.Remove(results);
            _context.SaveChanges();
        }
    }
}
