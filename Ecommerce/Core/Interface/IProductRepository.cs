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
        Task<Product> getProductById(int id);

        Task<IReadOnlyList<Product>> getProductsAsync();

        void Seed();
    }
}
