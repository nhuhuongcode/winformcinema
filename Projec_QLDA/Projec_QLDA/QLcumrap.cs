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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
	public partial class QL_CumRap : Form
	{
        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-6B95ADJ\\HUONG;Initial Catalog=RAP5;User ID=sa;Password=nguyennhuhuong");

        public SqlDataAdapter sda = new SqlDataAdapter();
		public DataSet ds = new DataSet();
		public QL_CumRap()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

        private void Form1_Load(object sender, EventArgs e)
        {
            grw_cr.AllowUserToDeleteRows = false;
            grw_cr.ReadOnly = true;
			laydulieu();
			grw_cr.DataSource = ds;
			grw_cr.DataMember = "CumRap";
			grw_cr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			grw_cr.Columns[2].Width = 420;
			grw_cr.Columns[1].Width = 130;
			grw_cr.Columns[0].Width = 80;


		}
		public void laydulieu()
		{
			try
			{
				SqlConnection cn = new SqlConnection("Data Source=DESKTOP-6B95ADJ\\HUONG;Initial Catalog=RAP5;User ID=sa;Password=nguyennhuhuong");
				cn.Open();
				SqlCommand cmd = new SqlCommand("select * from CumRap", cn);
				sda.SelectCommand = cmd;
				sda.Fill(ds, "CumRap");
				cn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
        }

		public void enable(bool i)
		{
			if (i)
			{
                grw_cr.ReadOnly = false;
                bt_chinhsua.Enabled = false;
                bt_chinhsua.BackColor = SystemColors.ControlLight;
                bt_them.Enabled = false;
                bt_them.BackColor = SystemColors.ControlLight;
                bt_xoa.Enabled = false;
                bt_xoa.BackColor = SystemColors.ControlLight;
            }
			else
			{
				grw_cr.ReadOnly = true;
				bt_chinhsua.Enabled = true;
				bt_chinhsua.BackColor = SystemColors.HotTrack;
				bt_them.Enabled = true;
				bt_them.BackColor = SystemColors.HotTrack;
				bt_xoa.Enabled = true;
				bt_xoa.BackColor = SystemColors.HotTrack;
			}

		}
        private void button2_Click(object sender, EventArgs e)
        {
			enable(true);

            // thiet lap chinh sua
            SqlCommand ucmd = new SqlCommand("" +
				"update CumRap set TenCum = @tencum, DiaChi = @diachi where MaCum = @macum"
				, cn);
			SqlParameter utencum = new SqlParameter(
				"@tencum", SqlDbType.NVarChar, 50, "TenCum");
            SqlParameter udiachi = new SqlParameter(
                "@diachi", SqlDbType.NVarChar, 100, "DiaChi");
            SqlParameter umacum = new SqlParameter(
                "@macum", SqlDbType.VarChar, 5, "MaCum");
			ucmd.Parameters.Add(utencum);
			ucmd.Parameters.Add(umacum);
			ucmd.Parameters.Add(udiachi);
			sda.UpdateCommand = ucmd;
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
			enable(true);
            // Chuyển đến hàng cuối cùng.
            grw_cr.FirstDisplayedScrollingRowIndex = grw_cr.Rows.Count - 1;
            // Chuyển đến cột đầu tiên.
            grw_cr.CurrentCell = grw_cr.Rows[grw_cr.Rows.Count - 1].Cells[0];
            // Bắt đầu chỉnh sửa ô.
            grw_cr.BeginEdit(true);

			//thiết lập insert
			SqlCommand icmd = new SqlCommand(
				"insert into CumRap values (@macum, @tencum, @diachi)", cn);
            SqlParameter itencum = new SqlParameter(
                "@tencum", SqlDbType.NVarChar, 50, "TenCum");
            SqlParameter idiachi = new SqlParameter(
                "@diachi", SqlDbType.NVarChar, 100, "DiaChi");
            SqlParameter imacum = new SqlParameter(
                "@macum", SqlDbType.VarChar, 5, "MaCum");
            icmd.Parameters.Add(itencum);
            icmd.Parameters.Add(imacum);
            icmd.Parameters.Add(idiachi);
            sda.InsertCommand = icmd;

        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
			enable(true);
			grw_cr.ReadOnly = true;
			grw_cr.AllowUserToDeleteRows = true;
			SqlCommand dcmd = new SqlCommand(
				"delete from CumRap where macum = @macum", cn);
            SqlParameter dmacum = new SqlParameter(
                "@macum", SqlDbType.VarChar, 5, "MaCum");
			dmacum.SourceVersion = DataRowVersion.Original;
			dcmd.Parameters.Add(dmacum);
			sda.DeleteCommand = dcmd;
        }

        private void bt_tim_Click(object sender, EventArgs e)
		{
			cn.Open();
			SqlCommand fcmd = new SqlCommand(
				"select * from CumRap where macum = @macum", cn);
			SqlParameter fmacum = new SqlParameter(
                "@macum", SqlDbType.VarChar, 5);
			fmacum.Value = textBox1.Text.ToString().Trim();
			fcmd.Parameters.Add(fmacum);
			sda.SelectCommand = fcmd;
			ds.Tables["CumRap"].Clear();
			sda.Fill(ds, "CumRap");
			cn.Close();
            grw_cr.DataSource = ds;
            grw_cr.DataMember = "CumRap";
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                // Truy vấn tất cả các sản phẩm trong table và hiển thị chúng trong DataGridView.
                laydulieu();
                grw_cr.DataSource = ds;
                grw_cr.DataMember = "CumRap";
            }

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Tìm kiếm theo mã cụm rạp")
			{
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
			try
			{
				sda.Update(ds, "CumRap");
				enable(false);
				grw_cr.AllowUserToDeleteRows = false;
			}
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show("Không thể xóa thông tin cụm rạp này!", "Error");
                }
                else if (ex.Number == 2627)
                {
                    MessageBox.Show("Mã cụm rạp đã tồn tại", "Error");
                }

            }
        }
    }
}
