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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txbA.Clear();
            txbB.Clear();
            txbC.Clear();
            lbKQ.Text = "= 0";
            lbX1.Text = "X1 =";
            lbX2.Text = "X2 =";
            lbX12.Text = "X1 = X2 =";
            lbVN.Text = "";
            txbA.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a,b,c;
            if(double.TryParse(txbA.Text, out a) && double.TryParse(txbB.Text, out b) && double.TryParse(txbC.Text, out c))
            {
                double delta = b * b - 4 * a * c;
                lbKQ.Text = string.Format("= {0}", delta);
                if (delta > 0)
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    lbX1.Text = string.Format("X1 = {0}", x1);
                    lbX2.Text = string.Format("X2 = {0}", x2);
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    lbX12.Text = string.Format("X1 = X2 {0}", x);
                }
                else
                {
                    lbVN.Text = "Phương trình Vô Nghiệm";
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập các hệ số hợp lệ (a, b, c) là số thực.");
            }
        }
    }
}
