using Core.Entities;
using Core.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductTypeController : ControllerBase
    {
        private readonly IProductTypeRepository _productTypeRepo;

        public ProductTypeController(IProductTypeRepository productTypeRepo)
        {
            _productTypeRepo = productTypeRepo;
        }

        [HttpGet(Name ="GetProductType")]
        public async Task<ActionResult<List<ProductType>>> Get()
        {
            try
            {
                var products = await _productTypeRepo.getProductTypeAsync();
                return Ok(products);
            }
            catch (System.Exception ex)
            {

                return Ok(ex.Message as string);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductType>> GetProductType(int id)
        {
            return await _productTypeRepo.getProductTypeById(id);
        }
    }
}
