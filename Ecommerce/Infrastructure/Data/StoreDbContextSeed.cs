using Core.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class StoreDbContextSeed
    {
        private readonly StoreDbContext _storeDbContext;

        //
        public StoreDbContextSeed(StoreDbContext storeDbContext)
        {
            _storeDbContext = storeDbContext;
        }
        public void SeedAsync(/*StoreDbContext dbContext  , ILoggerFactory loggerFactory*/)
        {
            try
            {
                if (!_storeDbContext.Products.Any())
                {
                    var brandsData = File.ReadAllText("../Infrastructure/Data/Seeddata/product.json");
                    var products = JsonSerializer.Deserialize<List<Product>>(brandsData);
                    var pr = products;
                // var prd = products.AsEnumerable();

                    _storeDbContext.Products.AddRange(products);
                    
                    //foreach (var item in products)
                    //{
                    //    dbContext.ProductBrands.Add(item);
                    //}
                     _storeDbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                //var looger = loggerFactory.CreateLogger<StoreDbContextSeed>();
                //looger.LogError(ex.Message);                
                //throw ;
                Console.WriteLine(ex.Message as string);
            }
        }
    }
}
