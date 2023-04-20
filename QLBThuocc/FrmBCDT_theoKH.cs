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
    public partial class FrmBCDT_theoKH : Form
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
        string sql,sql1, constr;
        public FrmBCDT_theoKH()
        {
            InitializeComponent();
        }

        private void btnMH_Click(object sender, EventArgs e)
        {
            sql = "select Q1.MaHH,Q1.TenHH,Sum(Q1.SL *Q1.DG) as Doanhthu From( Select DMHH.MaHH,TenHH,SL,DG,MaKH from HDXuatCT Inner join DMHH on HDxuatCT.MaHH=DMHH.MaHH Inner join HDXuat  on HDXuatCT.SoCTX=HDXuat.SoCTX  where NgayCTX >='" + dtt1.Value + " '  and NgayCTX <= '" + dtt2.Value + "' )Q1  where Q1.MaKH = '" + txtMaKH.Text + "'Group by Q1.MaHH,Q1.TenHH ";
            da = new SqlDataAdapter(sql, conn);
          dt.Clear();
            da.Fill(dt);
            rptbcdoanhthu_theoKH bc = new rptbcdoanhthu_theoKH();
            bc.SetDataSource(dt);// dua du lieu vao bao cao
           bc.DataDefinition.FormulaFields["MaKH"].Text = "'" + txtMaKH.Text + "'";
            //bc.DataDefinition.FormulaFields["GiaTri"].Text = "'" + comboGT.Text + " '";
            FrmrptBCTKH f = new FrmrptBCTKH(bc);
            f.Show();
           // NapKH();
        }
        void NapKH()
        {
            sql1 = "select Distinct MaKH from DMKH";
            da1 = new SqlDataAdapter(sql1, conn1);
            dt1.Clear();
            da1.Fill(dt1);
            txtMaKH.DataSource = dt1;
            txtMaKH.DisplayMember = "MaKH";


        }

        private void FrmBCDT_theoKH_Load(object sender, EventArgs e)
        {
            constr = "Data Source = DESKTOP-IEGRD2D\\SQLEXPRESS; Initial Catalog = quanlybanthuoc; Integrated Security = True";
            conn1.ConnectionString = constr;
            conn1.Open();
            conn.ConnectionString = constr;
            conn.Open();
            NapKH();
        }
    }
}
