using Coffee.frames;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.db
{
    public class DbReport
    {
        private static DbReport instance;

        public static DbReport Instance
        {
            get { if (instance == null) instance = new DbReport(); return DbReport.instance; }
            private set { DbReport.instance = value; }
        }

        private DbReport() { }

        public bool InsertRP(string title, string content, int idstaff)
        {
            string query = string.Format("INSERT Report ( title, content, idstaff )VALUES  ( N'{0}', N'{1}', 2)", title, content, idstaff);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public List<Report> getlstrp()
        {
            List<Report> lst = new List<Report>();
            DataTable dt = DataProvider.Instance.ExecuteQuery("select * from Report");
            foreach (DataRow dr in dt.Rows)
            {
                Report St = new Report(dr);
                lst.Add(St);
            }
            return lst;
        }
    }
}
