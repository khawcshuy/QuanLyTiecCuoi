namespace QuanLyTiecCuoi
{
    partial class Venue
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sANHINFORTableAdapter = new QuanLyTiecCuoi.DatabaseDataSet1TableAdapters.SANHINFORTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Confirm = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SearchVenue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ChangeVenue = new System.Windows.Forms.Button();
            this.AddVenue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.venueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VenueId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.VenueName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VenueType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.venueBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VenueId,
            this.Image,
            this.VenueName,
            this.VenueType,
            this.MaxTable,
            this.MinTable,
            this.Note});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Location = new System.Drawing.Point(13, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 100;
            this.dataGridView1.Size = new System.Drawing.Size(946, 571);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // sANHINFORTableAdapter
            // 
            this.sANHINFORTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Confirm);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.SearchVenue);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ChangeVenue);
            this.panel1.Controls.Add(this.AddVenue);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 734);
            this.panel1.TabIndex = 1;
            // 
            // Confirm
            // 
            this.Confirm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Confirm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Confirm.Location = new System.Drawing.Point(799, 683);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(0, 0);
            this.Confirm.TabIndex = 44;
            this.Confirm.Text = "Xác Nhận";
            this.Confirm.UseVisualStyleBackColor = false;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(714, 64);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 32);
            this.button3.TabIndex = 8;
            this.button3.Text = "- Xóa Sảnh";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SearchVenue
            // 
            this.SearchVenue.Location = new System.Drawing.Point(96, 69);
            this.SearchVenue.Name = "SearchVenue";
            this.SearchVenue.Size = new System.Drawing.Size(179, 22);
            this.SearchVenue.TabIndex = 7;
            this.SearchVenue.TextChanged += new System.EventHandler(this.SearchVenue_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tìm Sảnh";
            // 
            // ChangeVenue
            // 
            this.ChangeVenue.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ChangeVenue.Location = new System.Drawing.Point(522, 64);
            this.ChangeVenue.Name = "ChangeVenue";
            this.ChangeVenue.Size = new System.Drawing.Size(160, 32);
            this.ChangeVenue.TabIndex = 5;
            this.ChangeVenue.Text = "Chỉnh sửa sảnh";
            this.ChangeVenue.UseVisualStyleBackColor = false;
            this.ChangeVenue.Click += new System.EventHandler(this.ChangeVenue_Click);
            // 
            // AddVenue
            // 
            this.AddVenue.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddVenue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddVenue.Location = new System.Drawing.Point(332, 64);
            this.AddVenue.Name = "AddVenue";
            this.AddVenue.Size = new System.Drawing.Size(160, 32);
            this.AddVenue.TabIndex = 4;
            this.AddVenue.Text = "+ Thêm Sảnh Mới";
            this.AddVenue.UseVisualStyleBackColor = false;
            this.AddVenue.Click += new System.EventHandler(this.AddVenue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(1, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÝ SẢNH CƯỚI";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // venueBindingSource
            // 
            this.venueBindingSource.DataSource = typeof(QuanLyTiecCuoi.Venue);
            // 
            // VenueId
            // 
            this.VenueId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.VenueId.HeaderText = "ID";
            this.VenueId.MinimumWidth = 6;
            this.VenueId.Name = "VenueId";
            this.VenueId.ReadOnly = true;
            this.VenueId.Width = 49;
            // 
            // Image
            // 
            this.Image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Image.HeaderText = "Ảnh";
            this.Image.MinimumWidth = 6;
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            this.Image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Image.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Image.Width = 200;
            // 
            // VenueName
            // 
            this.VenueName.HeaderText = "Tên Sảnh";
            this.VenueName.MinimumWidth = 6;
            this.VenueName.Name = "VenueName";
            this.VenueName.ReadOnly = true;
            this.VenueName.Width = 125;
            // 
            // VenueType
            // 
            this.VenueType.HeaderText = "Loại Sảnh";
            this.VenueType.MinimumWidth = 6;
            this.VenueType.Name = "VenueType";
            this.VenueType.ReadOnly = true;
            this.VenueType.Width = 125;
            // 
            // MaxTable
            // 
            this.MaxTable.HeaderText = "Số lượng bàn tối đa";
            this.MaxTable.MinimumWidth = 6;
            this.MaxTable.Name = "MaxTable";
            this.MaxTable.ReadOnly = true;
            this.MaxTable.Width = 125;
            // 
            // MinTable
            // 
            this.MinTable.HeaderText = "Gía bàn tối thiểu";
            this.MinTable.MinimumWidth = 6;
            this.MinTable.Name = "MinTable";
            this.MinTable.ReadOnly = true;
            this.MinTable.Width = 125;
            // 
            // Note
            // 
            this.Note.HeaderText = "Ghi Chú";
            this.Note.MinimumWidth = 6;
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            this.Note.Width = 125;
            // 
            // Venue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 759);
            this.Controls.Add(this.panel1);
            this.Name = "Venue";
            this.Text = "Venue";
            this.Load += new System.EventHandler(this.Venue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.venueBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DatabaseDataSet1TableAdapters.SANHINFORTableAdapter sANHINFORTableAdapter;
        private System.Windows.Forms.BindingSource venueBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox SearchVenue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ChangeVenue;
        private System.Windows.Forms.Button AddVenue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn VenueId;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn VenueName;
        private System.Windows.Forms.DataGridViewTextBoxColumn VenueType;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
    }
}