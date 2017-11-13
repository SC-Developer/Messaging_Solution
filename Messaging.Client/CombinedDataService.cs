using Messaging.PdfFileAdapter;
using Messaging.SqlDatabaseAdapter;

namespace Messaging.Client
{
    public class CombinedDataService : ICombinedDataService
    {
        private readonly IPdfDataService _pdfDataService;
        private readonly ISqlDataService _sqlDataService;

        public CombinedDataService(IPdfDataService pdfDataService, ISqlDataService sqlDataService)
        {
            _pdfDataService = pdfDataService;
            _sqlDataService = sqlDataService;
        }

        public object GetCombinedData(string output)
        {
            return $"{_pdfDataService.WriteData(output)}\n{_sqlDataService.WriteData(output)}";
        }
    }
    public interface ICombinedDataService
    {
        object GetCombinedData(string output);
    }
}
