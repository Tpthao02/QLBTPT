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
    public partial class FrmDMHH : Form
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
        public FrmDMHH()
        {
            InitializeComponent();
        }

        private void FrmDMHH_Load(object sender, EventArgs e)
        {

            constr = "Data Source = DESKTOP-IEGRD2D\\SQLEXPRESS; Initial Catalog = quanlybanthuoc; Integrated Security = True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = " Select Makho,MaNhom,MaHH,TenHH, Hoatchat,Dvt, DG, NuocSX from DMHH";
            da = new SqlDataAdapter(sql, conn);
            da1 = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);//du lieu do vao data
            grdDMHH.DataSource = dt;// gan du lieu cho o luoi
            sql = "select Distinct MaNhom from DMHH";
           da = new SqlDataAdapter(sql, conn);
           da.Fill(dtNhom);
            txtMaNhom.DataSource = dtNhom;
            txtMaNhom.DisplayMember = "Manhom";
            grdDMHH.DataSource = dt;// gan du lieu cho o luoi
            sql = "select Distinct Makho from DMHH";
            da1 = new SqlDataAdapter(sql, conn);
            da1.Fill(dtkho);
            txtMakho.DataSource = dtkho;
            txtMakho.DisplayMember = "Makho";

            //NapCT();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void grdDMHH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void NapCT()
        {
            i = grdDMHH.CurrentRow.Index;// so thu tu cua dong hien thoi trong o luoi
            txtMakho.Text = grdDMHH.Rows[i].Cells["Makho"].Value.ToString();
            txtMaNhom.Text = grdDMHH.Rows[i].Cells["MaNhom"].Value.ToString();// lay ra gt dong y va cot manhom
            txtMaHH.Text = grdDMHH.Rows[i].Cells["MaHH"].Value.ToString();// lay ra gt dong y va cot manhom
            txtTenHH.Text = grdDMHH.Rows[i].Cells["TenHH"].Value.ToString();// lay ra gt dong y va cot manhom
            txtHoatchat.Text = grdDMHH.Rows[i].Cells["Hoatchat"].Value.ToString();
            txtDvt.Text = grdDMHH.Rows[i].Cells["Dvt"].Value.ToString();
            txtDG.Text = grdDMHH.Rows[i].Cells["DG"].Value.ToString();
            txtNuocSX.Text = grdDMHH.Rows[i].Cells["NuocSX"].Value.ToString();
        }

        private void grdDMHH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            grdDMHH.CurrentCell = grdDMHH[0, grdDMHH.RowCount - 1];
            NapCT();
            MessageBox.Show("Hãy nhập nội dung bản ghi mới,kết thúc bằng nút cập nhật ");
            txtMakho.Focus();
            addnewflag = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            NapCT();
            MessageBox.Show("Hãy sửa nội dung của bản ghi hiện thời, kết thúc bằng nút cập nhật");
            txtTenHH.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn chắc chắn muốn xóa bản ghi hiện thời ?(Y/N )", "Xác nhận yêu cầu ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Bản ghi đã được xóa ");
                sql = "Delete from DMHH where MaHH = '" + txtMaHH.Text +  "'"; 
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                i = grdDMHH.CurrentRow.Index;
                grdDMHH.Rows.RemoveAt(i);// xoa o dong i 
                //NapCT();

            }
            else
                MessageBox.Show("Kết thúc  ");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (addnewflag == true)
            {
                sql = "Insert into DMHH (Makho, MaNhom, MaHH, TenHH, Hoatchat , Dvt, DG, NuocSX) Values ('"+ txtMakho.Text + "','"+ txtMaNhom.Text + "',N'" + txtMaHH.Text + "',N'" + txtTenHH.Text + "',N'" + txtHoatchat.Text + "','" + "',N'" + txtDvt.Text + "','" + txtDG.Text + "',N'" + txtNuocSX.Text + "')";

                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                addnewflag = false;
                //NapCT();
                sql = "Select Makho, MaNhom, MaHH, TenHH, Hoatchat,Dvt, DG, NuocSX From DMHH";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt); //cmt
                grdDMHH.DataSource = dt;
                grdDMHH.Refresh();
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
                for (i = 0; i <= grdDMHH.RowCount - 2; i++)//hang cuoi la k co du lieu nen tru 2
                {
                    txtMakho.Text = grdDMHH.Rows[i].Cells["Makho"].Value.ToString();
                    txtMaNhom.Text = grdDMHH.Rows[i].Cells["MaNhom"].Value.ToString();// lay ra gt dong y va cot manhom
                    txtMaHH.Text = grdDMHH.Rows[i].Cells["MaHH"].Value.ToString();// lay ra gt dong y va cot manhom
                    txtTenHH.Text = grdDMHH.Rows[i].Cells["TenHH"].Value.ToString();// lay ra gt dong y va cot manhom
                    txtHoatchat.Text = grdDMHH.Rows[i].Cells["Hoatchat"].Value.ToString();
                    txtDvt.Text = grdDMHH.Rows[i].Cells["Dvt"].Value.ToString();
                    txtDG.Text = grdDMHH.Rows[i].Cells["DG"].Value.ToString();
                    txtNuocSX.Text = grdDMHH.Rows[i].Cells["NuocSX"].Value.ToString();

                    sql = "Update DMHH set TenHH=N'" + txtTenHH.Text + "',Hoatchat=N'" + txtHoatchat.Text + "',DG='" + txtDG.Text + "',Dvt=N'" + txtDvt.Text + "',NuocSX=N'" + txtNuocSX.Text + "' where MaHH='" + txtMaHH.Text + "'";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    //cmd.ExecuteNonQuery();
                    NapCT();

                }
                MessageBox.Show("Đã cập nhật thành công!");

            }
        }

        private void FrmDMHH_KeyDown(object sender, KeyEventArgs e)
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
                sql = "Select Makho,MaNhom, MaHH, TenHH,Hoatchat, Dvt, DG, NuocSX From DMHH " +
                    " where " + comTruong.Text + "=N'" + comGT.Text + "'";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt); //cmt
                grdDMHH.DataSource = dt;
                grdDMHH.Refresh();
                //tạo grid table -> tạo column -> sửa name, text và name = data property name, sửa align ...
                NapCT();


            }
        }

        private void comTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "Select Distinct " + comTruong.Text + " From DMHH ";

            da = new SqlDataAdapter(sql, conn);
            comdt.Clear();
            da.Fill(comdt);
            comGT.DataSource = comdt;//dan du lieu cho combo 
            comGT.DisplayMember = comTruong.Text;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            sql = "Select Makho, MaNhom, MaHH, TenHH,Hoatchat, Dvt , DG, NuocSX  From DMHH";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt); //cmt
            grdDMHH.DataSource = dt;
            grdDMHH.Refresh();
            //tạo grid table -> tạo column -> sửa name, text và name = data property name, sửa align ...
            NapCT();
        }

        private void txtMakho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql = "Select MaNhom, MaHH, TenHH, DG, Dvt, NuocSX From DMHH";// +
                                                                          // " where " + comTruong.Text + " =N'" + comboGT.Text + "'";// de co the so sanh gt co tieng viet

            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dtbc);
            CrtHH bc = new CrtHH();
            bc.SetDataSource(dtbc);// dua du lieu vao bao cao
                                   //bc.DataDefinition.FormulaFields["TenTruong"].Text = "'" + comTruong.Text + "'";
                                   // bc.DataDefinition.FormulaFields["GiaTri"].Text = "'" + comGT.Text + " '";
            FrmBCDMHH f = new FrmBCDMHH(bc);
            f.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
