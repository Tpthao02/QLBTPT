
namespace QLBThuocc
{
    partial class FrmHDX
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdHDX = new System.Windows.Forms.DataGridView();
            this.SoCTX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayCTX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diengiai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdHDX)).BeginInit();
            this.SuspendLayout();
            // 
            // grdHDX
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.grdHDX.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdHDX.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdHDX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHDX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoCTX,
            this.MaKH,
            this.MaNV,
            this.NgayCTX,
            this.Diengiai});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdHDX.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdHDX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdHDX.Location = new System.Drawing.Point(0, 0);
            this.grdHDX.Name = "grdHDX";
            this.grdHDX.RowHeadersWidth = 62;
            this.grdHDX.RowTemplate.Height = 28;
            this.grdHDX.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdHDX.Size = new System.Drawing.Size(1101, 707);
            this.grdHDX.TabIndex = 2;
            this.grdHDX.DoubleClick += new System.EventHandler(this.grdHD_DoubleClick);
            // 
            // SoCTX
            // 
            this.SoCTX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SoCTX.DataPropertyName = "SoCTX";
            this.SoCTX.HeaderText = "Số Hóa Đơn";
            this.SoCTX.MinimumWidth = 8;
            this.SoCTX.Name = "SoCTX";
            this.SoCTX.ReadOnly = true;
            this.SoCTX.Width = 97;
            // 
            // MaKH
            // 
            this.MaKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã khách hàng";
            this.MaKH.MinimumWidth = 8;
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            this.MaKH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaKH.Width = 130;
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
            // NgayCTX
            // 
            this.NgayCTX.DataPropertyName = "NgayCTX";
            this.NgayCTX.HeaderText = "Ngày xuất";
            this.NgayCTX.MinimumWidth = 8;
            this.NgayCTX.Name = "NgayCTX";
            this.NgayCTX.ReadOnly = true;
            this.NgayCTX.Width = 95;
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
            // FrmHDX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 707);
            this.Controls.Add(this.grdHDX);
            this.Name = "FrmHDX";
            this.Text = "FrmHDX";
            this.Load += new System.EventHandler(this.FrmHDX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdHDX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdHDX;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCTX;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayCTX;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diengiai;
    }
}