using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Coffee.frames
{
    public class Report
    {
        private int id;
        private string title;
        private string content;
        private int idstaff;

        public Report(int id, string title, string content, int idstaff)
        {
            Id = id;
            Title = title;
            Content = content;
            Idstaff = idstaff;
        }

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Content { get => content; set => content = value; }
        public int Idstaff { get => idstaff; set => idstaff = value; }

        public Report(DataRow row)
        {
            Id = int.Parse(row["id"].ToString());
            Title = row["title"].ToString();
            Content = row["content"].ToString();
            Idstaff = int.Parse(row["idstaff"].ToString());
        }
    }
}
