using Core.Entities;
using Core.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly StoreDbContext _storeDbContext;

        public ProductRepository(StoreDbContext storeDbContext)
        {
            _storeDbContext = storeDbContext;
        }
        public async Task<Product> getProductById(int id)
        {
             var productHolder = await _storeDbContext.Products.Include(p => p.ProductType).Include(p => p.ProductBrand).FirstOrDefaultAsync(x => x.Id == id);
            return productHolder;
        }

        public async Task<IReadOnlyList<Product>> getProductsAsync()
        {

            //return await _storeDbContext.Products.ToListAsync();
            return await _storeDbContext.Products.Include(p => p.ProductType).Include(p => p.ProductBrand).ToListAsync();
        }



        public void Seed()
        {
            
        }
    }
}
