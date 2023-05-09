using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingApp.Models
{
    public class Product
    {
        public Product() { }

        public Product(int prodId, string? productImageURL, string? productName, int stockStatus, double price, string? description, int categoryId)
        {
            ProdId = prodId;
            ProductImageURL = productImageURL;
            ProductName = productName;
            StockStatus = stockStatus;
            Price = price;
            Description = description;
            CategoryId = categoryId;
        }

        [Key]
        public int ProdId { get; set; }
        public string? ProductImageURL { get; set; }

        public string? ProductName { get; set; }

        public int StockStatus { get; set; }

        public double Price { get; set; }

        public string? Description { get; set; }


        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]

        public Category Category { get; set; }


        //Relationships

        public List<Feedback>? Feedbacks { get; set; }
    }
}
