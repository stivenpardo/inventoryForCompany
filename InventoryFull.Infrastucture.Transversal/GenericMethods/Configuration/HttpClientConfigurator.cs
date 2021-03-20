using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace InventoryFull.Infrastucture.Transversal.GenericMethods.Configuration
{
    public static class HttpClientConfigurator
    {
        public static void ConfigureHttpClientService(this IServiceCollection services, HttpClientSettings settings)
        {
            services.AddHttpClient<HttpGenericBaseClient>();
            services.Configure<HttpClientSettings>(o => o.CopyFrom(settings));
            services.TryAddTransient<IHttpGenericBaseClient, HttpGenericBaseClient>();
        }
    }
}
