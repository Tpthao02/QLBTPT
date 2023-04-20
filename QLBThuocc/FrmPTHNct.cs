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
    public partial class FrmPTHNct : Form
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
        public static string SoCTX;
        Boolean addnewflag = false;
        public FrmPTHNct()
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
            lenh.CommandText = " Select MaPTHN, PTHNHapCT.MaHH, TenHH,SLT from PTHNhapCT,DMHH where MaPTHN = @PTN and DMHH.MaHH =PTHNHapCT.MaHH ";
            lenh.Parameters.Clear();
            lenh.Parameters.AddWithValue("@PTN", ptn);
            da.SelectCommand = lenh;
            dtchitiet.Clear(); 
            da.Fill(dtchitiet);
            grdPTHN.DataSource = dtchitiet;
            //tinh tong tien phieu xuat
            
        }
        void napmothoadon(string ptn )
        {
            lenh2.CommandText = "select * from PTHNhap where MaPTHN= @MTHN";
            lenh2.Parameters.Clear();
            lenh2.Parameters.AddWithValue("@MTHN", ptn);
            da2.SelectCommand = lenh2;
            DataTable dt = new DataTable(" Mothoadon");
            da2.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtMaPTHN.Text = dt.Rows[0]["MaPTHN"].ToString();
                txtNgaytra.Value = Convert.ToDateTime(dt.Rows[0]["NgayTra"]);
                cboSoCT.SelectedValue = dt.Rows[0]["SoCTN"].ToString();
                txtlido.Text = dt.Rows[0]["LiDo"].ToString();
                //txtSCT.Text = dt.Rows[0]["SoCTN"].ToString();

            }
        }
        void napdanhsachHDN()
        {
            lenh2.CommandText = "Select * from PTHNhap ";
            lenh2.Parameters.Clear();
            da2.SelectCommand = lenh2;
            dthdnhap.Clear();
            da2.Fill(dthdnhap);
        }
        void dichuyendenHD(int i)//i la ban ghi can di chuyen den
        {
            txtMaPTHN.Text = dthdnhap.Rows[i]["MaPTHN"].ToString();
            txtNgaytra.Value = Convert.ToDateTime(dthdnhap.Rows[i]["NgayTra"]);
            cboSoCT.SelectedValue = dthdnhap.Rows[i]["SoCTN"].ToString();
           

            txtlido.Text = dthdnhap.Rows[i]["LiDo"].ToString();
            //txtSCT.Text = dthdnhap.Rows[i]["SoCTN"].ToString();

        }
        void NapSoCTG()
        {
            lenh2.CommandText = " Select SoCTN from HDNHap ";
            lenh2.Parameters.Clear();// do k co dieu kien loc lay toan bo ban ghi
            da2.SelectCommand = lenh2;
            DataTable dt = new DataTable(" SCTG");
            da2.Fill(dt);
            cboSoCT.DataSource = dt;
            cboSoCT.ValueMember = "SoCTN";
            cboSoCT.DisplayMember = "SoCTN";


        }

       /* void NapMH()
        {
            lenh2.CommandText = " Select MaHH,TenHH from DMHH ";
            lenh2.Parameters.Clear();// do k co dieu kien loc lay toan bo ban ghi
            da2.SelectCommand = lenh2;
            DataTable dt = new DataTable("HH");
            da2.Fill(dt);
            cboMaHH.DataSource = dt;
            cboMaHH.ValueMember = "MaHH";
            cboMaHH.DisplayMember = "MaHH";*/


            private void FrmPTHNct_Load(object sender, EventArgs e)
        {
           
            NapSoCTG();
            //NapMH();
            napdanhsachHDN();


            if (dthdnhap.Rows.Count > 0)// ton tai it nhat 1 phieu
            {
                vitri = 0;
                dichuyendenHD(vitri);
                napchitietHD(txtMaPTHN.Text);
            }

             NapCT();
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            addnewflag = true;
           txtMaPTH.Text = " ";
            txtMaPTH.Text = txtMaPTHN.Text;
            //NapCT();
            //txtSCT.Focus();
            //txtSCT.Text = txtCTN.Text;
            cboMaHH.Focus();
            /*txtSCT.Text = " ";*/
            txtsl.Text = " ";
            cboMaHH.Text = " ";
        
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Moi ban dien thong tin sau so an cap nhat de luu");
            txtMaPTHN.Text = " ";
            cboSoCT.SelectedValue = " ";
             txtlido.Text = " ";
        }

        private void ctnthem_Click(object sender, EventArgs e)
        {

            //i = grdHDCT.CurrentRow.Index;
            lenh2.CommandText = " Insert into PTHNhap(MaPTHN, SoCTN, NgayTra,LiDo)"
                 + " Values(@MaPTHN,@SoCTN,@NgayTra,@LiDo)";
            lenh2.Parameters.Clear();
            lenh2.Parameters.AddWithValue("@MaPTHN", txtMaPTHN.Text);
            lenh2.Parameters.AddWithValue("@SoCTN", cboSoCT.SelectedValue);
           
            lenh2.Parameters.AddWithValue("@NgayTra", txtNgaytra.Value);
            lenh2.Parameters.AddWithValue("@LiDo", txtlido.Text);
            lenh2.ExecuteNonQuery();
            MessageBox.Show("ban thanh cong vui long nhap chi tiet hoa don" +
                "");
            

            //napdanhsachHDN();
            //napchitietHD(clsthuvien.SoCTN);
            sql = "Select MaPTHN, PTHNHapCT.MaHH ,TenHH,SLT From PTHNhapCT,DMHH where DMHH.MaHH = PTHNHapCT.MaHH and MaPTHN = '" + txtMaPTHN.Text + "'";
            da2 = new SqlDataAdapter(sql, ketnoi);
            dthdnhap.Clear();
            da2.Fill(dthdnhap);
            grdPTHN.DataSource = dthdnhap;
            grdPTHN.Refresh();
            txtMaPTH.Text = " ";
            cboMaHH.Text = " ";
            txtsl.Text = " ";
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co chac chan muon xoa dong hien thoi?(Y/N )", "Xac nhan yeu cau", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Ban da chon yes, gio toi xoa nhe");
                sql = "Delete from PTHNhap where MaPTHN = '" + txtMaPTHN.Text + "' ";
                lenh2.CommandText = sql;
                lenh2.Connection = ketnoi;
                lenh2.ExecuteNonQuery();
                //napdanhsachHDN();
                //napchitietHD(txtCTN.Text);
                //NapCT();
                txtMaPTHN.Text = " ";
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
        private void NapCT()
        {

            i = grdPTHN.CurrentRow.Index;
            txtMaPTH.Text = grdPTHN.Rows[i].Cells["MaPTHN"].Value.ToString();// lay ra gt dong y va cot manhom
            cboMaHH.Text = grdPTHN.Rows[i].Cells["MaHH"].Value.ToString();// lay ra gt dong y va cot manhom
            txtsl.Text = grdPTHN.Rows[i].Cells["SLT"].Value.ToString();// lay ra gt dong y va cot manhom
          


        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            addnewflag = false;
            NapCT();
            MessageBox.Show("Hay sua noi dung cua ban ghi hien thoi ,ket thuc voi nut cap nhat ");
            cboMaHH.Focus();
        }

        private void grdPTHN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }
        void NapMaHH()
        {
            lenh2.CommandText = " Select DISTINCT MaHH from HDNhapCT where  SoCTN = @CTN";
            da2 = new SqlDataAdapter(sql, ketnoi);
            lenh2.Parameters.Clear();// do k co dieu kien loc lay toan bo ban ghi
            lenh2.Parameters.AddWithValue("@CTN", cboSoCT.Text);
            da2.SelectCommand = lenh2;
            DataTable dt = new DataTable("MahH");
            da2.Fill(dt);
            cboMaHH.DataSource = dt;
            cboMaHH.ValueMember = "MaHH";
            cboMaHH.DisplayMember = "MaHH";

        }
        private void cboSoCT_SelectedIndexChanged(object sender, EventArgs e)
        {
            NapMaHH();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Ban co chac chan muon xoa dong hien thoi?(Y/N )", "Xac nhan yeu cau", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Ban da chon yes, gio toi xoa nhe");
                sql = "Delete from PTHNhapCT where MaPTHN = '" + txtMaPTHN.Text + "' and MaHH = '" + cboMaHH.Text + "'";
                lenh2.CommandText = sql;
                lenh2.Connection = ketnoi;
                lenh2.ExecuteNonQuery();
                i = grdPTHN.CurrentRow.Index;
                grdPTHN.Rows.RemoveAt(i);// xoa o dong i 
                //NapCT();
            }
            else
                MessageBox.Show("Ban da chon No , vay thi tam biet nho ");
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (addnewflag == true)
            {
                lenh2.CommandText = "Insert into PTHNhapCT(MaPTHN,MaHH,SLT) Values ('" + txtMaPTHN.Text + "',N'" + cboMaHH.Text + "',N'" + txtsl.Text + "')";

                lenh2.ExecuteNonQuery();

                // NapCT();
                sql = "Select MaPTHN, PTHNHapCT.MaHH ,TenHH,SLT From PTHNhapCT,DMHH where DMHH.MaHH = PTHNHapCT.MaHH and MaPTHN = '" + txtMaPTHN.Text + "'";
                da2 = new SqlDataAdapter(sql, ketnoi);
                dthdnhap.Clear();
                da2.Fill(dthdnhap);
                grdPTHN.DataSource = dthdnhap;
                grdPTHN.Refresh();


            }
            else
            {
                lenh2.CommandText = "Update PTHNhapCT set SLT ='" + txtsl.Text + "' where MaPTHN ='" + txtMaPTHN.Text + "' and MaHH =N'" + cboMaHH.Text +  "' ";

                lenh2.ExecuteNonQuery();
                sql = "Select MaPTHN, PTHNHapCT.MaHH ,TenHH,SLT From PTHNhapCT,DMHH where DMHH.MaHH = PTHNHapCT.MaHH and MaPTHN = '" + txtMaPTHN.Text + "'";
                da2 = new SqlDataAdapter(sql, ketnoi);
                dtchitiet.Clear();
                da2.Fill(dtchitiet);
                grdPTHN.DataSource = dtchitiet;
                grdPTHN.Refresh();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnchonHD_Click(object sender, EventArgs e)
        {
            FrmPTraHDNhap f = new FrmPTraHDNhap();
            f.ShowDialog();
            if (ClassTraHangNhap.MaPTHN != " ")
            {
                napmothoadon(ClassTraHangNhap.MaPTHN);
                napchitietHD(ClassTraHangNhap.MaPTHN);

               // NapCT();
            }
        }
    }
}
