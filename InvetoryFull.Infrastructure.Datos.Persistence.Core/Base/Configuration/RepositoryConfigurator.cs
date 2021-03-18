using Microsoft.Extensions.DependencyInjection;

namespace InvetoryFull.Infrastructure.Data.Persistence.Core.Base.Configuration
{
    public static class RepositoryConfigurator
    {
        public static void ConfigureBaseRepository(this IServiceCollection services, DbSettings settings)
        {
            //services.TryAddTransient<ICategoryRepository, >
        }
    }
}
