using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom4_BaiToanCoBan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = "";
            txtSoA.Text = "";
            txtSoB.Text = "";
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            try
            {
                double soA = Convert.ToDouble(txtSoA.Text);
                double soB = Convert.ToDouble(txtSoB.Text);

                if (soB != 0)
                {
                    double ketQua = soA / soB;
                    txtKetQua.Text = ketQua.ToString();
                }
                else
                {
                    MessageBox.Show("Không thể chia cho 0!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!");
            }
        }
    }
}
