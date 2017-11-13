using System;
using System.Collections.Generic;
using System.Text;

namespace Messaging.SqlDatabaseAdapter
{
    public class SqlDataService : ISqlDataService
    {
        private readonly ISqlDataProvider _provider;

        public SqlDataService(ISqlDataProvider provider)
        {
            _provider = provider;
        }

        public string WriteData(string output)
        {
            return _provider.PrintData(output);
        }
    }
}
