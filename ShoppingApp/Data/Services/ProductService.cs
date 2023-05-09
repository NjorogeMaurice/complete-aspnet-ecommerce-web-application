using Microsoft.EntityFrameworkCore;
using ShoppingApp.Models;

namespace ShoppingApp.Data.Services
{
    public class ProductService : IProductService
    {
        //injecting from the database
        private readonly AppDbContext _context;

        //constructor
        public ProductService(AppDbContext context)
        {
            _context = context;
        }
        public void Add(Product product)
        {
            _context.Productss.Add(product);
            _context.SaveChanges();
            if (product.CategoryId == 1) 
            {
                _context.Tables.AddRange(new List<Table>()
                {
                    new Table()
                    {
                        TableName = product.ProductName,
                        ImageURL = product.ProductImageURL,
                        Description = product.Description,
                        Price = product.Price,
                        StockStatus = product.StockStatus,
                        CategoryId = product.CategoryId
                    }
                });
                _context.SaveChanges();
            }
            else if (product.CategoryId == 2)
            {
                _context.Chairs.AddRange(new List<Chair>()
                {
                    new Chair()
                    {
                        ChairName = product.ProductName,
                        ChairImageURL = product.ProductImageURL,
                        Description = product.Description,
                        Price = product.Price,
                        StockStatus = product.StockStatus,
                        CategoryId = product.CategoryId
                    }
                });
                _context.SaveChanges();
            }
            else if (product.CategoryId == 3)
            {
                _context.Sofasets.AddRange(new List<SofaSet>()
                {
                    new SofaSet()
                    {
                        SofaName = product.ProductName,
                        ImageURL = product.ProductImageURL,
                        Description = product.Description,
                        Price = product.Price,
                        StockStatus = product.StockStatus,
                        CategoryId = product.CategoryId
                    }
                });
                _context.SaveChanges();
            }
            else if (product.CategoryId == 4)
            {
                _context.Beds.AddRange(new List<Bed>()
                {
                    new Bed()
                    {
                        BedName = product.ProductName,
                        ImageURL = product.ProductImageURL,
                        Description = product.Description,
                        Price = product.Price,
                        StockStatus = product.StockStatus,
                        CategoryId = product.CategoryId
                    }
                });
                _context.SaveChanges();
            }
        }

        public void Delete(int id) 
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            var result = await _context.Productss.Include(n=>n.Category).ToListAsync();
            return result;
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Product Update(int id, Product product)
        {
            throw new NotImplementedException();
        }
    }
}
