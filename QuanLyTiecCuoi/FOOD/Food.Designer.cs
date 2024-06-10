namespace QuanLyTiecCuoi
{
    partial class Food
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Food));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.SearchVenue = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.VenueId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.VenueName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VenueType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VenueState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.ChangeVenue = new System.Windows.Forms.Button();
            this.AddVenue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.XacNhan = new QuanLyTiecCuoi.UIDesign.RJButton();
            this.btnDelete = new QuanLyTiecCuoi.UIDesign.RJButton();
            this.btnEdit = new QuanLyTiecCuoi.UIDesign.RJButton();
            this.btnAdd = new QuanLyTiecCuoi.UIDesign.RJButton();
            this.searchFoodname = new QuanLyTiecCuoi.UIDesign.TextBoxTemplate();
            this.dataGridViewFood = new System.Windows.Forms.DataGridView();
            this.FoodId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PictureFood = new System.Windows.Forms.DataGridViewImageColumn();
            this.FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Confirm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFood)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.SearchVenue);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ChangeVenue);
            this.panel1.Controls.Add(this.AddVenue);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-66, -115);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(536, 52);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 26);
            this.button3.TabIndex = 8;
            this.button3.Text = "- Xóa Sảnh";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // SearchVenue
            // 
            this.SearchVenue.Location = new System.Drawing.Point(72, 56);
            this.SearchVenue.Margin = new System.Windows.Forms.Padding(2);
            this.SearchVenue.Name = "SearchVenue";
            this.SearchVenue.Size = new System.Drawing.Size(135, 20);
            this.SearchVenue.TabIndex = 7;
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
            this.VenueState,
            this.MaxTable,
            this.MinTable,
            this.Note});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Location = new System.Drawing.Point(10, 86);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 100;
            this.dataGridView1.Size = new System.Drawing.Size(710, 489);
            this.dataGridView1.TabIndex = 0;
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
            // VenueState
            // 
            this.VenueState.HeaderText = "Trạng Thái Sảnh";
            this.VenueState.MinimumWidth = 6;
            this.VenueState.Name = "VenueState";
            this.VenueState.ReadOnly = true;
            this.VenueState.Width = 125;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tìm Sảnh";
            // 
            // ChangeVenue
            // 
            this.ChangeVenue.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ChangeVenue.Location = new System.Drawing.Point(392, 52);
            this.ChangeVenue.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeVenue.Name = "ChangeVenue";
            this.ChangeVenue.Size = new System.Drawing.Size(120, 26);
            this.ChangeVenue.TabIndex = 5;
            this.ChangeVenue.Text = "Chỉnh sửa sảnh";
            this.ChangeVenue.UseVisualStyleBackColor = false;
            // 
            // AddVenue
            // 
            this.AddVenue.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddVenue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddVenue.Location = new System.Drawing.Point(249, 52);
            this.AddVenue.Margin = new System.Windows.Forms.Padding(2);
            this.AddVenue.Name = "AddVenue";
            this.AddVenue.Size = new System.Drawing.Size(120, 26);
            this.AddVenue.TabIndex = 4;
            this.AddVenue.Text = "+ Thêm Sảnh Mới";
            this.AddVenue.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(1, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÝ SẢNH CƯỚI";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.XacNhan);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.searchFoodname);
            this.panel2.Controls.Add(this.dataGridViewFood);
            this.panel2.Location = new System.Drawing.Point(-2, -2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(965, 660);
            this.panel2.TabIndex = 3;
            // 
            // XacNhan
            // 
            this.XacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(12)))), ((int)(((byte)(74)))));
            this.XacNhan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(12)))), ((int)(((byte)(74)))));
            this.XacNhan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.XacNhan.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.XacNhan.BorderRadius = 10;
            this.XacNhan.BorderRadius1 = 10;
            this.XacNhan.BorderSize = 0;
            this.XacNhan.BorderSize1 = 0;
            this.XacNhan.FlatAppearance.BorderSize = 0;
            this.XacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XacNhan.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XacNhan.ForeColor = System.Drawing.Color.White;
            this.XacNhan.Location = new System.Drawing.Point(564, 15);
            this.XacNhan.Name = "XacNhan";
            this.XacNhan.Size = new System.Drawing.Size(170, 40);
            this.XacNhan.TabIndex = 13;
            this.XacNhan.Text = "Xác Nhận";
            this.XacNhan.TextColor = System.Drawing.Color.White;
            this.XacNhan.UseVisualStyleBackColor = false;
            this.XacNhan.Visible = false;
            this.XacNhan.Click += new System.EventHandler(this.XacNhan_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(12)))), ((int)(((byte)(74)))));
            this.btnDelete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(12)))), ((int)(((byte)(74)))));
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
            this.btnDelete.Location = new System.Drawing.Point(782, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(170, 40);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Xóa Món Ăn";
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(12)))), ((int)(((byte)(74)))));
            this.btnEdit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(12)))), ((int)(((byte)(74)))));
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
            this.btnEdit.Location = new System.Drawing.Point(564, 15);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(187, 40);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Chỉnh Sửa Món Ăn";
            this.btnEdit.TextColor = System.Drawing.Color.White;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(12)))), ((int)(((byte)(74)))));
            this.btnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(12)))), ((int)(((byte)(74)))));
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
            this.btnAdd.Location = new System.Drawing.Point(366, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(170, 40);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Thêm Món Ăn";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // searchFoodname
            // 
            this.searchFoodname.BackColor = System.Drawing.SystemColors.Window;
            this.searchFoodname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(12)))), ((int)(((byte)(74)))));
            this.searchFoodname.BorderFocusColor = System.Drawing.Color.HotPink;
            this.searchFoodname.BorderRadius = 0;
            this.searchFoodname.BorderSize = 2;
            this.searchFoodname.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchFoodname.ForeColor = System.Drawing.Color.Black;
            this.searchFoodname.Location = new System.Drawing.Point(84, 15);
            this.searchFoodname.Margin = new System.Windows.Forms.Padding(4);
            this.searchFoodname.Multiline = false;
            this.searchFoodname.Name = "searchFoodname";
            this.searchFoodname.Padding = new System.Windows.Forms.Padding(7);
            this.searchFoodname.PasswordChar = false;
            this.searchFoodname.PlaceholderColor = System.Drawing.Color.DimGray;
            this.searchFoodname.PlaceholderText = "Tìm Món Ăn";
            this.searchFoodname.Size = new System.Drawing.Size(239, 36);
            this.searchFoodname.TabIndex = 9;
            this.searchFoodname.Texts = "";
            this.searchFoodname.UnderlinedStyle = true;
            this.searchFoodname._TextChanged += new System.EventHandler(this.searchFoodname__TextChanged);
            // 
            // dataGridViewFood
            // 
            this.dataGridViewFood.AllowUserToAddRows = false;
            this.dataGridViewFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFood.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewFood.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewFood.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(12)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFood.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFood.ColumnHeadersHeight = 40;
            this.dataGridViewFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodId,
            this.PictureFood,
            this.FoodName,
            this.FoodPrice,
            this.FoodNote});
            this.dataGridViewFood.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(12)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(148)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFood.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewFood.EnableHeadersVisualStyles = false;
            this.dataGridViewFood.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(12)))), ((int)(((byte)(74)))));
            this.dataGridViewFood.Location = new System.Drawing.Point(3, 80);
            this.dataGridViewFood.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewFood.Name = "dataGridViewFood";
            this.dataGridViewFood.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFood.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewFood.RowHeadersVisible = false;
            this.dataGridViewFood.RowHeadersWidth = 51;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewFood.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewFood.RowTemplate.Height = 100;
            this.dataGridViewFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFood.Size = new System.Drawing.Size(950, 569);
            this.dataGridViewFood.TabIndex = 0;
            this.dataGridViewFood.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFood_CellContentClick);
            // 
            // FoodId
            // 
            this.FoodId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.FoodId.DefaultCellStyle = dataGridViewCellStyle2;
            this.FoodId.HeaderText = "STT";
            this.FoodId.MinimumWidth = 6;
            this.FoodId.Name = "FoodId";
            this.FoodId.ReadOnly = true;
            this.FoodId.Width = 50;
            // 
            // PictureFood
            // 
            this.PictureFood.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            this.PictureFood.DefaultCellStyle = dataGridViewCellStyle3;
            this.PictureFood.HeaderText = "Ảnh";
            this.PictureFood.MinimumWidth = 6;
            this.PictureFood.Name = "PictureFood";
            this.PictureFood.ReadOnly = true;
            this.PictureFood.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PictureFood.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PictureFood.Width = 210;
            // 
            // FoodName
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.FoodName.DefaultCellStyle = dataGridViewCellStyle4;
            this.FoodName.HeaderText = "Tên Món Ăn";
            this.FoodName.MinimumWidth = 6;
            this.FoodName.Name = "FoodName";
            this.FoodName.ReadOnly = true;
            // 
            // FoodPrice
            // 
            this.FoodPrice.HeaderText = "Đơn Giá";
            this.FoodPrice.MinimumWidth = 6;
            this.FoodPrice.Name = "FoodPrice";
            this.FoodPrice.ReadOnly = true;
            // 
            // FoodNote
            // 
            this.FoodNote.HeaderText = "Ghi Chú";
            this.FoodNote.MinimumWidth = 6;
            this.FoodNote.Name = "FoodNote";
            this.FoodNote.ReadOnly = true;
            // 
            // Confirm
            // 
            this.Confirm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Confirm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Confirm.Location = new System.Drawing.Point(616, 578);
            this.Confirm.Margin = new System.Windows.Forms.Padding(2);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(0, 0);
            this.Confirm.TabIndex = 9;
            this.Confirm.Text = "Xac Nhan";
            this.Confirm.UseVisualStyleBackColor = false;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click_1);
            // 
            // Food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(962, 658);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Food";
            this.Text = "Food";
            this.Load += new System.EventHandler(this.Food_Load);
            this.Resize += new System.EventHandler(this.Food_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox SearchVenue;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn VenueId;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn VenueName;
        private System.Windows.Forms.DataGridViewTextBoxColumn VenueType;
        private System.Windows.Forms.DataGridViewTextBoxColumn VenueState;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ChangeVenue;
        private System.Windows.Forms.Button AddVenue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Confirm;
        private UIDesign.TextBoxTemplate searchFoodname;
        private UIDesign.RJButton btnDelete;
        private UIDesign.RJButton btnEdit;
        private UIDesign.RJButton btnAdd;
        private System.Windows.Forms.DataGridView dataGridViewFood;
        private UIDesign.RJButton XacNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodId;
        private System.Windows.Forms.DataGridViewImageColumn PictureFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodNote;
    }
}