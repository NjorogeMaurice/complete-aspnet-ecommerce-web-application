using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace ShoppingApp.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string? ProductImageURL { get; set; }

        public string? ProductName { get; set; }

        public int StockStatus { get; set; }

        public double Price { get; set; }


        //Relationships

        public List<Feedback> Feedbacks { get; set; }
    }
}
