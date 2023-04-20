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
    public partial class FrmPTraHDNhap : Form
    {
        SqlConnection ketnoi = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();

        SqlCommand lenh = new SqlCommand();
        DataTable dt = new DataTable();
        string constr, sql;
        public FrmPTraHDNhap()
        {

            InitializeComponent();
            constr = "Data Source = DESKTOP-IEGRD2D\\SQLEXPRESS; Initial Catalog = quanlybanthuoc; Integrated Security = True";
            ketnoi.ConnectionString = constr;
            ketnoi.Open();
            lenh.Connection = ketnoi;

        }
        void napdsachHD()
        {
            sql = "select * from PTHNhap ";
            lenh.CommandText = sql;
            lenh.Connection = ketnoi;
            da = new SqlDataAdapter(sql, ketnoi);
            dt.Clear();
            da.Fill(dt);
            grdHDX.DataSource = dt;

        }

        private void grdHDX_DoubleClick(object sender, EventArgs e)
        {
            if (grdHDX.SelectedRows.Count > 0)
            {
                ClassTraHangNhap.MaPTHN = grdHDX.SelectedRows[0].Cells["MaPTHN"].Value.ToString();
                Close();

            }
        }

        private void FrmPTraHDNhap_Load(object sender, EventArgs e)
        {
            napdsachHD();
        }
    }
}
