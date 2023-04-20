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
    public partial class FrmTonghopkho : Form
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
        public FrmTonghopkho()
        {
            InitializeComponent();
        }

        private void grdTonghop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmTonghopkho_Load(object sender, EventArgs e)
        {
            constr = "Data Source = DESKTOP-IEGRD2D\\SQLEXPRESS; Initial Catalog = quanlybanthuoc; Integrated Security = True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = " SELECT  ROW_NUMBER() OVER (ORDER BY Ngay) AS [STT] ,* from HDxuatt_view union all SELECT  ROW_NUMBER() OVER (ORDER BY Ngay) AS [Số thứ tự],* from HDnhapp_view order by Ngay";
            da = new SqlDataAdapter(sql, conn);
            da1 = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);//du lieu do vao data
            grdTonghop.DataSource = dt;// gan du lieu cho o luoi
         

        }
    }
}
