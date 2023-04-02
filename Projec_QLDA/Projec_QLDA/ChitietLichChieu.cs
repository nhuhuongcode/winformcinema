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
using System.Reflection;

namespace Projec_QLDA
{
	public partial class ChitietLichChieu : Form
	{
		public string malc { get; set; }
		public string ngaychieu { get; set; }
		public string map { get; set; }
		public string tenphim { get; set; }
		public string mar { get; set; }

		public string masuat { get; set; }


		SqlConnection cn = new SqlConnection("Data Source=DESKTOP-6B95ADJ\\HUONG;Initial Catalog=RAP5;User ID=sa;Password=nguyennhuhuong");

		public SqlDataAdapter sda = new SqlDataAdapter();
		public SqlDataAdapter sda2 = new SqlDataAdapter();

		public DataSet ds = new DataSet();
		public ChitietLichChieu()

		{
			InitializeComponent();
		}

		public void laydulieu()
		{
			try
			{
				SqlConnection cn = new SqlConnection("Data Source=DESKTOP-6B95ADJ\\HUONG;Initial Catalog=RAP5;User ID=sa;Password=nguyennhuhuong");
				cn.Open();
				SqlCommand cmd = new SqlCommand("SELECT LichChieu.MaLichChieu, Phim.TenPhim, Rap.MaRap, CumRap.TenCum, LichChieu.NgayChieu, " +
					"CONCAT(SuatChieu.GioBatDau, ':', SuatChieu.PhutBatDau) AS SuatChieu FROM(((LichChieu INNER JOIN Phim ON LichChieu.MaPhim = Phim.MaPhim) " +
					"INNER JOIN Rap ON Rap.MaRap = LichChieu.MaRap) INNER JOIN CumRap ON Rap.MaCum = CumRap.MaCum) INNER JOIN ChiTietLichChieu ON ChiTietLichChieu.MaLichChieu = " +
					"LichChieu.MaLichChieu INNER JOIN SuatChieu ON SuatChieu.MaSuat = ChiTietLichChieu.MaSuat " +
					"where LichChieu.MaPhim = '"+map+"' and LichChieu.NgayChieu ='"+ngaychieu+"'" , cn);
				SqlCommand cmd2 = new SqlCommand("SELECT Phim.TenPhim, Rap.MaRap, CumRap.TenCum, LichChieu.MaLichChieu, LichChieu.NgayChieu, " +
					"CONCAT(SuatChieu.GioBatDau, ':', SuatChieu.PhutBatDau) AS SuatChieu FROM(((LichChieu INNER JOIN Phim ON LichChieu.MaPhim = Phim.MaPhim) " +
					"INNER JOIN Rap ON Rap.MaRap = LichChieu.MaRap) INNER JOIN CumRap ON Rap.MaCum = CumRap.MaCum) INNER JOIN ChiTietLichChieu ON ChiTietLichChieu.MaLichChieu = " +
					"LichChieu.MaLichChieu INNER JOIN SuatChieu ON SuatChieu.MaSuat = ChiTietLichChieu.MaSuat " +
					"where LichChieu.malichchieu = '"+malc+"'", cn);
				sda.SelectCommand = cmd;
				sda.Fill(ds, "ChiTietLichChieu");
				cn.Close();
                tb_malc.Text = malc;
                tb_tenp.Text = tenphim;
                tb_ngaychieu.Text = Convert.ToDateTime(ngaychieu).ToString("dd-MM-yyyy");
                tb_mar.Text = mar;
				sda2.SelectCommand = cmd2;
				sda2.Fill(ds, "chitietmotlichchieu");
				tb_cumr.Text = ds.Tables["chitietmotlichchieu"].Rows[0]["TenCum"].ToString();
				tb_suatchieu.Text = ds.Tables["chitietmotlichchieu"].Rows[0]["SuatChieu"].ToString();
            }
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void ChitietLichChieu_Load_1(object sender, EventArgs e)
		{
			grw_chitiet.AllowUserToDeleteRows = false;
			grw_chitiet.ReadOnly = true;
			laydulieu();
			grw_chitiet.DataSource = ds;
			grw_chitiet.DataMember = "ChiTietLichChieu";
			grw_chitiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			grw_chitiet.Columns[2].Width = 180;
			grw_chitiet.Columns[1].Width = 80;
			grw_chitiet.Columns[3].Width = 80;
			grw_chitiet.Columns[0].Width = 250;
			grw_chitiet.Columns[4].Width = 80;
			tb_cumr.ReadOnly= true;
			tb_mar.ReadOnly= true;
			tb_malc.ReadOnly= true;
			tb_ngaychieu.ReadOnly= true;
			tb_suatchieu.ReadOnly= true;
			tb_tenp.ReadOnly= true;
		}

    }
}
