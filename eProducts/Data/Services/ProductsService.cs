using eProducts.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProducts.Data.Services
{
    public class ProductsService : IProductsService
    {
        private readonly AppDbContext _context;
        public ProductsService(AppDbContext context) 
        {
            _context = context;
        }  
        
        public void Add(Product product)
        {
            _context.Products.Add(product);
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            var result = await _context.Products.ToListAsync();
            return result;
        }

        public Product GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Product Update(int id, Product newProduct)
        {
            throw new System.NotImplementedException();
        }
    }
}
