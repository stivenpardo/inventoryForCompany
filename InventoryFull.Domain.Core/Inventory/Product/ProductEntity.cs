using InventoryFull.Domain.Core.Inventory.Category;
using InventoryFull.Domain.Core.Inventory.Storage;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InventoryFull.Domain.Core.Inventory.Product
{
    public class ProductEntity
    {
        [Key]
        [StringLength(10)]
        public string ProductId { get; set; }

        [Required]
        [StringLength(100)]
        public string ProductName { get; set; }

        [Required]
        [StringLength(600)]
        public string ProductDescription { get; set; }

        [Required]
        public int TotalQuantity { get; set; }

        public string CategoryId { get; set; }
        public CategoryEntity Category { get; set; }

        public ICollection<StorageEntity> Storages { get; set; }
    }
}
