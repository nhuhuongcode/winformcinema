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
using System.Windows.Forms.VisualStyles;
using System.Reflection;

namespace Projec_QLDA
{
    public partial class Dashboard__QL_ : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-6B95ADJ\\HUONG;Initial Catalog=RAP5;User ID=sa;Password=nguyennhuhuong");

        public SqlDataAdapter sda = new SqlDataAdapter();
        public SqlDataAdapter sdalc = new SqlDataAdapter();
        public SqlDataAdapter sdactlc = new SqlDataAdapter();

        public DataSet ds = new DataSet();
        public Dashboard__QL_()
        {
            InitializeComponent();
        }

        private void Dashboard__QL__Load(object sender, EventArgs e)
        {
            grw_lc.AllowUserToDeleteRows = false;
            grw_lc.ReadOnly = true;
			enable(false);
            laydulieu();
            grw_lc.DataSource = ds;
            grw_lc.DataMember = "LichChieuChiTiet";
            grw_lc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grw_lc.Columns[2].Width = 230;
            grw_lc.Columns[1].Width = 80;
            grw_lc.Columns[0].Width = 80;


        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
		public string cmdmaintext = "select LichChieu.MaLichChieu, ChiTietLichChieu.MaPhim, Phim.TenPhim, LichChieu.MaRap, LichChieu.NgayChieu, ChiTietLichChieu.MaSuat from(LichChieu left JOIN ChiTietLichChieu ON LichChieu.MalichChieu = ChiTietLichChieu.MaLichChieu) " +
					"inner join Phim on ChiTietLichChieu.MaPhim = Phim.MaPhim";
        public void laydulieu()
		{
			try
			{
				SqlConnection cn = new SqlConnection("Data Source=DESKTOP-6B95ADJ\\HUONG;Initial Catalog=RAP5;User ID=sa;Password=nguyennhuhuong");
				cn.Open();
				SqlCommand cmd = new SqlCommand(cmdmaintext, cn);
				sda.SelectCommand = cmd;
				sda.Fill(ds, "LichChieuChiTiet");

				SqlCommand cmdlc = new SqlCommand("select * from LichChieu", cn);
				SqlCommand cmdctlc = new SqlCommand("select * from ChiTietLichChieu", cn);
				SqlCommand cmdp = new SqlCommand("select maphim, tenphim, maphim +': '+ tenphim as thehienphim from Phim", cn);
				SqlCommand cmdsc = new SqlCommand("Select *, MaSuat +': '+ Convert(varchar(2), GioBatDau)+ 'gio'+convert(varchar(2),PhutBatDau) as thehienthoigian from suatchieu", cn);
				SqlCommand cmdr = new SqlCommand("Select *, MaRap +': '+ TenCum as thehienrap from rap inner join cumrap on cumrap.macum = rap.macum", cn);
				SqlDataAdapter sdap = new SqlDataAdapter();
				SqlDataAdapter sdasc = new SqlDataAdapter();
				SqlDataAdapter sdar = new SqlDataAdapter();

				sdalc.SelectCommand = cmdlc;
                sdalc.Fill(ds, "LichChieu");
                sdactlc.SelectCommand = cmdctlc;
				sdactlc.Fill(ds, "ChiTietLichChieu");
				sdap.SelectCommand = cmdp;
				sdap.Fill(ds, "Phim");
				sdasc.SelectCommand = cmdsc;
				sdasc.Fill(ds, "SuatChieu");
				sdar.SelectCommand = cmdr;
				sdar.Fill(ds, "Rap");

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
				tb_malc.ReadOnly = false;
				bt_chinhsua.Enabled = false;
				bt_chinhsua.BackColor = SystemColors.ControlLight;
				bt_them.Enabled = false;
				bt_them.BackColor = SystemColors.ControlLight;
				bt_xoa.Enabled = false;
				bt_xoa.BackColor = SystemColors.ControlLight;

                cb_mar.DataSource = ds.Tables["Rap"];
                cb_mar.ValueMember = "marap";
                cb_mar.DisplayMember = "thehienrap";

                cb_p.DataSource = ds.Tables["Phim"];
                cb_p.ValueMember = "maphim";
                cb_p.DisplayMember = "thehienphim";

                cb_suatchieu.DataSource = ds.Tables["SuatChieu"];
                cb_suatchieu.ValueMember = "masuat";
                cb_suatchieu.DisplayMember = "thehienthoigian";
            }
			else
			{
				bt_chinhsua.Enabled = true;
				bt_chinhsua.BackColor = SystemColors.HotTrack;
				bt_them.Enabled = true;
				bt_them.BackColor = SystemColors.HotTrack;
				bt_xoa.Enabled = true;
				bt_xoa.BackColor = SystemColors.HotTrack;
				tb_malc.ReadOnly= true;
			}

		}

        public bool sua;
        private void bt_chinhsua_Click(object sender, EventArgs e)
		{
			enable(true);
			sua = true;
			if (tb_malc.Text != "")
			{
                SqlCommand fcmd = new SqlCommand(
				"select LichChieu.MaLichChieu, ChiTietLichChieu.MaPhim, Phim.TenPhim, LichChieu.MaRap, LichChieu.NgayChieu, ChiTietLichChieu.MaSuat " +
				"from LichChieu " +
				"inner join ChiTietLichChieu on LichChieu.MalichChieu = ChiTietLichChieu.MaLichChieu " +
				"inner join Phim on ChiTietLichChieu.MaPhim = Phim.MaPhim " +
				"where LichChieu.MalichChieu = @malichchieu", cn);
                cn.Open();
                SqlParameter fmalichchieu = new SqlParameter(
                    "@malichchieu", SqlDbType.VarChar, 10);
                fmalichchieu.Value = tb_malc.Text.Trim();
                fcmd.Parameters.Add(fmalichchieu);
                sda.SelectCommand = fcmd;
                DataTable tb = new DataTable();
                sda.Fill(tb);
                DataRow row = tb.Rows[0];
                cb_p.Text = row[2].ToString();
                cb_suatchieu.Text = row[5].ToString();
				cb_mar.Text = row[3].ToString();
                dT_ngaychieu.Value = DateTime.Parse(row[4].ToString());
                cn.Close();
            }

        }

		public bool them = false;
		private void bt_them_Click(object sender, EventArgs e)
		{
			enable(true);
			them = true;
			tb_malc.Focus();

		}
		
		private void bt_xoa_Click(object sender, EventArgs e)
		{
			enable(true);
			grw_lc.ReadOnly = true;
			grw_lc.AllowUserToDeleteRows = false;
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa thông tin này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			try
			{
				if (result == DialogResult.Yes)
				{
					SqlCommand cmd = new SqlCommand("Delete from chitietlichchieu where malichchieu ='" + tb_malc.Text + "'", cn);
					cn.Open();
					cmd.ExecuteNonQuery();
					cn.Close();
					MessageBox.Show("Đã xóa thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					SqlCommand cmd2 = new SqlCommand(cmdmaintext, cn);
					ds.Tables["LichChieuChiTiet"].Clear();
					cn.Open();
					sda.SelectCommand= cmd2;
					sda.Fill(ds, "LichChieuChiTiet");
					grw_lc.DataSource = ds;
					grw_lc.DataMember = "LichChieuChiTiet";
					cn.Close();
				}
				enable(false);
			}
			catch(Exception ex) { MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void bt_tim_Click(object sender, EventArgs e)
		{
			cn.Open();
			SqlCommand fcmd = new SqlCommand(
                "select LichChieu.MaLichChieu, ChiTietLichChieu.MaPhim, Phim.TenPhim, LichChieu.MaRap, LichChieu.NgayChieu, ChiTietLichChieu.MaSuat " +
				"from (LichChieu INNER JOIN ChiTietLichChieu ON LichChieu.MalichChieu = ChiTietLichChieu.MaLichChieu) " +
				"inner join Phim on ChiTietLichChieu.MaPhim = Phim.MaPhim AND LichChieu.Malichchieu = @malichchieu where LichChieu.MalichChieu = @malichchieu"
				, cn);
			SqlParameter fmalichchieu = new SqlParameter(
				"@malichchieu", SqlDbType.VarChar, 10);
			fmalichchieu.Value = textBox1.Text.Trim();
			fcmd.Parameters.Add(fmalichchieu);
			sda.SelectCommand = fcmd;
			sda.Fill(ds, "LichChieuChiTiettim");
			cn.Close();
			grw_lc.DataSource = ds;
			grw_lc.DataMember = "LichChieuChiTiettim";
			if (string.IsNullOrEmpty(textBox1.Text))
			{
				// Truy vấn tất cả các sản phẩm trong table và hiển thị chúng trong DataGridView.
				laydulieu();
				grw_lc.DataSource = ds;
				grw_lc.DataMember = "LichChieuChiTiet";
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

        private void bt_luu_Click(object sender, EventArgs e)
        {
			enable(true);
				if (tb_malc.Text != "")
				{
				if (them == true)
				{
					SqlCommand command = new SqlCommand();
					command = cn.CreateCommand();
					try
					{
						cn.Open();
						command.CommandText = "insert into LichChieu values ('" + tb_malc.Text.Trim() + "','"+ cb_mar.SelectedValue + "','" + dT_ngaychieu.Value + "')";
						command.ExecuteNonQuery();
						command.CommandText = "insert into ChiTietLichChieu values ('" + tb_malc.Text.Trim() + "','" + cb_suatchieu.SelectedValue + "','"+ cb_p.SelectedValue +"')";
						command.ExecuteNonQuery();
						MessageBox.Show("Cập nhật thành công");
						sda.Fill(ds, "LichChieuChiTiet");
						them = false;
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
				}else if(sua == true)
				{
                    SqlCommand command = new SqlCommand();
                    command = cn.CreateCommand();
                    try
                    {
                        cn.Open();
                        command.CommandText = "update Chitietlichchieu set masuat= '" + cb_suatchieu.SelectedValue + "', maphim ='" + cb_p.SelectedValue+"' where malichchieu ='"+ tb_malc.Text.Trim() + "'";
                        command.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật thành công");
						SqlCommand cmd = new SqlCommand(cmdmaintext,cn);
						ds.Tables["LichChieuChiTiet"].Clear();
						sda.SelectCommand= cmd;
						sda.Fill(ds, "LichChieuChiTiet");
						grw_lc.DataSource= ds;
						grw_lc.DataMember = "LichChieuChiTiet";
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
					MessageBox.Show("Vui lòng nhập mã lịch chiếu","Lỗi", MessageBoxButtons.OK,MessageBoxIcon.Error);
					bt_them_Click(sender, e);
					tb_malc.Focus();
				}
			
            
        }
        private void grw_lc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
			//int i = grw_lc.CurrentRow.Index;
			tb_malc.Text = grw_lc.CurrentRow.Cells[0].Value.ToString();
			cb_p.Text = grw_lc.CurrentRow.Cells[2].Value.ToString();
			cb_mar.Text = grw_lc.CurrentRow.Cells[3].Value.ToString();
			cb_suatchieu.Text = grw_lc.CurrentRow.Cells[5].Value.ToString();
			dT_ngaychieu.Text = grw_lc.CurrentRow.Cells[4].Value.ToString();
        }
        private void grw_lc_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
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