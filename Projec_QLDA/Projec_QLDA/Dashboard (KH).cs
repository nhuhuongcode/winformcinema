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
    public partial class Form1 : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-T87PM31\\SQLEXPRESS;Initial Catalog=RAP5;Integrated Security=True");

        public SqlDataAdapter sda = new SqlDataAdapter();
        public DataSet ds = new DataSet();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grw_kh.AllowUserToDeleteRows = false;
            grw_kh.ReadOnly = true;
            laydulieu();
            grw_kh.DataSource = ds;
            grw_kh.DataMember = "KeHoach";
            grw_kh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //grw_cr.Columns[2].Width = 420;
            //grw_cr.Columns[1].Width = 130;
            //grw_cr.Columns[0].Width = 80;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //private void textBox12_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void textBox22_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void checkBox1_CheckedChanged(object sender, EventArgs e)
        //{

        //}

        //private void label9_Click(object sender, EventArgs e)
        //{

        //}

        //private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        //{

        //}

        //private void checkBox6_CheckedChanged(object sender, EventArgs e)
        //{

        //}

        //private void textBox15_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void textBox17_TextChanged(object sender, EventArgs e)
        //{

        //}

        public void laydulieu()
        {
            try
            {
                SqlConnection cn = new SqlConnection("Data Source=DESKTOP-T87PM31\\SQLEXPRESS;Initial Catalog=RAP5;Integrated Security=True");
                cn.Open();
                SqlCommand cmd = new SqlCommand("select * from KeHoach", cn);
                sda.SelectCommand = cmd;
                sda.Fill(ds, "KeHoach");
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
                grw_kh.ReadOnly = false;
                bt_chinhsua.Enabled = false;
                bt_chinhsua.BackColor = SystemColors.ControlLight;
                bt_them.Enabled = false;
                bt_them.BackColor = SystemColors.ControlLight;
                bt_xoa.Enabled = false;
                bt_xoa.BackColor = SystemColors.ControlLight;
            }
            else
            {
                grw_kh.ReadOnly = true;
                bt_chinhsua.Enabled = true;
                bt_chinhsua.BackColor = SystemColors.HotTrack;
                bt_them.Enabled = true;
                bt_them.BackColor = SystemColors.HotTrack;
                bt_xoa.Enabled = true;
                bt_xoa.BackColor = SystemColors.HotTrack;
            }

        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            enable(true);
            //chinh sua
            SqlCommand ucmd = new SqlCommand("" +
                "update KeHoach set GhiChu = @ghichu where MaPhim=@maphim and MaCum = @macum and NgayKhoiChieu = @ngaykhoichieu and NgayKetThuc = @ngayketthuc", cn);
            SqlParameter umaphim = new SqlParameter(
                "@maphim", SqlDbType.NVarChar, 10, "MaPhim");
            SqlParameter umacum = new SqlParameter(
                "@macum", SqlDbType.NVarChar, 5, "MaCum");
            SqlParameter ungaykhoichieu = new SqlParameter(
                "@ngaykhoichieu", SqlDbType.Date, 10, "NgayKhoiChieu");
            SqlParameter ungayketthuc = new SqlParameter(
                "@ngayketthuc", SqlDbType.Date, 10, "NgayKetThuc");
            SqlParameter ughichu = new SqlParameter(
                "@ghichu", SqlDbType.NVarChar, 100, "GhiChu");
            ucmd.Parameters.Add(umaphim);
            ucmd.Parameters.Add(umacum);
            ucmd.Parameters.Add(ungaykhoichieu);
            ucmd.Parameters.Add(ungayketthuc);
            ucmd.Parameters.Add(ughichu);
            sda.UpdateCommand = ucmd;
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            sda.Update(ds, "KeHoach");
            enable(false);
            grw_kh.AllowUserToDeleteRows = false;
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            enable(true);
            // Chuyển đến hàng cuối cùng.
            grw_kh.FirstDisplayedScrollingRowIndex = grw_kh.Rows.Count - 1;
            // Chuyển đến cột đầu tiên.
            grw_kh.CurrentCell = grw_kh.Rows[grw_kh.Rows.Count - 1].Cells[0];
            // Bắt đầu chỉnh sửa ô.
            grw_kh.BeginEdit(true);

            //thiết lập insert
            SqlCommand icmd = new SqlCommand(
                "insert into KeHoach values (@maphim, @macum, @ngaykhoichieu, @ngayketthuc, @ghichu)", cn);
            SqlParameter imaphim = new SqlParameter(
                "@maphim", SqlDbType.NVarChar, 10, "MaPhim");
            SqlParameter imacum = new SqlParameter(
                "@macum", SqlDbType.NVarChar, 5, "MaCum");
            SqlParameter ingaykhoichieu = new SqlParameter(
                "@ngaykhoichieu", SqlDbType.Date, 10, "NgayKhoiChieu");
            SqlParameter ingayketthuc = new SqlParameter(
                "@ngayketthuc", SqlDbType.Date, 10, "NgayKetThuc");
            SqlParameter ighichu = new SqlParameter(
                "@ghichu", SqlDbType.NVarChar, 100, "GhiChu");
            icmd.Parameters.Add(imaphim);
            icmd.Parameters.Add(imacum);
            icmd.Parameters.Add(ingaykhoichieu);
            icmd.Parameters.Add(ingayketthuc);
            icmd.Parameters.Add(ighichu);
            sda.UpdateCommand = icmd;
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            enable(true);
            grw_kh.ReadOnly = true;
            grw_kh.AllowUserToDeleteRows = true;
            SqlCommand dcmd = new SqlCommand(
                "delete from KeHoach where maphim = @maphim and macum = @macum and ngaykhoichieu = @ngaykhoichieu and ngayketthuc = @ngayketthuc", cn);
            SqlParameter dmaphim = new SqlParameter(
                "@maphim", SqlDbType.VarChar, 10, "MaPhim");
            SqlParameter dmacum = new SqlParameter(
                "@macum", SqlDbType.NVarChar, 5, "MaCum");
            SqlParameter dngaykhoichieu = new SqlParameter(
                "@ngaykhoichieu", SqlDbType.Date, 10, "NgayKhoiChieu");
            SqlParameter dngayketthuc = new SqlParameter(
                "@ngayketthuc", SqlDbType.Date, 10, "NgayKetThuc");
            SqlParameter dghichu = new SqlParameter(
                "@ghichu", SqlDbType.NVarChar, 100, "GhiChu");
            dmaphim.SourceVersion = DataRowVersion.Original;
            dmacum.SourceVersion = DataRowVersion.Original;
            dngaykhoichieu.SourceVersion = DataRowVersion.Original;
            dngayketthuc.SourceVersion = DataRowVersion.Original;
            dghichu.SourceVersion = DataRowVersion.Original;
            dcmd.Parameters.Add(dmaphim);
            dcmd.Parameters.Add(dmacum);
            dcmd.Parameters.Add(dngaykhoichieu);
            dcmd.Parameters.Add(dngayketthuc);
            dcmd.Parameters.Add(dghichu);
            sda.DeleteCommand = dcmd;
        }

        private void bt_tim_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand fcmd = new SqlCommand(
                "select * from KeHoach where maphim = @maphim");
            SqlParameter fmaphim = new SqlParameter(
                "@maphim", SqlDbType.VarChar, 10 );
            fmaphim.Value = textBox1.Text.ToString().Trim();
            fcmd.Parameters.Add(fmaphim);
            sda.SelectCommand = fcmd;
            ds.Tables["KeHoach"].Clear();
            sda.Fill(ds, "KeHoach");
            cn.Close();
            grw_kh.DataSource = ds;
            grw_kh.DataMember = "KeHoach";
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                laydulieu();
                grw_kh.DataSource = ds;
                grw_kh.DataMember = "KeHoach";
            }    

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Tìm kiếm theo mã phim")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }



        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // Form1
        //    // 
        //    this.ClientSize = new System.Drawing.Size(360, 271);
        //    this.Name = "Form1";
        //    this.ResumeLayout(false);

        //}
    }
}




