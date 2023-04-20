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
    public partial class FrmDMNV : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        bool addnewflag = false;
        string sql, constr;
        DataTable comdt = new DataTable();
        int i;
        public FrmDMNV()
        {
            InitializeComponent();
        }

        private void comTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "Select Distinct " + comTruong.Text + " From DMNV ";

            da = new SqlDataAdapter(sql, conn);
            comdt.Clear();
            da.Fill(comdt);
            comGT.DataSource = comdt;//dan du lieu cho combo 
            comGT.DisplayMember = comTruong.Text;
        }
        private void NapCT()
        {
            i = grdDMNV.CurrentRow.Index;// so thu tu cua dong hien thoi trong o luoi
            txtMaNV.Text = grdDMNV.Rows[i].Cells["MaNV"].Value.ToString();// lay ra gt dong y va cot manv
            txtTenNV.Text = grdDMNV.Rows[i].Cells["TenNV"].Value.ToString();// lay ra gt dong y va cot tennv
            txtChucvu.Text = grdDMNV.Rows[i].Cells["Chucvu"].Value.ToString();// lay ra gt dong y va cot chucvu
            txtDiachi.Text = grdDMNV.Rows[i].Cells["Diachi"].Value.ToString();
            txtTel.Text = grdDMNV.Rows[i].Cells["Tel"].Value.ToString();
            txtEmail.Text = grdDMNV.Rows[i].Cells["Email"].Value.ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

            sql = "Select MaNV,TenNV, Chucvu,Diachi,Tel,Email from DMNV";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt); //cmt
            grdDMNV.DataSource = dt;
            grdDMNV.Refresh();
            //tạo grid table -> tạo column -> sửa name, text và name = data property name, sửa align ...
            NapCT();
        }

        private void FrmDMNV_Load(object sender, EventArgs e)
        {
            constr = "Data Source = DESKTOP-IEGRD2D\\SQLEXPRESS; Initial Catalog = quanlybanthuoc; Integrated Security = True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = " Select MaNV,TenNV, Chucvu,Diachi,Tel,Email from DMNV";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);//du lieu do vao data
            grdDMNV.DataSource = dt;// gan du lieu cho o luoi
                                    //sql = "select Distinct MaNhom from DMHH";
                                    //da = new SqlDataAdapter(sql, conn);
                                    //  da.Fill(dtNhom);
                                    //txtM.DataSource = dtNhom;
                                    // txtMaNhom.DisplayMember = "Manhom";

            NapCT();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            grdDMNV.CurrentCell = grdDMNV[0, grdDMNV.RowCount - 1];
            NapCT();
            MessageBox.Show(" Hãy thêm nội dung của bản ghi mới, kết thúc với nút cập nhật  ");
            txtTenNV.Focus();
            addnewflag = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            NapCT();
            MessageBox.Show("Hãy sửa nội dung của bản ghi hiện thời, kết thúc bằng nút cập nhật ");
            txtTenNV.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co chac chan muon xoa dong hien thoi?(Y/N )", "Xac nhan yeu cau", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Ban da chon yes, gio toi xoa nhe");
                sql = "Delete from DMNV where MaNV = '" + txtMaNV.Text + " '";
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                i = grdDMNV.CurrentRow.Index;
                grdDMNV.Rows.RemoveAt(i);// xoa o dong i 
                NapCT();
            }
            else
                MessageBox.Show("Ban da chon No , vay thi tam biet nho ");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (addnewflag == true)
            {
                sql = "Insert into DMNV (MaNV,TenNV,Chucvu,Diachi,Tel,Email) Values ('" + txtMaNV.Text + "',N'" + txtTenNV.Text + "',N'" + txtChucvu.Text + "',N'" + txtDiachi.Text + "',N'" + txtTel.Text + "',N'" + txtEmail.Text + "')";

                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                addnewflag = false;
                //NapCT();
                sql = "Select MaNV,TenNV,Chucvu,Diachi,Tel,Email from DMNV ";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt); //cmt
                grdDMNV.DataSource = dt;
                grdDMNV.Refresh();
                //tạo grid table -> tạo column -> sửa name, text và name = data property name, sửa align ...
                NapCT();



            }
            else
            {

                /*  sql = "Update tblDMHH set TenHH=N'" + txtTenH.Text + "',Dgvnd='" + txtDG.Text + "',dvt='" + txtDvt.Text + "',SanXuat=N'" + txtSX.Text + "' where Mahh='" + txtMaHH.Text + "'";
                  cmd = new SqlCommand(sql, conn);
                  cmd.ExecuteNonQuery();


              //naplai();
              MessageBox.Show("Đã cập nhật thành công!");*/
                for (i = 0; i <= grdDMNV.RowCount - 2; i++)//hang cuoi la k co du lieu nen tru 2
                {
                    txtMaNV.Text = grdDMNV.Rows[i].Cells["MaNV"].Value.ToString();// lay ra gt dong y va cot manv
                    txtTenNV.Text = grdDMNV.Rows[i].Cells["TenNV"].Value.ToString();// lay ra gt dong y va cot tennv
                    txtChucvu.Text = grdDMNV.Rows[i].Cells["Chucvu"].Value.ToString();// lay ra gt dong y va cot chucvu
                    txtDiachi.Text = grdDMNV.Rows[i].Cells["Diachi"].Value.ToString();
                    txtTel.Text = grdDMNV.Rows[i].Cells["Tel"].Value.ToString();
                    txtEmail.Text = grdDMNV.Rows[i].Cells["Email"].Value.ToString();

                    sql = "Update DMNV set TenNV=N'" + txtTenNV.Text + "',Diachi='" + txtDiachi.Text + "',Email=N'" + txtEmail.Text + "',Chucvu=N'" + txtChucvu.Text + "',Tel=N'" + txtTel.Text + "'where MaNV = ' " + txtMaNV + "'";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    //cmd.ExecuteNonQuery();

                }
                MessageBox.Show("Đã cập nhật thành công!");
            }
            }

        private void FrmDMNV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("\t");
            }
        }

        private void grdDMNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (comTruong.Text == "")
            {
                MessageBox.Show("Bạn cần thiết lập điều kiện lọc trước");
            }
            else
            {
                sql = "Select MaNV,TenNV, Chucvu,Diachi,Tel,Email from DMNV" +
                    " where " + comTruong.Text + "=N'" + comGT.Text + "'";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt); //cmt
                grdDMNV.DataSource = dt;
                grdDMNV.Refresh();
                //tạo grid table -> tạo column -> sửa name, text và name = data property name, sửa align ...
                NapCT();
            }
        }
    }
}
