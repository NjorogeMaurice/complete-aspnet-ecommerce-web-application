using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingApp.Models
{
    public class Feedback
    {
        [Key]
        public int Id { get; set; }
        public string? Description { get; set; }

        public int ProductId { get; set; }
        [ForeignKey("ProductId")]

        public Product? Product { get; set; }
    }
}
