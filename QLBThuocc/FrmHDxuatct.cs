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
    public partial class FrmHDxuatct : Form
    {
        SqlConnection ketnoi = new SqlConnection();
        SqlCommand lenh = new SqlCommand();// doi tuong de thuc thi lenh
        SqlDataAdapter da = new SqlDataAdapter();//do du lieu vao data
        DataTable dtchitiet = new DataTable("HDXuatCT");//do du lieu vao
        DataTable dthdxuat = new DataTable(" ");
        SqlConnection conn = new SqlConnection();
        DataTable dtbc = new DataTable();
        DataTable dt = new DataTable();
        int vitri = -1;// do chua biet ban dau hd so may
        string constr, sql;
        public static string MaHD;
        SqlCommand lenh2 = new SqlCommand();
        SqlDataAdapter da2 = new SqlDataAdapter();// nap cac dieu kien con nho 
        int i;
        Boolean addnewflag = false;
        
        public FrmHDxuatct()
        {
            InitializeComponent();
            constr = "Data Source = DESKTOP-IEGRD2D\\SQLEXPRESS; Initial Catalog = quanlybanthuoc; Integrated Security = True";
            ketnoi.ConnectionString = constr;
            ketnoi.Open();
            lenh.Connection = ketnoi;// lenh tro toi csdl qlht
            lenh2.Connection = ketnoi;// tro den cung 1 coso du lieu qlhieuthuoc
        }
        void NapMNV()
        {
            sql = " Select MaNV from DMNV ";
            da2 = new SqlDataAdapter(sql, ketnoi);
            DataTable dt = new DataTable(" NV");
            da2.Fill(dt);
            cbonhanvien.DataSource = dt;
            cbonhanvien.ValueMember = "MaNV";
            cbonhanvien.DisplayMember = "MaNV";
        }
        void NapKH()
        {
            sql = "select Distinct MaKH from DMKH";
            da2 = new SqlDataAdapter(sql, ketnoi);
            DataTable dt = new DataTable(" NV");
            da2.Fill(dt);
            cboKH.DataSource = dt;
            cboKH.ValueMember = "MaKH";
            cboKH.DisplayMember = "MaKH";
        }
        void NapMH()
        {
            sql = " Select MaHH from DMHH ";
            da2 = new SqlDataAdapter(sql, ketnoi);
            DataTable dt = new DataTable(" MH");
            da2.Fill(dt);
            cboMaHH.DataSource = dt;
            cboMaHH.ValueMember = "MaHH";
            cboMaHH.DisplayMember = "MaHH";


        }
        void NapLSX()
        {
            lenh2.CommandText = " Select LoSX from HDNhapCT where  MaHH = @MaHH";
            da2 = new SqlDataAdapter(sql, ketnoi);
            lenh2.Parameters.Clear();// do k co dieu kien loc lay toan bo ban ghi
            lenh2.Parameters.AddWithValue("@MaHH", cboMaHH.Text);
            da2.SelectCommand = lenh2;
            DataTable dt = new DataTable("LoSX");
            da2.Fill(dt);
            cboLoSX.DataSource = dt;
            cboLoSX.ValueMember = "LoSX";
            cboLoSX.DisplayMember = "LoSX";

        }

        void napchitietHD(string spx)
        {
            //NapMH();
            lenh.CommandText = " Select SoCTX, HDXuatCT.MaHH, DMHH.TenHH, HDXuatCT.LoSX, HDXuatCT.SL, DMHH.DG ,SL*DG as Thanhtien from HDXuatCT,DMHH  where DMHH.MaHH =HDXuatCT.MaHH  and SoCTX = @SPX ";
            lenh.Parameters.Clear();
            lenh.Parameters.AddWithValue("@SPX", spx);
            da.SelectCommand = lenh;
            dtchitiet.Clear();
            da.Fill(dtchitiet);
            grdHDXCT.DataSource = dtchitiet;
            //tinh tong tien phieu xuat
            double tongtien = 0;
            for (int i = 0; i < dtchitiet.Rows.Count; i++)
            {
                double sl = Convert.ToDouble(dtchitiet.Rows[i]["SL"]);
                double dg = Convert.ToDouble(dtchitiet.Rows[i]["DG"]);
                tongtien += sl * dg;
            }
            txttongtien.Text = tongtien.ToString();
        }
        void napmothoadon(string spx)
        {
            lenh2.CommandText = "select * from HDXuat where SoCTX = @SPX";
            lenh2.Parameters.Clear();
            lenh2.Parameters.AddWithValue("@SPX", spx);
            da2.SelectCommand = lenh2;
            DataTable dt = new DataTable(" Mothoadon");
            da2.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtCTX.Text = dt.Rows[0]["SoCTX"].ToString();
                txtNgayxuat.Value = Convert.ToDateTime(dt.Rows[0]["NgayCTX"]);
                cboKH.SelectedValue = dt.Rows[0]["MaKH"].ToString();
                cbonhanvien.SelectedValue = dt.Rows[0]["MaNV"].ToString();
                txtlido.Text = dt.Rows[0]["Diengiai"].ToString();


            }
        }
        void napdanhsachHDX()
        {
            lenh2.CommandText = "Select * from HDXuat ";
            lenh2.Parameters.Clear();
            da2.SelectCommand = lenh2;
            dthdxuat.Clear();
            da2.Fill(dthdxuat);
        }
        void dichuyendenHD(int i)//i la ban ghi can di chuyen den
        {
            txtCTX.Text = dthdxuat.Rows[i]["SoCTX"].ToString();
            txtNgayxuat.Value = Convert.ToDateTime(dthdxuat.Rows[i]["NgayCTX"]);
            cboKH.SelectedValue = dthdxuat.Rows[i]["MaKH"].ToString();
            cbonhanvien.SelectedValue = dthdxuat.Rows[i]["MaNV"].ToString();

            txtlido.Text = dthdxuat.Rows[i]["Diengiai"].ToString();
        }

        private void FrmHDxuatct_Load(object sender, EventArgs e)
        {
            NapMH();

            NapKH();

            NapMNV();
            napdanhsachHDX();
            if (dthdxuat.Rows.Count > 0)// ton tai it nhat 1 phieu
            {
                vitri = 0;
                dichuyendenHD(vitri);
                napchitietHD(txtCTX.Text);
            }
            NapCT();


        }

        private void ctnthem_Click(object sender, EventArgs e)
        {
            lenh2.CommandText = " Insert into HDXuat(SoCTX,MaKH,MaNV,NgayCTX,Diengiai)"
                + " Values(@SoCTX,@MaKH,@MaNV,@NgayCTX,@Diengiai)";
            lenh2.Parameters.Clear();
            lenh2.Parameters.AddWithValue("@SoCTX", txtCTX.Text);
            lenh2.Parameters.AddWithValue("@MaKH", cboKH.SelectedValue);
            lenh2.Parameters.AddWithValue("@MaNV", cbonhanvien.SelectedValue);
            lenh2.Parameters.AddWithValue("@NgayCTX", txtNgayxuat.Value);
            lenh2.Parameters.AddWithValue("@Diengiai", txtlido.Text);
            lenh2.ExecuteNonQuery();
            MessageBox.Show("ban thanh cong vui long nhap chi tiet hoa don" +
                "");

            //napdanhsachHDN();
            //napchitietHD(clsthuvien.SoCTN);
            sql = "Select  *, SL*DG as Thanhtien from HDXuatCT,DMHH where  HDXuatCT.MaHH=DMHH.MaHH and SoCTX = '" + txtCTX.Text + "'";
            da2 = new SqlDataAdapter(sql, ketnoi);
            dthdxuat.Clear();
            da2.Fill(dthdxuat);
            grdHDXCT.DataSource = dthdxuat;
            grdHDXCT.Refresh();
            
            
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co chac chan muon xoa dong hien thoi?(Y/N )", "Xac nhan yeu cau", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Ban da chon yes, gio toi xoa nhe");
                sql = "Delete from HDXuat where SoCTX = '" + txtCTX.Text + "' ";
                lenh2.CommandText = sql;
                lenh2.Connection = ketnoi;
                lenh2.ExecuteNonQuery();
                napdanhsachHDX();
                txtCTX.Text = " ";
                napchitietHD(txtCTX.Text);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Moi ban dien thong tin sau so an cap nhat de luu");
            txtCTX.Text = " ";
            cboKH.SelectedValue = " ";
            cbonhanvien.SelectedValue = " ";
            txtlido.Text = " ";
            txttongtien.Text = "0";
        }

        private void cboMaHH_SelectedIndexChanged(object sender, EventArgs e)
        {
            NapLSX();
            /*sql = "Select Distinct " + comTruong.Text + " From DMHH ";

            da = new SqlDataAdapter(sql, conn);
            comdt.Clear();
            da.Fill(comdt);
            comGT.DataSource = comdt;//dan du lieu cho combo 
            comGT.DisplayMember = comTruong.Text;*/
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            NapMH();
            addnewflag = true;
            txtSCT.Text = " ";
            txtSCT.Text = txtCTX.Text;
            //NapCT();
            //txtSCT.Focus();
            //txtSCT.Text = txtCTN.Text;
            cboMaHH.Focus();
        }
        private void NapCT()
        {

            i = grdHDXCT.CurrentRow.Index;
            txtSCT.Text = grdHDXCT.Rows[i].Cells["SoCTX"].Value.ToString();// lay ra gt dong y va cot manhom
            cboMaHH.Text = grdHDXCT.Rows[i].Cells["MaHH"].Value.ToString();// lay ra gt dong y va cot manhom
            cboLoSX.Text = grdHDXCT.Rows[i].Cells["LoSX"].Value.ToString();
            txtsl.Text = grdHDXCT.Rows[i].Cells["SL"].Value.ToString();// lay ra gt dong y va cot manhom




        
        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            addnewflag = false;
            NapCT();
            MessageBox.Show("Hay sua noi dung cua ban ghi hien thoi ,ket thuc voi nut cap nhat ");
            cboMaHH.Focus();
        }

        private void txtcapnhat_Click(object sender, EventArgs e)
        {
            if (addnewflag == true)
            {
                lenh2.CommandText = "Insert into HDXuatCT (STT,SoCTX,MaHH,SL) Values ('"  + txtSCT.Text + "',N'" + cboMaHH.Text + "',N'" + txtsl.Text + "')";

                lenh2.ExecuteNonQuery();
                sql = "Select *,DG*SL as Thanhtien From HDXuatCT,DMHH where  HDXuatCT.MaHH=DMHH.MaHH and SoCTX = '" + txtSCT.Text + "'";
                da2 = new SqlDataAdapter(sql, ketnoi);
                dtchitiet.Clear();
                da2.Fill(dtchitiet);
                grdHDXCT.DataSource = dtchitiet;
                grdHDXCT.Refresh();
                // NapCT();
                double tongtien = 0;
                for (int i = 0; i < dtchitiet.Rows.Count; i++)
                {
                    double sl = Convert.ToDouble(dtchitiet.Rows[i]["SL"]);
                    double dg = Convert.ToDouble(dtchitiet.Rows[i]["DG"]);
                    tongtien += sl * dg;
                }
                txttongtien.Text = " ";
                txttongtien.Text = tongtien.ToString();
                addnewflag = false;

            }
            else
            {
                for (i = 0; i <= grdHDXCT.RowCount - 2; i++)//hang cuoi la k co du lieu nen tru 2
                {
                    //txtstt.Text = grdHDXCT.Rows[i].Cells["STT"].Value.ToString();
                    cboMaHH.Text = grdHDXCT.Rows[i].Cells["MaHH"].Value.ToString();// lay ra gt dong y va cot manhom
                    txtsl.Text = grdHDXCT.Rows[i].Cells["SL"].Value.ToString();



                    sql = "Update HDXuatCT set MaHH =N'" + cboMaHH.Text + "',SL ='" + txtsl.Text + "' where SoCTX ='" + txtSCT.Text +  "'";
                    lenh = new SqlCommand(sql, ketnoi);
                    lenh.ExecuteNonQuery();

                }
                double tongtien = 0;
                for (int i = 0; i < dtchitiet.Rows.Count; i++)
                {
                    double sl = Convert.ToDouble(dtchitiet.Rows[i]["SL"]);
                    double dg = Convert.ToDouble(dtchitiet.Rows[i]["DG"]);
                    tongtien += sl * dg;
                }
                txttongtien.Text = " ";
                txttongtien.Text = tongtien.ToString();

            }
        }

        private void grdHDXCT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void grdHDXCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co chac chan muon xoa dong hien thoi?(Y/N )", "Xac nhan yeu cau", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Ban da chon yes, gio toi xoa nhe");
                sql = "Delete from HDXuatCT where SoCTX = '" + txtSCT.Text + "' and MaHH = '" + cboMaHH.Text + "' and LoSX = '" + cboLoSX.Text + "' " ;
                lenh2.CommandText = sql;
                lenh2.Connection = ketnoi;
                lenh2.ExecuteNonQuery();
                i = grdHDXCT.CurrentRow.Index;
                grdHDXCT.Rows.RemoveAt(i);// xoa o dong i 
                //NapCT();
            }
            else
                MessageBox.Show("Ban da chon No , vay thi tam biet nho ");
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (addnewflag == true)
            {
                lenh2.CommandText = "Insert into HDXuatCT (SoCTX,MaHH,LoSX,SL) Values ('" + txtSCT.Text + "',N'" + cboMaHH.Text + "',N'" + cboLoSX.Text + "',N'" + txtsl.Text + "')";

                lenh2.ExecuteNonQuery();
                sql = "Select SoCTX, HDXuatCT.MaHH, DMHH.TenHH, HDXuatCT.LoSX, HDXuatCT.SL, DMHH.DG ,DG*SL as Thanhtien From HDXuatCT,DMHH where  HDXuatCT.MaHH=DMHH.MaHH and SoCTX = '" + txtSCT.Text + "'";
                da2 = new SqlDataAdapter(sql, ketnoi);
                dtchitiet.Clear();
                da2.Fill(dtchitiet);
                grdHDXCT.DataSource = dtchitiet;
                grdHDXCT.Refresh();
                // NapCT();
                double tongtien = 0;
                for (int i = 0; i < dtchitiet.Rows.Count; i++)
                {
                    double sl = Convert.ToDouble(dtchitiet.Rows[i]["SL"]);
                    double dg = Convert.ToDouble(dtchitiet.Rows[i]["DG"]);
                    tongtien += sl * dg;
                }
                txttongtien.Text = " ";
                txttongtien.Text = tongtien.ToString();
                addnewflag = false;

            }
            else
            {
                /*for (i = 0; i <= grdHDXCT.RowCount - 2; i++)//hang cuoi la k co du lieu nen tru 2
                {
                    //txtstt.Text = grdHDXCT.Rows[i].Cells["STT"].Value.ToString();
                    cboMaHH.Text = grdHDXCT.Rows[i].Cells["MaHH"].Value.ToString();// lay ra gt dong y va cot manhom
                    txtsl.Text = grdHDXCT.Rows[i].Cells["SL"].Value.ToString();



                   

                }*/
                lenh2.CommandText = "Update HDXuatCT set SL ='" + txtsl.Text + "' where SoCTX ='" + txtSCT.Text + "' and MaHH =N'" + cboMaHH.Text + "'and LoSX = '" + cboLoSX.Text + "' ";

                lenh2.ExecuteNonQuery();
                sql = "Select SoCTX, HDXuatCT.MaHH, DMHH.TenHH, HDXuatCT.LoSX, HDXuatCT.SL, DMHH.DG ,DG*SL as Thanhtien From HDXuatCT,DMHH where  HDXuatCT.MaHH=DMHH.MaHH and SoCTX = '" + txtSCT.Text + "'";
                da2 = new SqlDataAdapter(sql, ketnoi);
                dtchitiet.Clear();
                da2.Fill(dtchitiet);
                grdHDXCT.DataSource = dtchitiet;
                grdHDXCT.Refresh();
                /*sql = "Update HDXuatCT set SL ='" + txtsl.Text + "' where SoCTX ='" + txtSCT.Text + "' and MaHH =N'" + cboMaHH.Text + "'and LoSX = '" + cboLoSX.Text + "' ,";
                lenh = new SqlCommand(sql, ketnoi);
                lenh.ExecuteNonQuery();
                sql = "Select SoCTX, HDXuatCT.MaHH, DMHH.TenHH, HDXuatCT.LoSX, HDXuatCT.SL, DMHH.DG ,DG*SL as Thanhtien From HDXuatCT,DMHH where  HDXuatCT.MaHH=DMHH.MaHH and SoCTX = '" + txtSCT.Text + "'";
                da2 = new SqlDataAdapter(sql, ketnoi);
                dtchitiet.Clear();
                da2.Fill(dtchitiet);
                grdHDXCT.DataSource = dtchitiet;
                grdHDXCT.Refresh();*/
                double tongtien = 0;
                for (int i = 0; i < dtchitiet.Rows.Count; i++)
                {
                    double sl = Convert.ToDouble(dtchitiet.Rows[i]["SL"]);
                    double dg = Convert.ToDouble(dtchitiet.Rows[i]["DG"]);
                    tongtien += sl * dg;
                }
                txttongtien.Text = " ";
                txttongtien.Text = tongtien.ToString();

            }
        }

        private void cboLoSX_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnin_Click(object sender, EventArgs e)
        {
            sql = "Select HDXuatCT.SoCTX,HDXuat.NgayCTX, DMKH.TenKH,DMKH.DiaChi,HDXuatCT.MaHH,DMHH.TenHH,HDXuatCT.SL ,DMHH.DG,HDXuat.Diengiai from HDXuat inner join  HDXuatCT on HDxuatCT.SoCTX=HDXuat.SoCTX inner join DMHH on DMHH.MaHH=HDXuatCT.MaHH inner join DMKH on DMKH.MaKH=HDXuat.MaKH where HDXuatCT.SoCTX = '" + txtCTX.Text + "'";// +
                                                                          // " where " + comTruong.Text + " =N'" + comboGT.Text + "'";// de co the so sanh gt co tieng viet

            da = new SqlDataAdapter(sql, ketnoi);
            dt.Clear();
            da.Fill(dtbc);
            rptHDBH bc = new rptHDBH();
            bc.SetDataSource(dtbc);// dua du lieu vao bao cao
                                   //bc.DataDefinition.FormulaFields["TenTruong"].Text = "'" + comTruong.Text + "'";
                                   // bc.DataDefinition.FormulaFields["GiaTri"].Text = "'" + comGT.Text + " '";
            frm_in f = new frm_in(bc);
            f.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        //txtSCT.Text = dthdnhap.Rows[i]["SoCTN"].ToString();



        private void btnchonHD_Click(object sender, EventArgs e)
        {
            FrmHDX f = new FrmHDX();
            f.ShowDialog();
            if (Classthuvienxuat.SoCTX != " ")
            {
                napmothoadon(Classthuvienxuat.SoCTX);
                napchitietHD(Classthuvienxuat.SoCTX);

                //NapCT();
            }
        }
    }
}
