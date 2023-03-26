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

namespace WindowsFormsApp3
{
	public partial class QL_Phim : Form
	{
		SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-DDKM1BA\HAO;Initial Catalog=RAP5;Integrated Security=True");

		public SqlDataAdapter sda = new SqlDataAdapter();
		public DataSet ds = new DataSet();
		public QL_Phim()
		{
			InitializeComponent();
		}

	

		private void Form1_Load(object sender, EventArgs e)
		{
			grw_phim.AllowUserToDeleteRows = false;
			grw_phim.ReadOnly = true;
			laydulieu();
			grw_phim.DataSource = ds;
			grw_phim.DataMember = "Phim";
			grw_phim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			grw_phim.Columns[1].Width = 260;
			grw_phim.Columns[0].Width = 60;
			grw_phim.Columns[2].Width = 110;



		}

		public void laydulieu()
		{
			try
			{
				SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-DDKM1BA\HAO;Initial Catalog=RAP5;Integrated Security=True");
				cn.Open();
				SqlCommand cmd = new SqlCommand("select Phim.MaPhim,  Phim.TenPhim, TheLoai.TenTheLoai, Phim.ThoiLuong, Phim.CoLa3D, Phim.CoLongTieng from(TheLoai INNER JOIN Phim ON TheLoai.MaTheLoai = Phim.MaTheLoaiChinh) ", cn);
				sda.SelectCommand = cmd;
				sda.Fill(ds, "Phim");
				cn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void label1_Click(object sender, EventArgs e)
		{

		}

		public void enable(bool i)
		{
			if (i)
			{
				grw_phim.ReadOnly = false;
				bt_sua.Enabled = false;
				bt_sua.BackColor = SystemColors.ControlLight;
				bt_them.Enabled = false;
				bt_them.BackColor = SystemColors.ControlLight;
				bt_xoa.Enabled = false;
				bt_xoa.BackColor = SystemColors.ControlLight;
			}
			else
			{
				grw_phim.ReadOnly = true;
				bt_sua.Enabled = true;
				bt_sua.BackColor = SystemColors.HotTrack;
				bt_them.Enabled = true;
				bt_them.BackColor = SystemColors.HotTrack;
				bt_xoa.Enabled = true;
				bt_xoa.BackColor = SystemColors.HotTrack;
			}

		}
		

		


		private void bt_them_Click_1(object sender, EventArgs e)
		{

			enable(true);
			// Chuyển đến hàng cuối cùng.
			grw_phim.FirstDisplayedScrollingRowIndex = grw_phim.Rows.Count - 1;
			// Chuyển đến cột đầu tiên.
			grw_phim.CurrentCell = grw_phim.Rows[grw_phim.Rows.Count - 1].Cells[0];
			// Bắt đầu chỉnh sửa ô.
			grw_phim.BeginEdit(true);

			//thiết lập insert
			SqlCommand icmd = new SqlCommand(
				"insert into Phim values (@maphim , @tenphim, @tentheloai, @cola3d, @colongtieng, @cola3d, @thoiluong)", cn);
			SqlParameter imaphim = new SqlParameter(
				"@maphim", SqlDbType.VarChar, 5, "MaPhim");
			SqlParameter itenphim = new SqlParameter(
				"@tenphim", SqlDbType.NVarChar, 50, "TenPhim");
			SqlParameter idiachi = new SqlParameter(
				"@tentheloai", SqlDbType.NVarChar, 50, "TenTheLoai");
			SqlParameter icola3d = new SqlParameter(
				"@cola3d", SqlDbType.Bit, 0, "CoLa3D");
			SqlParameter icolongtieng = new SqlParameter(
				"@colongtieng", SqlDbType.Bit, 0, "CoLongTieng");
			SqlParameter ithoiluong = new SqlParameter(
				"@thoiluong", SqlDbType.Int, 200, "ThoiLuong");
			icmd.Parameters.Add(itenphim);
			icmd.Parameters.Add(imaphim);
			icmd.Parameters.Add(idiachi);
			icmd.Parameters.Add(icola3d);
			icmd.Parameters.Add(icolongtieng);
			icmd.Parameters.Add(ithoiluong);
			sda.UpdateCommand = icmd;
		}

		private void bt_tim_Click_1(object sender, EventArgs e)
		{

			cn.Open();
			SqlCommand fcmd = new SqlCommand(
				"select * from Phim where maphim = @maphim", cn);
			SqlParameter fmacum = new SqlParameter(
				"@maphim", SqlDbType.VarChar, 5);
			fmacum.Value = textBox1.Text.ToString().Trim();
			fcmd.Parameters.Add(fmacum);
			sda.SelectCommand = fcmd;
			ds.Tables["Phim"].Clear();
			sda.Fill(ds, "Phim");
			cn.Close();
			grw_phim.DataSource = ds;
			grw_phim.DataMember = "Phim";
		}

		private void bt_xoa_Click_1(object sender, EventArgs e)
		{
			enable(true);
			grw_phim.ReadOnly = true;
			grw_phim.AllowUserToDeleteRows = true;
			SqlCommand dcmd = new SqlCommand(
				"delete from Phim where maphim = @maphim", cn);
			SqlParameter dmacum = new SqlParameter(
				"@maphim", SqlDbType.VarChar, 5, "MaPhim");
			dmacum.SourceVersion = DataRowVersion.Original;
			dcmd.Parameters.Add(dmacum);
			sda.DeleteCommand = dcmd;
		}

		private void bt_luu_Click_1(object sender, EventArgs e)
		{
			sda.Update(ds, "Phim");
			enable(false);
			grw_phim.AllowUserToDeleteRows = true;
		}

		private void bt_sua_Click(object sender, EventArgs e)
		{
			enable(true);

			// thiet lap chinh sua
			SqlCommand ucmd = new SqlCommand("" +
				"update Phim set TenPhim = @tenphim, TenTheLoai = @tentheloai, CoLa3D = @cola3d, CoLongTieng = @colongtieng, ThoiLuong = @thoiluong where MaPhim = @maphim"
				, cn);
			SqlParameter utenphim = new SqlParameter(
				"@tenphim", SqlDbType.NVarChar, 50, "TenPhim");
			SqlParameter udiachi = new SqlParameter(
				"@tentheloai", SqlDbType.NVarChar, 50, "TenTheLoai");
			SqlParameter umaphim = new SqlParameter(
				"@maphim", SqlDbType.VarChar, 5, "MaPhim");
			SqlParameter ucola3d = new SqlParameter(
				"@cola3d", SqlDbType.Bit, 0, "CoLa3D");
			SqlParameter ucolongtieng = new SqlParameter(
				"@colongtieng", SqlDbType.Bit, 0, "CoLongTieng");
			SqlParameter uthoiluong = new SqlParameter(
				"@thoiluong", SqlDbType.Int, 200, "ThoiLuong");
			ucmd.Parameters.Add(utenphim);
			ucmd.Parameters.Add(umaphim);
			ucmd.Parameters.Add(udiachi);
			ucmd.Parameters.Add(ucola3d);
			ucmd.Parameters.Add(ucolongtieng);
			ucmd.Parameters.Add(uthoiluong);
			sda.UpdateCommand = ucmd;
		}
	}
}
