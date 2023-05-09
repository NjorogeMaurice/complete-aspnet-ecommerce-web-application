using ShoppingApp.Models;

namespace ShoppingApp.Data.Services
{
    public interface IProductService
    {
        //Interface providing CRUD methods signatures

        Task<IEnumerable<Product>> GetAll();
        Product GetById(int id);
        void Add(Product product);
        Product Update(int id, Product product);
        void Delete(int id);

    }
}
