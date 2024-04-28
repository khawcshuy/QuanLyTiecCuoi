namespace QuanLyTiecCuoi
{
    partial class Report
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LsParty = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.OrderDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.totalParty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.admin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Month = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumberOfParty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Revenue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ratio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "LAP BAO CAO THANG";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ConfirmButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 735);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.LsParty);
            this.panel3.Location = new System.Drawing.Point(18, 224);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(941, 446);
            this.panel3.TabIndex = 24;
            // 
            // LsParty
            // 
            this.LsParty.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.index,
            this.Date,
            this.NumberOfParty,
            this.Revenue,
            this.Ratio});
            this.LsParty.HideSelection = false;
            this.LsParty.Location = new System.Drawing.Point(18, 18);
            this.LsParty.Name = "LsParty";
            this.LsParty.Size = new System.Drawing.Size(903, 410);
            this.LsParty.TabIndex = 0;
            this.LsParty.UseCompatibleStateImageBehavior = false;
            this.LsParty.View = System.Windows.Forms.View.Details;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.OrderDate);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.totalParty);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.admin);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Total);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Month);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Location = new System.Drawing.Point(18, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(941, 151);
            this.panel2.TabIndex = 23;
            // 
            // OrderDate
            // 
            this.OrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.8F);
            this.OrderDate.Location = new System.Drawing.Point(696, 65);
            this.OrderDate.Margin = new System.Windows.Forms.Padding(4);
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.Size = new System.Drawing.Size(199, 20);
            this.OrderDate.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(537, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Ngày Lập Hóa Đơn";
            // 
            // totalParty
            // 
            this.totalParty.Location = new System.Drawing.Point(696, 22);
            this.totalParty.Margin = new System.Windows.Forms.Padding(4);
            this.totalParty.Name = "totalParty";
            this.totalParty.Size = new System.Drawing.Size(199, 22);
            this.totalParty.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(537, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tổng Số Lượng Tiệc";
            // 
            // admin
            // 
            this.admin.Location = new System.Drawing.Point(232, 108);
            this.admin.Margin = new System.Windows.Forms.Padding(4);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(199, 22);
            this.admin.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Người lập hóa đơn";
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(232, 65);
            this.Total.Margin = new System.Windows.Forms.Padding(4);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(199, 22);
            this.Total.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tổng Doanh Thu";
            // 
            // Month
            // 
            this.Month.Location = new System.Drawing.Point(232, 22);
            this.Month.Margin = new System.Windows.Forms.Padding(4);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(199, 22);
            this.Month.TabIndex = 13;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(68, 24);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(57, 17);
            this.label20.TabIndex = 12;
            this.label20.Text = "Tháng :";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ConfirmButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ConfirmButton.Location = new System.Drawing.Point(783, 677);
            this.ConfirmButton.Margin = new System.Windows.Forms.Padding(4);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(176, 38);
            this.ConfirmButton.TabIndex = 22;
            this.ConfirmButton.Text = "Xác Nhận";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            // 
            // index
            // 
            this.index.Text = "STT";
            // 
            // Date
            // 
            this.Date.Text = "Ngày";
            // 
            // NumberOfParty
            // 
            this.NumberOfParty.Text = "Số Lượng Tiệc Cưới ";
            // 
            // Revenue
            // 
            this.Revenue.Text = "Doanh Thu";
            // 
            // Ratio
            // 
            this.Ratio.Text = "Tỉ Lệ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 759);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Bao Cao Thang";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Month;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox totalParty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox admin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker OrderDate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView LsParty;
        private System.Windows.Forms.ColumnHeader index;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader NumberOfParty;
        private System.Windows.Forms.ColumnHeader Revenue;
        private System.Windows.Forms.ColumnHeader Ratio;
    }
}