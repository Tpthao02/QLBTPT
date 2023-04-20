
namespace QLBThuocc
{
    partial class FrmBCDT
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
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKH = new System.Windows.Forms.Button();
            this.btnMH = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtt2 = new System.Windows.Forms.DateTimePicker();
            this.dtt1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(478, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 27);
            this.label5.TabIndex = 21;
            this.label5.Text = "Đến ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 27);
            this.label2.TabIndex = 20;
            this.label2.Text = "Từ ngày ";
            // 
            // btnKH
            // 
            this.btnKH.BackColor = System.Drawing.Color.ForestGreen;
            this.btnKH.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKH.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKH.Location = new System.Drawing.Point(498, 352);
            this.btnKH.Name = "btnKH";
            this.btnKH.Size = new System.Drawing.Size(215, 52);
            this.btnKH.TabIndex = 19;
            this.btnKH.Text = "Xuất báo cáo";
            this.btnKH.UseVisualStyleBackColor = false;
            this.btnKH.Click += new System.EventHandler(this.btnKH_Click);
            // 
            // btnMH
            // 
            this.btnMH.BackColor = System.Drawing.Color.ForestGreen;
            this.btnMH.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMH.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMH.Location = new System.Drawing.Point(498, 263);
            this.btnMH.Name = "btnMH";
            this.btnMH.Size = new System.Drawing.Size(215, 52);
            this.btnMH.TabIndex = 18;
            this.btnMH.Text = "Xuất báo cáo";
            this.btnMH.UseVisualStyleBackColor = false;
            this.btnMH.Click += new System.EventHandler(this.btnMH_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(214, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 27);
            this.label4.TabIndex = 17;
            this.label4.Text = "BÁO CÁO CHI PHÍ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(214, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 27);
            this.label3.TabIndex = 16;
            this.label3.Text = "BÁO CÁO DOANH THU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(243, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 38);
            this.label1.TabIndex = 15;
            this.label1.Text = "BÁO CÁO DOANH THU - CHI PHÍ";
            // 
            // dtt2
            // 
            this.dtt2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtt2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtt2.Location = new System.Drawing.Point(592, 170);
            this.dtt2.Name = "dtt2";
            this.dtt2.Size = new System.Drawing.Size(204, 34);
            this.dtt2.TabIndex = 14;
            // 
            // dtt1
            // 
            this.dtt1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtt1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtt1.Location = new System.Drawing.Point(230, 170);
            this.dtt1.Name = "dtt1";
            this.dtt1.Size = new System.Drawing.Size(204, 34);
            this.dtt1.TabIndex = 13;
            // 
            // FrmBCDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 503);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnKH);
            this.Controls.Add(this.btnMH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtt2);
            this.Controls.Add(this.dtt1);
            this.Name = "FrmBCDT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhà thuốc VNPharma";
            this.Load += new System.EventHandler(this.FrmBCDT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKH;
        private System.Windows.Forms.Button btnMH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtt2;
        private System.Windows.Forms.DateTimePicker dtt1;
    }
}