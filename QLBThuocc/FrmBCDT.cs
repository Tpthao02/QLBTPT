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
    public partial class FrmBCDT : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        DataTable dtNhom = new DataTable();
        DataTable dtBC = new DataTable();
        string sql, constr;
        public FrmBCDT()
        {
            InitializeComponent();
        }

        private void FrmBCDT_Load(object sender, EventArgs e)
        {
            constr = "Data Source = DESKTOP-IEGRD2D\\SQLEXPRESS; Initial Catalog = quanlybanthuoc; Integrated Security = True";
            conn.ConnectionString = constr;
            conn.Open();

        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            sql = "select Q2.MaHH,Q2.TenHH,Sum(Q2.SL *Q2.DGN) as chiphi From(Select DMHH.MaHH,TenHH, SL,DGN   from HDNhapCT Inner join DMHH on HDNhapCT.MaHH=DMHH.MaHH where DMHH.MaHH in( select MaHH from HDNhap join HDNhapCT on HDNhap.SoCTN =HDNhapCT.SoCTN where NgayCTN>= '" + dtt1.Value + "' and NgayCTN<= '" + dtt2.Value + " '))Q2  Group by Q2.MaHH,Q2.TenHH";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            rptbcchiphi bc = new rptbcchiphi();
            bc.SetDataSource(dt);// dua du lieu vao bao cao
            //bc.DataDefinition.FormulaFields["TenTruong"].Text = "'" + comTruong.Text + "'";
            //bc.DataDefinition.FormulaFields["GiaTri"].Text = "'" + comboGT.Text + " '";
            Frmbcchiphi f = new Frmbcchiphi(bc);
            f.Show();
        }

        private void btnMH_Click(object sender, EventArgs e)
        {
            sql = "select Q1.MaHH,Q1.TenHH,Sum(Q1.SL *Q1.DG) as Doanhthu From( Select DMHH.MaHH,TenHH,SL,DG from HDXuatCT Inner join DMHH on HDxuatCT.MaHH=DMHH.MaHH Inner join HDXuat  on HDXuatCT.SoCTX=HDXuat.SoCTX  where NgayCTX >='" + dtt1.Value + " '  and NgayCTX <= '" + dtt2.Value + "' )Q1  Group by Q1.MaHH,Q1.TenHH ";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            rptbcdoanhthu bc = new rptbcdoanhthu();
            bc.SetDataSource(dt);// dua du lieu vao bao cao
           
            Frmbcdoanhthu f = new Frmbcdoanhthu(bc);
            f.Show();
        }
    }
}
