using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon2024_Group2
{
    internal static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public class Birthday
    {
        public string Name { get; private set; }
        public int Year { get; private set; }
        public int Month { get; private set; }
        public int Day { get; private set; }
        public string Gift_last { get; private set; }
        public Birthday()
        {
        }
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
