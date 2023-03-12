using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace eProducts.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "Name")]
        public string Name { get; set; }
    }
}
