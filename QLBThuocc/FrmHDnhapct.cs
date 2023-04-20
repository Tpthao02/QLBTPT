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
    public partial class FrmHDnhapct : Form
    {
        SqlConnection ketnoi = new SqlConnection();
        SqlCommand lenh = new SqlCommand();// doi tuong de thuc thi lenh
        SqlDataAdapter da = new SqlDataAdapter();//do du lieu vao data
        DataTable dtchitiet = new DataTable("HDNHapCT");//do du lieu vao
        DataTable dthdnhap = new DataTable(" ");
        SqlConnection conn = new SqlConnection();
        DataTable dtbc = new DataTable();
        DataTable dt = new DataTable();
        int vitri = -1;// do chua biet ban dau hd so may
        string constr, sql;
        SqlCommand lenh2 = new SqlCommand();
        SqlDataAdapter da2 = new SqlDataAdapter();// nap cac dieu kien con nho 
        int i;
        Boolean addnewflag = false;
        public FrmHDnhapct()
        {
            InitializeComponent();
            constr = "Data Source = DESKTOP-IEGRD2D\\SQLEXPRESS; Initial Catalog = quanlybanthuoc; Integrated Security = True";
            ketnoi.ConnectionString = constr;
            ketnoi.Open();
            lenh.Connection = ketnoi;// lenh tro toi csdl qlht
            lenh2.Connection = ketnoi;// tro den cung 1 coso du lieu qlhieuthuoc

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void NapMNCC()
        {
            lenh2.CommandText = " Select MaNCC,TenNCC from DMNCC ";
            lenh2.Parameters.Clear();// do k co dieu kien loc lay toan bo ban ghi
            da2.SelectCommand = lenh2;
            DataTable dt = new DataTable(" NCC");
            da2.Fill(dt);
            cboMancc.DataSource = dt;
            cboMancc.ValueMember = "MaNCC";
            cboMancc.DisplayMember = "TenNCC";


        }
        void NapMNV()
        {
            lenh2.CommandText = " Select MaNV from DMNV ";
            lenh2.Parameters.Clear();// do k co dieu kien loc lay toan bo ban ghi
            da2.SelectCommand = lenh2;
            DataTable dt = new DataTable(" NV");
            da2.Fill(dt);
            cbonhanvien.DataSource = dt;
            cbonhanvien.ValueMember = "MaNV";
            cbonhanvien.DisplayMember = "MaNV";


        }

        void NapMH()
        {
            lenh2.CommandText = " Select MaHH,TenHH from DMHH ";
            lenh2.Parameters.Clear();// do k co dieu kien loc lay toan bo ban ghi
            da2.SelectCommand = lenh2;
            DataTable dt = new DataTable("HH");
            da2.Fill(dt);
            cboMaHH.DataSource = dt;
            cboMaHH.ValueMember = "MaHH";
            cboMaHH.DisplayMember = "MaHH";


        }
       
        void napchitietHD(string spn)
        {
            //NapMH();
            lenh.CommandText = " Select SoCTN,MaHH,LoSX,SL,DGN,NgaySX,HanSD, SL*DGN as Thanhtien from HDNHapCT where SoCTN = @SPN";
            lenh.Parameters.Clear();
            lenh.Parameters.AddWithValue("@SPN", spn);
            da.SelectCommand = lenh;
            dtchitiet.Clear();
            da.Fill(dtchitiet);
            grdHDCT.DataSource = dtchitiet;
            //tinh tong tien phieu xuat
            double tongtien = 0;
            for (int i = 0; i < dtchitiet.Rows.Count; i++)
            {
                double sl = Convert.ToDouble(dtchitiet.Rows[i]["SL"]);
                double dg = Convert.ToDouble(dtchitiet.Rows[i]["DGN"]);
                tongtien += sl * dg;
            }
            txttongtien.Text = tongtien.ToString();
        }
        void napmothoadon(string spn)
        {
            lenh2.CommandText = "select * from HDNhap where SoCTN = @SPN";
            lenh2.Parameters.Clear();
            lenh2.Parameters.AddWithValue("@SPN", spn);
            da2.SelectCommand = lenh2;
            DataTable dt = new DataTable(" Mothoadon");
            da2.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtCTN.Text = dt.Rows[0]["SoCTN"].ToString();
                txtNgaynhap.Value = Convert.ToDateTime(dt.Rows[0]["NgayCTN"]);
                cboMancc.SelectedValue = dt.Rows[0]["MaNCC"].ToString();
                cbonhanvien.SelectedValue = dt.Rows[0]["MaNV"].ToString();
                txtlido.Text = dt.Rows[0]["Diengiai"].ToString();
                //txtSCT.Text = dt.Rows[0]["SoCTN"].ToString();

            }
        }
        void napdanhsachHDN()
        {
            lenh2.CommandText = "Select * from HDNHap";
            lenh2.Parameters.Clear();
            da2.SelectCommand = lenh2;
            dthdnhap.Clear();
            da2.Fill(dthdnhap);
        }
        void dichuyendenHD(int i)//i la ban ghi can di chuyen den
        {
            txtCTN.Text = dthdnhap.Rows[i]["SoCTN"].ToString();
            txtNgaynhap.Value = Convert.ToDateTime(dthdnhap.Rows[i]["NgayCTN"]);
            cboMancc.SelectedValue = dthdnhap.Rows[i]["MaNCC"].ToString();
            cbonhanvien.SelectedValue = dthdnhap.Rows[i]["MaNV"].ToString();

            txtlido.Text = dthdnhap.Rows[i]["Diengiai"].ToString();
            //txtSCT.Text = dthdnhap.Rows[i]["SoCTN"].ToString();

        }

        private void FrmHDnhapct_Load(object sender, EventArgs e)
        {
            NapMNCC();
            NapMNV();
            NapMH();
            napdanhsachHDN();
           // NapCT();


            if (dthdnhap.Rows.Count > 0)// ton tai it nhat 1 phieu
            {
                vitri = 0;
                dichuyendenHD(vitri);
                napchitietHD(txtCTN.Text);

            }
            NapCT();
        }

        // 2 ham tren de di chuyen toi lui

        private void Tinhtong()
        {
            double tongtien = 0;
            for (int i = 0; i < dtchitiet.Rows.Count; i++)
            {
                double sl = Convert.ToDouble(dtchitiet.Rows[i]["SL"]);
                double dg = Convert.ToDouble(dtchitiet.Rows[i]["DGN"]);
                tongtien += sl * dg;
            }
            txttongtien.Text = tongtien.ToString();


        }

        private void cboMaHH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txttongtien_TextChanged(object sender, EventArgs e)
        {

        }

        private void ctnthem_Click(object sender, EventArgs e)
        {

            //i = grdHDCT.CurrentRow.Index;
            lenh2.CommandText = " Insert into HDNhap(SoCTN,MaNCC,MaNV,NgayCTN,Diengiai)"
                 + " Values(@SoCTN,@MaNCC,@MaNV,@NgayCTN,@Diengiai)";
            lenh2.Parameters.Clear();
            lenh2.Parameters.AddWithValue("@SoCTN", txtCTN.Text);
            lenh2.Parameters.AddWithValue("@MaNCC", cboMancc.SelectedValue);
            lenh2.Parameters.AddWithValue("@MaNV", cbonhanvien.SelectedValue);
            lenh2.Parameters.AddWithValue("@NgayCTN", txtNgaynhap.Value);
            lenh2.Parameters.AddWithValue("@Diengiai", txtlido.Text);
            lenh2.ExecuteNonQuery();
            MessageBox.Show("ban thanh cong vui long nhap chi tiet hoa don" +
                "");

            //napdanhsachHDN();
            //napchitietHD(clsthuvien.SoCTN);
            sql = "Select  *, SL*DGN as Thanhtien from HDNhapCT where SoCTN = '" + txtCTN.Text + "'";
            da2 = new SqlDataAdapter(sql, ketnoi);
            dthdnhap.Clear();
           da2.Fill(dthdnhap);
           grdHDCT.DataSource = dthdnhap;
            grdHDCT.Refresh();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            addnewflag = true;
            txtSCT.Text = " ";
            txtSCT.Text = txtCTN.Text;
            //NapCT();
            //txtSCT.Focus();
            //txtSCT.Text = txtCTN.Text;
            cboMaHH.Focus();
            /*txtSCT.Text = " ";*/
            txtLoSX.Text = " ";
            txtsl.Text = " ";
            cboMaHH.Text = " ";
            txtdg.Text = " ";
            txtnsx.Text = " ";
            txthd.Text = " ";


        }
        private void NapCT()
        {

            i = grdHDCT.CurrentRow.Index;
            txtSCT.Text = grdHDCT.Rows[i].Cells["SoCTN"].Value.ToString();// lay ra gt dong y va cot manhom
            cboMaHH.Text = grdHDCT.Rows[i].Cells["MaHH"].Value.ToString();// lay ra gt dong y va cot manhom
            txtLoSX.Text = grdHDCT.Rows[i].Cells["LoSX"].Value.ToString();
            txtsl.Text = grdHDCT.Rows[i].Cells["SL"].Value.ToString();// lay ra gt dong y va cot manhom
            txtdg.Text = grdHDCT.Rows[i].Cells["DGN"].Value.ToString();
            txtnsx.Text = grdHDCT.Rows[i].Cells["NgaySX"].Value.ToString();
            txthd.Text = grdHDCT.Rows[i].Cells["HanSD"].Value.ToString();



        }

        private void grdHDCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (addnewflag == true)
            {
                lenh2.CommandText = "Insert into HDNhapCT(SoCTN,MaHH,LoSX,SL,DGN,NgaySX,HanSD) Values ('" + txtSCT.Text + "',N'" + cboMaHH.Text + "',N'" + txtLoSX.Text + "',N'" + txtsl.Text + "','" + txtdg.Text + "','" + txtnsx.Text + "','" + txthd.Text + "')";

                lenh2.ExecuteNonQuery();
                sql = "Select SoCTN,MaHH,LoSX,SL,DGN,NgaySX,HanSD, DGN*SL as Thanhtien From HDNhapCT where  SoCTN = '" + txtSCT.Text + "'";
                da2 = new SqlDataAdapter(sql, ketnoi);
                dthdnhap.Clear();
                da2.Fill(dthdnhap);
                grdHDCT.DataSource = dthdnhap;
                grdHDCT.Refresh();
               // NapCT();
                double tongtien = 0;
                for (int i = 0; i < dthdnhap.Rows.Count; i++)
                {
                    double sl = Convert.ToDouble(dthdnhap.Rows[i]["SL"]);
                    double dg = Convert.ToDouble(dthdnhap.Rows[i]["DGN"]);
                    tongtien += sl * dg;
                }
                txttongtien.Text = " ";
                txttongtien.Text = tongtien.ToString();

            }
            else
            {
                lenh2.CommandText = "Update HDNhapCT set SL ='" + txtsl.Text + "', DGN = ' " + txtdg.Text + "' where SoCTN ='" + txtSCT.Text + "' and MaHH =N'" + cboMaHH.Text + "'and LoSX = '" + txtLoSX.Text + "' ";

                lenh2.ExecuteNonQuery();
                sql = "Select SoCTN,MaHH,LoSX,SL,DGN,NgaySX,HanSD, DGN*SL as Thanhtien From HDNhapCT where  SoCTN = '" + txtSCT.Text + "'";
                da2 = new SqlDataAdapter(sql, ketnoi);
                dtchitiet.Clear();
                da2.Fill(dtchitiet);
                grdHDCT.DataSource = dtchitiet;
                grdHDCT.Refresh();

                //NapCT();
                double tongtien = 0;
                for (int i = 0; i < dtchitiet.Rows.Count; i++)
                {
                    double sl = Convert.ToDouble(dtchitiet.Rows[i]["SL"]);
                    double dg = Convert.ToDouble(dtchitiet.Rows[i]["DGN"]);
                    tongtien += sl * dg;
                }
                txttongtien.Text = " ";
                txttongtien.Text = tongtien.ToString();


                // sql = "Update HDNhap set NgayCTN='" + txtNgaynhap.Value + "',MaNCC ='" + cboMancc.Text + "',MaNV='" + cbonhanvien.Text +  "',Diengiai=N'" + txtlido.Text + "' where SoCTN='" + txtCTN.Text + "'";
                // lenh2.ExecuteNonQuery();
                /* for (i = 0; i <= grdHDCT.RowCount - 2; i++)//hang cuoi la k co du lieu nen tru 2
                 {

                     cboMaHH.Text = grdHDCT.Rows[i].Cells["MaHH"].Value.ToString();// lay ra gt dong y va cot manhom
                     txtsl.Text = grdHDCT.Rows[i].Cells["SL"].Value.ToString();// lay ra gt dong y va cot manhom
                     txtdg.Text = grdHDCT.Rows[i].Cells["DGN"].Value.ToString();
                     txtnsx.Text = grdHDCT.Rows[i].Cells["NgaySX"].Value.ToString();
                     txthd.Text = grdHDCT.Rows[i].Cells["HanSD"].Value.ToString();


                     sql = "Update HDNhapCT set MaHH=N'" + cboMaHH.Text + "',SL='" + txtsl.Text + "',DGN='" + txtdg.Text + "',NgaySX=N'" + txtnsx.Text + txtdg.Text + "',HanSD=N'" + txthd.Text + "' where SoCTN='" + txtSCT.Text + "'";
                     da2 = new SqlDataAdapter(sql, ketnoi);
                     lenh2.ExecuteNonQuery();
                     dthdnhap.Clear();
                     //da2.Fill(dthdnhap);
                     grdHDCT.DataSource = dthdnhap;
                 }*/
            }
        
    }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co chac chan muon xoa dong hien thoi?(Y/N )", "Xac nhan yeu cau", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Ban da chon yes, gio toi xoa nhe");
                sql = "Delete from HDNhap where SoCTN = '" + txtCTN.Text + "' ";
                lenh2.CommandText = sql;
                lenh2.Connection = ketnoi;
                lenh2.ExecuteNonQuery();
                //napdanhsachHDN();
                //napchitietHD(txtCTN.Text);
                txtCTN.Text = " ";
                cboMancc.SelectedValue = " ";
                cbonhanvien.SelectedValue = " ";
                txtlido.Text = " ";
                txtSCT.Text = " ";
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
                grdHDCT.Refresh();
                txttongtien.Text = "0";







            }
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
                sql = "Delete from HDNhapCT where SoCTN = '" + txtSCT.Text + "' and MaHH = '" + cboMaHH.Text + "'";
                lenh2.CommandText = sql;
                lenh2.Connection = ketnoi;
                lenh2.ExecuteNonQuery();
                i = grdHDCT.CurrentRow.Index;
                grdHDCT.Rows.RemoveAt(i);// xoa o dong i 
                //NapCT();
            }
            else
                MessageBox.Show("Ban da chon No , vay thi tam biet nho ");
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Moi ban dien thong tin sau so an cap nhat de luu");
            txtCTN.Text = " ";
            cboMancc.SelectedValue = " ";
            cbonhanvien.SelectedValue = " ";
            txtlido.Text = " ";
            txttongtien.Text = " 0";
        }

        private void txtCTN_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sql = "select HDNhapCT.SoCTN,HDNhap.NgayCTN,DMNCC.TenNCC,DMNCC.Diachi,HDNhapCT.MaHH,DMHH.TenHH,HDNhapCT.SL,HDNhapCT.DGN,HDNhap.Diengiai from HDNhap inner join HDNhapCT on HDNhapCT.SoCTN=HDNhap.SoCTN inner join DMHH on DMHH.MaHH=HDNhapCT.MaHH inner join DMNCC on DMNCC.MaNCC=HDNhap.MaNCC where HDNhapCT.SoCTN = '" + txtCTN.Text + "'";// +
                                                                                                                                                                                                                                                                                                                                                // " where " + comTruong.Text + " =N'" + comboGT.Text + "'";// de co the so sanh gt co tieng viet

            da = new SqlDataAdapter(sql, ketnoi);
            dt.Clear();
            da.Fill(dtbc);
            rptHDMH bc = new rptHDMH();
            bc.SetDataSource(dtbc);// dua du lieu vao bao cao
                                   //bc.DataDefinition.FormulaFields["TenTruong"].Text = "'" + comTruong.Text + "'";
                                   // bc.DataDefinition.FormulaFields["GiaTri"].Text = "'" + comGT.Text + " '";
           FrmInHDMH f = new FrmInHDMH(bc);
            f.Show();

        }

        private void grdHDCT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnchonHD_Click(object sender, EventArgs e)
        {
            FrmHDN f = new FrmHDN();
            f.ShowDialog();
            if (clsthuvien.SoCTN != " ")
            {
                napmothoadon(clsthuvien.SoCTN);
                napchitietHD(clsthuvien.SoCTN);

                //NapCT();

            }
        }
    }
}
