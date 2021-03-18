using InventoryFull.Domain.Core.Inventory.Storage;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InventoryFull.Domain.Core.Inventory.Warehouse
{
    public class WarehouseEntity
    {
        [Key]
        [StringLength(50)]
        public string WarehouseId { get; set; }

        [Required]
        [StringLength(100)]
        public string WarehouseName { get; set; }

        [Required]
        [StringLength(100)]
        public string WarehouseAdress { get; set; }
        public ICollection<StorageEntity> Storages { get; set; }
    }
}
