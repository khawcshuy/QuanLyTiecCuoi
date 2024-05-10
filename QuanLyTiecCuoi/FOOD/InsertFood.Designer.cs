namespace QuanLyTiecCuoi.SERVICE
{
    partial class InsertFood
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
            this.FoodNameAdd = new System.Windows.Forms.TextBox();
            this.UploadPhoto = new System.Windows.Forms.Button();
            this.FoodPriceAdd = new System.Windows.Forms.TextBox();
            this.NoteAdd = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.Confirm.TabIndex = 46;
            this.Confirm.Text = "Xác Nhận";
            this.Confirm.UseVisualStyleBackColor = false;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.FoodNameAdd);
            this.panel1.Controls.Add(this.UploadPhoto);
            this.panel1.Controls.Add(this.FoodPriceAdd);
            this.panel1.Controls.Add(this.NoteAdd);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(13, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 503);
            this.panel1.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "TEN MON AN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 40);
            this.label1.TabIndex = 40;
            this.label1.Text = "Thêm Món Ăn";
            // 
            // FoodNameAdd
            // 
            this.FoodNameAdd.Location = new System.Drawing.Point(182, 81);
            this.FoodNameAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FoodNameAdd.Name = "FoodNameAdd";
            this.FoodNameAdd.Size = new System.Drawing.Size(176, 26);
            this.FoodNameAdd.TabIndex = 26;
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
            // FoodPriceAdd
            // 
            this.FoodPriceAdd.Location = new System.Drawing.Point(182, 138);
            this.FoodPriceAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FoodPriceAdd.Name = "FoodPriceAdd";
            this.FoodPriceAdd.Size = new System.Drawing.Size(176, 26);
            this.FoodPriceAdd.TabIndex = 29;
            // 
            // NoteAdd
            // 
            this.NoteAdd.Location = new System.Drawing.Point(182, 210);
            this.NoteAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NoteAdd.Name = "NoteAdd";
            this.NoteAdd.Size = new System.Drawing.Size(176, 95);
            this.NoteAdd.TabIndex = 37;
            this.NoteAdd.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "Ghi Chú";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "DON GIA";
            // 
            // InsertFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 581);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.panel1);
            this.Name = "InsertFood";
            this.Text = "INSERTFOOD";
            this.Load += new System.EventHandler(this.INSERTFOOD_Load);
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
        private System.Windows.Forms.TextBox FoodNameAdd;
        private System.Windows.Forms.Button UploadPhoto;
        private System.Windows.Forms.TextBox FoodPriceAdd;
        private System.Windows.Forms.RichTextBox NoteAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
    }
}