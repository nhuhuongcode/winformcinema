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

namespace Projec_QLDA
{
	public partial class Dashboard__QL_ : Form
	{
		SqlConnection cn = new SqlConnection("Data Source=DESKTOP-T87PM31\SQLEXPRESS;Initial Catalog=RAP5;Integrated Security=True");

		public SqlDataAdapter sda = new SqlDataAdapter();
		public DataSet ds = new DataSet();
		public Dashboard__QL_()
		{
			InitializeComponent();
		}

		//private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		//{

		//}

		//private void textBox18_TextChanged(object sender, EventArgs e)
		//{

		//}

		//private void label2_Click(object sender, EventArgs e)
		//{

		//}

		//private void button4_Click(object sender, EventArgs e)
		//{

		//}

		//private void textBox12_TextChanged(object sender, EventArgs e)
		//{

		//}

		//private void label10_Click(object sender, EventArgs e)
		//{

		//}

		//private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		//{
		//	Chi_tiết_lịch_chiếu_phim form2 = new Chi_tiết_lịch_chiếu_phim(); //create an instance of Form 2
		//	form2.ShowDialog(); //show Form2 á a modal dialog
		//}

		private void Dashboard__QL__Load(object sender, EventArgs e)
		{
			grw_cr.AllowUserToDeleteRows = false;
			grw_cr.ReadOnly = true;
			laydulieu();
			grw_cr.DataSource = ds;
			grw_cr.DataMember = "LichChieu";
			grw_cr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			grw_cr.Columns[2].Width = 230;
			grw_cr.Columns[1].Width = 80;
			grw_cr.Columns[0].Width = 80;
		}

		private void label2_Click_1(object sender, EventArgs e)
		{

		}
		public void laydulieu()
		{
			try
			{
				SqlConnection cn = new SqlConnection("Data Source=DESKTOP-T87PM31\SQLEXPRESS;Initial Catalog=RAP5;Integrated Security=True");
				cn.Open();
				SqlCommand cmd = new SqlCommand("select LichChieu.MaLichChieu, LichChieu.MaPhim, Phim.TenPhim, LichChieu.MaRap, LichChieu.NgayChieu from (LichChieu INNER JOIN Phim ON LichChieu.MaPhim = Phim.MaPhim)", cn);
				sda.SelectCommand = cmd;
				sda.Fill(ds, "LichChieu");
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


		private void bt_chinhsua_Click(object sender, EventArgs e)
		{
			enable(true);

			// thiet lap chinh sua
			SqlCommand ucmd = new SqlCommand("" +
				"update LichChieu set MaPhim = @maphim, MaRap = @marap, NgayChieu = @ngaychieu where MaLichChieu = @malichchieu"
				, cn);
			SqlParameter umaphim = new SqlParameter(
				"@maphim", SqlDbType.NVarChar, 10, "MaPhim");
			SqlParameter umarap = new SqlParameter(
				"@marap", SqlDbType.NVarChar, 5, "MaRap");
			SqlParameter umalichchieu = new SqlParameter(
				"@malichchieu", SqlDbType.VarChar, 10, "MaLichChieu");
			SqlParameter ungaychieu = new SqlParameter(
				"@ngaychieu", SqlDbType.Date, 10, "NgayChieu");
			ucmd.Parameters.Add(umaphim);
			ucmd.Parameters.Add(umarap);
			ucmd.Parameters.Add(umalichchieu);
			ucmd.Parameters.Add(ungaychieu);
			sda.UpdateCommand = ucmd;
		}

		private void bt_luu_Click(object sender, EventArgs e)
		{
			sda.Update(ds, "LichChieu");
			enable(false);
			grw_cr.AllowUserToDeleteRows = false;
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
				"insert into LichChieu values (@maphim,@marap,@malichchieu,@ngaychieu)", cn);
			SqlParameter imaphim = new SqlParameter(
				"@maphim", SqlDbType.NVarChar, 10, "MaPhim");
			SqlParameter imarap = new SqlParameter(
				"@marap", SqlDbType.NVarChar, 5, "MaRap");
			SqlParameter imalichchieu = new SqlParameter(
				"@malichchieu", SqlDbType.VarChar, 10, "MaLichChieu");
			SqlParameter ingaychieu = new SqlParameter(
				"@ngaychieu", SqlDbType.Date, 10, "NgayChieu");
			icmd.Parameters.Add(imaphim);
			icmd.Parameters.Add(imarap);
			icmd.Parameters.Add(imalichchieu);
			icmd.Parameters.Add(ingaychieu);
			sda.InsertCommand = icmd;
		}

		private void bt_xoa_Click(object sender, EventArgs e)
		{
			enable(true);
			grw_cr.ReadOnly = true;
			grw_cr.AllowUserToDeleteRows = true;
			SqlCommand dcmd = new SqlCommand(
				"delete from LichChieu where malichchieu = @malichchieu", cn);
			SqlParameter dmalichchieu = new SqlParameter(
				"@malichchieu", SqlDbType.VarChar, 10, "MaLichChieu");
			dmalichchieu.SourceVersion = DataRowVersion.Original;
			dcmd.Parameters.Add(dmalichchieu);
			sda.DeleteCommand = dcmd;
		}

		private void bt_tim_Click(object sender, EventArgs e)
		{
			cn.Open();
			SqlCommand fcmd = new SqlCommand(
				"select * from LichChieu where malichchieu = @malichchieu", cn);
			SqlParameter fmalichchieu = new SqlParameter(
				"@malichchieu", SqlDbType.VarChar, 10);
			fmalichchieu.Value = textBox1.Text.ToString().Trim();
			fcmd.Parameters.Add(fmalichchieu);
			sda.SelectCommand = fcmd;
			ds.Tables["LichChieu"].Clear();
			sda.Fill(ds, "LichChieu");
			cn.Close();
			grw_cr.DataSource = ds;
			grw_cr.DataMember = "LichChieu";
			if (string.IsNullOrEmpty(textBox1.Text))
			{
				// Truy vấn tất cả các sản phẩm trong table và hiển thị chúng trong DataGridView.
				laydulieu();
				grw_cr.DataSource = ds;
				grw_cr.DataMember = "LichChieu";
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
	}
}


