namespace QuanLyTiecCuoi
{
    partial class TraCuu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.rjTextBox1 = new QuanLyTiecCuoi.UIDesign.RJTextBox();
            this.button1 = new QuanLyTiecCuoi.UIDesign.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(880, 430);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập Số Điện Thoại";
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox1.BorderColor1 = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox1.BorderColor2 = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox1.BorderFocusColor1 = System.Drawing.Color.HotPink;
            this.rjTextBox1.BorderFocusColor2 = System.Drawing.Color.HotPink;
            this.rjTextBox1.BorderSize = 2;
            this.rjTextBox1.BorderSize1 = 2;
            this.rjTextBox1.BorderSize2 = 2;
            this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.Black;
            this.rjTextBox1.IsFocused = false;
            this.rjTextBox1.IsFocused1 = false;
            this.rjTextBox1.Location = new System.Drawing.Point(307, 69);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.Size = new System.Drawing.Size(250, 31);
            this.rjTextBox1.TabIndex = 5;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = false;
            this.rjTextBox1.UnderlinedStyle1 = false;
            this.rjTextBox1.UnderlinedStyle2 = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateBlue;
            this.button1.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.button1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.button1.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.button1.BorderRadius = 20;
            this.button1.BorderRadius1 = 20;
            this.button1.BorderSize = 0;
            this.button1.BorderSize1 = 0;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(564, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search";
            this.button1.TextColor = System.Drawing.Color.White;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TraCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 644);
            this.Controls.Add(this.rjTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TraCuu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TraCuu";
            this.Load += new System.EventHandler(this.TraCuu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private UIDesign.RJButton button1;
        private UIDesign.RJTextBox rjTextBox1;
    }
}