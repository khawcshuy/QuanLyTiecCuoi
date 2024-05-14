namespace QuanLyTiecCuoi.Service
{
    partial class InsertService
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
            this.Confirm = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ServiceNameAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ServiceTypeAdd = new System.Windows.Forms.ComboBox();
            this.ServicePriceAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Confirm
            // 
            this.Confirm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Confirm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Confirm.Location = new System.Drawing.Point(430, 332);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(160, 32);
            this.Confirm.TabIndex = 48;
            this.Confirm.Text = "Xác Nhận";
            this.Confirm.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "LOAI DICH VU";
            // 
            // ServiceNameAdd
            // 
            this.ServiceNameAdd.Location = new System.Drawing.Point(161, 78);
            this.ServiceNameAdd.Name = "ServiceNameAdd";
            this.ServiceNameAdd.Size = new System.Drawing.Size(157, 22);
            this.ServiceNameAdd.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 36);
            this.label1.TabIndex = 40;
            this.label1.Text = "Thêm Dich Vu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "TEN DICH VU";
            // 
            // ServiceTypeAdd
            // 
            this.ServiceTypeAdd.FormattingEnabled = true;
            this.ServiceTypeAdd.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.ServiceTypeAdd.Location = new System.Drawing.Point(161, 122);
            this.ServiceTypeAdd.Name = "ServiceTypeAdd";
            this.ServiceTypeAdd.Size = new System.Drawing.Size(157, 24);
            this.ServiceTypeAdd.TabIndex = 41;
            // 
            // ServicePriceAdd
            // 
            this.ServicePriceAdd.Location = new System.Drawing.Point(161, 167);
            this.ServicePriceAdd.Name = "ServicePriceAdd";
            this.ServicePriceAdd.Size = new System.Drawing.Size(157, 22);
            this.ServicePriceAdd.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "GIA DICH VU";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ServicePriceAdd);
            this.panel1.Controls.Add(this.ServiceTypeAdd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ServiceNameAdd);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 280);
            this.panel1.TabIndex = 47;
            // 
            // InsertService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 465);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InsertService";
            this.Text = "InsertService";
            this.Load += new System.EventHandler(this.InsertService_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ServiceNameAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ServiceTypeAdd;
        private System.Windows.Forms.TextBox ServicePriceAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}