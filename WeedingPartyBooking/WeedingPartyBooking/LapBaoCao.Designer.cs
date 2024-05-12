namespace WeedingPartyBooking
{
    partial class LapBaoCao
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
            this.textBoxSoLuongTiec = new System.Windows.Forms.TextBox();
            this.dateTimePickerNgayLap = new System.Windows.Forms.DateTimePicker();
            this.textBoxTenNguoiLap = new System.Windows.Forms.TextBox();
            this.textBoxDoanhThu = new System.Windows.Forms.TextBox();
            this.textBoxTiLe = new System.Windows.Forms.TextBox();
            this.textBoxThang = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSoLuongTiec
            // 
            this.textBoxSoLuongTiec.Location = new System.Drawing.Point(440, 115);
            this.textBoxSoLuongTiec.Name = "textBoxSoLuongTiec";
            this.textBoxSoLuongTiec.Size = new System.Drawing.Size(123, 20);
            this.textBoxSoLuongTiec.TabIndex = 0;
            // 
            // dateTimePickerNgayLap
            // 
            this.dateTimePickerNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgayLap.Location = new System.Drawing.Point(220, 115);
            this.dateTimePickerNgayLap.Name = "dateTimePickerNgayLap";
            this.dateTimePickerNgayLap.Size = new System.Drawing.Size(123, 20);
            this.dateTimePickerNgayLap.TabIndex = 1;
            // 
            // textBoxTenNguoiLap
            // 
            this.textBoxTenNguoiLap.Location = new System.Drawing.Point(220, 162);
            this.textBoxTenNguoiLap.Name = "textBoxTenNguoiLap";
            this.textBoxTenNguoiLap.Size = new System.Drawing.Size(123, 20);
            this.textBoxTenNguoiLap.TabIndex = 2;
            // 
            // textBoxDoanhThu
            // 
            this.textBoxDoanhThu.Location = new System.Drawing.Point(440, 162);
            this.textBoxDoanhThu.Name = "textBoxDoanhThu";
            this.textBoxDoanhThu.Size = new System.Drawing.Size(123, 20);
            this.textBoxDoanhThu.TabIndex = 3;
            // 
            // textBoxTiLe
            // 
            this.textBoxTiLe.Location = new System.Drawing.Point(220, 210);
            this.textBoxTiLe.Name = "textBoxTiLe";
            this.textBoxTiLe.Size = new System.Drawing.Size(123, 20);
            this.textBoxTiLe.TabIndex = 4;
            // 
            // textBoxThang
            // 
            this.textBoxThang.Location = new System.Drawing.Point(440, 210);
            this.textBoxThang.Name = "textBoxThang";
            this.textBoxThang.Size = new System.Drawing.Size(123, 20);
            this.textBoxThang.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "Báo Cáo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LapBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxThang);
            this.Controls.Add(this.textBoxTiLe);
            this.Controls.Add(this.textBoxDoanhThu);
            this.Controls.Add(this.textBoxTenNguoiLap);
            this.Controls.Add(this.dateTimePickerNgayLap);
            this.Controls.Add(this.textBoxSoLuongTiec);
            this.Name = "LapBaoCao";
            this.Text = "LapBaoCao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSoLuongTiec;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayLap;
        private System.Windows.Forms.TextBox textBoxTenNguoiLap;
        private System.Windows.Forms.TextBox textBoxDoanhThu;
        private System.Windows.Forms.TextBox textBoxTiLe;
        private System.Windows.Forms.TextBox textBoxThang;
        private System.Windows.Forms.Button button1;
    }
}