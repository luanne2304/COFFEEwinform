using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.frames
{
    public class Food
    {
        public Food(int id, string name, int idCate, float price, bool oss)
        {
            this.ID = id;
            this.Name = name;
            this.IdCate = idCate;
            this.Price = price;
            this.Oos = oss;
        }

        public Food(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.IdCate = (int)row["idCate"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
            this.Oos =(bool)row["outofstock"];

        }
        private int iD;
        private string name;
        private float price;
        private int idCate;
        private bool oos;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public float Price { get => price; set => price = value; }
        public int IdCate { get => idCate; set => idCate = value; }
        public bool Oos { get => oos; set => oos = value; }
    }
}
