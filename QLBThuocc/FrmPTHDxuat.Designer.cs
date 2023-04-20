
namespace QLBThuocc
{
    partial class FrmPTHDxuat
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
            this.grdTHDX = new System.Windows.Forms.DataGridView();
            this.MaPTHX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoCTX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdTHDX)).BeginInit();
            this.SuspendLayout();
            // 
            // grdTHDX
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.grdTHDX.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdTHDX.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdTHDX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTHDX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPTHX,
            this.SoCTX,
            this.NgayTra,
            this.Lido});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdTHDX.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdTHDX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTHDX.Location = new System.Drawing.Point(0, 0);
            this.grdTHDX.Name = "grdTHDX";
            this.grdTHDX.RowHeadersWidth = 62;
            this.grdTHDX.RowTemplate.Height = 28;
            this.grdTHDX.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTHDX.Size = new System.Drawing.Size(800, 450);
            this.grdTHDX.TabIndex = 4;
            this.grdTHDX.DoubleClick += new System.EventHandler(this.grdHDX_DoubleClick);
            // 
            // MaPTHX
            // 
            this.MaPTHX.DataPropertyName = "MaPTHX";
            this.MaPTHX.HeaderText = "Mã phiếu";
            this.MaPTHX.MinimumWidth = 8;
            this.MaPTHX.Name = "MaPTHX";
            this.MaPTHX.Width = 150;
            // 
            // SoCTX
            // 
            this.SoCTX.DataPropertyName = "SoCTX";
            this.SoCTX.HeaderText = "Số chứng từ gốc";
            this.SoCTX.MinimumWidth = 8;
            this.SoCTX.Name = "SoCTX";
            this.SoCTX.Width = 150;
            // 
            // NgayTra
            // 
            this.NgayTra.DataPropertyName = "NgayTra";
            this.NgayTra.HeaderText = "Ngày trả ";
            this.NgayTra.MinimumWidth = 8;
            this.NgayTra.Name = "NgayTra";
            this.NgayTra.Width = 150;
            // 
            // Lido
            // 
            this.Lido.DataPropertyName = "Lido";
            this.Lido.HeaderText = "Lí do";
            this.Lido.MinimumWidth = 8;
            this.Lido.Name = "Lido";
            this.Lido.Width = 150;
            // 
            // FrmPTHDxuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdTHDX);
            this.Name = "FrmPTHDxuat";
            this.Text = "FrmPTHDxuat";
            this.Load += new System.EventHandler(this.FrmPTHDxuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTHDX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdTHDX;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPTHX;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCTX;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lido;
    }
}