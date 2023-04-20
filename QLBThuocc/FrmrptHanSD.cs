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
    public partial class FrmrptHanSD : Form
    {
        public string Makho { get; set; }
        public string MaHH { get; set; }
        public string TenHH { get; set; }
        public DateTime  HanSD { get; set; }
        public float SLHH { get; set; }
        public FrmrptHanSD(Cryhandung rpt)
        {
            InitializeComponent();
            crystalReportViewer1.ReportSource = rpt;
        }

        private void FrmrptHanSD_Load(object sender, EventArgs e)
        {

        }
    }
}
