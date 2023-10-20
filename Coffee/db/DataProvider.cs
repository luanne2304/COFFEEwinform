using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance 
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set => instance = value; 
        }
        private DataProvider() { }
        public DataTable ExecuteQuery(string query, object[] parameter =null)
        {
            DataTable data=new DataTable();
            using (SqlConnection sqlConnection = Connection.Getcom())
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                if(parameter != null)
                {
                    string[] lstpara = query.Split(' ');
                    int i = 0;
                    foreach (string item in lstpara)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item,parameter[i++]);
                        }
                    }
                }
                SqlDataAdapter adap=new SqlDataAdapter(cmd);
                adap.Fill(data);
                sqlConnection.Close();
            }
            return data;
        }
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection sqlConnection = Connection.Getcom())
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand(query, sqlConnection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                sqlConnection.Close();
            }

            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection sqlConnection = Connection.Getcom())
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand(query, sqlConnection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                sqlConnection.Close();
            }
            return data;
        }
    }
}
