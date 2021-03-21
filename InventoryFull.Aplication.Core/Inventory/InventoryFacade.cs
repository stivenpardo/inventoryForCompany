using InventoryFull.Aplication.Dto.Inventory.Products;
using System.Threading.Tasks;

namespace InventoryFull.Aplication.Core.Inventory
{
    public class InventoryFacade : IInvetoryFacade
    {
        public Task<ProductResponseDto> ProductInventory(ProductRequestDto request, string nameMethod)
        {
            //TODO: Michael, se realiza un Switch para que se pase el nombre del metodo que va ejecuta
            //en el servicio pero es metodo tiene que retornar un Tipo generico porque los metodos 
            // post, put, delete retornar un tipo diferente. 
            throw new System.NotImplementedException();
        }
    }
}
