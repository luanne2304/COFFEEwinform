using Coffee.frames;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.db
{
    public class Dbsala
    {
        private static Dbsala instance;

        public static Dbsala Instance
        {
            get { if (instance == null) instance = new Dbsala(); return Dbsala.instance; }
            private set { Dbsala.instance = value; }
        }

        private Dbsala() { }

        public List<Sala> getlstsala()
        {
            List<Sala> lst = new List<Sala>();
            DataTable dt = DataProvider.Instance.ExecuteQuery("select * from Salary where status=0");
            foreach (DataRow dr in dt.Rows)
            {
                Sala St = new Sala(dr);
                lst.Add(St);
            }
            return lst;
        }

        public bool editluong(int idstaff, float sala)
        {
            string query = string.Format("select * from Salary where idstaff ='{0}'and status=0", idstaff);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count > 0)
            {
                int result = DataProvider.Instance.ExecuteNonQuery(string.Format("Update Salary set luong=luong+{0} where idstaff ='{1}' ", sala, idstaff));
                return result > 0;

            }
            else
            {
                int result = DataProvider.Instance.ExecuteNonQuery(string.Format("Insert into Salary(idstaff,luong) Values('{0}','{1}') ", idstaff, sala));
                return result > 0;
            }
        }

        public float showluong(int idstaff)
        {
            string query = string.Format("Select luong from Salary where idstaff ={0} and status=0", idstaff);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count > 0)
            {
                float finalluong = (float)Double.Parse(dt.Rows[0][0].ToString());
                return finalluong;
            }
            else return 0;
        }
        public void getluong(int idstaff)
        {
            string query = string.Format("Update Salary set status=1 where idstaff={0} and status=0", idstaff);
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
