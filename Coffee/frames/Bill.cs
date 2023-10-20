using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.db
{
    public class Bill
    {
        public Bill(int id, DateTime? date, int status)
        {
            this.ID = id;
            this.Date = date;
            this.Status = status;
        }

        public Bill(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Date = (DateTime?)row["date"];
            this.Status = (int)row["status"];
        }

        private int status;

        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        private DateTime? date;

        public DateTime? Date
        {
            get { return date; }
            set { date = value; }
        }

        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}
