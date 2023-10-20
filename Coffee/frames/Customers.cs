using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.frames
{
    public class Customers
    {
        private int id;
        private string tenkh;
        private string sdt;
        private string email;
        private DateTime ngaysinh;
        private int idrank;

        public int Id { get => id; set => id = value; }
        public string Tenkh { get => tenkh; set => tenkh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public int Idrank { get => idrank; set => idrank = value; }

        public Customers(int id, string tenkh, string sdt, string email, DateTime ngaysinh, int idrank)
        {
            Id = id;
            Tenkh = tenkh;
            Sdt = sdt;
            Email = email;
            Ngaysinh = ngaysinh;
            Idrank = idrank;
        }

        public Customers(DataRow row)
        {
            this.Id = int.Parse(row["id"].ToString());
            this.Tenkh = row["name"].ToString();
            this.Sdt = row["sdt"].ToString();
            this.Email = row["email"].ToString();
            this.Ngaysinh = (DateTime)row["ngaysinh"];
            this.Idrank = int.Parse(row["idrank"].ToString());
        }
    }
}
