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
    public partial class FrmHDN : Form
    {
        SqlConnection ketnoi = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();

        SqlCommand lenh = new SqlCommand();
        DataTable dt = new DataTable();
        string constr;
        public FrmHDN()
        {
            InitializeComponent();
            constr = "Data Source = DESKTOP-IEGRD2D\\SQLEXPRESS; Initial Catalog = quanlybanthuoc; Integrated Security = True";
            ketnoi.ConnectionString = constr;
            ketnoi.Open();
            lenh.Connection = ketnoi;
        }
        void napdsachHD()
        {
            lenh.CommandText = "select SoCTN,MaNCC,MaNV,NgayCTN,Diengiai from HDNHap ";
            lenh.Parameters.Clear();
            da.SelectCommand = lenh; ;
            da.Fill(dt);
            grdHD.DataSource = dt;
        }
        private void grdHD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdHD_DoubleClick(object sender, EventArgs e)
        {
            if (grdHD.SelectedRows.Count > 0)
            {
                clsthuvien.SoCTN = grdHD.SelectedRows[0].Cells["SoCTN"].Value.ToString();
                Close();

            }
        }

        private void grdHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmHDN_Load(object sender, EventArgs e)
        {
            napdsachHD();
        }
    }
}
