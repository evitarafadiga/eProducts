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
            var allProducts = await _service.GetAllAsync();
            return View(allProducts);
        }

        [HttpGet]
        public async Task<IActionResult> Menu()
        {
            var allProducts = await _service.GetAllAsync();
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
            await _service.AddAsync(product);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var productDetails = await _service.GetByIdAsync(id);
            if (productDetails == null) return View("NotFound");
            return View(productDetails);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var productDetails = await _service.GetByIdAsync(id);
            if (productDetails == null) return View("NotFound");
            return View(productDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id,[Bind("Id,Name,Description,Image,Price")] Product product)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }
            await _service.UpdateAsync(id, product);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var productDetails = await _service.GetByIdAsync(id);
            if (productDetails == null) return View("NotFound");
            return View(productDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productDetails = await _service.GetByIdAsync(id);
            if (productDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
