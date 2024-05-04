﻿namespace QuanLyTiecCuoi.Service
{
    partial class Service
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SearchService = new System.Windows.Forms.TextBox();
            this.dataGridViewService = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.ChangeService = new System.Windows.Forms.Button();
            this.AddFood = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ServiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServicePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewService)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.SearchService);
            this.panel2.Controls.Add(this.dataGridViewService);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.ChangeService);
            this.panel2.Controls.Add(this.AddFood);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(14, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1099, 918);
            this.panel2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(803, 80);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "- Xóa Sảnh";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // SearchService
            // 
            this.SearchService.Location = new System.Drawing.Point(108, 86);
            this.SearchService.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchService.Name = "SearchService";
            this.SearchService.Size = new System.Drawing.Size(201, 26);
            this.SearchService.TabIndex = 7;
            this.SearchService.TextChanged += new System.EventHandler(this.SearchService_TextChanged);
            // 
            // dataGridViewService
            // 
            this.dataGridViewService.AllowUserToAddRows = false;
            this.dataGridViewService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceId,
            this.ServiceName,
            this.ServiceType,
            this.ServicePrice,
            this.ServiceNote});
            this.dataGridViewService.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridViewService.Location = new System.Drawing.Point(18, 128);
            this.dataGridViewService.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewService.Name = "dataGridViewService";
            this.dataGridViewService.ReadOnly = true;
            this.dataGridViewService.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewService.RowHeadersWidth = 51;
            this.dataGridViewService.RowTemplate.Height = 100;
            this.dataGridViewService.Size = new System.Drawing.Size(1064, 752);
            this.dataGridViewService.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tìm Dich Vu";
            // 
            // ChangeService
            // 
            this.ChangeService.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ChangeService.Location = new System.Drawing.Point(587, 80);
            this.ChangeService.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChangeService.Name = "ChangeService";
            this.ChangeService.Size = new System.Drawing.Size(180, 40);
            this.ChangeService.TabIndex = 5;
            this.ChangeService.Text = "Chỉnh sửa sảnh";
            this.ChangeService.UseVisualStyleBackColor = false;
            this.ChangeService.Click += new System.EventHandler(this.ChangeService_Click);
            // 
            // AddFood
            // 
            this.AddFood.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddFood.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddFood.Location = new System.Drawing.Point(374, 80);
            this.AddFood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddFood.Name = "AddFood";
            this.AddFood.Size = new System.Drawing.Size(180, 40);
            this.AddFood.TabIndex = 4;
            this.AddFood.Text = "+ Thêm Sảnh Mới";
            this.AddFood.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label4.Location = new System.Drawing.Point(1, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(331, 40);
            this.label4.TabIndex = 2;
            this.label4.Text = "Danh Sách Dich Vu";
            // 
            // ServiceId
            // 
            this.ServiceId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ServiceId.HeaderText = "ID";
            this.ServiceId.MinimumWidth = 6;
            this.ServiceId.Name = "ServiceId";
            this.ServiceId.ReadOnly = true;
            this.ServiceId.Width = 49;
            // 
            // ServiceName
            // 
            this.ServiceName.HeaderText = "Tên Dich Vu";
            this.ServiceName.MinimumWidth = 6;
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.ReadOnly = true;
            this.ServiceName.Width = 125;
            // 
            // ServiceType
            // 
            this.ServiceType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ServiceType.HeaderText = "Loai Dich Vu";
            this.ServiceType.MinimumWidth = 6;
            this.ServiceType.Name = "ServiceType";
            this.ServiceType.ReadOnly = true;
            this.ServiceType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ServiceType.Width = 200;
            // 
            // ServicePrice
            // 
            this.ServicePrice.HeaderText = "Đơn Giá";
            this.ServicePrice.MinimumWidth = 6;
            this.ServicePrice.Name = "ServicePrice";
            this.ServicePrice.ReadOnly = true;
            this.ServicePrice.Width = 125;
            // 
            // ServiceNote
            // 
            this.ServiceNote.HeaderText = "Ghi Chú";
            this.ServiceNote.MinimumWidth = 6;
            this.ServiceNote.Name = "ServiceNote";
            this.ServiceNote.ReadOnly = true;
            this.ServiceNote.Width = 125;
            // 
            // Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 949);
            this.Controls.Add(this.panel2);
            this.Name = "Service";
            this.Text = "Service";
            this.Load += new System.EventHandler(this.Service_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewService)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SearchService;
        private System.Windows.Forms.DataGridView dataGridViewService;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ChangeService;
        private System.Windows.Forms.Button AddFood;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServicePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceNote;
    }
}