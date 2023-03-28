using Projec_QLDA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;


namespace WindowsFormsApp1
{
    public partial class QL_Rap : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-6B95ADJ\\HUONG;Initial Catalog=RAP5;User ID=sa;Password=nguyennhuhuong");
        public SqlDataAdapter sda = new SqlDataAdapter();
        public DataSet ds = new DataSet();
        public function fn = new function();
        public QL_CumRap cr = new QL_CumRap();
        public QL_Rap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grw_r.AllowUserToDeleteRows = false;
            grw_r.ReadOnly = true;
            laydulieu();
            grw_r.DataSource = ds;
            grw_r.DataMember = "Rap";
            grw_r.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grw_r.Columns[2].Width = 420;
            grw_r.Columns[1].Width = 130;
            grw_r.Columns[0].Width = 80;
        }

        public void laydulieu()
        {
            try
            {
                SqlConnection cn = new SqlConnection("Data Source=DESKTOP-6B95ADJ\\HUONG;Initial Catalog=RAP5;User ID=sa;Password=nguyennhuhuong");
                cn.Open();
                SqlCommand cmd = new SqlCommand("select * from Rap", cn);
                sda.SelectCommand = cmd;
                sda.Fill(ds, "Rap");
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void bt_them_Click(object sender, EventArgs e)
        {
            fn.enable(true, grw_r, bt_chinhsua, bt_them, bt_xoa);
            // Chuyển đến hàng cuối cùng.
            grw_r.FirstDisplayedScrollingRowIndex = grw_r.Rows.Count - 1;
            // Chuyển đến cột đầu tiên.
            grw_r.CurrentCell = grw_r.Rows[grw_r.Rows.Count - 1].Cells[0];
            // Bắt đầu chỉnh sửa ô.
            grw_r.BeginEdit(true);

            //thiết lập insert
            SqlCommand icmd = new SqlCommand(
                "insert into Rap values (@marap, @tongghe, @macum)", cn);
            SqlParameter itongghe = new SqlParameter(
                "@tongghe", SqlDbType.Int, 100, "TongGhe");
            SqlParameter imarap = new SqlParameter(
                "@marap", SqlDbType.VarChar, 5, "MaRap");
            SqlParameter imacum = new SqlParameter(
                "@macum", SqlDbType.VarChar, 5, "MaCum");
            icmd.Parameters.Add(itongghe);
            icmd.Parameters.Add(imacum);
            icmd.Parameters.Add(imarap);
            sda.InsertCommand = icmd;
        }

        private void bt_chinhsua_Click(object sender, EventArgs e)
        {
            fn.enable(true, grw_r, bt_chinhsua, bt_them, bt_xoa);

            // thiet lap chinh sua
            SqlCommand ucmd = new SqlCommand("" +
                "update Rap set TongGhe = @tongghe, MaCum = @macum where MaRap = @marap"
                , cn);
            SqlParameter utongghe = new SqlParameter(
                "@tongghe", SqlDbType.Int, 100, "TongGhe");
            SqlParameter umarap = new SqlParameter(
                "@marap", SqlDbType.VarChar, 5, "MaRap");
            SqlParameter umacum = new SqlParameter(
                "@macum", SqlDbType.VarChar, 5, "MaCum");
            ucmd.Parameters.Add(utongghe);
            ucmd.Parameters.Add(umacum);
            ucmd.Parameters.Add(umarap);
            sda.UpdateCommand = ucmd;
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            fn.enable(true, grw_r, bt_chinhsua, bt_them, bt_xoa);
            grw_r.ReadOnly = true;
            grw_r.AllowUserToDeleteRows = true;
            SqlCommand dcmd = new SqlCommand(
                "delete from Rap where marap = @marap", cn);
            SqlParameter dmacum = new SqlParameter(
                "@marap", SqlDbType.VarChar, 5, "MaRap");
            dmacum.SourceVersion = DataRowVersion.Original;
            dcmd.Parameters.Add(dmacum);
            sda.DeleteCommand = dcmd;
        }

        private void bt_tim_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand fcmd = new SqlCommand(
                "select * from Rap where marap = @marap", cn);
            SqlParameter fmacum = new SqlParameter(
                "@marap", SqlDbType.VarChar, 5);
            fmacum.Value = textBox1.Text.ToString().Trim();
            fcmd.Parameters.Add(fmacum);
            sda.SelectCommand = fcmd;
            ds.Tables["Rap"].Clear();
            sda.Fill(ds, "Rap");
            cn.Close();
            grw_r.DataSource = ds;
            grw_r.DataMember = "Rap";
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                // Truy vấn tất cả các sản phẩm trong table và hiển thị chúng trong DataGridView.
                laydulieu();
                grw_r.DataSource = ds;
                grw_r.DataMember = "Rap";
            }

        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Tìm kiếm theo mã rạp")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }



        private void bt_luu_Click(object sender, EventArgs e)
        {
            
            try
            {
                sda.Update(ds, "Rap");
                fn.enable(false, grw_r, bt_chinhsua, bt_them, bt_xoa);
                grw_r.AllowUserToDeleteRows = false;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show("Mã cụm không tồn tại", "Error");
                }
                else if (ex.Number == 2627)
                {
                    MessageBox.Show("Mã rạp đã tồn tại", "Error");
                }

            }

        }

        // Kiểm tra giá trị đang nhập vào tổng ghế có phải là số nguyên không
        private void grw_r_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (grw_r.IsCurrentCellDirty) // Kiểm tra ô đang được chỉnh sửa thực sự chứa dữ liệu
            {
                if (e.ColumnIndex == 1) // Kiểm tra cột đang nhập có phải là cột số nguyên hay không
                {
                    int i;
                    if (!int.TryParse(e.FormattedValue.ToString(), out i)) // Kiểm tra giá trị nhập vào có phải là số nguyên hay không
                    {
                        e.Cancel = true; // Hủy bỏ thao tác thêm dữ liệu
                        MessageBox.Show("Giá trị nhập vào phải là số nguyên!"); // Hiển thị hộp thoại thông báo
                    }
                }
            }
        }
    }
}