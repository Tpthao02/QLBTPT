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
    public partial class FrmBCDMHH : Form
    {
            
        
        public FrmBCDMHH(CrtHH rpt)
        {
          
            InitializeComponent();
            crystalReportViewer1.ReportSource = rpt;
         
        }

        private void FrmBCDMHH_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
