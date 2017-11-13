using Microsoft.Extensions.DependencyInjection;

namespace Messaging.SqlDatabaseAdapter
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddSqlDataAdapter(this IServiceCollection services)
        {
            services.AddTransient<ISqlDataService, SqlDataService>();
            services.AddTransient<ISqlDataProvider, SqlDataProvider>();
            return services;
        }
    }
}
