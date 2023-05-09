using ShoppingApp.Models;

namespace ShoppingApp.Data.Services
{
    public interface IPurchaseService
    {
        void Add(int ProductId, string productName, double price, int Quantity);
        Task Remove(int Id);
        Task<IEnumerable<Purchase>> GetAll();
    }
}
