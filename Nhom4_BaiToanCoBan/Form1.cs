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

        private void btnTru_Click(object sender, EventArgs e)
        {
            double soA = double.Parse(txtSoA.Text);
            double soB = double.Parse(txtSoB.Text);
            double ketQua = soA - soB;
            txtKetQua.Text = ketQua.ToString();	
	      }
  
        private void btnCong_Click(object sender, EventArgs e)
        {
                int tong;
                Console.WriteLine(txtSoA.Text);
                Console.WriteLine(txtSoB.Text);
                tong = int.Parse(txtSoA.Text) + int.Parse(txtSoB.Text);
                txtKetQua.Text = txtSoA.Text + " + " + txtSoB.Text + " = " + tong;
        }

	      private void btnChia_Click(object sender, EventArgs e){
 		      try
		            {
                double soA = Convert.ToDouble(txtSoA.Text);
                double soB = Convert.ToDouble(txtSoB.Text);
            
                if (soB != 0)
                {
                    double ketQua = soA / soB;
                    lblKetQua.Text = ketQua.ToString();
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
	
        private void btnNhan_Click(object sender, EventArgs e)
        {
            try
            {
                double soA = Convert.ToDouble(txtSoA.Text);
                double soB = Convert.ToDouble(txtSoB.Text);
                double ketQua = soA * soB;
                txtKetQua.Text = ketQua.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please input a valid number!");
            }
        }
    }

}
