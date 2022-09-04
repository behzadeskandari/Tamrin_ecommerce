using Core.Entities;
using Core.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductBrandController : ControllerBase
    {
        private readonly IProductBrandRepository _productBrandRepo;

        public ProductBrandController(IProductBrandRepository productBrandRepo)
        {
            _productBrandRepo = productBrandRepo;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProductBrand>>> Get()
        {
            try
            {
                var products = await _productBrandRepo.getProductBrandAsync();
                if (products == null)
                {
                    return NotFound("Products Not Found");
                }
                return Ok(products);
            }
            catch (System.Exception ex)
            {

                return Ok(ex.Message as string);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductBrand>> GetProductBrand(int id)
        {
            return await _productBrandRepo.getProductBrandById(id);
        }
    }
}
