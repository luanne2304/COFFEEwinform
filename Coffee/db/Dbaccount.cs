using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.db
{
    public class Dbaccount
    {
        private static Dbaccount instance;

        public static Dbaccount Instance
        {
            get { if (instance == null) instance = new Dbaccount(); return Dbaccount.instance; }
            private set { Dbaccount.instance = value; }
        }

        private Dbaccount() { }

        public bool Createacc(string username, string pass)
        {
            try
            {
                string sql = string.Format("Insert into Acc(tentk,mk) values('{0}','{1}')", username, pass);
                DataProvider.Instance.ExecuteNonQuery(sql);
                return true;
            }
            catch
            {
                return false;
            }
        }


    }
}
