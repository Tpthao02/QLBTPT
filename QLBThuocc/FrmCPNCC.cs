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
    public partial class FrmCPNCC : Form
    {
        QuanlybanthuocDataSet db = new QuanlybanthuocDataSet();
        class NXT
        {
            public string MaHH { get; set; }
            public string TenHH { get; set; }
            public float Chiphi { get; set; }
        }
        public FrmCPNCC(rptbcchiphi__NCC rpt )
        {
            InitializeComponent();
            crystalReportViewer1.ReportSource = rpt;

        }

        private void FrmCPNCC_Load(object sender, EventArgs e)
        {

        }
    }
}
