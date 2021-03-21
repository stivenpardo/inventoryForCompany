using InventoryFull.Aplication.Dto.Inventory.Products;
using System.Threading.Tasks;

namespace InventoryFull.Aplication.Core.Inventory
{
    public class InventoryFacade : IInvetoryFacade
    {
        public Task<ProductResponseDto> ProductInventory(ProductRequestDto request)
        {
            throw new System.NotImplementedException();
        }
    }
}
