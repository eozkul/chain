using Chain.Data.Services.Abstractions;
using Chain.Data.Services.Concretes;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
namespace Chain.Data.Services.Extensions
{
    public static class ServiceCollectionsExtensions
    {
        public static IServiceCollection AddDataServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IOrderService, OrderService>();
            //var queriesAssembly = AppDomain.CurrentDomain.Load("Chain.Data.Queries");
            var commandsAssembly = AppDomain.CurrentDomain.Load("Chain.Data.Commands");
            services.AddMediatR(commandsAssembly);
            return services;
        }
    }
}
