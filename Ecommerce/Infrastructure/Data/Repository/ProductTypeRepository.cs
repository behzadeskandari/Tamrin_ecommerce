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
    public class ProductTypeRepository : IProductTypeRepository
    {
        private readonly StoreDbContext _dbContext;

        public ProductTypeRepository(StoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IReadOnlyList<ProductType>> getProductTypeAsync()
        {
            var valueHolder = await _dbContext.ProductTypes.ToListAsync();
            return valueHolder;
        }

        public async Task<ProductType> getProductTypeById(int id)
        {
            var valueHolder = await _dbContext.ProductTypes.FirstOrDefaultAsync(x => x.Id == id);
            return valueHolder;
        }
    }
}
