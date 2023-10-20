using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    internal class Sanpham
    {
        string masp;
        string tensp;
        int dongia;
        SqlCommand cmd;
        public Sanpham() { }

        public string Masp { get => masp; set => masp = value; }
        public string Tensp { get => tensp; set => tensp = value; }
        public int Dongia { get => dongia; set => dongia = value; }
        //public DataTable ListProduct (string sp_name)
        //{
        //    cmd.CommandText=sp_name;
        //    if (masp != null)
        //        cmd.Parameters.Add("@MaSP", SqlDbType.Char).Value = Masp;

        //}
    }
}
