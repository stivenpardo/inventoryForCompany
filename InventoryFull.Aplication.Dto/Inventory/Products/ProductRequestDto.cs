using InventoryFull.Aplication.Dto.Base;

namespace InventoryFull.Aplication.Dto.Inventory.Products
{
    public class ProductRequestDto : DataTransferObject 
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string  ProductDescription { get; set; }
        public string CategoryId { get; set; }
    }
}
