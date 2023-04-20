
namespace QLBThuocc
{
    partial class FrmPTraHDNhap
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
            this.MaPTHN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoCTN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LiDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.MaPTHN,
            this.SoCTN,
            this.NgayTra,
            this.LiDo});
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
            this.grdHDX.Size = new System.Drawing.Size(921, 696);
            this.grdHDX.TabIndex = 3;
            this.grdHDX.DoubleClick += new System.EventHandler(this.grdHDX_DoubleClick);
            // 
            // MaPTHN
            // 
            this.MaPTHN.DataPropertyName = "MaPTHN";
            this.MaPTHN.HeaderText = "Mã phiếu";
            this.MaPTHN.MinimumWidth = 8;
            this.MaPTHN.Name = "MaPTHN";
            this.MaPTHN.Width = 150;
            // 
            // SoCTN
            // 
            this.SoCTN.DataPropertyName = "SoCTN";
            this.SoCTN.HeaderText = "Số chứng từ gốc";
            this.SoCTN.MinimumWidth = 8;
            this.SoCTN.Name = "SoCTN";
            this.SoCTN.Width = 150;
            // 
            // NgayTra
            // 
            this.NgayTra.DataPropertyName = "NgayTra";
            this.NgayTra.HeaderText = "Ngày trả ";
            this.NgayTra.MinimumWidth = 8;
            this.NgayTra.Name = "NgayTra";
            this.NgayTra.Width = 150;
            // 
            // LiDo
            // 
            this.LiDo.DataPropertyName = "LiDo";
            this.LiDo.HeaderText = "Lí do";
            this.LiDo.MinimumWidth = 8;
            this.LiDo.Name = "LiDo";
            this.LiDo.Width = 150;
            // 
            // FrmPTraHDNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 696);
            this.Controls.Add(this.grdHDX);
            this.Name = "FrmPTraHDNhap";
            this.Text = "FrmPTraHDNhap";
            this.Load += new System.EventHandler(this.FrmPTraHDNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdHDX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdHDX;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPTHN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn LiDo;
    }
}