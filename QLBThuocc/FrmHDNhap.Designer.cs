
namespace QLBThuocc
{
    partial class FrmHDNhap
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
            this.grdHD = new System.Windows.Forms.DataGridView();
            this.btnxoa = new System.Windows.Forms.Button();
            this.ctnthem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdHD)).BeginInit();
            this.SuspendLayout();
            // 
            // grdHD
            // 
            this.grdHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHD.Location = new System.Drawing.Point(73, 95);
            this.grdHD.Name = "grdHD";
            this.grdHD.RowHeadersWidth = 62;
            this.grdHD.RowTemplate.Height = 28;
            this.grdHD.Size = new System.Drawing.Size(976, 353);
            this.grdHD.TabIndex = 0;
            this.grdHD.DoubleClick += new System.EventHandler(this.grdHD_DoubleClick);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.ForestGreen;
            this.btnxoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnxoa.Location = new System.Drawing.Point(606, 477);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(119, 48);
            this.btnxoa.TabIndex = 62;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            // 
            // ctnthem
            // 
            this.ctnthem.BackColor = System.Drawing.Color.ForestGreen;
            this.ctnthem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctnthem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctnthem.Location = new System.Drawing.Point(431, 477);
            this.ctnthem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctnthem.Name = "ctnthem";
            this.ctnthem.Size = new System.Drawing.Size(101, 48);
            this.ctnthem.TabIndex = 60;
            this.ctnthem.Text = "Thêm";
            this.ctnthem.UseVisualStyleBackColor = false;
            // 
            // FrmHDNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 554);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.ctnthem);
            this.Controls.Add(this.grdHD);
            this.Name = "FrmHDNhap";
            this.Text = "FrmHDNhap";
            this.Load += new System.EventHandler(this.FrmHDNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdHD;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button ctnthem;
    }
}