using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.db
{
    public class Dbbill
    {
        private static Dbbill instance;

        public static Dbbill Instance
        {
            get { if (instance == null) instance = new Dbbill(); return Dbbill.instance; }
            private set { Dbbill.instance = value; }
        }

        private Dbbill() { }

        /// <summary>
        /// Thành công: bill ID
        /// thất bại: -1
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetUncheckBillIDByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("sp_findbillbytable @id ", new object[] {id});

            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }

            return -1;
        }

        public void CheckOut(int id, float totalPrice,string sdt,int idpro,int idstaff)
        {
            DataProvider.Instance.ExecuteNonQuery("exec sp_checkoutbill @status , @totalPrice , @sdt , @idpro , @idstaff , @id ", new object[] {1,totalPrice,sdt, idpro, idstaff,id});
        }
        public void InsertBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("exec sp_nhapbill @idTable", new object[] { id });
        }

        public DataTable GetBillListByDate(DateTime tungay, DateTime denngay)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("sp_showlstbill @tungay , @denngay", new object[] { tungay, denngay });
            return data;
        }
        public float GettotalPricefromlist(DateTime tungay, DateTime denngay)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("sp_showlstbill @tungay , @denngay", new object[] { tungay, denngay });
            float tongtien = 0;
            foreach (DataRow dr in data.Rows)
            {
                tongtien += (float)Convert.ToDouble(dr[6].ToString());
            }
            return tongtien;
        }
        public int GetMaxIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("sp_GetMaxIdBill");
            }
            catch
            {
                return 1;
            }
        }
    }
}
