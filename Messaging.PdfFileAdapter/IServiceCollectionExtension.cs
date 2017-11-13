using Microsoft.Extensions.DependencyInjection;

namespace Messaging.PdfFileAdapter
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddPdfFileAdapter(this IServiceCollection services)
        {
            services.AddTransient<IPdfDataService, PdfDataService>();
            return services;
        }
    }
}
