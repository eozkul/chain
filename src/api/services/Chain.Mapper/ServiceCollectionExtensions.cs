using Microsoft.Extensions.DependencyInjection;
namespace Chain.Mapper
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(config =>
            {
                config.AddProfile<MainProfile>();
            });
            return services;
        }
    }
}
