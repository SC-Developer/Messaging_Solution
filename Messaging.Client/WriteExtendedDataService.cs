using System;
using System.Collections.Generic;
using System.Text;

namespace Messaging.Client
{
    public class WriteExtendedDataService : IWriteExtendedDataService
    {
        private readonly ICombinedDataService _combinedDataService;

        public WriteExtendedDataService(ICombinedDataService combinedDataService)
        {
            _combinedDataService = combinedDataService;
        }

        public string WriteData(string output)
        {
            var data = _combinedDataService.GetCombinedData(output);
            return data.ToString();
        }
    }
    public interface IWriteExtendedDataService
    {
        string WriteData(string output);
    }
}
