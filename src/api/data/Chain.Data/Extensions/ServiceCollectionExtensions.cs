using Chain.Common;
using Chain.Data.Abstractions;
using Chain.Data.Concretes;
using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.DependencyInjection;
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddData(this IServiceCollection services,IConfiguration configuration)
    {
        var section = configuration.GetSection($"{nameof(Settings)}:Database");
        var settings = section.Get<Settings.DatabaseConfiguration>();
        services.AddDbContext<ChainDbContext>(builder =>
        {
            builder.UseSqlServer(settings.ConnectionString);
        });
        services.AddScoped<DbContext, ChainDbContext>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        return services;
    }
}

