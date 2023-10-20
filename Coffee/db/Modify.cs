using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    internal class Modify
    {
        public Modify() { }
        SqlCommand sqlcmd;
        SqlDataReader reader;
        public List<Account> Lstacc(string query)
        {
            List<Account> lstacc = new List<Account>();
            using(SqlConnection sqlConnection = Connection.Getcom())
            {
                sqlConnection.Open();
                sqlcmd = new SqlCommand(query, sqlConnection);
                reader = sqlcmd.ExecuteReader();
                while (reader.Read())
                {
                    lstacc.Add(new Account(reader.GetString(0),reader.GetString(1)));
                    
                }
                sqlConnection.Close();
            }
            return lstacc;
        }
        public void Cmd(string query)
        {
            using (SqlConnection sqlConnection = Connection.Getcom())
            {
                sqlConnection.Open();
                sqlcmd = new SqlCommand(query, sqlConnection);
                sqlcmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
    }
}
