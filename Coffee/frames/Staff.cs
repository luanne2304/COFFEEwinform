using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.frames
{
    public class Staff
    {
        private int id;
        private string tennv;
        private string sdt;
        private string diachi;
        private string email;
        private int chucvu;
        private string tentk;
        private string mk;
        private int admin;

        public int Id { get => id; set => id = value; }
        public string Tennv { get => tennv; set => tennv = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Email { get => email; set => email = value; }
        public int Chucvu { get => chucvu; set => chucvu = value; }
        public string Tentk { get => tentk; set => tentk = value; }
        public string Mk { get => mk; set => mk = value; }
        public int Admin { get => admin; set => admin = value; }


        public Staff(DataRow row)
        {
            Id = (int)row["id"];
            Tennv = row["name"].ToString();
            Sdt = row["sdt"].ToString();
            Diachi = row["diachi"].ToString();
            Email = row["email"].ToString();
            Chucvu = (int)row["idpos"];
            Tentk = row["tentk"].ToString();
            Mk = row["mk"].ToString();
            Admin = (int)row["admin"];
        }

        public Staff(int id, string tennv, string sdt, string diachi, string email, int chucvu, string tentk, string mk, int admin)
        {
            Id = id;
            Tennv = tennv;
            Sdt = sdt;
            Diachi = diachi;
            Email = email;
            Chucvu = chucvu;
            Tentk = tentk;
            Mk = mk;
            Admin = admin;
        }
    }
}
