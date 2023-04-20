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
    public partial class FrmKiemke : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataAdapter da1 = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable dtbc = new DataTable();
        DataTable comdt = new DataTable();
        DataTable dtNhom = new DataTable();
        DataTable dtkho = new DataTable();
        string sql, constr;
        int i;
        Boolean addnewflag = false;
        public FrmKiemke()
        {
            InitializeComponent();

        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (cboMakho.Text == "")
            {
                MessageBox.Show("Bạn cần thiết lập điều kiện lọc trước");
            }
            else
            {
                sql = " SELECT Q1.Makho , Q1.MaHH,Q1.TenHH,  SUM(Q1.SLTon) as TongSLT From (SELECT DMHH.MaHH, DMHH.TenHH, DMHH.Makho, HDNhapCT.SL AS SLTon From HDNhapCT inner join DMHH on HDNhapCT.MaHH = DMHH.MaHH inner join HDNhap on HDNhap.SoCTN = HDNhapCT.SoCTN where NgayCTN <= getdate() union all SELECT DMHH.MaHH, DMHH.TenHH, DMHH.Makho, -PTHNhapCT.SLT AS SLTon From PTHNhapCT inner join DMHH on PTHNhapCT.MaHH = DMHH.MaHH inner join PTHNhap on PTHNhap.MaPTHN = PTHNhapCT.MaPTHN where PTHNhap.NgayTra <= getdate() union all SELECT DMHH.MaHH, DMHH.TenHH, DMHH.Makho, -SL AS SLTon From HDXuatCT inner join DMHH on HDXuatCT.MaHH = DMHH.MaHH inner join HDXuat on HDXuat.SoCTX = HDXuatCT.SoCTX where NgayCTX <= getdate() union all SELECT DMHH.MaHH, DMHH.TenHH, DMHH.Makho, THXCT.SLT AS SLTon From THXCT inner join DMHH on THXCT.MaHH = DMHH.MaHH inner join PTHX on PTHX.MaPTHX = THXCT.MaPTHX where PTHX.NgayTra <= getdate() )Q1 where Q1.Makho =  '" + cboMakho.Text + "' Group by Q1.MaHH, TenHH,Makho";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt); //cmt
                grdKiemke.DataSource = dt;
                grdKiemke.Refresh();
                //tạo grid table -> tạo column -> sửa name, text và name = data property name, sửa align ...
         


            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            sql = " SELECT Q1.Makho , Q1.MaHH,Q1.TenHH,  SUM(Q1.SLTon) as TongSLT From (SELECT DMHH.MaHH, DMHH.TenHH, DMHH.Makho, HDNhapCT.SL AS SLTon From HDNhapCT inner join DMHH on HDNhapCT.MaHH = DMHH.MaHH inner join HDNhap on HDNhap.SoCTN = HDNhapCT.SoCTN where NgayCTN <= getdate() union all SELECT DMHH.MaHH, DMHH.TenHH, DMHH.Makho, -PTHNhapCT.SLT AS SLTon From PTHNhapCT inner join DMHH on PTHNhapCT.MaHH = DMHH.MaHH inner join PTHNhap on PTHNhap.MaPTHN = PTHNhapCT.MaPTHN where PTHNhap.NgayTra <= getdate() union all SELECT DMHH.MaHH, DMHH.TenHH, DMHH.Makho, -SL AS SLTon From HDXuatCT inner join DMHH on HDXuatCT.MaHH = DMHH.MaHH inner join HDXuat on HDXuat.SoCTX = HDXuatCT.SoCTX where NgayCTX <= getdate() union all SELECT DMHH.MaHH, DMHH.TenHH, DMHH.Makho, THXCT.SLT AS SLTon From THXCT inner join DMHH on THXCT.MaHH = DMHH.MaHH inner join PTHX on PTHX.MaPTHX = THXCT.MaPTHX where PTHX.NgayTra <= getdate() )Q1 Group by Q1.MaHH, TenHH,Makho";
            da = new SqlDataAdapter(sql, conn);
            da1 = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);//du lieu do vao data
            grdKiemke.DataSource = dt;// gan du lieu cho o luoi
                                      // NapCT();
        }

        private void FrmKiemke_Load(object sender, EventArgs e)
        {
            constr = "Data Source = DESKTOP-IEGRD2D\\SQLEXPRESS; Initial Catalog = quanlybanthuoc; Integrated Security = True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = " SELECT Q1.Makho , Q1.MaHH,Q1.TenHH,  SUM(Q1.SLTon) as TongSLT From (SELECT DMHH.MaHH, DMHH.TenHH, DMHH.Makho, HDNhapCT.SL AS SLTon From HDNhapCT inner join DMHH on HDNhapCT.MaHH = DMHH.MaHH inner join HDNhap on HDNhap.SoCTN = HDNhapCT.SoCTN where NgayCTN <= getdate() union all SELECT DMHH.MaHH, DMHH.TenHH, DMHH.Makho, -PTHNhapCT.SLT AS SLTon From PTHNhapCT inner join DMHH on PTHNhapCT.MaHH = DMHH.MaHH inner join PTHNhap on PTHNhap.MaPTHN = PTHNhapCT.MaPTHN where PTHNhap.NgayTra <= getdate() union all SELECT DMHH.MaHH, DMHH.TenHH, DMHH.Makho, -SL AS SLTon From HDXuatCT inner join DMHH on HDXuatCT.MaHH = DMHH.MaHH inner join HDXuat on HDXuat.SoCTX = HDXuatCT.SoCTX where NgayCTX <= getdate() union all SELECT DMHH.MaHH, DMHH.TenHH, DMHH.Makho, THXCT.SLT AS SLTon From THXCT inner join DMHH on THXCT.MaHH = DMHH.MaHH inner join PTHX on PTHX.MaPTHX = THXCT.MaPTHX where PTHX.NgayTra <= getdate() )Q1 Group by Q1.MaHH, TenHH,Makho";
            da = new SqlDataAdapter(sql, conn);
            da1 = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);//du lieu do vao data
            grdKiemke.DataSource = dt;// gan du lieu cho o luoi
                                      // NapCT();
            sql = "select Distinct Makho from DMHH";
            da1 = new SqlDataAdapter(sql, conn);
            da1.Fill(dtkho);
            cboMakho.DataSource = dtkho;
            cboMakho.DisplayMember = "Makho";

        }
    }
}
