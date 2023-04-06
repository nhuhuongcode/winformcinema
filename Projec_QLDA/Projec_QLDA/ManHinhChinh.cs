using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using WindowsFormsApp2;
using WindowsFormsApp3;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projec_QLDA
{
    public partial class ManHinhChinh : Form
    {
        public ManHinhChinh()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void menuStrip8_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void quảnLýKếHoạchChiếuPhimToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
           Form1 dashboard__kh_ =new Form1();
                dashboard__kh_.ShowDialog();

        }

        private void nguyễnVănCáToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        //private void quảnlýphimtoolstripmenuitem1_click(object sender, EventArgs e)
        //{
            //this.Hide();
            //QL_Phim ql_phim = new QL_Phim();
           // ql_phim.ShowDialog();
        //}
     

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýLịchChiếuPhimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard__QL_ dashboard__QL_ = new Dashboard__QL_();
            dashboard__QL_.ShowDialog();

        }

        private void quảnLýRạpToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            
        }

        private void quảnLýThểLoaiToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            The_loai_phim the_Loai_Phim = new The_loai_phim();
            the_Loai_Phim.ShowDialog();
        }
         
        private void quảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            QL_Rap qL_Rap = new QL_Rap();
            qL_Rap.ShowDialog();
        }

        private void quảnLýCụmRạpToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            QL_CumRap qL_CumRap = new QL_CumRap();
            qL_CumRap.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dangnhap dangnhap = new Dangnhap();
            dangnhap.ShowDialog();
        }

        private void quảnLýPhimToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            QL_Phim ql_phim = new QL_Phim();
            ql_phim.ShowDialog();
        }
    }
}
