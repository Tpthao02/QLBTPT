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
    public partial class FrmCPNCC1 : Form
    {
        public string MaNCC { get; set; }
        public string TenNCC { get; set; }
        public string CP { get; set; }
        public FrmCPNCC1(CrystalReport6 rpt)
        {
            InitializeComponent();
            crystalReportViewer1.ReportSource = rpt;
        }

        private void FrmCPNCC1_Load(object sender, EventArgs e)
        {

        }
    }
}
