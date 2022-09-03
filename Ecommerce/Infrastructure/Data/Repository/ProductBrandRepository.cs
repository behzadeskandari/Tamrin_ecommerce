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
    public class ProductBrandRepository : IProductBrandRepository
    {
        private readonly StoreDbContext _dbContext;

        public ProductBrandRepository(StoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IReadOnlyList<ProductBrand>> getProductBrandAsync()
        {
            var valueHolder = await _dbContext.ProductBrands.ToListAsync();
            return valueHolder;
        }

        public async Task<ProductBrand> getProductBrandById(int id)
        {
            var valueHolder = await _dbContext.ProductBrands.FirstOrDefaultAsync(x => x.Id == id);
            return valueHolder;
        }
    }
}
