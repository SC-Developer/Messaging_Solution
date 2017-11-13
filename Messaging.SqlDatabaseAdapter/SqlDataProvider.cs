using System;
using System.Collections.Generic;
using System.Text;

namespace Messaging.SqlDatabaseAdapter
{
    public class SqlDataProvider : ISqlDataProvider
    {
        public string PrintData(string output)
        {
            return "Data is supposed to be written in DB by SqlDataProvider";
        }
    }
}
