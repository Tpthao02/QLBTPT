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
namespace QLBThuocc
{
    public partial class FrmHDX : Form
    {
        SqlConnection ketnoi = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();

        SqlCommand lenh = new SqlCommand();
        DataTable dt = new DataTable();
        string constr, sql;
        public FrmHDX()
        {
            InitializeComponent();
            constr = "Data Source = DESKTOP-IEGRD2D\\SQLEXPRESS; Initial Catalog = quanlybanthuoc; Integrated Security = True";
            ketnoi.ConnectionString = constr;
            ketnoi.Open();
            lenh.Connection = ketnoi;
        }
        void napdsachHD()
        {
            sql = "select * from HDXuat ";
            lenh.CommandText = sql;
            lenh.Connection = ketnoi;
            da = new SqlDataAdapter(sql, ketnoi);
            dt.Clear();
            da.Fill(dt);
            grdHDX.DataSource = dt;

        }

        private void grdHD_DoubleClick(object sender, EventArgs e)
        {
            if (grdHDX.SelectedRows.Count > 0)
            {
                Classthuvienxuat.SoCTX = grdHDX.SelectedRows[0].Cells["SoCTX"].Value.ToString();
                Close();

            }
        }

        private void FrmHDX_Load(object sender, EventArgs e)
        {
            napdsachHD();
        }
    }
}
