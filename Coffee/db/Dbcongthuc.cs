using Coffee.frames;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.db
{
    public class Dbcongthuc
    {
        private static Dbcongthuc instance;

        public static Dbcongthuc Instance
        {
            get { if (instance == null) instance = new Dbcongthuc(); return Dbcongthuc.instance; }
            private set { Dbcongthuc.instance = value; }
        }

        private Dbcongthuc() { }

        public bool CheckLoadCongthucs(int id)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("Select * from Congthuc where idfood =" + id);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else return false;
        }
        public DataTable LoadCongthucs(int id)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("Select * from Congthuc where idfood =" + id);
            return dt;
        }

        public DataTable GetCongthucs2(int id)
        {
            DataTable dt= DataProvider.Instance.ExecuteQuery("Select * from Congthuc where idfood =" + id);
            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            else
            {
                DataProvider.Instance.ExecuteNonQuery(string.Format("Insert into Congthuc(idfood) values({0})", id));
                dt = DataProvider.Instance.ExecuteQuery("Select * from Congthuc where idfood =" + id);
                return dt;
            }
        }

        public List<Congthuc> GetListCongthuc()
        {
            List<Congthuc> list = new List<Congthuc>();

            string query = "select c.id,c.idfood, c.guide ,f.name from Congthuc c,Food f where c.idfood=f.id";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Congthuc ct = new Congthuc(item);
                list.Add(ct);
            }

            return list;
        }

        public bool UpdateCongthuc(string guide,int idfood)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(string.Format("Update Congthuc Set guide=N'{0}' Where idfood={1}", guide, idfood));
            return result > 0;
        }

    }
}
