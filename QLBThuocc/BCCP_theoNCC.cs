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
    public partial class BCCP_theoNCC : Form
    {

        SqlConnection conn = new SqlConnection();
        SqlConnection conn1 = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataAdapter da1 = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        DataTable comdt = new DataTable();
        DataTable dtNhom = new DataTable();
        DataTable dtBC = new DataTable();
        string sql, sql1, constr;

        private void BCCP_theoNCC_Load(object sender, EventArgs e)
        {
            constr = "Data Source = DESKTOP-IEGRD2D\\SQLEXPRESS; Initial Catalog = quanlybanthuoc; Integrated Security = True";
            conn1.ConnectionString = constr;
            conn1.Open();
            conn.ConnectionString = constr;
            conn.Open();
            NapNCC();
        }
        void NapNCC()
        {
            sql1 = "select Distinct MaNCC from DMNCC";
            da1 = new SqlDataAdapter(sql1, conn1);
            dt1.Clear();
            da1.Fill(dt1);
            txtMaNCC.DataSource = dt1;
            txtMaNCC.DisplayMember = "MaNCC";


        }

        private void btnMH_Click(object sender, EventArgs e)
        {
            sql = "select Q2.MaHH,Q2.TenHH,Sum(Q2.SL *Q2.DGN) as chiphi From(Select DMHH.MaHH,TenHH, SL,DGN,MaNCC  from HDNhapCT Inner join DMHH on HDNhapCT.MaHH=DMHH.MaHH  inner  join HDNhap on HDNhap.SoCTN =HDNhapCT.SoCTN where NgayCTN>= '" + dtt1.Value + "' and NgayCTN<= '" + dtt2.Value + " ')Q2 where MaNCC = '" +txtMaNCC.Text + "'Group by Q2.MaHH,Q2.TenHH";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            rptbcchiphi__NCC bc = new rptbcchiphi__NCC();
            bc.SetDataSource(dt);// dua du lieu vao bao cao
            bc.DataDefinition.FormulaFields["MaNCC"].Text = "'" + txtMaNCC.Text + "'";
            //bc.DataDefinition.FormulaFields["GiaTri"].Text = "'" + comboGT.Text + " '";
            FrmCPNCC f = new FrmCPNCC(bc);
            f.Show();
        }

        public BCCP_theoNCC()
        {
            InitializeComponent();
        }

        private void txtMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
