using Microsoft.Extensions.DependencyInjection;
using Messaging.SqlDatabaseAdapter;
using Messaging.PdfFileAdapter;
using Messaging.MessageSimulator;

namespace Messaging.Client
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddInternalServices(this IServiceCollection services)
        {
            services.AddTransient<IWriteExtendedDataService, WriteExtendedDataService>();
            services.AddTransient<ICombinedDataService, CombinedDataService>();

            services.AddTransient<ISqlDataService, SqlDataService>();
            services.AddTransient<ISqlDataProvider, SqlDataProvider>();

            services.AddTransient<IPdfDataService, PdfDataService>();

            services.AddTransient(typeof(IMessageQueue<>), typeof(MessageQueue<>));
            services.AddTransient<IMessageQueueHandler, MessageQueueHandler>();
            return services;
        }
    }
}
