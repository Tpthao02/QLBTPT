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
    public partial class FrmBCtheoDT : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        DataTable dtNhom = new DataTable();
        DataTable dtBC = new DataTable();
        string sql, constr;

        public FrmBCtheoDT()
        {
            InitializeComponent();
        }

        private void btnMH_Click(object sender, EventArgs e)
        {
            sql = "select DMKH.MaKH, TenKH ,Sum( DG* SL) as Doanhthu from DMKH inner join HDXuat on DMkH.MaKH=HDXuat.MaKH inner join HDXuatCT on HDXuatCT.SoCTX =HDXuat.SoCTX inner join DMHH on DMHH.MaHH=HDXuatCT.MaHH  where NgayCTX >='" + dtt1.Value + " '  and NgayCTX <= '" + dtt2.Value + "'   Group by DMKH.MaKH,TenKH ";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            CrystalReport5 bc = new CrystalReport5();
            bc.SetDataSource(dt);// dua du lieu vao bao cao
            //bc.DataDefinition.FormulaFields["TenTruong"].Text = "'" + comTruong.Text + "'";
            //bc.DataDefinition.FormulaFields["GiaTri"].Text = "'" + comboGT.Text + " '";
            frmbcDTNCC f = new frmbcDTNCC(bc);
            f.Show();
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            sql = "select DMNCC.MaNCC , TenNCC ,Sum(DGN*SL) as CP from DMNCC inner join HDNhap on HDNhap.MaNCC=DMNCC.MaNCC inner join HDNhapCT on HDNhapCT.SoCTN=HDNhap.SoCTN  where NgayCTN >='" + dtt1.Value + " '  and NgayCTN <= '" + dtt2.Value + "'   group by DMNCC.MaNCC,TenNCC ";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            CrystalReport6 bc = new CrystalReport6();
            bc.SetDataSource(dt);// dua du lieu vao bao cao
            //bc.DataDefinition.FormulaFields["TenTruong"].Text = "'" + comTruong.Text + "'";
            //bc.DataDefinition.FormulaFields["GiaTri"].Text = "'" + comboGT.Text + " '";
            FrmCPNCC1 f = new FrmCPNCC1(bc);
            f.Show();

        }

        private void FrmBCtheoDT_Load(object sender, EventArgs e)
        {
            constr = "Data Source = DESKTOP-IEGRD2D\\SQLEXPRESS; Initial Catalog = quanlybanthuoc; Integrated Security = True";
            conn.ConnectionString = constr;
            conn.Open();
        }
    }
}
