using Coffee.frames;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.db
{
    public class Dbrank
    {
        private static Dbrank instance;

        public static Dbrank Instance
        {
            get { if (instance == null) instance = new Dbrank(); return Dbrank.instance; }
            private set { Dbrank.instance = value; }
        }

        private Dbrank() { }

        public List<Rank> getlstrank()
        {
            List<Rank> list = new List<Rank>();

            string query = "select * from Rank";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Rank rank = new Rank(item);
                list.Add(rank);
            }
            return list;
        }
    }
}
