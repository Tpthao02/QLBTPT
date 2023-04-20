
namespace QLBThuocc
{
    partial class FrmPTHNct
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
            this.btnchonHD = new System.Windows.Forms.Button();
            this.txtlido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboSoCT = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNgaytra = new System.Windows.Forms.DateTimePicker();
            this.txtMaPTHN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.ctnthem = new System.Windows.Forms.Button();
            this.grdPTHN = new System.Windows.Forms.DataGridView();
            this.MaPTHN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoCTN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LiDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.txtMaPTH = new System.Windows.Forms.TextBox();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.cboMaHH = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdPTHN)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnchonHD
            // 
            this.btnchonHD.BackColor = System.Drawing.Color.ForestGreen;
            this.btnchonHD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnchonHD.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchonHD.ForeColor = System.Drawing.Color.White;
            this.btnchonHD.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnchonHD.Location = new System.Drawing.Point(566, 32);
            this.btnchonHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnchonHD.Name = "btnchonHD";
            this.btnchonHD.Size = new System.Drawing.Size(142, 52);
            this.btnchonHD.TabIndex = 67;
            this.btnchonHD.Text = "Chọn phiếu";
            this.btnchonHD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnchonHD.UseVisualStyleBackColor = false;
            this.btnchonHD.Click += new System.EventHandler(this.btnchonHD_Click);
            // 
            // txtlido
            // 
            this.txtlido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtlido.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlido.Location = new System.Drawing.Point(230, 149);
            this.txtlido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtlido.Multiline = true;
            this.txtlido.Name = "txtlido";
            this.txtlido.Size = new System.Drawing.Size(312, 37);
            this.txtlido.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 28);
            this.label5.TabIndex = 65;
            this.label5.Text = "Lí do trả";
            // 
            // cboSoCT
            // 
            this.cboSoCT.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSoCT.FormattingEnabled = true;
            this.cboSoCT.Location = new System.Drawing.Point(924, 96);
            this.cboSoCT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboSoCT.Name = "cboSoCT";
            this.cboSoCT.Size = new System.Drawing.Size(307, 36);
            this.cboSoCT.TabIndex = 64;
            this.cboSoCT.SelectedIndexChanged += new System.EventHandler(this.cboSoCT_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(746, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 28);
            this.label4.TabIndex = 63;
            this.label4.Text = "Số chứng từ gốc";
            // 
            // txtNgaytra
            // 
            this.txtNgaytra.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgaytra.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgaytra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgaytra.Location = new System.Drawing.Point(230, 90);
            this.txtNgaytra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNgaytra.Name = "txtNgaytra";
            this.txtNgaytra.Size = new System.Drawing.Size(313, 34);
            this.txtNgaytra.TabIndex = 61;
            // 
            // txtMaPTHN
            // 
            this.txtMaPTHN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaPTHN.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPTHN.Location = new System.Drawing.Point(230, 42);
            this.txtMaPTHN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaPTHN.Name = "txtMaPTHN";
            this.txtMaPTHN.Size = new System.Drawing.Size(312, 34);
            this.txtMaPTHN.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 28);
            this.label2.TabIndex = 59;
            this.label2.Text = "Mã phiếu";
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Location = new System.Drawing.Point(55, 86);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(89, 28);
            this.txt.TabIndex = 62;
            this.txt.Text = "Ngày trả";
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.ForestGreen;
            this.btnupdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnupdate.Location = new System.Drawing.Point(301, 225);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(162, 48);
            this.btnupdate.TabIndex = 70;
            this.btnupdate.Text = "Thêm phiếu";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.ForestGreen;
            this.btnxoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnxoa.Location = new System.Drawing.Point(898, 225);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(157, 48);
            this.btnxoa.TabIndex = 69;
            this.btnxoa.Text = "Xóa phiếu";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // ctnthem
            // 
            this.ctnthem.BackColor = System.Drawing.Color.ForestGreen;
            this.ctnthem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctnthem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctnthem.Location = new System.Drawing.Point(617, 225);
            this.ctnthem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctnthem.Name = "ctnthem";
            this.ctnthem.Size = new System.Drawing.Size(157, 48);
            this.ctnthem.TabIndex = 68;
            this.ctnthem.Text = "Cập nhật";
            this.ctnthem.UseVisualStyleBackColor = false;
            this.ctnthem.Click += new System.EventHandler(this.ctnthem_Click);
            // 
            // grdPTHN
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.grdPTHN.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.grdPTHN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPTHN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPTHN,
            this.SoCTN,
            this.NgayTra,
            this.LiDo,
            this.MaHH,
            this.TenHH,
            this.SLT});
            this.grdPTHN.Location = new System.Drawing.Point(92, 348);
            this.grdPTHN.Name = "grdPTHN";
            this.grdPTHN.RowHeadersWidth = 62;
            this.grdPTHN.RowTemplate.Height = 28;
            this.grdPTHN.Size = new System.Drawing.Size(890, 381);
            this.grdPTHN.TabIndex = 72;
            this.grdPTHN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPTHN_CellClick);
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
            this.SoCTN.HeaderText = "c1";
            this.SoCTN.MinimumWidth = 8;
            this.SoCTN.Name = "SoCTN";
            this.SoCTN.Visible = false;
            this.SoCTN.Width = 150;
            // 
            // NgayTra
            // 
            this.NgayTra.DataPropertyName = "NgayTra";
            this.NgayTra.HeaderText = "Column2";
            this.NgayTra.MinimumWidth = 8;
            this.NgayTra.Name = "NgayTra";
            this.NgayTra.Visible = false;
            this.NgayTra.Width = 150;
            // 
            // LiDo
            // 
            this.LiDo.DataPropertyName = "LiDo";
            this.LiDo.HeaderText = "Column3";
            this.LiDo.MinimumWidth = 8;
            this.LiDo.Name = "LiDo";
            this.LiDo.Visible = false;
            this.LiDo.Width = 150;
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
            // SLT
            // 
            this.SLT.DataPropertyName = "SLT";
            this.SLT.HeaderText = "Số lượng";
            this.SLT.MinimumWidth = 8;
            this.SLT.Name = "SLT";
            this.SLT.Width = 150;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator7,
            this.toolStripSeparator8,
            this.toolStripButton1,
            this.toolStripSeparator9,
            this.toolStripButton4,
            this.toolStripSeparator11,
            this.toolStripButton5,
            this.toolStripSeparator12,
            this.toolStripButton6});
            this.toolStrip2.Location = new System.Drawing.Point(92, 298);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(184, 33);
            this.toolStrip2.TabIndex = 75;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackgroundImage = global::QLBThuocc.Properties.Resources.add;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::QLBThuocc.Properties.Resources.plus;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton1.Text = "toolStripButton2";
            this.toolStripButton1.ToolTipText = "Sửa hóa đơn chi tiết";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::QLBThuocc.Properties.Resources.sưa;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton4.Text = "Xóa hóa đơn chi tiết";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::QLBThuocc.Properties.Resources.remove;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton5.Text = "Thêm hóa đơn chi tiết";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = global::QLBThuocc.Properties.Resources.update1;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton6.Text = "toolStripButton6";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // txtMaPTH
            // 
            this.txtMaPTH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaPTH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPTH.Location = new System.Drawing.Point(165, 56);
            this.txtMaPTH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaPTH.Name = "txtMaPTH";
            this.txtMaPTH.Size = new System.Drawing.Size(186, 31);
            this.txtMaPTH.TabIndex = 26;
            // 
            // txtsl
            // 
            this.txtsl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsl.Location = new System.Drawing.Point(165, 163);
            this.txtsl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(186, 31);
            this.txtsl.TabIndex = 28;
            // 
            // cboMaHH
            // 
            this.cboMaHH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaHH.FormattingEnabled = true;
            this.cboMaHH.Location = new System.Drawing.Point(165, 108);
            this.cboMaHH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMaHH.Name = "cboMaHH";
            this.cboMaHH.Size = new System.Drawing.Size(186, 33);
            this.cboMaHH.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(4, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 25);
            this.label8.TabIndex = 33;
            this.label8.Text = "Mã phiếu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(4, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 25);
            this.label9.TabIndex = 34;
            this.label9.Text = "Mã thuốc";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(7, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 25);
            this.label10.TabIndex = 35;
            this.label10.Text = "Số lượng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cboMaHH);
            this.groupBox1.Controls.Add(this.txtsl);
            this.groupBox1.Controls.Add(this.txtMaPTH);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.ForestGreen;
            this.groupBox1.Location = new System.Drawing.Point(1001, 348);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(395, 419);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // FrmPTHNct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 857);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.grdPTHN);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.ctnthem);
            this.Controls.Add(this.btnchonHD);
            this.Controls.Add(this.txtlido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboSoCT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.txtNgaytra);
            this.Controls.Add(this.txtMaPTHN);
            this.Controls.Add(this.label2);
            this.Name = "FrmPTHNct";
            this.Text = "Nhà thuốc VNPharma";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPTHNct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPTHN)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnchonHD;
        private System.Windows.Forms.TextBox txtlido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboSoCT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txtNgaytra;
        private System.Windows.Forms.TextBox txtMaPTHN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button ctnthem;
        private System.Windows.Forms.DataGridView grdPTHN;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.TextBox txtMaPTH;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.ComboBox cboMaHH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPTHN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn LiDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLT;
    }
}