namespace QuanLyTiecCuoi
{
    partial class NhanVien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteEmployee = new QuanLyTiecCuoi.UIDesign.RJButton();
            this.ChangeInforEmployee = new QuanLyTiecCuoi.UIDesign.RJButton();
            this.addEmployee = new QuanLyTiecCuoi.UIDesign.RJButton();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.rjTextBox1 = new QuanLyTiecCuoi.UIDesign.RJTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.Controls.Add(this.deleteEmployee);
            this.panel1.Controls.Add(this.ChangeInforEmployee);
            this.panel1.Controls.Add(this.addEmployee);
            this.panel1.Controls.Add(this.dataGridViewEmployee);
            this.panel1.Controls.Add(this.rjTextBox1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 711);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // deleteEmployee
            // 
            this.deleteEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.deleteEmployee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.deleteEmployee.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.deleteEmployee.BorderColor1 = System.Drawing.Color.DarkSlateBlue;
            this.deleteEmployee.BorderRadius = 10;
            this.deleteEmployee.BorderRadius1 = 10;
            this.deleteEmployee.BorderSize = 2;
            this.deleteEmployee.BorderSize1 = 2;
            this.deleteEmployee.FlatAppearance.BorderSize = 0;
            this.deleteEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteEmployee.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteEmployee.ForeColor = System.Drawing.Color.White;
            this.deleteEmployee.Location = new System.Drawing.Point(826, 34);
            this.deleteEmployee.Name = "deleteEmployee";
            this.deleteEmployee.Size = new System.Drawing.Size(163, 56);
            this.deleteEmployee.TabIndex = 5;
            this.deleteEmployee.Text = "Xóa Nhân Viên";
            this.deleteEmployee.TextColor = System.Drawing.Color.White;
            this.deleteEmployee.UseVisualStyleBackColor = false;
            this.deleteEmployee.Click += new System.EventHandler(this.deleteEmployee_Click);
            // 
            // ChangeInforEmployee
            // 
            this.ChangeInforEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.ChangeInforEmployee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.ChangeInforEmployee.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.ChangeInforEmployee.BorderColor1 = System.Drawing.Color.DarkSlateBlue;
            this.ChangeInforEmployee.BorderRadius = 10;
            this.ChangeInforEmployee.BorderRadius1 = 10;
            this.ChangeInforEmployee.BorderSize = 2;
            this.ChangeInforEmployee.BorderSize1 = 2;
            this.ChangeInforEmployee.FlatAppearance.BorderSize = 0;
            this.ChangeInforEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeInforEmployee.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeInforEmployee.ForeColor = System.Drawing.Color.White;
            this.ChangeInforEmployee.Location = new System.Drawing.Point(639, 34);
            this.ChangeInforEmployee.Name = "ChangeInforEmployee";
            this.ChangeInforEmployee.Size = new System.Drawing.Size(163, 56);
            this.ChangeInforEmployee.TabIndex = 4;
            this.ChangeInforEmployee.Text = "Sửa Nhân Viên";
            this.ChangeInforEmployee.TextColor = System.Drawing.Color.White;
            this.ChangeInforEmployee.UseVisualStyleBackColor = false;
            this.ChangeInforEmployee.Click += new System.EventHandler(this.ChangeInforEmployee_Click);
            // 
            // addEmployee
            // 
            this.addEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.addEmployee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.addEmployee.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.addEmployee.BorderColor1 = System.Drawing.Color.DarkSlateBlue;
            this.addEmployee.BorderRadius = 10;
            this.addEmployee.BorderRadius1 = 10;
            this.addEmployee.BorderSize = 2;
            this.addEmployee.BorderSize1 = 2;
            this.addEmployee.FlatAppearance.BorderSize = 0;
            this.addEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployee.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee.ForeColor = System.Drawing.Color.White;
            this.addEmployee.Location = new System.Drawing.Point(450, 34);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(163, 56);
            this.addEmployee.TabIndex = 3;
            this.addEmployee.Text = "Thêm Nhân Viên";
            this.addEmployee.TextColor = System.Drawing.Color.White;
            this.addEmployee.UseVisualStyleBackColor = false;
            this.addEmployee.Click += new System.EventHandler(this.addEmployee_Click);
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.AllowUserToAddRows = false;
            this.dataGridViewEmployee.AllowUserToDeleteRows = false;
            this.dataGridViewEmployee.AllowUserToResizeRows = false;
            this.dataGridViewEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmployee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.dataGridViewEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewEmployee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEmployee.ColumnHeadersHeight = 40;
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewEmployee.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridViewEmployee.EnableHeadersVisualStyles = false;
            this.dataGridViewEmployee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.dataGridViewEmployee.Location = new System.Drawing.Point(3, 135);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.ReadOnly = true;
            this.dataGridViewEmployee.RowHeadersVisible = false;
            this.dataGridViewEmployee.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.GhostWhite;
            this.dataGridViewEmployee.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(1048, 490);
            this.dataGridViewEmployee.TabIndex = 1;
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.rjTextBox1.BorderRadius = 10;
            this.rjTextBox1.BorderSize = 2;
            this.rjTextBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox1.Location = new System.Drawing.Point(128, 45);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = true;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.Gray;
            this.rjTextBox1.PlaceholderText = "Search";
            this.rjTextBox1.Size = new System.Drawing.Size(259, 32);
            this.rjTextBox1.TabIndex = 0;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = false;
            this.rjTextBox1._TextChanged += new System.EventHandler(this.rjTextBox1__TextChanged);
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1054, 711);
            this.Controls.Add(this.panel1);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            this.Resize += new System.EventHandler(this.NhanVien_Resize);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UIDesign.RJTextBox rjTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private UIDesign.RJButton deleteEmployee;
        private UIDesign.RJButton ChangeInforEmployee;
        private UIDesign.RJButton addEmployee;
    }
}