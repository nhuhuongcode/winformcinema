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
		SqlConnection cn = new SqlConnection("Data Source=DESKTOP-6B95ADJ\\HUONG;Initial Catalog=RAP5;User ID=sa;Password=nguyennhuhuong");

		public SqlDataAdapter sda = new SqlDataAdapter();
		public DataSet ds = new DataSet();
		public Dashboard__QL_()
		{
			InitializeComponent();
		}

		private void Dashboard__QL__Load(object sender, EventArgs e)
		{
			grw_lc.AllowUserToDeleteRows = false;
			grw_lc.ReadOnly = true;
			laydulieu();
			grw_lc.DataSource = ds;
			grw_lc.DataMember = "LichChieu";
			grw_lc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			grw_lc.Columns[2].Width = 230;
			grw_lc.Columns[1].Width = 80;
			grw_lc.Columns[0].Width = 80;
		}

		private void label2_Click_1(object sender, EventArgs e)
		{

		}
		public void laydulieu()
		{
			try
			{
				SqlConnection cn = new SqlConnection("Data Source=DESKTOP-6B95ADJ\\HUONG;Initial Catalog=RAP5;User ID=sa;Password=nguyennhuhuong");
				cn.Open();
				SqlCommand cmd = new SqlCommand("select LichChieu.MaLichChieu, LichChieu.MaPhim, Phim.TenPhim, LichChieu.MaRap, LichChieu.NgayChieu, ChiTietLichChieu.MaSuat from (LichChieu INNER JOIN Phim ON LichChieu.MaPhim = Phim.MaPhim) " +
					"inner join ChiTietLichChieu on ChiTietLichChieu.MaLichChieu = LichChieu.MaLichChieu", cn);
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
				grw_lc.ReadOnly = false;
				bt_chinhsua.Enabled = false;
				bt_chinhsua.BackColor = SystemColors.ControlLight;
				bt_them.Enabled = false;
				bt_them.BackColor = SystemColors.ControlLight;
				bt_xoa.Enabled = false;
				bt_xoa.BackColor = SystemColors.ControlLight;
			}
			else
			{
				grw_lc.ReadOnly = true;
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
			grw_lc.AllowUserToDeleteRows = false;
		}


		private void bt_them_Click(object sender, EventArgs e)
		{
			enable(true);
			// Chuyển đến hàng cuối cùng.
			grw_lc.FirstDisplayedScrollingRowIndex = grw_lc.Rows.Count - 1;
			// Chuyển đến cột đầu tiên.
			grw_lc.CurrentCell = grw_lc.Rows[grw_lc.Rows.Count - 1].Cells[0];
			// Bắt đầu chỉnh sửa ô.
			grw_lc.BeginEdit(true);

			//thiết lập insert
			SqlCommand icmd = new SqlCommand(
				"insert into LichChieu values (@maphim,@marap,@malichchieu,@ngaychieu)", cn);
			SqlCommand i1cmd = new SqlCommand(
				"insert into SuatChieu values (@masuat)", cn);
			SqlCommand i2cmd = new SqlCommand(
				"insert into Phim values (@tenphim)", cn);
			SqlParameter itenphim = new SqlParameter(
				"@tenphim", SqlDbType.NVarChar, 50, "TenPhim");
			SqlParameter imasuat = new SqlParameter(
				"@masuat", SqlDbType.VarChar, 3, "MaSuat");
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
			i1cmd.Parameters.Add(imasuat);
			i2cmd.Parameters.Add(itenphim);
			sda.InsertCommand = icmd;
		}

		private void bt_xoa_Click(object sender, EventArgs e)
		{
			enable(true);
			grw_lc.ReadOnly = true;
			grw_lc.AllowUserToDeleteRows = true;
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
			grw_lc.DataSource = ds;
			grw_lc.DataMember = "LichChieu";
			if (string.IsNullOrEmpty(textBox1.Text))
			{
				// Truy vấn tất cả các sản phẩm trong table và hiển thị chúng trong DataGridView.
				laydulieu();
				grw_lc.DataSource = ds;
				grw_lc.DataMember = "LichChieu";
			}

		}

		private void textBox1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "Tìm kiếm theo mã lịch chiếu")
			{
				textBox1.Text = "";
				textBox1.ForeColor = Color.Black;
			}
		}

        private void grw_lc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ChitietLichChieu form = new ChitietLichChieu();
            form.malc = grw_lc.CurrentRow.Cells[0].Value.ToString();
            form.mar = grw_lc.CurrentRow.Cells[3].Value.ToString();
            form.ngaychieu = grw_lc.CurrentRow.Cells[4].Value.ToString();
            form.tenphim = grw_lc.CurrentRow.Cells[2].Value.ToString();
            form.map = grw_lc.CurrentRow.Cells[1].Value.ToString();
            form.masuat = grw_lc.CurrentRow.Cells[5].Value.ToString();
            this.Hide();
            form.ShowDialog();
        }
    }
}


