using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eProducts.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }

        public List<Product> Products { get; set; }
    }
}
