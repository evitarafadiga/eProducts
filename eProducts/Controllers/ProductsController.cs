using eProducts.Data;
using eProducts.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace eProducts.Controllers
{
    public class ProductsController : Controller
    {

        private readonly IProductsService _service;

        public ProductsController(IProductsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allProducts = await _service.GetAll();
            return View(allProducts);
        }
    }
}
