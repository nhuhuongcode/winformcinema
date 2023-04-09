using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;


namespace Projec_QLDA
{
    public partial class Dangnhap : Form
    {
        public SqlConnection cn = new SqlConnection("Data Source=DESKTOP-6B95ADJ\\HUONG;Initial Catalog=RAP5;User ID=test;Password=123456789");
        public SqlCommand cmd = new SqlCommand();
        
        public Dangnhap()
        {
            InitializeComponent();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (checkBox1.Checked == false)
                    tb_mk.PasswordChar = '*';
                else
                    tb_mk.PasswordChar = '\0';
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT COUNT(*) FROM account WHERE nameuser = '"+tb_tendn.Text+"' and passwork ='"+tb_mk.Text+"'";
            SqlCommand command = new SqlCommand(query, cn);
            cn.Open();
            int count = (int)command.ExecuteScalar();
            cn.Close();
            if (count > 0)
            {
                string query2 = "SELECT roleuser FROM ten_bang WHERE ten_cot = '" + tb_tendn.Text + "' and '" + tb_mk.Text + "'";
                this.Hide();
                ManHinhChinh manhinhchinh = new ManHinhChinh();
                manhinhchinh.ShowDialog();
            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập sai hoặc mật khẩu sai", "Đăng nhập thất bại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
