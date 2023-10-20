using Coffee.frames;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.db
{
    public class Dbtable
    {
        private static Dbtable instance;

        public static Dbtable Instance
        {
            get { if (instance == null) instance = new Dbtable(); return Dbtable.instance; }
            private set { Dbtable.instance = value; }
        }
        private Dbtable() { }

        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();

            DataTable data = DataProvider.Instance.ExecuteQuery("sp_lsttable");

            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }

            return tableList;
        }
    }
}
