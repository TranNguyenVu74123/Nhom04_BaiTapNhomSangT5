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
            DialogResult result = MessageBox.Show(
                "Chắc muốn thoát chưa",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if(result == DialogResult.Yes)
                Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
			DialogResult result = MessageBox.Show(
				"Chắc muốn cài lại chưa",
				"Xác nhận",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question
				);
            
			txtKetQua.Text = "";
            txtSoA.Text = "";
            txtSoB.Text = "";
        }

		private void btnCong_Click(object sender, EventArgs e)
		{
            int tong;
            Console.WriteLine(txtSoA.Text);
            Console.WriteLine(txtSoB.Text);
            tong = int.Parse(txtSoA.Text) + int.Parse(txtSoB.Text);
            txtKetQua.Text = txtSoA.Text + " + " + txtSoB.Text + " = " + tong;
		}
	}
}
