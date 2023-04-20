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
    public partial class frmbcDTNCC : Form
    {
        QuanlybanthuocDataSet db = new QuanlybanthuocDataSet();
        class NXT
        {
            public string MaKH { get; set; }
            public string TenKH { get; set; }
            public string DoanhThu { get; set; }
          
        }
        public frmbcDTNCC(CrystalReport5 rpt)
        {
            InitializeComponent();
            crystalReportViewer1.ReportSource = rpt;

        }

        private void frmbcDTNCC_Load(object sender, EventArgs e)
        {

        }
    }
}
