using InventoryFull.Domain.Core.Base;
using InventoryFull.Domain.Core.Inventory.Category;
using InventoryFull.Domain.Core.Inventory.InputOutput;
using InventoryFull.Domain.Core.Inventory.Product;
using InventoryFull.Domain.Core.Inventory.Storage;
using InventoryFull.Domain.Core.Inventory.Warehouse;
using Microsoft.EntityFrameworkCore;
using System;

namespace InvetoryFull.Infrastructure.Data.Persistence.Core.Base
{
    public interface IContextDb : IUnitOfWork, IDisposable
    {
        public DbSet<ProductEntity> Product { get; }
        public DbSet<CategoryEntity> Category { get; }
        public DbSet<InputOutputEntity> InOut { get; }
        public DbSet<WarehouseEntity> Warehouse { get; }
        public DbSet<StorageEntity> Storage { get; }
    }
}
