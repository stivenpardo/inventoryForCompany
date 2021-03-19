using InventoryFull.Domain.Core.Inventory.Category;
using InventoryFull.Domain.Core.Inventory.InputOutput;
using InventoryFull.Domain.Core.Inventory.Product;
using InventoryFull.Domain.Core.Inventory.Storage;
using InventoryFull.Domain.Core.Inventory.Warehouse;
using InvetoryFull.Infrastructure.Data.Persistence.Core.Inventory;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace InvetoryFull.Infrastructure.Data.Persistence.Core.Base.Configuration
{
    public static class RepositoryConfigurator
    {
        public static void ConfigureBaseRepository(this IServiceCollection services, DbSettings settings)
        {
            services.TryAddTransient<ICategoryRepository, CategoryRepository>();
            services.TryAddTransient<IInputOutputRepository, InputOutputRepository>();
            services.TryAddTransient<IProductRepository, ProductRepository>();
            services.TryAddTransient<IStorageRepository, StorageRepository>();
            services.TryAddTransient<IWarehouseRepository, WarehouseRepository>();

            services.ConfigureContext(settings);
        }

        public static void ConfigureContext(this IServiceCollection services, DbSettings settings)
        {
            services.Configure<DbSettings>(o => o.CopyFrom(settings));
            services.TryAddScoped<IContextDb, ContextDb>();
        }
    }
}
