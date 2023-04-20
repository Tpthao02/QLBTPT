using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBThuocc
{
    public partial class FrmrptBCTKH : Form
    {
        QuanlybanthuocDataSet db = new QuanlybanthuocDataSet();
        class NXT
        {
            public string MaHH { get; set; }
            public string TenHH { get; set; }
            public float Doanhthu { get; set; }
        }
        public FrmrptBCTKH(rptbcdoanhthu_theoKH rpt)
        {
            InitializeComponent();
            crystalReportViewer1.ReportSource = rpt;
        }

        private void FrmrptBCTKH_Load(object sender, EventArgs e)
        {

        }
    }
}
