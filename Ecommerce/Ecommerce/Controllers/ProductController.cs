using Core.Entities;
using Core.Interface;
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

        //private readonly StoreDbContext _storeDbContext;
        //private readonly StoreDbContextSeed storeDbContextSeed;
        public ProductController(IProductRepository repo)
        {
            _repo = repo;
        }
        //public ProductController(StoreDbContext storeDbContext)
        //{
        //    _storeDbContext = storeDbContext;
        //    //this.storeDbContextSeed = storeDbContextSeed;
        //}

        [HttpGet("Seed")]
        public void Seed()
        {
            //StoreDbContextSeed storeDbContext = new StoreDbContextSeed(_storeDbContext);
            //storeDbContext.SeedAsync();
            _repo.Seed();
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> Get()
        {
            try
            {
                var products = await _repo.getProductsAsync();
                return Ok(products);
            }
            catch (System.Exception ex)
            {

                return Ok(ex.Message as string);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            return await _repo.getProductById(id);
        }

    }
}

