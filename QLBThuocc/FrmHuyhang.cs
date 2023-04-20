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
    public partial class FrmHuyhang : Form
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
        public FrmHuyhang()
        {
            InitializeComponent();
        }
        private void Napbang()
        {
            constr = "Data Source = DESKTOP-IEGRD2D\\SQLEXPRESS; Initial Catalog = quanlybanthuoc; Integrated Security = True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = " Select Makho, Q2.MaHH,TenHH,Q2.HanSD, Sum(Q2.SLTon) as SLHH from((SELECT HDNhapCT.MaHH,HanSD,SL as SLTon from HDNHapCT) union all (Select PTHNhapCT.MaHH,HDNhapCT.HanSD,-PTHNhapCT.SLT as SLTon from PTHNhap,PTHNhapCT,HDNhap,HDNhapCT where PTHNhap.MaPTHN = PTHNhapCT.MaPTHN and   HDNhap.SoCTN=PTHNhap.SoCTN and   HDNhapCT.SoCTN=HDNhap.SoCTN and   HDNhapCT.MaHH=PTHNhapCT.MaHH) union all select HDNhapCT.MaHH , HDNhapCT.HanSD,-HDXuatCT.SL as SLTon  from HDXuatCT , HDNhapCT where  HDNhapCT.LoSX=HDXuatCT.LoSX  union all select HDNhapCT.MaHH, HDNhapCT.HanSD,THXCT.SLT as SLTon from THXCT inner join PTHX on THXCT.MaPTHX=PTHX.MaPTHX inner join HDXuat on HDXuat.SoCTX=PTHX.SoCTX inner join HDXuatCT on HDXuatCT.SoCTX=HDXuat.SoCTX inner join HDNhapCT on HDNhapCT.LoSX=HDXuatCT.LoSX where THXCT.MaHH = HDNhapCT.MaHH)Q2,DMHH where Q2.MaHH=DMHH.MaHH  and Datediff (day,Q2.HanSD,getdate()) between -60 and 0 and Q2.Makho =  '" + cboMakho.Text + "' group by Q2.MaHH,Q2.HanSD,DMHH.TenHH,Makho order by Q2.MaHH,Q2.HanSD";
            da = new SqlDataAdapter(sql, conn);
            da1 = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);//du lieu do vao data
            grdHuyhang.DataSource = dt;// gan du lieu c
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (cboMakho.Text == "")
            {
                MessageBox.Show("Bạn cần thiết lập điều kiện lọc trước");
            }
            else
            {
                sql = "  Select Makho, Q2.MaHH,TenHH,Q2.HanSD, Sum(Q2.SLTon) as SLHH from((SELECT HDNhapCT.MaHH,HanSD,SL as SLTon from HDNHapCT) union all (Select PTHNhapCT.MaHH,HDNhapCT.HanSD,-PTHNhapCT.SLT as SLTon from PTHNhap,PTHNhapCT,HDNhap,HDNhapCT where PTHNhap.MaPTHN = PTHNhapCT.MaPTHN and   HDNhap.SoCTN=PTHNhap.SoCTN and   HDNhapCT.SoCTN=HDNhap.SoCTN and   HDNhapCT.MaHH=PTHNhapCT.MaHH) union all select HDNhapCT.MaHH , HDNhapCT.HanSD,-HDXuatCT.SL as SLTon  from HDXuatCT , HDNhapCT where  HDNhapCT.LoSX=HDXuatCT.LoSX  union all select HDNhapCT.MaHH, HDNhapCT.HanSD,THXCT.SLT as SLTon from THXCT inner join PTHX on THXCT.MaPTHX=PTHX.MaPTHX inner join HDXuat on HDXuat.SoCTX=PTHX.SoCTX inner join HDXuatCT on HDXuatCT.SoCTX=HDXuat.SoCTX inner join HDNhapCT on HDNhapCT.LoSX=HDXuatCT.LoSX where THXCT.MaHH = HDNhapCT.MaHH)Q2,DMHH where Q2.MaHH=DMHH.MaHH and Makho = '" + cboMakho.Text + "' and Datediff (day,Q2.HanSD, getdate()) between -60 and 0 group by Q2.MaHH,Q2.HanSD,DMHH.TenHH,Makho order by Q2.MaHH,Q2.HanSD";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt); //cmt
                grdHuyhang.DataSource = dt;
                grdHuyhang.Refresh();
                //tạo grid table -> tạo column -> sửa name, text và name = data property name, sửa align ...

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            sql = " Select Makho, Q2.MaHH,TenHH,Q2.HanSD, Sum(Q2.SLTon) as SLHH from((SELECT HDNhapCT.MaHH,HanSD,SL as SLTon from HDNHapCT) union all (Select PTHNhapCT.MaHH,HDNhapCT.HanSD,-PTHNhapCT.SLT as SLTon from PTHNhap,PTHNhapCT,HDNhap,HDNhapCT where PTHNhap.MaPTHN = PTHNhapCT.MaPTHN and   HDNhap.SoCTN=PTHNhap.SoCTN and   HDNhapCT.SoCTN=HDNhap.SoCTN and   HDNhapCT.MaHH=PTHNhapCT.MaHH) union all select HDNhapCT.MaHH , HDNhapCT.HanSD,-HDXuatCT.SL as SLTon  from HDXuatCT , HDNhapCT where  HDNhapCT.LoSX=HDXuatCT.LoSX  union all select HDNhapCT.MaHH, HDNhapCT.HanSD,THXCT.SLT as SLTon from THXCT inner join PTHX on THXCT.MaPTHX=PTHX.MaPTHX inner join HDXuat on HDXuat.SoCTX=PTHX.SoCTX inner join HDXuatCT on HDXuatCT.SoCTX=HDXuat.SoCTX inner join HDNhapCT on HDNhapCT.LoSX=HDXuatCT.LoSX where THXCT.MaHH = HDNhapCT.MaHH)Q2,DMHH where Q2.MaHH=DMHH.MaHH  and Datediff (day,Q2.HanSD, getdate()) between -60 and 0 group by Q2.MaHH,Q2.HanSD,DMHH.TenHH,Makho order by Q2.MaHH,Q2.HanSD";
            da = new SqlDataAdapter(sql, conn);
            da1 = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);//du lieu do vao data
            grdHuyhang.DataSource = dt;
        }// gan du lieu cho o luoi
                                       // NapCT();

            private void FrmHuyhang_Load(object sender, EventArgs e)
        {
            constr = "Data Source = DESKTOP-IEGRD2D\\SQLEXPRESS; Initial Catalog = quanlybanthuoc; Integrated Security = True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = " Select Makho, Q2.MaHH,TenHH,Q2.HanSD, Sum(Q2.SLTon) as SLHH from((SELECT HDNhapCT.MaHH,HanSD,SL as SLTon from HDNHapCT) union all (Select PTHNhapCT.MaHH,HDNhapCT.HanSD,-PTHNhapCT.SLT as SLTon from PTHNhap,PTHNhapCT,HDNhap,HDNhapCT where PTHNhap.MaPTHN = PTHNhapCT.MaPTHN and   HDNhap.SoCTN=PTHNhap.SoCTN and   HDNhapCT.SoCTN=HDNhap.SoCTN and   HDNhapCT.MaHH=PTHNhapCT.MaHH) union all select HDNhapCT.MaHH , HDNhapCT.HanSD,-HDXuatCT.SL as SLTon  from HDXuatCT , HDNhapCT where  HDNhapCT.LoSX=HDXuatCT.LoSX  union all select HDNhapCT.MaHH, HDNhapCT.HanSD,THXCT.SLT as SLTon from THXCT inner join PTHX on THXCT.MaPTHX=PTHX.MaPTHX inner join HDXuat on HDXuat.SoCTX=PTHX.SoCTX inner join HDXuatCT on HDXuatCT.SoCTX=HDXuat.SoCTX inner join HDNhapCT on HDNhapCT.LoSX=HDXuatCT.LoSX where THXCT.MaHH = HDNhapCT.MaHH)Q2,DMHH where Q2.MaHH=DMHH.MaHH  and Datediff (day,Q2.HanSD, getdate()) between -60 and 0 group by Q2.MaHH,Q2.HanSD,DMHH.TenHH,Makho order by Q2.MaHH,Q2.HanSD";
            da = new SqlDataAdapter(sql, conn);
            da1 = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);//du lieu do vao data
            grdHuyhang.DataSource = dt;// gan du lieu cho o luoi
                                      // NapCT();
            sql = "select Distinct Makho from DMHH";
            da1 = new SqlDataAdapter(sql, conn);
            da1.Fill(dtkho);
            cboMakho.DataSource = dtkho;
            cboMakho.DisplayMember = "Makho";
        }
    }
}
