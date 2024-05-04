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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ServiceNameAdd = new System.Windows.Forms.TextBox();
            this.UploadPhoto = new System.Windows.Forms.Button();
            this.NoteAdd = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ServiceTypeAdd = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ServicePriceAdd = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Confirm
            // 
            this.Confirm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Confirm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Confirm.Location = new System.Drawing.Point(483, 526);
            this.Confirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(180, 40);
            this.Confirm.TabIndex = 48;
            this.Confirm.Text = "Xác Nhận";
            this.Confirm.UseVisualStyleBackColor = false;
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
            this.panel1.Controls.Add(this.UploadPhoto);
            this.panel1.Controls.Add(this.NoteAdd);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(13, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 503);
            this.panel1.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "TEN DICH VU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 40);
            this.label1.TabIndex = 40;
            this.label1.Text = "Thêm Dich Vu";
            // 
            // ServiceNameAdd
            // 
            this.ServiceNameAdd.Location = new System.Drawing.Point(182, 81);
            this.ServiceNameAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ServiceNameAdd.Name = "ServiceNameAdd";
            this.ServiceNameAdd.Size = new System.Drawing.Size(176, 26);
            this.ServiceNameAdd.TabIndex = 26;
            // 
            // UploadPhoto
            // 
            this.UploadPhoto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UploadPhoto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UploadPhoto.Location = new System.Drawing.Point(443, 306);
            this.UploadPhoto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UploadPhoto.Name = "UploadPhoto";
            this.UploadPhoto.Size = new System.Drawing.Size(138, 40);
            this.UploadPhoto.TabIndex = 27;
            this.UploadPhoto.Text = "Upload ảnh";
            this.UploadPhoto.UseVisualStyleBackColor = false;
            this.UploadPhoto.Click += new System.EventHandler(this.UploadPhoto_Click);
            // 
            // NoteAdd
            // 
            this.NoteAdd.Location = new System.Drawing.Point(182, 260);
            this.NoteAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NoteAdd.Name = "NoteAdd";
            this.NoteAdd.Size = new System.Drawing.Size(176, 95);
            this.NoteAdd.TabIndex = 37;
            this.NoteAdd.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "Ghi Chú";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "LOAI DICH VU";
            // 
            // ServiceTypeAdd
            // 
            this.ServiceTypeAdd.FormattingEnabled = true;
            this.ServiceTypeAdd.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.ServiceTypeAdd.Location = new System.Drawing.Point(182, 136);
            this.ServiceTypeAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ServiceTypeAdd.Name = "ServiceTypeAdd";
            this.ServiceTypeAdd.Size = new System.Drawing.Size(176, 28);
            this.ServiceTypeAdd.TabIndex = 41;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(406, 81);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "GIA DICH VU";
            // 
            // ServicePriceAdd
            // 
            this.ServicePriceAdd.Location = new System.Drawing.Point(182, 192);
            this.ServicePriceAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ServicePriceAdd.Name = "ServicePriceAdd";
            this.ServicePriceAdd.Size = new System.Drawing.Size(176, 26);
            this.ServicePriceAdd.TabIndex = 42;
            // 
            // InsertService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 581);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.panel1);
            this.Name = "InsertService";
            this.Text = "InsertService";
            this.Load += new System.EventHandler(this.InsertService_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ServiceNameAdd;
        private System.Windows.Forms.Button UploadPhoto;
        private System.Windows.Forms.RichTextBox NoteAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ServiceTypeAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ServicePriceAdd;
    }
}