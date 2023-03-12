using eProducts.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eProducts.Data.Services
{
    public interface IProductsService
    {

        Task<IEnumerable<Product>> GetAllAsync();        
        Task<Product> GetByIdAsync(int id);    
        Task AddAsync(Product product);
        Task<Product> UpdateAsync(int id, Product newProduct);
        Task DeleteAsync(int id);
    }
}
