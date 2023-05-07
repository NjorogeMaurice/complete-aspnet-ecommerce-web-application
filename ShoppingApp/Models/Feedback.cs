using System.ComponentModel.DataAnnotations;

namespace ShoppingApp.Models
{
    public class Feedback
    {
        [Key]
        public int Id { get; set; }
        public string? Description { get; set; }
    }
}
