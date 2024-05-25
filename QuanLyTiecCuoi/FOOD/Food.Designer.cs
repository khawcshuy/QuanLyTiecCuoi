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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Food));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dataGridViewFood = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.SearchFood = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ChangeFood = new System.Windows.Forms.Button();
            this.AddFood = new System.Windows.Forms.Button();
            this.Confirm = new System.Windows.Forms.Button();
            this.FoodId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PictureFood = new System.Windows.Forms.DataGridViewImageColumn();
            this.FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel2.Controls.Add(this.dataGridViewFood);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.SearchFood);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.ChangeFood);
            this.panel2.Controls.Add(this.AddFood);
            this.panel2.Location = new System.Drawing.Point(24, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(839, 574);
            this.panel2.TabIndex = 3;
            // 
            // dataGridViewFood
            // 
            this.dataGridViewFood.AllowUserToAddRows = false;
            this.dataGridViewFood.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.dataGridViewFood.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodId,
            this.PictureFood,
            this.FoodName,
            this.FoodPrice,
            this.FoodNote});
            this.dataGridViewFood.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFood.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewFood.GridColor = System.Drawing.Color.LightGray;
            this.dataGridViewFood.Location = new System.Drawing.Point(2, 80);
            this.dataGridViewFood.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewFood.Name = "dataGridViewFood";
            this.dataGridViewFood.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFood.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewFood.RowHeadersVisible = false;
            this.dataGridViewFood.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewFood.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewFood.RowTemplate.Height = 100;
            this.dataGridViewFood.Size = new System.Drawing.Size(835, 477);
            this.dataGridViewFood.TabIndex = 0;
            this.dataGridViewFood.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFood_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(648, 33);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 26);
            this.button1.TabIndex = 8;
            this.button1.Text = "- Xóa Mon An";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchFood
            // 
            this.SearchFood.Location = new System.Drawing.Point(210, 33);
            this.SearchFood.Margin = new System.Windows.Forms.Padding(2);
            this.SearchFood.Name = "SearchFood";
            this.SearchFood.Size = new System.Drawing.Size(135, 20);
            this.SearchFood.TabIndex = 7;
            this.SearchFood.TextChanged += new System.EventHandler(this.SearchFood_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tìm Món Ăn";
            // 
            // ChangeFood
            // 
            this.ChangeFood.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ChangeFood.Location = new System.Drawing.Point(510, 33);
            this.ChangeFood.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeFood.Name = "ChangeFood";
            this.ChangeFood.Size = new System.Drawing.Size(120, 26);
            this.ChangeFood.TabIndex = 5;
            this.ChangeFood.Text = "Chỉnh sửa sảnh";
            this.ChangeFood.UseVisualStyleBackColor = false;
            this.ChangeFood.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddFood
            // 
            this.AddFood.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddFood.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddFood.Location = new System.Drawing.Point(386, 33);
            this.AddFood.Margin = new System.Windows.Forms.Padding(2);
            this.AddFood.Name = "AddFood";
            this.AddFood.Size = new System.Drawing.Size(120, 26);
            this.AddFood.TabIndex = 4;
            this.AddFood.Text = "+ Thêm Mon An Mới";
            this.AddFood.UseVisualStyleBackColor = false;
            this.AddFood.Click += new System.EventHandler(this.AddFood_Click);
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
            // FoodId
            // 
            this.FoodId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.FoodId.DefaultCellStyle = dataGridViewCellStyle1;
            this.FoodId.HeaderText = "STT";
            this.FoodId.MinimumWidth = 6;
            this.FoodId.Name = "FoodId";
            this.FoodId.ReadOnly = true;
            this.FoodId.Width = 50;
            // 
            // PictureFood
            // 
            this.PictureFood.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            this.PictureFood.DefaultCellStyle = dataGridViewCellStyle2;
            this.PictureFood.HeaderText = "Ảnh";
            this.PictureFood.MinimumWidth = 6;
            this.PictureFood.Name = "PictureFood";
            this.PictureFood.ReadOnly = true;
            this.PictureFood.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PictureFood.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PictureFood.Width = 200;
            // 
            // FoodName
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.FoodName.DefaultCellStyle = dataGridViewCellStyle3;
            this.FoodName.HeaderText = "Tên Món Ăn";
            this.FoodName.MinimumWidth = 6;
            this.FoodName.Name = "FoodName";
            this.FoodName.ReadOnly = true;
            this.FoodName.Width = 175;
            // 
            // FoodPrice
            // 
            this.FoodPrice.HeaderText = "Đơn Giá";
            this.FoodPrice.MinimumWidth = 6;
            this.FoodPrice.Name = "FoodPrice";
            this.FoodPrice.ReadOnly = true;
            this.FoodPrice.Width = 150;
            // 
            // FoodNote
            // 
            this.FoodNote.HeaderText = "Ghi Chú";
            this.FoodNote.MinimumWidth = 6;
            this.FoodNote.Name = "FoodNote";
            this.FoodNote.ReadOnly = true;
            this.FoodNote.Width = 200;
            // 
            // Food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(874, 601);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Food";
            this.Text = "Food";
            this.Load += new System.EventHandler(this.Food_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SearchFood;
        private System.Windows.Forms.DataGridView dataGridViewFood;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ChangeFood;
        private System.Windows.Forms.Button AddFood;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodId;
        private System.Windows.Forms.DataGridViewImageColumn PictureFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodNote;
    }
}