using System.ComponentModel.DataAnnotations;

namespace ShoppingApp.Models
{
    public class Buyer
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? Password { get; set; }
    }
}
