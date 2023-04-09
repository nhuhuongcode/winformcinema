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
using Projec_QLDA;
using WindowsFormsApp2;
using WindowsFormsApp1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WindowsFormsApp3
{
	public partial class QL_Phim : Form
	{
		SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-DDKM1BA\HAO;Initial Catalog=RAP23;Integrated Security=True"); 

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
			grw_phim.DataMember = "PhimPhim";
			grw_phim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			grw_phim.Columns[1].Width = 230;
			grw_phim.Columns[0].Width = 50;
			grw_phim.Columns[2].Width = 80;
			grw_phim.Columns[3].Width = 120;

		}
		public string cmdmaintext = "SELECT phim.MaPhim, Phim.TenPhim, TheLoai.TenTheLoai as TheLoaiChinh, TenTheLoaiPhu, Phim.ThoiLuong, Phim.CoLa3D, Phim.CoLongTieng FROM Phim left join (SELECT PhimTheLoaiPhu.MaPhim, isnull(STRING_AGG(TheLoai.TenTheLoai, ', '), '') AS TenTheLoaiPhu FROM PhimTheLoaiPhu INNER JOIN TheLoai ON PhimTheLoaiPhu.MaTheLoai = TheLoai.MaTheLoai GROUP BY PhimTheLoaiPhu.MaPhim) as PhimPhim on phim.MaPhim = PhimPhim.MaPhim inner join TheLoai on TheLoai.MaTheLoai = Phim.MaTheLoaiChinh";
		public void laydulieu()
		{
			try
			{
				cn.Open();
				SqlCommand cmd = new SqlCommand(cmdmaintext, cn);
				sda.SelectCommand = cmd;
				sda.Fill(ds, "PhimPhim");
				//SqlCommand cmdphim = new SqlCommand("SELECT phim.MaPhim, Phim.TenPhim, TheLoai.TenTheLoai as TheLoaiChinh, TenTheLoaiPhu, Phim.ThoiLuong, Phim.CoLa3D, Phim.CoLongTieng FROM Phim left join (SELECT PhimTheLoaiPhu.MaPhim, isnull(STRING_AGG(TheLoai.TenTheLoai, ', '), '') AS TenTheLoaiPhu FROM PhimTheLoaiPhu INNER JOIN TheLoai ON PhimTheLoaiPhu.MaTheLoai = TheLoai.MaTheLoai GROUP BY PhimTheLoaiPhu.MaPhim) as PhimPhim on phim.MaPhim = PhimPhim.MaPhim inner join TheLoai on TheLoai.MaTheLoai = Phim.MaTheLoaiChinh;", cn);
				//sda.SelectCommand = cmdphim;
				//sda.Fill(ds, "Phim");

				SqlCommand cmdtl = new SqlCommand("select matheloai, tentheloai, matheloai +': '+ tentheloai as TheLoaiChinh from TheLoai", cn);
				SqlDataAdapter sdaphim = new SqlDataAdapter();
				SqlDataAdapter sdatl = new SqlDataAdapter();

				sdatl.SelectCommand = cmdtl;
				sdatl.Fill(ds, "TheLoai");

				SqlCommand cmdtlp = new SqlCommand("select matheloai, tentheloai, matheloai +': '+ tentheloai as TheLoaiPhu from TheLoai", cn);
				SqlDataAdapter sdatlp = new SqlDataAdapter();
				sdatlp.SelectCommand = cmdtlp;
				sdatlp.Fill(ds, "TheLoaiPhu");

				SqlCommand command = new SqlCommand("SELECT Cola3D FROM Phim", cn);
				SqlDataReader reader = command.ExecuteReader();
				if (reader.Read())
				{
					checkBox1.Checked = (bool)reader["Cola3D"];
				}

				//SqlCommand command1 = new SqlCommand("SELECT CoLongTieng FROM Phim", cn);
				//SqlDataReader reader1 = command.ExecuteReader();

				//if (reader1.Read())
				//{
				//	checkBox2.Checked = (bool)reader1["CoLongTieng"];
				//}

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

				cb_tlc.DataSource = ds.Tables["TheLoai"];
				cb_tlc.ValueMember = "matheloai";
				cb_tlc.DisplayMember = "TheLoaiChinh";

				cb_tlp.DataSource = ds.Tables["TheLoaiPhu"];
				cb_tlp.ValueMember = "tentheloai";
				cb_tlp.DisplayMember = "TheLoaiPhu";

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
				tb_maphim.ReadOnly = true;
			}

		}

		public bool them = false;
		private void bt_them_Click_1(object sender, EventArgs e)
		{
			enable(true);
			them = true;
			tb_maphim.Focus();
		}

		private void bt_tim_Click_1(object sender, EventArgs e)
		{

			cn.Open();
			SqlCommand fcmd = new SqlCommand(
				"SELECT phim.MaPhim, Phim.TenPhim, TheLoai.TenTheLoai as TheLoaiChinh, TenTheLoaiPhu, Phim.ThoiLuong, Phim.CoLa3D, Phim.CoLongTieng FROM Phim left join (SELECT PhimTheLoaiPhu.MaPhim, isnull(STRING_AGG(TheLoai.TenTheLoai, ', '), '') AS TenTheLoaiPhu FROM PhimTheLoaiPhu INNER JOIN TheLoai ON PhimTheLoaiPhu.MaTheLoai = TheLoai.MaTheLoai GROUP BY PhimTheLoaiPhu.MaPhim) as PhimPhim on phim.MaPhim = PhimPhim.MaPhim inner join TheLoai on TheLoai.MaTheLoai = Phim.MaTheLoaiChinh where Phim.maphim = '" + tb_tim.Text.Trim() + "';", cn);
			SqlParameter fmacum = new SqlParameter(
				"@maphim", SqlDbType.VarChar, 5);
			fmacum.Value = tb_tim.Text.ToString().Trim();
			fcmd.Parameters.Add(fmacum);
			sda.SelectCommand = fcmd;
			ds.Tables["PhimPhim"].Clear();
			sda.Fill(ds, "Phim");
			cn.Close();
			grw_phim.DataSource = ds;
			grw_phim.DataMember = "PhimPhim";
			if (string.IsNullOrEmpty(tb_tim.Text))
			{
				// Truy vấn tất cả các sản phẩm trong table và hiển thị chúng trong DataGridView.
				laydulieu();
				grw_phim.DataSource = ds;
				grw_phim.DataMember = "PhimPhim";
			}
		}

		private void bt_xoa_Click_1(object sender, EventArgs e)
		{
			enable(true);
			grw_phim.ReadOnly = true;
			grw_phim.AllowUserToDeleteRows = true;
			DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa thông tin này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			try
			{
				if (result == DialogResult.Yes)
				{
					SqlCommand cmd = new SqlCommand("Delete from Phim where maphim ='" + tb_maphim.Text + "'", cn);
					cn.Open();
					cmd.ExecuteNonQuery();
					cn.Close();
					MessageBox.Show("Đã xóa thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					SqlCommand cmd2 = new SqlCommand(cmdmaintext, cn);
					ds.Tables["PhimPhim"].Clear();
					cn.Open();
					sda.SelectCommand = cmd2;
					sda.Fill(ds, "PhimPhim");
					grw_phim.DataSource = ds;
					grw_phim.DataMember = "PhimPhim";
					cn.Close();
				}
				enable(false);
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
		}

		public bool sua;

		private void bt_sua_Click(object sender, EventArgs e)
		{
			enable(true);
			sua = true;
			if (tb_maphim.Text != "")
			{
				SqlCommand fcmd = new SqlCommand(
				"SELECT phim.MaPhim, Phim.TenPhim, TheLoai.TenTheLoai as TheLoaiChinh, TenTheLoaiPhu, Phim.ThoiLuong, Phim.CoLa3D, Phim.CoLongTieng FROM Phim left join (SELECT PhimTheLoaiPhu.MaPhim, isnull(STRING_AGG(TheLoai.TenTheLoai, ', '), '') AS TenTheLoaiPhu FROM PhimTheLoaiPhu INNER JOIN TheLoai ON PhimTheLoaiPhu.MaTheLoai = TheLoai.MaTheLoai GROUP BY PhimTheLoaiPhu.MaPhim) as PhimPhim on phim.MaPhim = PhimPhim.MaPhim inner join TheLoai on TheLoai.MaTheLoai = Phim.MaTheLoaiChinh where Phim.MaPhim = @maphim", cn);
				cn.Open();
				SqlParameter fmaphim = new SqlParameter(
					"@maphim", SqlDbType.VarChar, 10);
				fmaphim.Value = tb_maphim.Text.Trim();
				fcmd.Parameters.Add(fmaphim);
				sda.SelectCommand = fcmd;
				DataTable tb = new DataTable();
				sda.Fill(tb);
				DataRow row = tb.Rows[0];
				tb_tenphim.Text = row[1].ToString();
				cb_tlc.Text = row[2].ToString();
				tb_thoiluong.Text = row[4].ToString();
				cb_tlp.Text = row[3].ToString();
				cn.Close();
			}
		}

		private void textBox1_Click(object sender, EventArgs e)
		{
			if (tb_tim.Text == "Tìm kiếm theo mã phim")
			{
				tb_tim.Text = "";
				tb_tim.ForeColor = Color.Black;
			}
		}

		private void bt_luu_Click_1(object sender, EventArgs e)
		{
			enable(true);
			if (tb_maphim.Text != "")
			{
				if (them == true)
				{
					SqlCommand command = new SqlCommand();
					command = cn.CreateCommand();
					try
					{
						int bad = ktrcheckbox(checkBox1);
						int longtieng = ktrcheckbox(checkBox2);
						cn.Open();
						command.CommandText = "insert into Phim values ('" + tb_maphim.Text.Trim() + "',N'" + tb_tenphim.Text.Trim() + "','" + cb_tlc.SelectedValue + "'," + tb_thoiluong.Text.Trim() + "," + bad + "," + longtieng + ")";
						command.ExecuteNonQuery();
						//command.CommandText = "insert into PhimTheLoaiPhu values ('" + lb_tlp.SelectedValue +  "')";
						foreach (var item in lb_tlp.Items)
						{
							command.CommandText = "select matheloai from theloai where tentheloai = N'" + item.ToString() + "'";
							string matheloai = (string)command.ExecuteScalar();
							command.CommandText = "insert into PhimTheLoaiPhu values ('" + tb_maphim.Text.Trim() + "','" + matheloai + "')";
							command.ExecuteNonQuery();
							cn.Close();
						}
						MessageBox.Show("Cập nhật thành công");
						SqlCommand cmd = new SqlCommand(cmdmaintext, cn);
						sda.SelectCommand = cmd;
						sda.Fill(ds, "PhimPhim");
						them = false;
						enable(false);
						cn.Close();
					}
					catch (SqlException ex)
					{
						if (ex.Number == 2627)
						{
							MessageBox.Show("Mã phim đã tồn tại", "Error");
						}
						else
						{
							MessageBox.Show(ex.Message);
						}
						cn.Close();

					}
				}
				else if (sua == true)
				{
					SqlCommand command = new SqlCommand();
					command = cn.CreateCommand();
					try
					{
						int bad = ktrcheckbox(checkBox1);
						int longtieng = ktrcheckbox(checkBox2);
						cn.Open();
						command.CommandText = "update Phim set tenphim=N'" + tb_tenphim.Text + "', matheloaichinh = '" + cb_tlc.SelectedValue + "', thoiluong =" + tb_thoiluong.Text.Trim() + ", cola3d=" + bad + ", colongtieng= " + longtieng + " where maphim ='" + tb_maphim.Text.Trim() + "'";
						command.ExecuteNonQuery();

						command.CommandText = "delete from PhimTheLoaiPhu where maphim = '" + tb_maphim + "'";
						foreach (var item in lb_tlp.Items)
						{
							command.CommandText = "select matheloai from theloai where tentheloai = N'" + item.ToString() + "'";
							string matheloai = (string)command.ExecuteScalar();
							command.CommandText = "insert into PhimTheLoaiPhu values ('" + tb_maphim.Text.Trim() + "','" + matheloai + "')";
							command.ExecuteNonQuery();
						}

						MessageBox.Show("Cập nhật thành công");
						SqlCommand cmd = new SqlCommand(cmdmaintext, cn);
						ds.Tables["PhimPhim"].Clear();
						sda.SelectCommand = cmd;
						sda.Fill(ds, "PhimPhim");
						grw_phim.DataSource = ds;
						grw_phim.DataMember = "PhimPhim";
						sua = false;
						enable(false);
						cn.Close();
					}
					catch (SqlException ex)
					{
						if (ex.Number == 2627)
						{
							MessageBox.Show("Thông tin bị trùng lặp!", "Error");
						}
						else
						{
							MessageBox.Show(ex.Message);
						}
						cn.Close();
					}
				}
			}
			else
			{
				MessageBox.Show("Vui lòng nhập mã phim", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				bt_them_Click_1(sender, e);
				tb_maphim.Focus();
			}


		}

		private void grw_phim_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			tb_maphim.Text = grw_phim.CurrentRow.Cells[0].Value.ToString();
			cb_tlc.Text = grw_phim.CurrentRow.Cells[2].Value.ToString();
			tb_tenphim.Text = grw_phim.CurrentRow.Cells[1].Value.ToString();
			tb_thoiluong.Text = grw_phim.CurrentRow.Cells[4].Value.ToString();
			//lb_tlp.Text = grw_phim.CurrentRow.Cells[3].Value.ToString(); 
			cb_tlp.Text = grw_phim.CurrentRow.Cells[3].Value.ToString();

		}

		public int ktrcheckbox(CheckBox a)
		{
			if (a.Checked == true)
			{ return 1; }
			return 0;
		}

		private void cb_tlp_SelectedIndexChanged(object sender, EventArgs e)
		{

			string selectedValue = cb_tlp.SelectedValue.ToString();

			if (!lb_tlp.Items.Contains(selectedValue))
			{
				if (!selectedValue.Contains('.'))
				{
					lb_tlp.Items.Add(selectedValue);
				}
			}
		}

		private void lb_tlp_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				int selectedIndex = lb_tlp.SelectedIndex;
				if (selectedIndex != -1)
				{
					lb_tlp.Items.RemoveAt(selectedIndex);
				}
			}

		}

		private void cb_tlp_Click(object sender, EventArgs e)
		{


		}
		private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Hide();
			ManHinhChinh manHinhChinh = new ManHinhChinh();
			manHinhChinh.ShowDialog();
		}

		private void quảnLýKếHoạchChiếuPhimToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form1 dashboard__kh_ = new Form1();
			dashboard__kh_.ShowDialog();
		}

		private void quảnLýLịchChiếuPhimToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Hide();
			Dashboard__QL_ dashboard__QL_ = new Dashboard__QL_();
			dashboard__QL_.ShowDialog();
		}

		private void quảnLýPhimToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Hide();
			QL_Phim qL_Phim = new QL_Phim();
			qL_Phim.ShowDialog();
		}

		private void quảnLýCụmRạpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Hide();
			QL_CumRap qL_CumRap = new QL_CumRap();
			qL_CumRap.ShowDialog();
		}

		private void quảnLýThểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Hide();
			The_loai_phim the_Loai_Phim = new The_loai_phim();
			the_Loai_Phim.ShowDialog();
		}

		private void quảnLýRạpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Hide();
			QL_Rap qL_Rap = new QL_Rap();
			qL_Rap.ShowDialog();
		}

	}
}


