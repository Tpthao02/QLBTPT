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
    public partial class FrmDMKho : Form
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
        public FrmDMKho()
        {
            InitializeComponent();
        }

        private void FrmDMKho_Load(object sender, EventArgs e)
        {
            constr = "Data Source = DESKTOP-IEGRD2D\\SQLEXPRESS; Initial Catalog = quanlybanthuoc; Integrated Security = True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = " Select Makho,Tenkho from DMKHO";
            da = new SqlDataAdapter(sql, conn);
            da1 = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);//du lieu do vao data
            grdDMK.DataSource = dt;// gan
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtTenHH_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtMaHH_TextChanged(object sender, EventArgs e)
        {

        }
        private void NapCT()
        {
            i = grdDMK.CurrentRow.Index;// so thu tu cua dong hien thoi trong o luoi
            txtMK.Text = grdDMK.Rows[i].Cells["Makho"].Value.ToString();

            txtTenK.Text = grdDMK.Rows[i].Cells["Tenkho"].Value.ToString();// lay ra gt dong y va cot manhom

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            grdDMK.CurrentCell = grdDMK[0, grdDMK.RowCount - 1];
            NapCT();
            MessageBox.Show("Hãy nhập nội dung bản ghi mới,kết thúc bằng nút cập nhật ");
            txtMK.Focus();
            addnewflag = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            NapCT();
            MessageBox.Show("Hãy sửa nội dung của bản ghi hiện thời, kết thúc bằng nút cập nhật");
            txtMK.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa bản ghi hiện thời ?(Y/N )", "Xác nhận yêu cầu ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Không thể xóa bản ghi do ràng buộc về hàng hóa ");

            }
            else { MessageBox.Show("Thoát "); }



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (addnewflag == true)
            {
                sql = "Insert into DMKHO (Makho, Tenkho) Values ('" + txtMK.Text + "','" + txtTenK.Text + "')";

                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                addnewflag = false;
                //NapCT();
                sql = "Select Makho, Tenkho from DMKHO";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt); //cmt
                grdDMK.DataSource = dt;
                grdDMK.Refresh();
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
                /*   for (i = 0; i <= grdDMK.RowCount - 2; i++)//hang cuoi la k co du lieu nen tru 2
                   {
                       txtMK.Text = grdDMK.Rows[i].Cells["Makho"].Value.ToString();

                       txtTenK.Text = grdDMK.Rows[i].Cells["Tenkho"].Value.ToString();// lay ra gt dong y va cot manhom*/


                sql = "Update DMKHO set Tenkho =N'" + txtTenK.Text + "' where Makho='" + txtMK.Text + "'";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                //cmd.ExecuteNonQuery();
                //NapCT();
                sql = "Select Makho, Tenkho from DMKHO";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt); //cmt
                grdDMK.DataSource = dt;
                grdDMK.Refresh();
                //tạo grid table -> tạo column -> sửa name, text và name = data property name, sửa align ...
                NapCT();

            }
            MessageBox.Show("Đã cập nhật thành công!");

        }
   

        private void grdDMK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
