using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingApp.Models
{
    public class Buyer
    {
        [Key]
        [Display(Name ="ID")]
        public int Id { get; set; }

        [Required(ErrorMessage ="Phone Number is required")]
        [Display(Name ="Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public int Phone { get; set; }

        [Display(Name = "Enter password")]
        [Required(ErrorMessage = "Please enter password")]
        [DataType(DataType.Password)]
        [StringLength(100,ErrorMessage ="Password is too short",MinimumLength = 8)]
        [RegularExpression(@"^([a-zA-z0-9@*#]{8,15})$",
            ErrorMessage = "Password must contain: Minimum 8 characters atleast 1 Uppercase Alphabet,1 lowercase Alphabet, 1 Number and 1 special Character")]
        public string Password { get; set; }

        [NotMapped]
        [Display(Name ="Confirm password")]
        [Required(ErrorMessage ="Please confirm password")]
        [Compare("Password",ErrorMessage ="Confirm password does not match. Try again.")]
        [DataType(DataType.Password)]   
        public string ConfirmPwd { get; set; }
        public Nullable<bool> Is_Deleted { get; set; }
    }
}
