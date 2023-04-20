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
    public partial class FrmDMKH : Form
    {

        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        bool addnewflag = false;
        string sql, constr;
        DataTable comdt = new DataTable();
        int i;
        public FrmDMKH()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            sql = "Select  MaKH,TenKH,Diachi,Tel,Email from DMKH";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt); //cmt
            grdData.DataSource = dt;
            grdData.Refresh();
            //tạo grid table -> tạo column -> sửa name, text và name = data property name, sửa align ...
            NapCT();
        }
        private void NapCT()
        {
            i = grdData.CurrentRow.Index;// so thu tu cua dong hien thoi trong o luoi
            txtMaKH.Text = grdData.Rows[i].Cells["MaKH"].Value.ToString();// lay ra gt dong y va cot manhom
            txtTenKH.Text = grdData.Rows[i].Cells["TenKH"].Value.ToString();// lay ra gt dong y va cot manhom
            txtDiachi.Text = grdData.Rows[i].Cells["Diachi"].Value.ToString();// lay ra gt dong y va cot manhom
            txtTel.Text = grdData.Rows[i].Cells["Tel"].Value.ToString();
            txtEmail.Text = grdData.Rows[i].Cells["Email"].Value.ToString();


        }
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (comTruong.Text == "")
            {
                MessageBox.Show("Bạn cần thiết lập điều kiện lọc trước");
            }
            else
            {
                sql = "Select  MaKH,TenKH,Diachi,Tel,Email from DMKH" +
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

        private void FrmDMKH_Load(object sender, EventArgs e)
        {
            constr = "Data Source = DESKTOP-IEGRD2D\\SQLEXPRESS; Initial Catalog = quanlybanthuoc; Integrated Security = True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = " Select MaKH,TenKH,Diachi,Tel,Email from DMKH";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);//du lieu do vao data
            grdData.DataSource = dt;// ga
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
            txtMaKH.Focus();
            addnewflag = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            NapCT();
            MessageBox.Show("Hay sua noi dung cua ban ghi hien thoi ,ket thuc voi nut cap nhat ");
            txtTenKH.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Ban co chac chan muon xoa dong hien thoi?(Y/N )", "Xac nhan yeu cau", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Ban da chon yes, gio toi xoa nhe");
                sql = "Delete from DMKH where MaKH = '" + txtMaKH.Text + " '";
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
                sql = "Insert into DMKH (MaKH,TenKH,Diachi,Tel,Email) Values ('" + txtMaKH.Text + "',N'" + txtTenKH.Text + "',N'" + txtDiachi.Text + "',N'" + txtTel.Text + "','" + txtEmail.Text + "')";

                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                addnewflag = false;
                //NapCT();
                sql = "Select MaKH,TenKH,Diachi,Tel,Email From DMKH";
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
                    txtMaKH.Text = grdData.Rows[i].Cells["MaKH"].Value.ToString();

                    txtTenKH.Text = grdData.Rows[i].Cells["TenKH"].Value.ToString();// lay ra gt dong y va cot manhom
                    txtDiachi.Text = grdData.Rows[i].Cells["Diachi"].Value.ToString();// lay ra gt dong y va cot manhom
                    txtTel.Text = grdData.Rows[i].Cells["Tel"].Value.ToString();// lay ra gt dong y va cot manhom
                    txtEmail.Text = grdData.Rows[i].Cells["Email"].Value.ToString();

                    sql = "Update DMKH set TenKH=N'" + txtTenKH.Text + "',Diachi='" + txtDiachi.Text + "',Tel='" + txtTel.Text + "',Email  = '" + txtEmail.Text + " ' where MaKH = '" + txtMaKH.Text + "'";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    //cmd.ExecuteNonQuery();

                }
                MessageBox.Show("Đã cập nhật thành công!");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "Select Distinct " + comTruong.Text + " From DMKH ";

            da = new SqlDataAdapter(sql, conn);
            comdt.Clear();
            da.Fill(comdt);
            comGT.DataSource = comdt;//dan du lieu cho combo 
            comGT.DisplayMember = comTruong.Text;

        }
    }
}
