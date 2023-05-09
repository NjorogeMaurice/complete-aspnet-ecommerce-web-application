using ShoppingApp.Models;

namespace ShoppingApp.Data.Services
{
    public interface ISellerService
    { 
        Task<Seller> GetSellerById(int id);
        void AddSeller(Seller seller);
        Seller UpdateSeller(int id, Seller seller);
    }
}
