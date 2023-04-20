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
    public partial class FrmPTHXct : Form
    {
        SqlConnection ketnoi = new SqlConnection();
        SqlCommand lenh = new SqlCommand();// doi tuong de thuc thi lenh
        SqlDataAdapter da = new SqlDataAdapter();//do du lieu vao data
        DataTable dtchitiet = new DataTable("HDNHapCT");//do du lieu vao
        DataTable dthdnhap = new DataTable(" ");
        int vitri = -1;// do chua biet ban dau hd so may
        string constr, sql;
        SqlCommand lenh2 = new SqlCommand();
        SqlDataAdapter da2 = new SqlDataAdapter();// nap cac dieu kien con nho 
        int i;
        Boolean addnewflag = false;
        public FrmPTHXct()
        {
            InitializeComponent();
            constr = "Data Source = DESKTOP-IEGRD2D\\SQLEXPRESS; Initial Catalog = quanlybanthuoc; Integrated Security = True";
            ketnoi.ConnectionString = constr;
            ketnoi.Open();
            lenh.Connection = ketnoi;// lenh tro toi csdl qlht
            lenh2.Connection = ketnoi;// tro den cung 1 coso du lieu qlhieuthuoc
        }

        void napchitietHD(string ptn)
        {
            //NapMH();
            lenh.CommandText = " Select MaPTHX, THXCT.MaHH, TenHH,SLT from THXCT,DMHH where MaPTHX = @PTN and DMHH.MaHH =THXCT.MaHH ";
            lenh.Parameters.Clear();
            lenh.Parameters.AddWithValue("@PTN", ptn);
            da.SelectCommand = lenh;
            dtchitiet.Clear();
            da.Fill(dtchitiet);
            grdPTHX.DataSource = dtchitiet;
            //tinh tong tien phieu xuat

        }
        void napmothoadon(string ptn)
        {
            lenh2.CommandText = "select * from PTHX where MaPTHX= @MTHN";
            lenh2.Parameters.Clear();
            lenh2.Parameters.AddWithValue("@MTHN", ptn);
            da2.SelectCommand = lenh2;
            DataTable dt = new DataTable(" Mothoadon");
            da2.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtMaPTHX.Text = dt.Rows[0]["MaPTHX"].ToString();
                txtNgaytra.Value = Convert.ToDateTime(dt.Rows[0]["NgayTra"]);
                cboSoCT.SelectedValue = dt.Rows[0]["SoCTX"].ToString();
                txtlido.Text = dt.Rows[0]["Lido"].ToString();
                //txtSCT.Text = dt.Rows[0]["SoCTN"].ToString();

            }
        }
        void napdanhsachHDN()
        {
            lenh2.CommandText = "Select * from PTHX ";
            lenh2.Parameters.Clear();
            da2.SelectCommand = lenh2;
            dthdnhap.Clear();
            da2.Fill(dthdnhap);
        }
        void dichuyendenHD(int i)//i la ban ghi can di chuyen den
        {
            txtMaPTHX.Text = dthdnhap.Rows[i]["MaPTHX"].ToString();
            txtNgaytra.Value = Convert.ToDateTime(dthdnhap.Rows[i]["NgayTra"]);
            cboSoCT.SelectedValue = dthdnhap.Rows[i]["SoCTX"].ToString();


            txtlido.Text = dthdnhap.Rows[i]["Lido"].ToString();
            //txtSCT.Text = dthdnhap.Rows[i]["SoCTN"].ToString();

        }
        void NapSoCTG()
        {
            lenh2.CommandText = " Select SoCTX from HDXuat ";
            lenh2.Parameters.Clear();// do k co dieu kien loc lay toan bo ban ghi
            da2.SelectCommand = lenh2;
            DataTable dt = new DataTable(" SCTG");
            da2.Fill(dt);
            cboSoCT.DataSource = dt;
            cboSoCT.ValueMember = "SoCTX";
            cboSoCT.DisplayMember = "SoCTX";


        }
        private void NapCT()
        {

            i = grdPTHX.CurrentRow.Index;
            txtMaPTH.Text = grdPTHX.Rows[i].Cells["MaPTHX"].Value.ToString();// lay ra gt dong y va cot manhom
            cboMaHH.Text = grdPTHX.Rows[i].Cells["MaHH"].Value.ToString();// lay ra gt dong y va cot manhom
            txtsl.Text = grdPTHX.Rows[i].Cells["SLT"].Value.ToString();// lay ra gt dong y va cot manhom



        }
        private void FrmPTHXct_Load(object sender, EventArgs e)
        {
            NapSoCTG();
            //NapMH();
            napdanhsachHDN();


            if (dthdnhap.Rows.Count > 0)// ton tai it nhat 1 phieu
            {
                vitri = 0;
                dichuyendenHD(vitri);
                napchitietHD(txtMaPTHX.Text);
            }

            NapCT();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Moi ban dien thong tin sau so an cap nhat de luu");
            txtMaPTHX.Text = " ";
            cboSoCT.SelectedValue = " ";
            txtlido.Text = " ";
        }

        private void ctnthem_Click(object sender, EventArgs e)
        {

            //i = grdHDCT.CurrentRow.Index;
            lenh2.CommandText = " Insert into PTHX(MaPTHX, SoCTX, NgayTra,Lido)"
                 + " Values(@MaPTHX,@SoCTX,@NgayTra,@LiDo)";
            lenh2.Parameters.Clear();
            lenh2.Parameters.AddWithValue("@MaPTHX", txtMaPTHX.Text);
            lenh2.Parameters.AddWithValue("@SoCTX", cboSoCT.SelectedValue);

            lenh2.Parameters.AddWithValue("@NgayTra", txtNgaytra.Value);
            lenh2.Parameters.AddWithValue("@Lido", txtlido.Text);
            lenh2.ExecuteNonQuery();
            MessageBox.Show("ban thanh cong vui long nhap chi tiet hoa don" +
                "");

            //napdanhsachHDN();
            //napchitietHD(clsthuvien.SoCTN);
            sql = "Select MaPTHX, THXCT.MaHH ,TenHH,SLT From THXCT,DMHH where DMHH.MaHH = THXCT.MaHH and MaPTHX = '" + txtMaPTHX.Text + "'";
            da2 = new SqlDataAdapter(sql, ketnoi);
            dthdnhap.Clear();
            da2.Fill(dthdnhap);
            grdPTHX.DataSource = dthdnhap;
            grdPTHX.Refresh();
            txtMaPTH.Text = " ";
            cboMaHH.Text = "";
            txtsl.Text = " ";
            
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co chac chan muon xoa dong hien thoi?(Y/N )", "Xac nhan yeu cau", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Ban da chon yes, gio toi xoa nhe");
                sql = "Delete from PTHX where MaPTHX = '" + txtMaPTHX.Text + "' ";
                lenh2.CommandText = sql;
                lenh2.Connection = ketnoi;
                lenh2.ExecuteNonQuery();
                //napdanhsachHDN();
                //napchitietHD(txtCTN.Text);
                //NapCT();
                txtMaPTHX.Text = " ";
                cboSoCT.SelectedValue = " ";
                txtlido.Text = " ";
                /*txtSCT.Text = " ";
                txtLoSX.Text = " ";
                txtsl.Text = " ";
                cboMaHH.Text = " ";
                txtdg.Text = " ";
                txtnsx.Text = " ";
                txthd.Text = " ";
                sql = "Select SoCTN,MaHH,SL,DGN,NgaySX,HanSD From HDNhapCT where SoCTN = '" + txtCTN.Text + "'";
                da2 = new SqlDataAdapter(sql, ketnoi);
                dthdnhap.Clear();
                da2.Fill(dthdnhap);
                grdHDCT.DataSource = dthdnhap;
                grdHDCT.Refresh();*/
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            addnewflag = true;
            txtMaPTH.Text = " ";
            txtMaPTH.Text = txtMaPTHX.Text;
            //NapCT();
            //txtSCT.Focus();
            //txtSCT.Text = txtCTN.Text;
            cboMaHH.Focus();
            /*txtSCT.Text = " ";*/
            txtsl.Text = " ";
            cboMaHH.Text = " ";

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            addnewflag = false;
            NapCT();
            MessageBox.Show("Hay sua noi dung cua ban ghi hien thoi ,ket thuc voi nut cap nhat ");
            cboMaHH.Focus();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Ban co chac chan muon xoa dong hien thoi?(Y/N )", "Xac nhan yeu cau", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Ban da chon yes, gio toi xoa nhe");
                sql = "Delete from THXCT where MaPTHX = '" + txtMaPTHX.Text + "' and MaHH = '" + cboMaHH.Text + "'";
                lenh2.CommandText = sql;
                lenh2.Connection = ketnoi;
                lenh2.ExecuteNonQuery();
                i = grdPTHX.CurrentRow.Index;
                grdPTHX.Rows.RemoveAt(i);// xoa o dong i 
                //NapCT();
            }
            else
                MessageBox.Show("Ban da chon No , vay thi tam biet nho ");
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (addnewflag == true)
            {
                lenh2.CommandText = "Insert into THXCT(MaPTHX,MaHH,SLT) Values ('" + txtMaPTHX.Text + "',N'" + cboMaHH.Text + "',N'" + txtsl.Text + "')";

                lenh2.ExecuteNonQuery();

                // NapCT();
                sql = "Select MaPTHX, THXCT.MaHH ,TenHH,SLT From THXCT,DMHH where DMHH.MaHH = THXCT.MaHH and MaPTHX = '" + txtMaPTHX.Text + "'";
                da2 = new SqlDataAdapter(sql, ketnoi);
                dthdnhap.Clear();
                da2.Fill(dthdnhap);
                grdPTHX.DataSource = dthdnhap;
                grdPTHX.Refresh();


            }
            else
            {
                lenh2.CommandText = "Update THXCT set SLT ='" + txtsl.Text + "' where MaPTHX ='" + txtMaPTHX.Text + "' and MaHH =N'" + cboMaHH.Text +"' ";

                lenh2.ExecuteNonQuery();
                sql = "Select MaPTHX, THXCT.MaHH ,TenHH,SLT From THXCT,DMHH where DMHH.MaHH = THXCT.MaHH and MaPTHX = '" + txtMaPTHX.Text + "'";
                da2 = new SqlDataAdapter(sql, ketnoi);
                dtchitiet.Clear();
                da2.Fill(dtchitiet);
                grdPTHX.DataSource = dtchitiet;
                grdPTHX.Refresh();
            }
        }
        void NapMaHH()
        {
            lenh2.CommandText = " Select DISTINCT MaHH from HDXuatCT where  SoCTX = @CTX";
            da2 = new SqlDataAdapter(sql, ketnoi);
            lenh2.Parameters.Clear();// do k co dieu kien loc lay toan bo ban ghi
            lenh2.Parameters.AddWithValue("@CTX", cboSoCT.Text);
            da2.SelectCommand = lenh2;
            DataTable dt = new DataTable("MaHH");
            da2.Fill(dt);
            cboMaHH.DataSource = dt;
            cboMaHH.ValueMember = "MaHH";
            cboMaHH.DisplayMember = "MaHH";

        }
        private void cboSoCT_SelectedIndexChanged(object sender, EventArgs e)
        {
            NapMaHH();
        }

        private void grdPTHX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void grdPTHX_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtMaPTHX_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnchonHD_Click(object sender, EventArgs e)
        {
            FrmPTHDxuat f = new FrmPTHDxuat();
            f.ShowDialog();
            if (ClassTraHangXuat.MaPTHX != " ")
            {
                napmothoadon(ClassTraHangXuat.MaPTHX);
                napchitietHD(ClassTraHangXuat.MaPTHX);

                // NapCT();
            }
        }
    }
}
