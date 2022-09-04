using Core.Entities;
using Core.Interface;
using Ecommerce.DTO;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _repo;

        public ProductController(IProductRepository repo)
        {
            _repo = repo;
        }
       

        //[HttpGet("Seed")]
        //public void Seed()
        //{
        //    //StoreDbContextSeed storeDbContext = new StoreDbContextSeed(_storeDbContext);
        //    //storeDbContext.SeedAsync();
        //    _repo.Seed();
        //}

        [HttpGet]
        public async Task<ActionResult<List<Product>>> Get()
        {
            try
            {
                var products = await _repo.getProductsAsync();
                if(products == null)
                {
                    return NotFound("Not Found");
                }
                return Ok(products);
            }
            catch (System.Exception ex)
            {

                return Ok(ex.Message as string);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Product>>> GetProduct(int id)
        {
           var product = await _repo.getProductById(id);
            if (product == null)
            {
                return NotFound("Not Found");
            }
            return Ok(product);
        }

        [HttpGet]
        [Route("type/{id}")]
        public async Task<ActionResult<Product>> getProductsByTypeIdAsync(int id)
        {
            var ProductValue = await _repo.getProductsByTypeIdAsync(id);
            if (ProductValue == null)
            {
                return NotFound("Not Found");
            }
            return Ok(ProductValue);
        }


        [HttpGet]
        [Route("brand/{id}")]
        public async Task<ActionResult<Product>> getProductsByBrandIdAsync(int id)
        {
            var ProductValue = await _repo.getProductsByBrandIdAsync(id);
            if (ProductValue == null)
            {
                return NotFound("Not Found");
            }
            return Ok(ProductValue);
        }
    }
}

