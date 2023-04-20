
namespace QLBThuocc
{
    partial class BCCP_theoNCC
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
            this.txtMaNCC = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMH = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtt2 = new System.Windows.Forms.DateTimePicker();
            this.dtt1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNCC.FormattingEnabled = true;
            this.txtMaNCC.Location = new System.Drawing.Point(305, 161);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(210, 33);
            this.txtMaNCC.TabIndex = 40;
            this.txtMaNCC.SelectedIndexChanged += new System.EventHandler(this.txtMaKH_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(319, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 27);
            this.label4.TabIndex = 39;
            this.label4.Text = "Mã nhà cung cấp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(417, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 27);
            this.label5.TabIndex = 38;
            this.label5.Text = "Đến ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 27);
            this.label2.TabIndex = 37;
            this.label2.Text = "Từ ngày ";
            // 
            // btnMH
            // 
            this.btnMH.BackColor = System.Drawing.Color.ForestGreen;
            this.btnMH.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMH.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMH.Location = new System.Drawing.Point(300, 346);
            this.btnMH.Name = "btnMH";
            this.btnMH.Size = new System.Drawing.Size(215, 52);
            this.btnMH.TabIndex = 36;
            this.btnMH.Text = "Xuất báo cáo";
            this.btnMH.UseVisualStyleBackColor = false;
            this.btnMH.Click += new System.EventHandler(this.btnMH_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(293, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 38);
            this.label1.TabIndex = 35;
            this.label1.Text = "BÁO CÁO CHI PHÍ";
            // 
            // dtt2
            // 
            this.dtt2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtt2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtt2.Location = new System.Drawing.Point(531, 249);
            this.dtt2.Name = "dtt2";
            this.dtt2.Size = new System.Drawing.Size(204, 34);
            this.dtt2.TabIndex = 34;
            // 
            // dtt1
            // 
            this.dtt1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtt1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtt1.Location = new System.Drawing.Point(169, 249);
            this.dtt1.Name = "dtt1";
            this.dtt1.Size = new System.Drawing.Size(204, 34);
            this.dtt1.TabIndex = 33;
            // 
            // BCCP_theoNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMaNCC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtt2);
            this.Controls.Add(this.dtt1);
            this.Name = "BCCP_theoNCC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VNPharmaNhà thuốc ";
            this.Load += new System.EventHandler(this.BCCP_theoNCC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtMaNCC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtt2;
        private System.Windows.Forms.DateTimePicker dtt1;
    }
}