using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.frames
{
    public class Namestaff
    {
        private int id;
        private string name;
        private string tenTaiKhoan;
        private int chucVu;


        public Namestaff(DataRow row)
        {
            Id = int.Parse(row["id"].ToString());
            Name = row["name"].ToString();
            TenTaiKhoan = row["tentk"].ToString();
            ChucVu = int.Parse(row["idpos"].ToString());
        }

        public Namestaff(int id, string name, string tenTaiKhoan, int chucVu)
        {
            Id = id;
            Name = name;
            TenTaiKhoan = tenTaiKhoan;
            ChucVu = chucVu;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
        public int ChucVu { get => chucVu; set => chucVu = value; }
    }
}
