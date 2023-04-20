
namespace QLBThuocc
{
    partial class FrmGiaVon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdGV = new System.Windows.Forms.DataGridView();
            this.MaHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLNhap = new System.Windows.Forms.DataGridViewLinkColumn();
            this.GVon = new System.Windows.Forms.DataGridViewLinkColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtGV = new System.Windows.Forms.TextBox();
            this.txtTenHH = new System.Windows.Forms.TextBox();
            this.txtMaHH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdGV)).BeginInit();
            this.SuspendLayout();
            // 
            // grdGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.grdGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHH,
            this.TenHH,
            this.SLNhap,
            this.GVon});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdGV.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdGV.Location = new System.Drawing.Point(29, 119);
            this.grdGV.Name = "grdGV";
            this.grdGV.RowHeadersWidth = 62;
            this.grdGV.RowTemplate.Height = 28;
            this.grdGV.Size = new System.Drawing.Size(989, 600);
            this.grdGV.TabIndex = 0;
            this.grdGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdGV_CellClick);
            this.grdGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdGV_CellContentClick);
            // 
            // MaHH
            // 
            this.MaHH.DataPropertyName = "MaHH";
            this.MaHH.HeaderText = "Mã thuốc";
            this.MaHH.MinimumWidth = 8;
            this.MaHH.Name = "MaHH";
            this.MaHH.Width = 150;
            // 
            // TenHH
            // 
            this.TenHH.DataPropertyName = "TenHH";
            this.TenHH.HeaderText = "Tên thuốc";
            this.TenHH.MinimumWidth = 8;
            this.TenHH.Name = "TenHH";
            this.TenHH.Width = 150;
            // 
            // SLNhap
            // 
            this.SLNhap.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.SLNhap.DataPropertyName = "SLNhap";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.NullValue = null;
            this.SLNhap.DefaultCellStyle = dataGridViewCellStyle3;
            this.SLNhap.HeaderText = "Số lượng nhập";
            this.SLNhap.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.SLNhap.LinkColor = System.Drawing.Color.Black;
            this.SLNhap.MinimumWidth = 8;
            this.SLNhap.Name = "SLNhap";
            this.SLNhap.VisitedLinkColor = System.Drawing.Color.Black;
            this.SLNhap.Width = 150;
            // 
            // GVon
            // 
            this.GVon.DataPropertyName = "GVon";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.GVon.DefaultCellStyle = dataGridViewCellStyle4;
            this.GVon.HeaderText = "Giá vốn ";
            this.GVon.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.GVon.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GVon.MinimumWidth = 8;
            this.GVon.Name = "GVon";
            this.GVon.VisitedLinkColor = System.Drawing.Color.White;
            this.GVon.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(34, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cập nhật báo giá";
            // 
            // txtsl
            // 
            this.txtsl.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsl.Location = new System.Drawing.Point(1214, 415);
            this.txtsl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(256, 34);
            this.txtsl.TabIndex = 63;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1039, 418);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 28);
            this.label12.TabIndex = 68;
            this.label12.Text = "Số lượng nhập";
            // 
            // txtGV
            // 
            this.txtGV.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGV.Location = new System.Drawing.Point(1214, 461);
            this.txtGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGV.Name = "txtGV";
            this.txtGV.Size = new System.Drawing.Size(256, 34);
            this.txtGV.TabIndex = 64;
            // 
            // txtTenHH
            // 
            this.txtTenHH.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHH.Location = new System.Drawing.Point(1218, 354);
            this.txtTenHH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenHH.Name = "txtTenHH";
            this.txtTenHH.Size = new System.Drawing.Size(256, 34);
            this.txtTenHH.TabIndex = 62;
            // 
            // txtMaHH
            // 
            this.txtMaHH.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHH.Location = new System.Drawing.Point(1218, 296);
            this.txtMaHH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.Size = new System.Drawing.Size(256, 34);
            this.txtMaHH.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1035, 471);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 28);
            this.label5.TabIndex = 67;
            this.label5.Text = "Giá vốn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1039, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 28);
            this.label3.TabIndex = 66;
            this.label3.Text = "Tên thuốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1039, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 28);
            this.label2.TabIndex = 65;
            this.label2.Text = "Mã thuốc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(1039, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 32);
            this.label4.TabIndex = 69;
            this.label4.Text = "Chi tiết";
            // 
            // FrmGiaVon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1515, 752);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsl);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtGV);
            this.Controls.Add(this.txtTenHH);
            this.Controls.Add(this.txtMaHH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdGV);
            this.Name = "FrmGiaVon";
            this.Text = "Nhà thuốc VNPharma";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmGiaVon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtGV;
        private System.Windows.Forms.TextBox txtTenHH;
        private System.Windows.Forms.TextBox txtMaHH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHH;
        private System.Windows.Forms.DataGridViewLinkColumn SLNhap;
        private System.Windows.Forms.DataGridViewLinkColumn GVon;
    }
}