using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

using System.Data.SqlClient;


namespace Projec_QLDA
{
    internal class function
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
    }
}
