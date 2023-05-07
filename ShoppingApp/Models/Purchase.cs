using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingApp.Models
{
    public class Purchase
    {
        [Key]
        public int Id { get; set; }
        public int Quantity { get; set; }

        public double? Price { get; set; }

        // Product
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]

        public Product Product { get; set; }
    }
}
