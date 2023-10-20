using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    internal class Connection
    {
        private static string strcon = @"Data Source=LUAN\SQLEXPRESS;Initial Catalog=coffee;Integrated Security=True";
        public static SqlConnection Getcom()
        {
            return new SqlConnection(strcon);
        }
    }
}
