using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShoppingApp.Models
{
    public class Chair    {
        [Key]
        public int ChairId { get; set; }
        public string? ChairImageURL { get; set; }

        public string? ChairName { get; set; }

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
