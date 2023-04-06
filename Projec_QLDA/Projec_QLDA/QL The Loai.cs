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
using WindowsFormsApp3;
using WindowsFormsApp1;

namespace WindowsFormsApp2
{
    public partial class The_loai_phim : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-6B95ADJ\\HUONG;Initial Catalog=RAP5;User ID=sa;Password=nguyennhuhuong");

        public SqlDataAdapter sda = new SqlDataAdapter();
        public DataSet ds = new DataSet();
        public The_loai_phim()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grw_tl.AllowUserToDeleteRows = false;
            grw_tl.ReadOnly = true;
            laydulieu();
            grw_tl.DataSource = ds;
            grw_tl.DataMember = "TheLoai";
            grw_tl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grw_tl.Columns[0].Width = 200;


        }
        public void laydulieu()
        {
            try
            {
                SqlConnection cn = new SqlConnection("Data Source=DESKTOP-6B95ADJ\\HUONG;Initial Catalog=RAP5;User ID=sa;Password=nguyennhuhuong");
                cn.Open();
                SqlCommand cmd = new SqlCommand("select * from TheLoai", cn);
                sda.SelectCommand = cmd;
                sda.Fill(ds, "TheLoai");
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
                grw_tl.ReadOnly = false;
                bt_chinhsua.Enabled = false;
                bt_chinhsua.BackColor = SystemColors.ControlLight;
                bt_them.Enabled = false;
                bt_them.BackColor = SystemColors.ControlLight;
                bt_xoa.Enabled = false;
                bt_xoa.BackColor = SystemColors.ControlLight;
            }
            else
            {
                grw_tl.ReadOnly = true;
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
                "update TheLoai set TenTheLoai = @tentheloai,where MaTheLoai = @matheloai"
                , cn);
            SqlParameter utentheloai = new SqlParameter(
                "@tentheloai", SqlDbType.NVarChar, 50, "TenTheLoai");
            SqlParameter umatheloai = new SqlParameter(
                "@matheloai", SqlDbType.VarChar, 5, "MaTheLoai");
            ucmd.Parameters.Add(utentheloai);
            ucmd.Parameters.Add(umatheloai);
            sda.UpdateCommand = ucmd;
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            sda.Update(ds, "TheLoai");
            enable(false);
            grw_tl.AllowUserToDeleteRows = true;
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            enable(true);
            // Chuyển đến hàng cuối cùng.
            grw_tl.FirstDisplayedScrollingRowIndex = grw_tl.Rows.Count - 1;
            // Chuyển đến cột đầu tiên.
            grw_tl.CurrentCell = grw_tl.Rows[grw_tl.Rows.Count - 1].Cells[0];
            // Bắt đầu chỉnh sửa ô.
            grw_tl.BeginEdit(true);

            //thiết lập insert
            SqlCommand icmd = new SqlCommand(
                "insert into TheLoai values (@matheloai, @tentheloai,)", cn);
            SqlParameter itentheloai = new SqlParameter(
                "@tentheloai", SqlDbType.NVarChar, 50, "TenTheLoai");
            SqlParameter imatheloai = new SqlParameter(
                "@matheloai", SqlDbType.VarChar, 5, "MaTheLoai");
            icmd.Parameters.Add(itentheloai);
            icmd.Parameters.Add(imatheloai);
            sda.InsertCommand = icmd;

        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            enable(true);
            grw_tl.ReadOnly = true;
            grw_tl.AllowUserToDeleteRows = true;
            SqlCommand dcmd = new SqlCommand(
                "delete from TheLoai where matheloai = @matheloai", cn);
            SqlParameter dmatheloai = new SqlParameter(
                "@matheloai", SqlDbType.VarChar, 5, "MaTheLoai");
            dmatheloai.SourceVersion = DataRowVersion.Original;
            dcmd.Parameters.Add(dmatheloai);
            sda.DeleteCommand = dcmd;
        }

        private void bt_tim_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand fcmd = new SqlCommand(
                "select * from TheLoai where matheloai = @matheloai", cn);
            SqlParameter fmatheloai = new SqlParameter(
                "@matheloai", SqlDbType.VarChar, 5);
            fmatheloai.Value = textBox1.Text.ToString().Trim();
            fcmd.Parameters.Add(fmatheloai);
            sda.SelectCommand = fcmd;
            ds.Tables["TheLoai"].Clear();
            sda.Fill(ds, "TheLoai");
            cn.Close();
            grw_tl.DataSource = ds;
            grw_tl.DataMember = "TheLoai";
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                // Truy vấn tất cả các sản phẩm trong table và hiển thị chúng trong DataGridView.
                laydulieu();
                grw_tl.DataSource = ds;
                grw_tl.DataMember = "TheLoai";
            }


        }

        private void grw_cr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }    

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Tìm kiếm theo mã thể loại")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
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


