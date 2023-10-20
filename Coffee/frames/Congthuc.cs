using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.frames
{
    public class Congthuc
    {
        private int id;
        private int idfood;
        private string name;
        private string guide;

        public int Id { get => id; set => id = value; }
        public int Idfood { get => idfood; set => idfood = value; }
        public string Name { get => name; set => name = value; }
        public string Guide { get => guide; set => guide = value; }

        public Congthuc(int id, int idfood, string name, string guide) 
        {
            this.Id = id;
            this.Idfood = idfood;
            this.Name = name;
            this.Guide = guide;
        }
        public Congthuc(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Idfood = (int)row["idfood"];
            this.Guide = row["guide"].ToString();
            this.Name= row["name"].ToString();
        }

    }
}
