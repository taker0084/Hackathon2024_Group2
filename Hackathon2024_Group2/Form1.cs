using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon2024_Group2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Birthday> birthday = new List<Birthday>();
        private void LoadFestivalData()
        {
            birthday.Clear();
            using (StreamReader sr = new StreamReader("csv2024_2.csv")) //データの読み込み
            {
                while (!sr.EndOfStream)
                {
                    string s = sr.ReadLine();
                    string[] test = s.Split(',');
                    string name = test[0];
                    int year = int.Parse(test[1]);
                    int month = int.Parse(test[2]);
                    int day = int.Parse(test[3]);
                    string gift_l = (test[4]);
                    Birthday b = new Birthday(name, year, month, day, gift_l);
                    birthday.Add(b);
                }
            }
        }
        //private void label4_Click(object sender, EventArgs e)
        //{
        //}
    }
    class Birthday
    {
        public string Name { get; private set; }
        public int Year { get; private set; }
        public int Month { get; private set; }
        public int Day { get; private set; }
        public string Gift_last { get; private set; }
        public Birthday(string name, int year, int month, int day, string gift_l)
        {
            Name = name;
            Year = year;
            Month = month;
            Day = day;
            Gift_last = gift_l;
        }
    }
}
