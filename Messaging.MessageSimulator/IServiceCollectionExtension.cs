using Microsoft.Extensions.DependencyInjection;

namespace Messaging.MessageSimulator
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddMessageQueue(this IServiceCollection services)
        {
            services.AddTransient(typeof(IMessageQueue<>), typeof(MessageQueue<>));
            services.AddTransient<IMessageQueueHandler, MessageQueueHandler>();
            return services;
        }
    }
}
