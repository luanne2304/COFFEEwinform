using Coffee.frames;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Coffee.db
{
    public class Dbstaff
    {
        private static Dbstaff instance;

        public static Dbstaff Instance
        {
            get { if (instance == null) instance = new Dbstaff(); return Dbstaff.instance; }
            private set { Dbstaff.instance = value; }
        }

        private Dbstaff() { }

        public List<Staff> getlstnv()
        {
            List<Staff> lst = new List<Staff>();
            DataTable dt = DataProvider.Instance.ExecuteQuery("sp_getlststaff");
            foreach (DataRow dr in dt.Rows)
            {
                Staff St = new Staff(dr);
                lst.Add(St);
            }
            return lst;

        }
        public List<Namestaff> getlstnamenv()
        {
            List<Namestaff> lst = new List<Namestaff>();
            DataTable dt = DataProvider.Instance.ExecuteQuery("sp_getlststaff");
            foreach (DataRow dr in dt.Rows)
            {
                Namestaff St = new Namestaff(dr);
                lst.Add(St);
            }
            return lst;
        }

        public bool updatestaff(int id, string tennv,string sdt,string diachi,string email,int idpos,  string mk,int admin)
        {   
            int result= DataProvider.Instance.ExecuteNonQuery("sp_updatestaff @id , @tennv , @sdt , @diachi , @email , @idpos , @mk , @admin ", 
                new object[] { id, tennv, sdt, diachi, email, idpos, mk, admin });
            return result>0;
        }

        public bool addstaff(string tennv, string sdt, string diachi, string email, int idpos, string tentk,string mk, int admin)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("sp_addstaff @tennv , @sdt , @diachi , @email , @idpos , @tentk , @mk , @admin ",
                new object[] { tennv, sdt, diachi, email, idpos, tentk, mk, admin });
            return result > 0;
        }

        public bool checktentk(string tentk)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("sp_checktentk @tentk ",new object[] { tentk });
            if (dt.Rows.Count != 0)
            {
                 return false;

            }
            return true;
        }   

        public List<Staff> SearchstaffBysdt(string sdt)
        {
            List<Staff> lst= new List<Staff>();
            string a = sdt;
            string query = string.Format("SELECT * FROM Staff WHERE sdt LIKE N'%{0}%'", sdt);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow dr in data.Rows)
            {
                Staff staff = new Staff(dr);    
                lst.Add(staff);

            }
            return lst;
        }
    }
}
