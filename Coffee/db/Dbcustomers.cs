using Coffee.frames;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.db
{
    public class Dbcustomers
    {
        private static Dbcustomers instance;

        public static Dbcustomers Instance
        {
            get { if (instance == null) instance = new Dbcustomers(); return Dbcustomers.instance; }
            private set { Dbcustomers.instance = value; }
        }

        private Dbcustomers() { }

        public bool Checksdtkh(string sdt)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery(string.Format("select * from Cus where sdt='{0}'", sdt));
            return data.Rows.Count>0;
        }
        public int Insertkh(string name,string sdt, string email, DateTime ngaysinh)
        {
            int i = DataProvider.Instance.ExecuteNonQuery(string.Format("INSERT INTO Cus(name, sdt, email,ngaysinh )VALUES ( N'{0}', '{1}', '{2}','{3}')",name,sdt,email,ngaysinh));
            return i;
        }

        public DataTable Checkvip(string sdt)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery(string.Format("select r.name,c.name from Cus c, Rank r where c.idrank=r.id and c.sdt='{0}'", sdt));
            return data;
        }

        //public DataTable getlstkh()
        //{
        //    DataTable data = DataProvider.Instance.ExecuteQuery("select * from Cus");
        //    return data;
        //}

        public List<Customers> getlstkh()
        {
            List<Customers> list = new List<Customers>();
            string query = "select * from  Cus";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Customers cus = new Customers(item);
                list.Add(cus);
            }
            return list;
        }

        public List<Customers> SearchkhBysdt(string sdt)
        {
            List<Customers> list = new List<Customers>();
            string query = string.Format("SELECT * FROM Cus WHERE sdt LIKE N'%{0}%'", sdt);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Customers cus = new Customers(item);
                list.Add(cus);
            }
            return list;
        }
        public bool updateKh(string name,int sdt,string mail,DateTime ns,int idrank)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(string.Format("Update Cus Set name=N'{0}',email='{1}',ngaysinh='{2}',idrank={3} where sdt=0{4}",name,mail,ns,idrank,sdt));
            return result > 0;
        }
    }
}
