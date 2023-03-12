using eProducts.Data.Base;
using eProducts.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eProducts.Data.Services
{
    public interface IProductsService : IEntityBaseRepository<Product>
    {
    }
}
