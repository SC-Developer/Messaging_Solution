using Messaging.PdfFileAdapter;
using Messaging.SqlDatabaseAdapter;
using Messaging.MessageSimulator;
using Microsoft.Extensions.DependencyInjection;
using System.Threading;

using System;

namespace Messaging.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            string communicationResults="", separator = "\n......\n";
            Console.WriteLine("Program Started!" + separator);

            var services = new ServiceCollection();
            services.AddInternalServices();

            #region
            //Another way to register dependencies from within their respective solutions              
            //services.AddPdfFileAdapter();
            //services.AddSqlDataAdapter();
            //services.AddMessageQueue();                        
            #endregion

            var provider = services.BuildServiceProvider();
            var messageQueueHandlerService = provider.GetService<IMessageQueueHandler>();
            
            messageQueueHandlerService.FillQueueWithMessages(provider.GetService<IMessageQueue<string>>());
            messageQueueHandlerService.ShowCommunication();            
            communicationResults = messageQueueHandlerService.GetCommunicationResults;

            var writerService = provider.GetService<IPdfDataService>();
            Console.WriteLine(writerService.WriteData(communicationResults) + separator);

            #region
            //Call for SQL dataservice & call for combined services
            
            var writer2 = provider.GetService<ISqlDataService>();
            Console.WriteLine(writer2.WriteData(communicationResults) + separator);

            var writer3 = provider.GetService<ICombinedDataService>();
            Console.WriteLine(writer3.GetCombinedData(communicationResults) + separator);

            var writer4 = provider.GetService<IWriteExtendedDataService>();
            Console.WriteLine(writer4.WriteData(communicationResults) + separator);
            
            #endregion

            Console.ReadLine();
        }

    }
}