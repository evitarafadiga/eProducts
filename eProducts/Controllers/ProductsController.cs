using eProducts.Data;
using eProducts.Data.Services;
using eProducts.Models;
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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name,Description,Image,Price")] Product product)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }
             _service.Add(product);
            return RedirectToAction(nameof(Index));
        }
    }
}
