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
    public partial class FrmDangnhap : Form
    {
        public FrmDangnhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("Data Source = DESKTOP-IEGRD2D\\SQLEXPRESS; Initial Catalog = quanlybanthuoc; Integrated Security = True");
            string sql = "Select * from DMND where Usname ='" + txtusername.Text +
                "' and Matkhau='" + txtpass.Text + "'";

            SqlCommand cmd = new SqlCommand(sql, conn);


            conn.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            conn.Close();
            int count = ds.Tables[0].Rows.Count;

            if (count == 1)
            {
                MessageBox.Show("Đăng nhập thành công !");
                this.Hide();
                FrmMain f = new FrmMain();
                f.ShowDialog();

            }
            else
            {
                MessageBox.Show("Bạn đã đăng nhập sai thông tin tài khoản !");
            }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtpass.UseSystemPasswordChar = false;
            }
            else
                txtpass.UseSystemPasswordChar = true;
        }

        private void FrmDangnhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                SendKeys.Send("{tab}");
                e.Handled = true;
            }
        }

        private void FrmDangnhap_Load(object sender, EventArgs e)
        {

        }
    }
}