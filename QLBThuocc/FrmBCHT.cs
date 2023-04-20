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
    public partial class FrmBCHT : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        DataTable dtNhom = new DataTable();
        DataTable dtBC = new DataTable();
        string sql, constr;
        public FrmBCHT()
        {
            InitializeComponent();
        }

        private void FrmBCHT_Load(object sender, EventArgs e)
        {
            constr = "Data Source = DESKTOP-IEGRD2D\\SQLEXPRESS; Initial Catalog = quanlybanthuoc; Integrated Security = True";
            conn.ConnectionString = constr;
            conn.Open();
        }

        private void txtTG_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sql = " Select Makho, Q2.MaHH,TenHH,Q2.HanSD, Sum(Q2.SLTon) as SLHH from((SELECT HDNhapCT.MaHH,HanSD,SL as SLTon from HDNHapCT) union all (Select PTHNhapCT.MaHH,HDNhapCT.HanSD,-PTHNhapCT.SLT as SLTon from PTHNhap,PTHNhapCT,HDNhap,HDNhapCT where PTHNhap.MaPTHN = PTHNhapCT.MaPTHN and   HDNhap.SoCTN=PTHNhap.SoCTN and   HDNhapCT.SoCTN=HDNhap.SoCTN and   HDNhapCT.MaHH=PTHNhapCT.MaHH) union all select HDNhapCT.MaHH , HDNhapCT.HanSD,-HDXuatCT.SL as SLTon  from HDXuatCT , HDNhapCT where  HDNhapCT.LoSX=HDXuatCT.LoSX  union all select HDNhapCT.MaHH, HDNhapCT.HanSD,THXCT.SLT as SLTon from THXCT inner join PTHX on THXCT.MaPTHX=PTHX.MaPTHX inner join HDXuat on HDXuat.SoCTX=PTHX.SoCTX inner join HDXuatCT on HDXuatCT.SoCTX=HDXuat.SoCTX inner join HDNhapCT on HDNhapCT.LoSX=HDXuatCT.LoSX where THXCT.MaHH = HDNhapCT.MaHH)Q2,DMHH where Q2.MaHH=DMHH.MaHH  and Datediff (day,Q2.HanSD,'" + txtTG.Value + "') between -60 and 0 group by Q2.MaHH,Q2.HanSD,DMHH.TenHH,Makho order by Q2.MaHH,Q2.HanSD";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            Cryhandung bc = new Cryhandung();
            bc.SetDataSource(dt);// dua du lieu vao bao cao
            //bc.DataDefinition.FormulaFields["TenTruong"].Text = "'" + comTruong.Text + "'";
            //bc.DataDefinition.FormulaFields["GiaTri"].Text = "'" + comboGT.Text + " '";
            FrmrptHanSD f = new FrmrptHanSD(bc);
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql = "SELECT Q1.Makho , Q1.MaHH,Q1.TenHH,  SUM(Q1.SLTon) as TongSLT From (SELECT DMHH.MaHH, DMHH.TenHH, DMHH.Makho, HDNhapCT.SL AS SLTon From HDNhapCT inner join DMHH on HDNhapCT.MaHH = DMHH.MaHH inner join HDNhap on HDNhap.SoCTN = HDNhapCT.SoCTN where NgayCTN <= '" + txtTG.Value + "' union all SELECT DMHH.MaHH, DMHH.TenHH, DMHH.Makho, -PTHNhapCT.SLT AS SLTon From PTHNhapCT inner join DMHH on PTHNhapCT.MaHH = DMHH.MaHH inner join PTHNhap on PTHNhap.MaPTHN = PTHNhapCT.MaPTHN where PTHNhap.NgayTra <= '" + txtTG.Value + "' union all SELECT DMHH.MaHH, DMHH.TenHH, DMHH.Makho, -SL AS SLTon From HDXuatCT inner join DMHH on HDXuatCT.MaHH = DMHH.MaHH inner join HDXuat on HDXuat.SoCTX = HDXuatCT.SoCTX where NgayCTX <= '" + txtTG.Value + "' union all SELECT DMHH.MaHH, DMHH.TenHH, DMHH.Makho, THXCT.SLT AS SLTon From THXCT inner join DMHH on THXCT.MaHH = DMHH.MaHH inner join PTHX on PTHX.MaPTHX = THXCT.MaPTHX where PTHX.NgayTra <= '" + txtTG.Value + "' )Q1 Group by Q1.MaHH, TenHH,Makho";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            rptbctk bc = new rptbctk();
            bc.SetDataSource(dt);// dua du lieu vao bao cao
            //bc.DataDefinition.FormulaFields["TenTruong"].Text = "'" + comTruong.Text + "'";
            //bc.DataDefinition.FormulaFields["GiaTri"].Text = "'" + comboGT.Text + " '";
            FrmrptBCHT f = new FrmrptBCHT(bc);
            f.Show();
        }
    }
}
