using ShoppingApp.Models;

namespace ShoppingApp.Data.Services
{
    public interface IAccountService
    {
        Task<Buyer> GetBuyerById(int id);
        void AddBuyer(Buyer buyer);
        Buyer UpdateBuyer(int id, Buyer buyer);
    }
}
