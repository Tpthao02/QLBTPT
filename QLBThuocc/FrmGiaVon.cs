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
    public partial class FrmGiaVon : Form
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
        public FrmGiaVon()
        {
            InitializeComponent();
     
        }
        private void NapCT()
        {
            i = grdGV.CurrentRow.Index;// so thu tu cua dong hien thoi trong o luoi
           
            txtMaHH.Text = grdGV.Rows[i].Cells["MaHH"].Value.ToString();// lay ra gt dong y va cot manhom
            txtTenHH.Text = grdGV.Rows[i].Cells["TenHH"].Value.ToString();// lay ra gt dong y va cot manhom
            txtsl.Text = grdGV.Rows[i].Cells["SLNhap"].Value.ToString();
            txtGV.Text = grdGV.Rows[i].Cells["GVon"].Value.ToString();
          
        }

        private void grdGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void grdGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void FrmGiaVon_Load(object sender, EventArgs e)
        {
            constr = "Data Source = DESKTOP-IEGRD2D\\SQLEXPRESS; Initial Catalog = quanlybanthuoc; Integrated Security = True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = " Select HDNHapCT.MaHH ,TenHH,Sum(SL)as SLNhap,Sum(SL*DGN)/Sum(SL) as GVon from HDNhapCT,DMHH where DMHH.MaHH = HDNhapCT.MaHH group by HDNHapCT.MaHH,TenHH";
            da = new SqlDataAdapter(sql, conn);
            da1 = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);//du lieu do vao data
            grdGV.DataSource = dt;// gan du lieu cho o luoi
            NapCT();
         
        }
    }
}
