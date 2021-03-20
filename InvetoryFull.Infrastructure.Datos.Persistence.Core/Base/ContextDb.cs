using InventoryFull.Domain.Core.Base;
using InventoryFull.Domain.Core.Inventory.Category;
using InventoryFull.Domain.Core.Inventory.InputOutput;
using InventoryFull.Domain.Core.Inventory.Product;
using InventoryFull.Domain.Core.Inventory.Storage;
using InventoryFull.Domain.Core.Inventory.Warehouse;
using InvetoryFull.Infrastructure.Data.Persistence.Core.Base.Configuration;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace InvetoryFull.Infrastructure.Data.Persistence.Core.Base
{
    internal class ContextDb : DbContext, IContextDb
    {
        private readonly DbSettings _settings;
        #region Tables DB
        public DbSet<ProductEntity> Product { get; set; }

        public DbSet<CategoryEntity> Category { get; set; }

        public DbSet<InputOutputEntity> InOut { get; set; }

        public DbSet<WarehouseEntity> Warehouse { get; set; }

        public DbSet<StorageEntity> Storage { get; set; }

        #endregion

        public ContextDb() => _settings = new DbSettings
        {
            ConnectionString = "Server = DESKTOP-A52QQCF\\SQLEXPRESS; Database = InventoryCompanyDB; Trusted_Connection = True;"
        };
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(_settings.ConnectionString);
        public int Commit() => base.SaveChanges();

        public void RollBack() =>
            base.ChangeTracker
            .Entries()
            .Where(e => e.Entity != null)
            .ToList()
            .ForEach(e => e.State = EntityState.Detached);

        public new DbSet<T> Set<T>() where T : class => base.Set<T>();
        public void SetDeatached<T>(T item) where T : class => Entry(item).State = EntityState.Detached;
        public void SetModified<T>(T item) where T : class => Entry(item).State = EntityState.Modified;
        void IUnitOfWork.Attach<T>(T item) where T : class
        {
            if (Entry(item).State == EntityState.Detached) base.Set<T>().Attach(item);
        }

    }
}
