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
    public partial class frm_in : Form
    {
        
     
        public frm_in( rptHDBH rpt)
        {
           
            InitializeComponent();
            crystalReportViewer1.ReportSource = rpt;
            
            
           
            
        }

        private void frm_in_Load(object sender, EventArgs e)
        {
           


        }
    }
}
