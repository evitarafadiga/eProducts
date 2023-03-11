using eProducts.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eProducts.Data.Services
{
    public interface IProductsService
    {

        Task<IEnumerable<Product>> GetAll();        
        Product GetById(int id);    
        void Add(Product product);
        Product Update(int id, Product newProduct);
        void Delete(int id);
    }
}
