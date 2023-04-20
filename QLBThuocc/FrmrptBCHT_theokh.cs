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
    public partial class FrmrptBCHT_theokh : Form
    {
        QuanlybanthuocDataSet db = new QuanlybanthuocDataSet();
        class NXT
        {
            public string Makho { get; set; }
            public string MaHH { get; set; }
            public string TenHH { get; set; }
            public float TongSLT { get; set; }
        }
        public FrmrptBCHT_theokh(rptbctk__theokho rpt)
        {
            InitializeComponent();
            crystalReportViewer1.ReportSource = rpt;
        }

        private void FrmrptBCHT_theokh_Load(object sender, EventArgs e)
        {

        }
    }
}
