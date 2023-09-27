using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_2001210455_BuiQuocCong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            this.errorProvider1.Clear();
            int n = 0, m = 0;
            string a = txbA.Text, b = txbB.Text;
            if (int.TryParse(a, out n) && int.TryParse(b, out m))
                txbKQ.Text = (n + m).ToString();
                
            else
                this.errorProvider1.SetError(ctr,"Nhập đủ 2 giá trị số");
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            this.errorProvider1.Clear();
            int n = 0, m = 0;
            string a = txbA.Text, b = txbB.Text;
            if (int.TryParse(a, out n) && int.TryParse(b, out m))
                txbKQ.Text = (n - m).ToString();

            else
                this.errorProvider1.SetError(ctr, "Nhập đủ 2 giá trị số");
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            this.errorProvider1.Clear();
            int n = 0, m = 0;
            string a = txbA.Text, b = txbB.Text;
            if (int.TryParse(a, out n) && int.TryParse(b, out m))
                txbKQ.Text = (n * m).ToString();

            else
                this.errorProvider1.SetError(ctr, "Nhập đủ 2 giá trị số");
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            this.errorProvider1.Clear();
            int n = 0, m = 0;
            string a = txbA.Text, b = txbB.Text;
            if (int.TryParse(a, out n) && int.TryParse(b, out m))
                txbKQ.Text = (n * 1.0 / m).ToString();

            else
                this.errorProvider1.SetError(ctr, "Nhập đủ 2 giá trị số");
        }

    }
}
