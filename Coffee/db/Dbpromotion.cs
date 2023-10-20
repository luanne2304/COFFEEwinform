using Coffee.frames;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.db
{
    public class Dbpromotion
    {
        private static Dbpromotion instance;

        public static Dbpromotion Instance
        {
            get { if (instance == null) instance = new Dbpromotion(); return Dbpromotion.instance; }
            private set { Dbpromotion.instance = value; }
        }

        private Dbpromotion() { }
        public List<Promotion> getlstpro()
        {
            List<Promotion> list = new List<Promotion>();

            string query = "select * from Promotion";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Promotion pro = new Promotion(item);
                list.Add(pro);
            }

            return list;
        }
    }
}
