
namespace QLBThuocc
{
    partial class FrmHuyhang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdHuyhang = new System.Windows.Forms.DataGridView();
            this.MaHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Makho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.cboMakho = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdHuyhang)).BeginInit();
            this.SuspendLayout();
            // 
            // grdHuyhang
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.grdHuyhang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.grdHuyhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHuyhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHH,
            this.Makho,
            this.TenHH,
            this.HanSD,
            this.SLHH});
            this.grdHuyhang.Location = new System.Drawing.Point(52, 206);
            this.grdHuyhang.Name = "grdHuyhang";
            this.grdHuyhang.RowHeadersWidth = 62;
            this.grdHuyhang.RowTemplate.Height = 28;
            this.grdHuyhang.Size = new System.Drawing.Size(1047, 513);
            this.grdHuyhang.TabIndex = 62;
            // 
            // MaHH
            // 
            this.MaHH.DataPropertyName = "MaHH";
            this.MaHH.HeaderText = "Mã thuốc";
            this.MaHH.MinimumWidth = 8;
            this.MaHH.Name = "MaHH";
            this.MaHH.Width = 150;
            // 
            // Makho
            // 
            this.Makho.DataPropertyName = "Makho";
            this.Makho.HeaderText = "Mã kho";
            this.Makho.MinimumWidth = 8;
            this.Makho.Name = "Makho";
            this.Makho.Width = 150;
            // 
            // TenHH
            // 
            this.TenHH.DataPropertyName = "TenHH";
            this.TenHH.HeaderText = "Tên thuốc";
            this.TenHH.MinimumWidth = 8;
            this.TenHH.Name = "TenHH";
            this.TenHH.Width = 150;
            // 
            // HanSD
            // 
            this.HanSD.DataPropertyName = "HanSD";
            this.HanSD.HeaderText = "Hạn sử dụng";
            this.HanSD.MinimumWidth = 8;
            this.HanSD.Name = "HanSD";
            this.HanSD.Width = 150;
            // 
            // SLHH
            // 
            this.SLHH.DataPropertyName = "SLHH";
            this.SLHH.HeaderText = "Số lượng hết hạn";
            this.SLHH.MinimumWidth = 8;
            this.SLHH.Name = "SLHH";
            this.SLHH.Width = 150;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.ForestGreen;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(560, 87);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(118, 41);
            this.btnHuy.TabIndex = 67;
            this.btnHuy.Text = "Hủy ";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.Color.ForestGreen;
            this.btnTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.ForeColor = System.Drawing.Color.White;
            this.btnTimkiem.Location = new System.Drawing.Point(406, 87);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(118, 41);
            this.btnTimkiem.TabIndex = 66;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = false;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // cboMakho
            // 
            this.cboMakho.FormattingEnabled = true;
            this.cboMakho.Location = new System.Drawing.Point(482, 42);
            this.cboMakho.Name = "cboMakho";
            this.cboMakho.Size = new System.Drawing.Size(145, 28);
            this.cboMakho.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 64;
            this.label2.Text = "Mã kho ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(411, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 25);
            this.label1.TabIndex = 63;
            this.label1.Text = "Tìm kiếm thông tin kho";
            // 
            // FrmHuyhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 832);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.cboMakho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdHuyhang);
            this.Name = "FrmHuyhang";
            this.Text = "Nhà thuốc VNPharma";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmHuyhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdHuyhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grdHuyhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Makho;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLHH;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.ComboBox cboMakho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}