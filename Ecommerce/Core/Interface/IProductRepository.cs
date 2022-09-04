using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interface
{
    public interface IProductRepository
    {
        Task<List<Product>> getProductById(int id);

        Task<IReadOnlyList<Product>> getProductsAsync();

        Task<IReadOnlyList<Product>> getProductsByTypeIdAsync(int id);

        Task<IReadOnlyList<Product>> getProductsByBrandIdAsync(int id);
        void Seed();
    }
}
