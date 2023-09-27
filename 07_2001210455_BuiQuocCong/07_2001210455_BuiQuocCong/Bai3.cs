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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            switch(txbCode.Text)
            {
                case "1":            
                    txbMH.Text = "Bánh trung thu đậu xanh";
                    lbGia.Text = "200000";
                    break;
                case "2":
                    txbMH.Text = "Bánh trung thu thập cẩm";
                    lbGia.Text = "250000";
                    break;
                case "3":
                    txbMH.Text = "Bánh nướng";
                    lbGia.Text = "150000";
                    break;
            }

        }

        private void btnTTien_Click(object sender, EventArgs e)
        {
            int n, m;
            string gia = lbGia.Text;
            string sl = txbSL.Text;

            if (int.TryParse(sl, out n) && int.TryParse(gia, out m))
            {
                lbTTien.Text = (n * m).ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ và giá tiền là số nguyên.");
            }
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int n, m;
            string thanhtien = lbTTien.Text;
            string tiendua = txbTDua.Text;

            if (int.TryParse(tiendua, out n) && int.TryParse(thanhtien, out m))
            {
                if (n < m)
                {
                    MessageBox.Show("Số tiền đưa phải lớn hơn hoặc bằng tổng tiền.");
                }
                else
                {
                    lbTThua.Text = (n - m).ToString();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số tiền đưa và tổng tiền là số nguyên.");
            }
        }
    }
}
