using InventoryFull.Domain.Core.Inventory.InputOutput;
using InventoryFull.Domain.Core.Inventory.Product;
using InventoryFull.Domain.Core.Inventory.Warehouse;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InventoryFull.Domain.Core.Inventory.Storage
{
    public class StorageEntity
    {
        [Key]
        [StringLength(50)]
        public string StorageId { get; set; }

        [Required]
        public DateTime LastUpdate { get; set; }

        [Required]
        public int PartialQuantity { get; set; }

        public string ProductId { get; set; }
        public ProductEntity Product { get; set; }
        public string WarehouseId { get; set; }
        public WarehouseEntity Warehouse { get; set; }

        public ICollection<InputOutputEntity> InputOutputs { get; set; }
    }
}
