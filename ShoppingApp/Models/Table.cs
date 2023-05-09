using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShoppingApp.Models
{
    public class Table
    {
        [Key]
        public int TableId { get; set; }
        public string? ImageURL { get; set; }

        public string? TableName { get; set; }

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
