using InventoryFull.Aplication.Dto.Base;

namespace InventoryFull.Aplication.Dto.Inventory.Products
{
    public class ProductDto : DataTransferObject 
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string  ProductDescription { get; set; }
        public int TotalQuantity { get; set; }
        public string CategoryId { get; set; }
    }
}
