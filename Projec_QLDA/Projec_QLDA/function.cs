using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Projec_QLDA
{
    public class function
    {
        SqlConnection cn = new SqlConnection("Data Source = DESKTOP-6B95ADJ\\HUONG;Initial Catalog = RAP5; User ID = sa;Password=nguyennhuhuong");
        public SqlDataAdapter sda = new SqlDataAdapter();
        public DataSet ds = new DataSet();
        public void laydulieu(string query, string nametb)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand(query, cn);
            sda.SelectCommand= cmd;
            sda.Fill(ds, nametb);
        }

        public void enable(bool i, DataGridView gr, Button sua, Button them, Button xoa)
        {
            if (i)
            {
                gr.ReadOnly = false;
                sua.Enabled = false;
                sua.BackColor = SystemColors.ControlLight;
                them.Enabled = false;
                them.BackColor = SystemColors.ControlLight;
                xoa.Enabled = false;
                xoa.BackColor = SystemColors.ControlLight;
            }
            else
            {
                gr.ReadOnly = true;
                sua.Enabled = true;
                sua.BackColor = SystemColors.HotTrack;
                them.Enabled = true;
                them.BackColor = SystemColors.HotTrack;
                xoa.Enabled = true;
                xoa.BackColor = SystemColors.HotTrack;
            }

        }

    }
}
