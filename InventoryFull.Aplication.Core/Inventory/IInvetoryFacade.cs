using InventoryFull.Aplication.Dto.Inventory.Products;
using System.Threading.Tasks;

namespace InventoryFull.Aplication.Core.Inventory
{
    public interface IInvetoryFacade
    {
        Task<ProductResponseDto> ProductInventory(ProductRequestDto request);
    }
}
