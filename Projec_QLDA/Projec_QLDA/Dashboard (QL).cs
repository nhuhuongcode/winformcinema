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
        public void laydulieu()
		{
			try
			{
				SqlConnection cn = new SqlConnection("Data Source=DESKTOP-6B95ADJ\\HUONG;Initial Catalog=RAP5;User ID=sa;Password=nguyennhuhuong");
				cn.Open();
				SqlCommand cmd = new SqlCommand("select LichChieu.MaLichChieu, LichChieu.MaPhim, Phim.TenPhim, LichChieu.MaRap, LichChieu.NgayChieu, ChiTietLichChieu.MaSuat from (LichChieu INNER JOIN Phim ON LichChieu.MaPhim = Phim.MaPhim) " +
					"inner join ChiTietLichChieu on ChiTietLichChieu.MaLichChieu = LichChieu.MaLichChieu", cn);
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
			fmalichchieu.Value = textBox1.Text.Trim();
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
                            command.CommandText = "insert into LichChieu values ('" + tb_malc.Text.Trim() + "','" + cb_p.SelectedValue + "','" + cb_mar.SelectedValue + "','" + dT_ngaychieu.Value + "')";
                            command.ExecuteNonQuery();
                            command.CommandText = "insert into ChiTietLichChieu values ('" + tb_malc.Text.Trim() + "','" + cb_suatchieu.SelectedValue + "')";
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
                            MessageBox.Show("Mã cụm rạp đã tồn tại", "Error");
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