using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projec_QLDA
{
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (checkBox1.Checked == false)
                    textBox2.PasswordChar = '*';
                else
                    textBox2.PasswordChar = '\0';
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  ví dụ điều kiện để đăng nhập
            if
                (textBox2.Text == "1234")
            {
                //MessageBox.Show("     Đăng nhập thành công  ");
                this.Hide();
                ManHinhChinh manhinhchinh = new ManHinhChinh();
                manhinhchinh.ShowDialog();
            }


            else
            {
                MessageBox.Show("                        Đăng nhập thất bại \n" +
                   "   Thông tin đăng nhập sai hoặc mật khẩu sai");
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
