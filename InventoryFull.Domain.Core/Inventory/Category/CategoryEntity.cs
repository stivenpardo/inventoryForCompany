using InventoryFull.Domain.Core.Inventory.Product;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InventoryFull.Domain.Core.Inventory.Category
{
    public class CategoryEntity
    {
        [Key]
        [StringLength(50)]
        public string CategoryId { get; set; }

        [Required]
        [StringLength(100)]
        public string CategoryName { get; set; }

        public ICollection<ProductEntity> Products { get; set; }
    }
}
