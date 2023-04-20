
namespace QLBThuocc
{
    partial class FrmHDN
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdHD = new System.Windows.Forms.DataGridView();
            this.SoCTN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayCTN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diengiai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdHD)).BeginInit();
            this.SuspendLayout();
            // 
            // grdHD
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.grdHD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grdHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoCTN,
            this.MaNCC,
            this.MaNV,
            this.NgayCTN,
            this.Diengiai});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdHD.DefaultCellStyle = dataGridViewCellStyle6;
            this.grdHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdHD.Location = new System.Drawing.Point(0, 0);
            this.grdHD.Name = "grdHD";
            this.grdHD.RowHeadersWidth = 62;
            this.grdHD.RowTemplate.Height = 28;
            this.grdHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdHD.Size = new System.Drawing.Size(1054, 734);
            this.grdHD.TabIndex = 1;
            this.grdHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdHD_CellContentClick);
            this.grdHD.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdHD_CellDoubleClick);
            this.grdHD.DoubleClick += new System.EventHandler(this.grdHD_DoubleClick);
            // 
            // SoCTN
            // 
            this.SoCTN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SoCTN.DataPropertyName = "SoCTN";
            this.SoCTN.HeaderText = "Số Hóa Đơn";
            this.SoCTN.MinimumWidth = 8;
            this.SoCTN.Name = "SoCTN";
            this.SoCTN.ReadOnly = true;
            this.SoCTN.Width = 97;
            // 
            // MaNCC
            // 
            this.MaNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Mã Nhà Cung Cấp";
            this.MaNCC.MinimumWidth = 8;
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.ReadOnly = true;
            this.MaNCC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaNCC.Width = 130;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.MinimumWidth = 8;
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            this.MaNV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaNV.Width = 110;
            // 
            // NgayCTN
            // 
            this.NgayCTN.DataPropertyName = "NgayCTN";
            this.NgayCTN.HeaderText = "Ngày Nhập";
            this.NgayCTN.MinimumWidth = 8;
            this.NgayCTN.Name = "NgayCTN";
            this.NgayCTN.ReadOnly = true;
            this.NgayCTN.Width = 95;
            // 
            // Diengiai
            // 
            this.Diengiai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Diengiai.DataPropertyName = "Diengiai";
            this.Diengiai.HeaderText = "Lí Do ";
            this.Diengiai.MinimumWidth = 8;
            this.Diengiai.Name = "Diengiai";
            this.Diengiai.ReadOnly = true;
            this.Diengiai.Width = 90;
            // 
            // FrmHDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 734);
            this.Controls.Add(this.grdHD);
            this.Name = "FrmHDN";
            this.Text = "FrmHDN";
            this.Load += new System.EventHandler(this.FrmHDN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayCTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diengiai;
    }
}