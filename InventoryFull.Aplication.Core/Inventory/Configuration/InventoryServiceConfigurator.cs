using InventoryFull.Aplication.Core.Inventory.Products.Service;
using InventoryFull.Aplication.Core.Mapper.Configuration;
using InvetoryFull.Infrastructure.Data.Persistence.Core.Base.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace InventoryFull.Aplication.Core.Inventory.Configuration
{
    public static class InventoryServiceConfigurator
    {
        public static void ConfigureInventoryService(this IServiceCollection services, DbSettings settings)
        {
            services.TryAddTransient<IProductService, ProductService>();
            services.TryAddTransient<IInvetoryFacade, InventoryFacade>();

            services.ConfigureMapper();
            services.ConfigureBaseRepository(settings);
        }
    }
}
