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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmTonghopkho f = new FrmTonghopkho();
            f.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmHuyhang  f = new FrmHuyhang();
            f.Show();
        }

        private void đăngNhậpHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDangnhap f = new FrmDangnhap();
            f.Show();
        }

        private void danhMụcThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDMHH f = new FrmDMHH();
            f.Show();
        }

        private void danhMụcKhoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDMKho f = new FrmDMKho();
            f.Show();
        }

        private void danhMụcNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDMNV f = new FrmDMNV();
            f.Show();
        }

        private void danhMụcNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDMNCC f = new FrmDMNCC();
            f.Show();
        }

        private void hóaĐơnNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHDnhapct f = new FrmHDnhapct();
            f.Show();
        }

        private void phiếuTrảHàngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPTHNct f = new FrmPTHNct();
            f.Show();
        }

        private void cậpNhậtBáoGiáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGiaVon f = new FrmGiaVon();
            f.Show();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDMKH f = new FrmDMKH();
            f.Show();
        }

        private void hóaĐơnBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHDxuatct f = new FrmHDxuatct();
            f.Show();
        }

        private void phiếuTrảHàngBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPTHXct f = new FrmPTHXct();
            f.Show();
        }

        private void kiểmKêKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKiemke f = new FrmKiemke();
            f.Show();
        }

        private void báoCáoDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void báoCáoChiPhíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void báoCáoHàngTồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void báoCáoHàngSắpHếtHSDToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void báoCáoDoanhThuToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void báoCáoDoanhThuToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void theoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBCtheoDT f = new FrmBCtheoDT();
            f.Show();
        }

        private void theoMặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBCDT f = new FrmBCDT();
            f.Show();
        }

        private void theoNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBCDT f = new FrmBCDT();
            f.Show();
        }

        private void theoMặtHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmBCHT f = new FrmBCHT();
            f.Show();
        }

        private void theoKhoHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            FrmBCHT_theo_kho f = new FrmBCHT_theo_kho();
            f.Show();
        }

        private void theoKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBCtheoDT f = new FrmBCtheoDT();
            f.Show();
        }

        private void theoTừngKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBCDT_theoKH f = new FrmBCDT_theoKH();
            f.Show();
        }

        private void theoTừngNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BCCP_theoNCC f = new BCCP_theoNCC();
            f.Show();
        }

        private void theoKhoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBCHT_theo_kho f = new FrmBCHT_theo_kho();
            f.Show();
        }

        private void theoMặtHàngToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmBCHT f = new FrmBCHT();
            f.Show();
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
