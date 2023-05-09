using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace ShoppingApp.Models
{
    public class Bill
    {

        [Key]
        public int Id { get; set; }
        public DateTime BillDate { get; set; }

        public DateTime DeliveryDate { get; set; }
        public double TotalPrice { get; set; }


        //Relationships
        public List<Purchase>? Purchases { get; set; }

    }
}
