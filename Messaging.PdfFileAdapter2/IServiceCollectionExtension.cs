using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace Messaging.PdfFileAdapter2
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddPdfFileAdapter(this IServiceCollection services)
        {
            services.AddTransient<IPdfDataService2, PdfDataService2>();
            return services;
        }
    }
}
