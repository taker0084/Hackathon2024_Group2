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
        private void LoadBirthDayData()
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

        

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            LoadBirthDayData();
            var today = DateTime.Today;
            int target_month = int.Parse(textBox1.Text);
            int target_day = int.Parse(textBox2.Text);
            var target_Birthday = new DateTime(today.Year, target_month, target_day);
            for (int i = 0; i < birthday.Count; i++) {
                var Birthday = new DateTime(today.Year, birthday[i].Month, birthday[i].Day);
                TimeSpan difference = target_Birthday-Birthday;
                int daysDifference = difference.Days;
                if (Math.Abs(daysDifference) <= 7)
                {
                    listBox1.Items.Add(birthday[i].Name + "　" + birthday[i].Month + "月　" + birthday[i].Day + "日");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadBirthDayData();
            var today = DateTime.Today;
            label5.Text = today.ToString("MM/dd");
            for (int i = 0; i < birthday.Count; i++) {
                var Birthday = new DateTime(today.Year, birthday[i].Month, birthday[i].Day);
                TimeSpan difference = today - Birthday;
                int daysDifference = difference.Days;
                if (Math.Abs(daysDifference) <= 7) {
                    listBox1.Items.Add(birthday[i].Name + "　" + birthday[i].Month + "月　" + birthday[i].Day + "日");
                }
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Form1_Load(sender, e);
        }

        private string _name;
        private string _month;
        private string _day;
        private string _LastGift;
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            Form2 form = new Form2();
            form.Data = 
        }

        //private void label4_Click(object sender, EventArgs e)
        //{
        //}

    }
    
}
