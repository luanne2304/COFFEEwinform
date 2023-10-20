using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.frames
{
    public class Promotion
    {
        private int iD;
        private string name;
        private double discount;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public double Discount { get => discount; set => discount = value; }

        public Promotion(int iD, string name, float discount)
        {
            ID = iD;
            Name = name;
            Discount = discount;
        }
        public Promotion(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Discount = (double)row["discount"];
        }

    }
}
