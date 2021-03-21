using InventoryFull.Aplication.Dto.Inventory.Products;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InventoryFull.Aplication.Core.Inventory.Products.Service
{
    public interface IProductService
    {
        public Task<ProductResponseDto> Create(ProductRequestDto request);
        public bool Update(ProductRequestDto request);
        public bool Delete(ProductRequestDto request);
        public IEnumerable<ProductDto> GetAll();
    }
}
