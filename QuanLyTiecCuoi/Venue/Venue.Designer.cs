using System.Windows.Forms;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sANHINFORTableAdapter = new QuanLyTiecCuoi.DatabaseDataSet1TableAdapters.SANHINFORTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new QuanLyTiecCuoi.UIDesign.RJButton();
            this.btnEdit = new QuanLyTiecCuoi.UIDesign.RJButton();
            this.btnAdd = new QuanLyTiecCuoi.UIDesign.RJButton();
            this.searchVenuename = new QuanLyTiecCuoi.UIDesign.TextBoxTemplate();
            this.Confirm = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.VenueId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.VenueName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VenueType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VenueState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.venueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.venueBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sANHINFORTableAdapter
            // 
            this.sANHINFORTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.searchVenuename);
            this.panel1.Controls.Add(this.Confirm);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 648);
            this.panel1.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(102)))));
            this.btnDelete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(102)))));
            this.btnDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelete.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.btnDelete.BorderRadius = 10;
            this.btnDelete.BorderRadius1 = 10;
            this.btnDelete.BorderSize = 0;
            this.btnDelete.BorderSize1 = 0;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(828, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(170, 40);
            this.btnDelete.TabIndex = 49;
            this.btnDelete.Text = "Xóa Sảnh";
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(102)))));
            this.btnEdit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(102)))));
            this.btnEdit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEdit.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.btnEdit.BorderRadius = 10;
            this.btnEdit.BorderRadius1 = 10;
            this.btnEdit.BorderSize = 0;
            this.btnEdit.BorderSize1 = 0;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(614, 14);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(170, 40);
            this.btnEdit.TabIndex = 48;
            this.btnEdit.Text = "Chỉnh Sửa Sảnh";
            this.btnEdit.TextColor = System.Drawing.Color.White;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(102)))));
            this.btnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(102)))));
            this.btnAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.BorderRadius1 = 10;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.BorderSize1 = 0;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(400, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(170, 40);
            this.btnAdd.TabIndex = 47;
            this.btnAdd.Text = "Thêm Sảnh Mới";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // searchVenuename
            // 
            this.searchVenuename.BackColor = System.Drawing.Color.White;
            this.searchVenuename.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(102)))));
            this.searchVenuename.BorderFocusColor = System.Drawing.Color.SpringGreen;
            this.searchVenuename.BorderRadius = 0;
            this.searchVenuename.BorderSize = 2;
            this.searchVenuename.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchVenuename.ForeColor = System.Drawing.Color.Black;
            this.searchVenuename.Location = new System.Drawing.Point(92, 14);
            this.searchVenuename.Margin = new System.Windows.Forms.Padding(4);
            this.searchVenuename.Multiline = false;
            this.searchVenuename.Name = "searchVenuename";
            this.searchVenuename.Padding = new System.Windows.Forms.Padding(7);
            this.searchVenuename.PasswordChar = false;
            this.searchVenuename.PlaceholderColor = System.Drawing.Color.DimGray;
            this.searchVenuename.PlaceholderText = "Tìm Sảnh";
            this.searchVenuename.Size = new System.Drawing.Size(259, 37);
            this.searchVenuename.TabIndex = 46;
            this.searchVenuename.Texts = "";
            this.searchVenuename.UnderlinedStyle = true;
            this.searchVenuename._TextChanged += new System.EventHandler(this.searchFoodname__TextChanged);
            // 
            // Confirm
            // 
            this.Confirm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Confirm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Confirm.Location = new System.Drawing.Point(599, 555);
            this.Confirm.Margin = new System.Windows.Forms.Padding(2);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(0, 0);
            this.Confirm.TabIndex = 44;
            this.Confirm.Text = "Xác Nhận";
            this.Confirm.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 60;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VenueId,
            this.Image,
            this.VenueName,
            this.VenueType,
            this.MaxTable,
            this.MinTable,
            this.Note,
            this.VenueState});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(102)))));
            this.dataGridView1.Location = new System.Drawing.Point(11, 79);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 100;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1033, 575);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
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
            // 
            // VenueType
            // 
            this.VenueType.HeaderText = "Loại Sảnh";
            this.VenueType.MinimumWidth = 6;
            this.VenueType.Name = "VenueType";
            this.VenueType.ReadOnly = true;
            // 
            // MaxTable
            // 
            this.MaxTable.HeaderText = "Số Lượng Bàn Tối Đa";
            this.MaxTable.MinimumWidth = 6;
            this.MaxTable.Name = "MaxTable";
            this.MaxTable.ReadOnly = true;
            // 
            // MinTable
            // 
            this.MinTable.HeaderText = "Giá Bàn Tối Thiểu";
            this.MinTable.MinimumWidth = 6;
            this.MinTable.Name = "MinTable";
            this.MinTable.ReadOnly = true;
            // 
            // Note
            // 
            this.Note.HeaderText = "Ghi Chú";
            this.Note.MinimumWidth = 6;
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            // 
            // VenueState
            // 
            this.VenueState.HeaderText = "Trạng Thái Sảnh";
            this.VenueState.MinimumWidth = 6;
            this.VenueState.Name = "VenueState";
            this.VenueState.ReadOnly = true;
            this.VenueState.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // venueBindingSource
            // 
            this.venueBindingSource.DataSource = typeof(QuanLyTiecCuoi.Venue);
            // 
            // Venue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1039, 658);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Venue";
            this.Text = "Venue";
            this.Load += new System.EventHandler(this.Venue_Load);
            this.Resize += new System.EventHandler(this.Venue_Resize);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.venueBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DatabaseDataSet1TableAdapters.SANHINFORTableAdapter sANHINFORTableAdapter;
        private System.Windows.Forms.BindingSource venueBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Confirm;
        private UIDesign.RJButton btnDelete;
        private UIDesign.RJButton btnEdit;
        private UIDesign.RJButton btnAdd;
        private UIDesign.TextBoxTemplate searchVenuename;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn VenueId;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn VenueName;
        private System.Windows.Forms.DataGridViewTextBoxColumn VenueType;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn VenueState;

    }
}