using InventoryFull.Domain.Core.Base;
using InventoryFull.Domain.Core.Inventory.Category;
using InventoryFull.Domain.Core.Inventory.InputOutput;
using InventoryFull.Domain.Core.Inventory.Product;
using InventoryFull.Domain.Core.Inventory.Storage;
using Microsoft.EntityFrameworkCore;
using System;

namespace InvetoryFull.Infrastructure.Data.Persistence.Core.Base
{
    public interface IContextDb : IUnitOfWork, IDisposable
    {
        public DbSet<ProductEntity> Products { get; }
        public DbSet<CategoryEntity> Categories { get; }
        public DbSet<InputOutputEntity> InOuts { get; }
        public DbSet<WareHouseEntity> Warehouses { get; }
        public DbSet<StorageEntity> Storages { get; }
    }
}
