using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exportDB
{
    class Record
    {
        string title;
        string number;
        string author;
        string content;
        DateTime theDate;
        DateTime modifytime;
        int authorid;
        int type;
        int lanmu;
        string laiyuan;
        int year;
        int views;
        int shanchu;

        public string Title { get => title; set => title = value; }
        public string Number { get => number; set => number = value; }
        public string Author { get => author; set => author = value; }
        public string Content { get => content; set => content = value; }
        public DateTime TheDate { get => theDate; set => theDate = value; }
        public DateTime Modifytime { get => modifytime; set => modifytime = value; }
        public int Authorid { get => authorid; set => authorid = value; }
        public int Type { get => type; set => type = value; }
        public int Lanmu { get => lanmu; set => lanmu = value; }
        public string Laiyuan { get => laiyuan; set => laiyuan = value; }
        public int Year { get => year; set => year = value; }
        public int Views { get => views; set => views = value; }
        public int Shanchu { get => shanchu; set => shanchu = value; }

        public Record()
        {
            Lanmu = 10;
            Views = 0;
            Shanchu = 0;
        }
    }
}
