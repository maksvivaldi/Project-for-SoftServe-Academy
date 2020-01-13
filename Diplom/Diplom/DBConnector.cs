﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;

namespace Diplom
{
    class DBConnector
    {
        public string GetConnectionString(string DBName)
        {
            return $@"Data Source = .\SQLEXPRESS; Initial Catalog = {DBName}; Integrated Security = true;";
        }

        public string QueryTable(string DBTableName)
        {
            return $"select * from {DBTableName}";
        }

        public string TableQueryWithChild(string parentTable, string childTable)
        {
            return $"select * from {parentTable}; select * from {childTable};";
        }

        public string WriteQuery(string query)
        {
            return $"{query}";
        }
    }
}