using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace eProducts.Data.ViewModels
{
    public class LoginVM
    {
        [Display(Name = "Email")]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
