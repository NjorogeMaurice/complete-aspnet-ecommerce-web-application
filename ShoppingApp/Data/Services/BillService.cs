using ShoppingApp.Models;

namespace ShoppingApp.Data.Services
{
    public class BillService : IBillService
    {
        private readonly AppDbContext _context;

        public BillService(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Bill bill)
        {
            _context.Bills.Add(bill);
            _context.SaveChanges();
        }
    }
}
