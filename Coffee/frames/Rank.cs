using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.frames
{
    public class Rank
    {
        private int id;
        private string name;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public Rank(int id, string name)
        {
            Id = id;
            Name = name;

        }
        public Rank(DataRow row)
        {
            Id = (int)row["id"];
            Name = row["name"].ToString();
        }
    }
}
