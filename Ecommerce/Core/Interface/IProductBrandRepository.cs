using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interface
{
    public interface IProductBrandRepository
    {
        Task<ProductBrand> getProductBrandById(int id);

        Task<IReadOnlyList<ProductBrand>> getProductBrandAsync();
    }
}
