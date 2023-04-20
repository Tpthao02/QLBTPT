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
    public partial class Frmbcdoanhthu : Form
    {
        QuanlybanthuocDataSet db = new QuanlybanthuocDataSet();
        class NXT
        {
            public string MaHH { get; set; }
            public string TenHH { get; set; }
            public float Doanhthu { get; set; }
        }


            public Frmbcdoanhthu(rptbcdoanhthu rpt)
        {
            InitializeComponent();
            crystalReportViewer1.ReportSource = rpt;
        }

        private void Frmbcdoanhthu_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
