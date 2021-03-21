using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Linq;
using System.Reflection;

namespace InventoryFull.Aplication.Core.Mapper.Configuration
{
    public static class DtpMapperConfigurator
    {
        public static void ConfigureMapper(this IServiceCollection services)
        {
            if (services.All(d => d.ServiceType != typeof(IMapper)))
            {
                services.TryAddSingleton(p =>
                {
                    var parameterlessMappers = Assembly
                    .GetExecutingAssembly()
                    .GetTypes()
                    .Where(t => typeof(Profile).IsAssignableFrom(t) && !t.IsInterface && t.GetConstructor(Type.EmptyTypes) != null)
                    .Select(t => (Profile)Activator.CreateInstance(t)!);

                    var ServiceMappers = Assembly
                    .GetExecutingAssembly()
                    .GetTypes()
                    .Where(t => typeof(Profile).IsAssignableFrom(t) && !t.IsInterface && t.GetConstructor(new[] { typeof(IServiceProvider) }) != null)
                    .Select(t => (Profile)Activator.CreateInstance(t, p)!);

                    var mappers = parameterlessMappers.Concat(ServiceMappers);
                    var configuration = new MapperConfiguration(cfg => cfg.AddProfiles(mappers));
                    return configuration.CreateMapper();
                });
            }
        }
    }
}
