using Coffee.frames;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.db
{
    public class DbbillInfo
    {
        private static DbbillInfo instance;

        public static DbbillInfo Instance
        {
            get { if (instance == null) instance = new DbbillInfo(); return DbbillInfo.instance; }
            private set { DbbillInfo.instance = value; }
        }

        private DbbillInfo() { }

        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.BillInfo WHERE idBill = " + id);

            foreach (DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfo.Add(info);
            }

            return listBillInfo;
        }

        public void InsertBillInfo(int idBill, int idFood, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("sp_nhapthongtinbill @idBill , @idFood , @count", new object[] { idBill, idFood, count });
        }
    }
}
