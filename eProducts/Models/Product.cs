using eProducts.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace eProducts.Models
{
    public class Product : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Insira um nome de produto.")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Insira uma descrição de produto.")]
        public string Description { get; set; }

        [Display(Name = "Image")]
        [Required(ErrorMessage = "Insira uma imagem de produto.")]
        public string Image { get; set; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "Insira um preço de produto.")]
        public double Price { get; set; }

    }
}
