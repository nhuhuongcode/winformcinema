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

namespace Projec_QLDA
{
	public partial class ChitietLichChieu : Form
	{

		SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-DDKM1BA\HAO;Initial Catalog=RAP5;Integrated Security=True");

		public SqlDataAdapter sda = new SqlDataAdapter();
		public DataSet ds = new DataSet();
		public ChitietLichChieu()

		{
			InitializeComponent();
		}

		private void ChitietLichChieu_Load(object sender, EventArgs e)
		{
			
		}

		public void laydulieu()
		{
			try
			{
				SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-DDKM1BA\HAO;Initial Catalog=RAP5;Integrated Security=True");
				cn.Open();
				SqlCommand cmd = new SqlCommand("select  Phim.TenPhim, Rap.MaRap, CumRap.TenCum, LichChieu.MaLichChieu, LichChieu.NgayChieu, Phim.ThoiLuong from((LichChieu INNER JOIN Phim ON LichChieu.MaPhim = Phim.MaPhim) INNER JOIN Rap on Rap.MaRap = LichChieu.MaRap) inner join CumRap on Rap.MaCum = CumRap.MaCum", cn);
				sda.SelectCommand = cmd;
				sda.Fill(ds, "ChiTietLichChieu");
				cn.Close();
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


		}
	}
}
