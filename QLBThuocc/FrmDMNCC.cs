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
    public partial class FrmDMNCC : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        DataTable dtNhom = new DataTable();
        string sql, constr;
        int i;
        Boolean addnewflag = false;
        public FrmDMNCC()
        {
            InitializeComponent();
        }
        private void NapCT()
        {
            i = grdData.CurrentRow.Index;// so thu tu cua dong hien thoi trong o luoi

            txtMNCC.Text = grdData.Rows[i].Cells["MaNCC"].Value.ToString();// lay ra gt dong y va cot manhom
            txtTNCC.Text = grdData.Rows[i].Cells["TenNCC"].Value.ToString();// lay ra gt dong y va cot manhom
            txtDC.Text = grdData.Rows[i].Cells["Diachi"].Value.ToString();
            txtSDT.Text = grdData.Rows[i].Cells["Tel"].Value.ToString();

        }
        private void FrmDMNCC_Load(object sender, EventArgs e)
        {
            constr = "Data Source = DESKTOP-IEGRD2D\\SQLEXPRESS; Initial Catalog = quanlybanthuoc; Integrated Security = True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = " Select MaNCC,TenNCC,Diachi,Tel from DMNCC";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);//du lieu do vao data
            grdData.DataSource = dt;// gan du lieu cho o luoi
            NapCT();

        }

        private void btnTimkiem_Click_1(object sender, EventArgs e)
        {
            if (comTruong.Text == "")
            {
                MessageBox.Show("Bạn cần thiết lập điều kiện lọc trước");
            }
            else
            {
                sql = "Select MaNCC,TenNCC,Diachi,Tel From DMNCC" +
                    " where " + comTruong.Text + "=N'" + comGT.Text + "'";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt); //cmt
                grdData.DataSource = dt;
                grdData.Refresh();
                //tạo grid table -> tạo column -> sửa name, text và name = data property name, sửa align ...
                NapCT();
            }
        }

        private void comTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "Select Distinct " + comTruong.Text + " From DMNCC ";

            da = new SqlDataAdapter(sql, conn);
            comdt.Clear();
            da.Fill(comdt);
            comGT.DataSource = comdt;//dan du lieu cho combo 
            comGT.DisplayMember = comTruong.Text;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            sql = "Select MaNCC,TenNCC,Diachi,Tel From DMNCC";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt); //cmt
            grdData.DataSource = dt;
            grdData.Refresh();
            //tạo grid table -> tạo column -> sửa name, text và name = data property name, sửa align ...
            NapCT();
        }

        private void grdData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            grdData.CurrentCell = grdData[0, grdData.RowCount - 1];
            NapCT();
            MessageBox.Show("Hay nhap noi dung cua ban ghi moi ,ket thuc voi nut cap nhat ");
            txtTNCC.Focus();
            addnewflag = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            NapCT();
            MessageBox.Show("Hay sua noi dung cua ban ghi hien thoi ,ket thuc voi nut cap nhat ");
            txtTNCC.Focus();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            NapCT();
            MessageBox.Show("Hay sua noi dung cua ban ghi hien thoi ,ket thuc voi nut cap nhat ");
            txtTNCC.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co chac chan muon xoa dong hien thoi?(Y/N )", "Xac nhan yeu cau", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Ban da chon yes, gio toi xoa nhe");
                sql = "Delete from DMNCC where MaNCC = '" + txtMNCC.Text + " '";
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                i = grdData.CurrentRow.Index;
                grdData.Rows.RemoveAt(i);// xoa o dong i 
                NapCT();
            }
            else
                MessageBox.Show("Ban da chon No , vay thi tam biet nho ");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (addnewflag == true)
            {
                sql = "Insert into DMNCC (MaNCC,TenNCC,Diachi,Tel) Values ('" + txtMNCC.Text + "',N'" + txtTNCC.Text + "',N'" + txtDC.Text + "',N'" + txtSDT.Text + "')";

                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                addnewflag = false;
                //NapCT();
                sql = "Select MaNCC,TenNCC,Diachi,Tel From DMNCC";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt); //cmt
                grdData.DataSource = dt;
                grdData.Refresh();
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
                for (i = 0; i <= grdData.RowCount - 2; i++)//hang cuoi la k co du lieu nen tru 2
                {

                    txtMNCC.Text = grdData.Rows[i].Cells["MaNCC"].Value.ToString();// lay ra gt dong y va cot manhom
                    txtTNCC.Text = grdData.Rows[i].Cells["TenNCC"].Value.ToString();// lay ra gt dong y va cot manhom
                    txtDC.Text = grdData.Rows[i].Cells["Diachi"].Value.ToString();// lay ra gt dong y va cot manhom
                    txtSDT.Text = grdData.Rows[i].Cells["Tel"].Value.ToString();

                    sql = "Update DMNCC set TenNCC=N'" + txtTNCC.Text + "',Diachi='" + txtDC.Text + "',Tel=N'" + txtSDT.Text + "'where MaNCC = ' " + txtMNCC + "'";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    //cmd.ExecuteNonQuery();

                }
                MessageBox.Show("Đã cập nhật thành công!");
            }
        }

        private void FrmDMNCC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("\t");
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (comTruong.Text == "")
            {
                MessageBox.Show("Bạn cần thiết lập điều kiện lọc trước");
            }
            else
            {
                sql = "Select MaNCC,TenNCC,Diachi,Tel From DMNCC" +
                    " where " + comTruong.Text + "=N'" + comGT.Text + "'";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt); //cmt
                grdData.DataSource = dt;
                grdData.Refresh();
                //tạo grid table -> tạo column -> sửa name, text và name = data property name, sửa align ...
                NapCT();
            }
        }

        
    }
}

  
