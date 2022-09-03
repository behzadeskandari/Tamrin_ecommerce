using Core.Entities;
using Core.Interface;
using Infrastructure.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class Program
    {
       
        public static  void Main(string[] args)
        {

            var host = CreateHostBuilder(args).Build();
            CreateIfNotExists(host);
            MigrateAysnc(host);
            host.Run();
        }

        private static async Task MigrateAysnc(IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var loogerFactory = services.GetRequiredService<ILoggerFactory>();
                try
                {
                    var context = services.GetRequiredService<StoreDbContext>();
                    await context.Database.MigrateAsync();
                    context.Database.EnsureCreated();
                }
                catch (Exception ex)
                {
                    var logger = loogerFactory.CreateLogger<Program>();
                    logger.LogError(ex, "Migrations Error");
                }
            }
        }

        //private static void CreateIfTestFn(IWebHost webHost)
        //{
        //    using (var scope = webHost.Services.CreateScope())
        //    {
        //        var provider = scope.ServiceProvider;

        //        var t=  provider.GetRequiredService<IProductRepository>();

        //    }
        //}

        private static void CreateIfNotExists(IHost host)
        {

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<StoreDbContext>();
                   

                    if (!context.ProductTypes.Any())
                    {
                        var ProductTypeData = File.ReadAllText("../Infrastructure/Data/Seeddata/ProductType.json");
                        var types = JsonSerializer.Deserialize<List<ProductType>>(ProductTypeData);
                        context.ProductTypes.AddRange(types);
                        context.SaveChanges();

                    }
                    if (!context.ProductBrands.Any())
                    {
                        var ProductBrandData = File.ReadAllText("../Infrastructure/Data/Seeddata/ProductBrand.json");
                        var brands = JsonSerializer.Deserialize<List<ProductBrand>>(ProductBrandData);
                        context.ProductBrands.AddRange(brands);
                        context.SaveChanges();

                    }
                    if (!context.Products.Any())
                    {
                        var brandsData = File.ReadAllText("../Infrastructure/Data/Seeddata/product.json");
                        var products = JsonSerializer.Deserialize<List<Product>>(brandsData);
                        context.Products.AddRange(products);
                        context.SaveChanges();

                    }




                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An Error Occured Creating The Db");
                }
            }
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {

                    webBuilder.UseStartup<Startup>();
                });
    }
}
