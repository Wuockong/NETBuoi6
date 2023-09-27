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
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private bool kiemtraSNT(int a)
        {
            if(a <= 1)
                return false;
            if(a <= 3)
                return true;
            for (int i = 2; i <= Math.Sqrt(a); i++)
                if (a % i == 0)
                    return false;
            return true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nhap = int.Parse(textBox1.Text);
            if(kiemtraSNT(nhap))
                lbCheck.Text = string.Format("{0} là số nguyên tố", nhap);
            else
                lbCheck.Text = string.Format("{0} không phải là số nguyên tố", nhap);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int nhap = int.Parse(textBox1.Text);
            lbPrint1.Text = string.Format("Các số nguyên tố từ 2..{0} là: ", nhap);
            for (int i = 2; i <= nhap; i++)
                if (kiemtraSNT(i))
                    lbPrint2.Text = string.Format(i + " ");
        }

        private void Bai1_Load(object sender, EventArgs e)
        {

        }
    }
}
