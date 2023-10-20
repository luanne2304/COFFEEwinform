using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.frames
{
    public class Sala
    {
        private string idstaff;
        private float luong;
        private bool status;

        public string Idstaff { get => idstaff; set => idstaff = value; }
        public float Luong { get => luong; set => luong = value; }
        public bool Status { get => status; set => status = value; }


        public Sala(DataRow row)
        {
            Idstaff = row["idstaff"].ToString();
            Luong = (float)Convert.ToDouble(row["luong"].ToString());
            Status= (bool)row["status"]; ;
        }

        public Sala(string idstaff, float luong, bool status)
        {
            Idstaff = idstaff;
            Luong = luong;
            Status = status;
        }
    }
}
