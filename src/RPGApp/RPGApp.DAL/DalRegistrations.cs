using Microsoft.Extensions.DependencyInjection;

namespace RPGApp.DAL;

public static class DalRegistrations
{
    public static IServiceCollection AddDbDriver(this IServiceCollection services)
    {
        services.AddSingleton<DBDriver>(_ => new DBDriver(""));
        return services;
    }
}