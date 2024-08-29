using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon2024_Group2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private Birthday _Data;
        public Birthday Data
        {
            get { return _Data; }
            set { _Data = value; }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = _Data.Name;
            string Birth = _Data.Year + "年" + _Data.Month + "月" + _Data.Day+"日";
            label2.Text = Birth;
            label3.Text = _Data.Gift_wish;
            label8.Text = _Data.Gift_last;
            label9.Text = _Data.Ideal_day;
        }

    }


}
