using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ToDo.Domain.Interface;
using ToDo.Infra.Data.Repositories;
using ToDo.Application.AutoMapper;
using ToDo.Application.Interfaces;
using ToDo.Application.Services;

namespace ToDo.Common
{
    public static class DependecyContainer
    {

        public static IServiceCollection ConfigureAuroMapper(this IServiceCollection services)
        {
            var scanAssemblies = AppDomain.CurrentDomain.GetAssemblies()
                .Where(w => w.FullName.StartsWith("Todo"));

            services.AddScoped<IItemRepository, ItemRepository>();

            services.AddAutoMapper((sp, cfg) =>
            {
                cfg.AddProfile(new ServiceProfile());

            }, scanAssemblies, ServiceLifetime.Transient);

            return services;

        }

        public static IServiceCollection RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IItemRepository, ItemRepository>();
            services.AddScoped<IItemService, ItemService>();
            
            return services;
        }

    }
}