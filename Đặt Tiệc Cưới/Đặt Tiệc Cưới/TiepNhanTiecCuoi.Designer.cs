namespace Đặt_Tiệc_Cưới
{
    partial class TiepNhanTiecCuoi
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
            System.Windows.Forms.Label tenChuReLabel;
            System.Windows.Forms.Label tenCoDauLabel;
            System.Windows.Forms.Label dienThoaiLabel;
            System.Windows.Forms.Label ngayDaiTiecLabel;
            System.Windows.Forms.Label caLabel;
            System.Windows.Forms.Label sanhLabel;
            System.Windows.Forms.Label soLuongBanLabel;
            System.Windows.Forms.Label soBanDuTruLabel;
            System.Windows.Forms.Label tienDatCocLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TiepNhanTiecCuoi));
            this.luuTruThongTin = new Đặt_Tiệc_Cưới.LuuTruThongTin();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new Đặt_Tiệc_Cưới.LuuTruThongTinTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new Đặt_Tiệc_Cưới.LuuTruThongTinTableAdapters.TableAdapterManager();
            this.tableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tenChuReTextBox = new System.Windows.Forms.TextBox();
            this.tenCoDauTextBox = new System.Windows.Forms.TextBox();
            this.dienThoaiTextBox = new System.Windows.Forms.TextBox();
            this.ngayDaiTiecDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.soLuongBanTextBox = new System.Windows.Forms.TextBox();
            this.soBanDuTruTextBox = new System.Windows.Forms.TextBox();
            this.tienDatCocTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            tenChuReLabel = new System.Windows.Forms.Label();
            tenCoDauLabel = new System.Windows.Forms.Label();
            dienThoaiLabel = new System.Windows.Forms.Label();
            ngayDaiTiecLabel = new System.Windows.Forms.Label();
            caLabel = new System.Windows.Forms.Label();
            sanhLabel = new System.Windows.Forms.Label();
            soLuongBanLabel = new System.Windows.Forms.Label();
            soBanDuTruLabel = new System.Windows.Forms.Label();
            tienDatCocLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.luuTruThongTin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).BeginInit();
            this.tableBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // tenChuReLabel
            // 
            tenChuReLabel.AutoSize = true;
            tenChuReLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            tenChuReLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenChuReLabel.Location = new System.Drawing.Point(320, 170);
            tenChuReLabel.Name = "tenChuReLabel";
            tenChuReLabel.Size = new System.Drawing.Size(91, 17);
            tenChuReLabel.TabIndex = 3;
            tenChuReLabel.Text = "Tên Chú Rể:";
            tenChuReLabel.Click += new System.EventHandler(this.tenChuReLabel_Click);
            // 
            // tenCoDauLabel
            // 
            tenCoDauLabel.AutoSize = true;
            tenCoDauLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            tenCoDauLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenCoDauLabel.Location = new System.Drawing.Point(645, 170);
            tenCoDauLabel.Name = "tenCoDauLabel";
            tenCoDauLabel.Size = new System.Drawing.Size(91, 17);
            tenCoDauLabel.TabIndex = 5;
            tenCoDauLabel.Text = "Tên Cô Dâu:";
            // 
            // dienThoaiLabel
            // 
            dienThoaiLabel.AutoSize = true;
            dienThoaiLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dienThoaiLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dienThoaiLabel.Location = new System.Drawing.Point(330, 215);
            dienThoaiLabel.Name = "dienThoaiLabel";
            dienThoaiLabel.Size = new System.Drawing.Size(82, 17);
            dienThoaiLabel.TabIndex = 7;
            dienThoaiLabel.Text = "Điện Thoại:";
            // 
            // ngayDaiTiecLabel
            // 
            ngayDaiTiecLabel.AutoSize = true;
            ngayDaiTiecLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            ngayDaiTiecLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ngayDaiTiecLabel.Location = new System.Drawing.Point(635, 215);
            ngayDaiTiecLabel.Name = "ngayDaiTiecLabel";
            ngayDaiTiecLabel.Size = new System.Drawing.Size(102, 17);
            ngayDaiTiecLabel.TabIndex = 9;
            ngayDaiTiecLabel.Text = "Ngày Đãi Tiệc:";
            // 
            // caLabel
            // 
            caLabel.AutoSize = true;
            caLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            caLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            caLabel.Location = new System.Drawing.Point(380, 260);
            caLabel.Name = "caLabel";
            caLabel.Size = new System.Drawing.Size(31, 17);
            caLabel.TabIndex = 11;
            caLabel.Text = "Ca:";
            // 
            // sanhLabel
            // 
            sanhLabel.AutoSize = true;
            sanhLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            sanhLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sanhLabel.Location = new System.Drawing.Point(690, 260);
            sanhLabel.Name = "sanhLabel";
            sanhLabel.Size = new System.Drawing.Size(46, 17);
            sanhLabel.TabIndex = 13;
            sanhLabel.Text = "Sảnh:";
            // 
            // soLuongBanLabel
            // 
            soLuongBanLabel.AutoSize = true;
            soLuongBanLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            soLuongBanLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            soLuongBanLabel.Location = new System.Drawing.Point(305, 305);
            soLuongBanLabel.Name = "soLuongBanLabel";
            soLuongBanLabel.Size = new System.Drawing.Size(108, 17);
            soLuongBanLabel.TabIndex = 15;
            soLuongBanLabel.Text = "Số Lượng Bàn:";
            // 
            // soBanDuTruLabel
            // 
            soBanDuTruLabel.AutoSize = true;
            soBanDuTruLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            soBanDuTruLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            soBanDuTruLabel.Location = new System.Drawing.Point(625, 305);
            soBanDuTruLabel.Name = "soBanDuTruLabel";
            soBanDuTruLabel.Size = new System.Drawing.Size(112, 17);
            soBanDuTruLabel.TabIndex = 17;
            soBanDuTruLabel.Text = "Số Bàn Dự Trữ:";
            // 
            // tienDatCocLabel
            // 
            tienDatCocLabel.AutoSize = true;
            tienDatCocLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            tienDatCocLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tienDatCocLabel.Location = new System.Drawing.Point(313, 350);
            tienDatCocLabel.Name = "tienDatCocLabel";
            tienDatCocLabel.Size = new System.Drawing.Size(97, 17);
            tienDatCocLabel.TabIndex = 19;
            tienDatCocLabel.Text = "Tiền Đặt Cọc:";
            // 
            // luuTruThongTin
            // 
            this.luuTruThongTin.DataSetName = "LuuTruThongTin";
            this.luuTruThongTin.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.luuTruThongTin;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = Đặt_Tiệc_Cưới.LuuTruThongTinTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableBindingNavigator
            // 
            this.tableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tableBindingNavigator.BindingSource = this.tableBindingSource;
            this.tableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tableBindingNavigatorSaveItem});
            this.tableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tableBindingNavigator.Name = "tableBindingNavigator";
            this.tableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tableBindingNavigator.Size = new System.Drawing.Size(1264, 25);
            this.tableBindingNavigator.TabIndex = 0;
            this.tableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tableBindingNavigatorSaveItem
            // 
            this.tableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tableBindingNavigatorSaveItem.Image")));
            this.tableBindingNavigatorSaveItem.Name = "tableBindingNavigatorSaveItem";
            this.tableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tableBindingNavigatorSaveItem.Text = "Save Data";
            this.tableBindingNavigatorSaveItem.Click += new System.EventHandler(this.tableBindingNavigatorSaveItem_Click);
            // 
            // tenChuReTextBox
            // 
            this.tenChuReTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "TenChuRe", true));
            this.tenChuReTextBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenChuReTextBox.Location = new System.Drawing.Point(409, 166);
            this.tenChuReTextBox.Name = "tenChuReTextBox";
            this.tenChuReTextBox.Size = new System.Drawing.Size(169, 25);
            this.tenChuReTextBox.TabIndex = 4;
            // 
            // tenCoDauTextBox
            // 
            this.tenCoDauTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "TenCoDau", true));
            this.tenCoDauTextBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenCoDauTextBox.Location = new System.Drawing.Point(734, 166);
            this.tenCoDauTextBox.Name = "tenCoDauTextBox";
            this.tenCoDauTextBox.Size = new System.Drawing.Size(169, 25);
            this.tenCoDauTextBox.TabIndex = 6;
            // 
            // dienThoaiTextBox
            // 
            this.dienThoaiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "DienThoai", true));
            this.dienThoaiTextBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dienThoaiTextBox.Location = new System.Drawing.Point(409, 212);
            this.dienThoaiTextBox.Name = "dienThoaiTextBox";
            this.dienThoaiTextBox.Size = new System.Drawing.Size(115, 25);
            this.dienThoaiTextBox.TabIndex = 8;
            // 
            // ngayDaiTiecDateTimePicker
            // 
            this.ngayDaiTiecDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tableBindingSource, "NgayDaiTiec", true));
            this.ngayDaiTiecDateTimePicker.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngayDaiTiecDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngayDaiTiecDateTimePicker.Location = new System.Drawing.Point(734, 212);
            this.ngayDaiTiecDateTimePicker.Name = "ngayDaiTiecDateTimePicker";
            this.ngayDaiTiecDateTimePicker.Size = new System.Drawing.Size(98, 25);
            this.ngayDaiTiecDateTimePicker.TabIndex = 10;
            // 
            // soLuongBanTextBox
            // 
            this.soLuongBanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "SoLuongBan", true));
            this.soLuongBanTextBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soLuongBanTextBox.Location = new System.Drawing.Point(409, 303);
            this.soLuongBanTextBox.Name = "soLuongBanTextBox";
            this.soLuongBanTextBox.Size = new System.Drawing.Size(67, 25);
            this.soLuongBanTextBox.TabIndex = 16;
            // 
            // soBanDuTruTextBox
            // 
            this.soBanDuTruTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "SoBanDuTru", true));
            this.soBanDuTruTextBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soBanDuTruTextBox.Location = new System.Drawing.Point(734, 303);
            this.soBanDuTruTextBox.Name = "soBanDuTruTextBox";
            this.soBanDuTruTextBox.Size = new System.Drawing.Size(67, 25);
            this.soBanDuTruTextBox.TabIndex = 18;
            // 
            // tienDatCocTextBox
            // 
            this.tienDatCocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "TienDatCoc", true));
            this.tienDatCocTextBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tienDatCocTextBox.Location = new System.Drawing.Point(409, 347);
            this.tienDatCocTextBox.Name = "tienDatCocTextBox";
            this.tienDatCocTextBox.Size = new System.Drawing.Size(115, 25);
            this.tienDatCocTextBox.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(515, 551);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 70);
            this.button1.TabIndex = 21;
            this.button1.Text = "Kiểm Tra Thông Tin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(515, 450);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 70);
            this.button2.TabIndex = 22;
            this.button2.Text = "Đặt Tiệc Cưới";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Trưa",
            "Tối"});
            this.comboBox1.Location = new System.Drawing.Point(409, 257);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(67, 25);
            this.comboBox1.TabIndex = 23;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.comboBox2.Location = new System.Drawing.Point(734, 257);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(67, 25);
            this.comboBox2.TabIndex = 24;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(273, 141);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(677, 260);
            this.listView1.TabIndex = 25;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(418, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 56);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tiếp Nhận Tiệc Cưới";
            // 
            // TiepNhanTiecCuoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tenChuReTextBox);
            this.Controls.Add(this.tenCoDauTextBox);
            this.Controls.Add(this.dienThoaiTextBox);
            this.Controls.Add(this.ngayDaiTiecDateTimePicker);
            this.Controls.Add(caLabel);
            this.Controls.Add(sanhLabel);
            this.Controls.Add(this.soLuongBanTextBox);
            this.Controls.Add(this.soBanDuTruTextBox);
            this.Controls.Add(this.tienDatCocTextBox);
            this.Controls.Add(this.tableBindingNavigator);
            this.Controls.Add(tenChuReLabel);
            this.Controls.Add(tenCoDauLabel);
            this.Controls.Add(dienThoaiLabel);
            this.Controls.Add(ngayDaiTiecLabel);
            this.Controls.Add(soLuongBanLabel);
            this.Controls.Add(soBanDuTruLabel);
            this.Controls.Add(tienDatCocLabel);
            this.Controls.Add(this.listView1);
            this.Name = "TiepNhanTiecCuoi";
            this.Text = "Đặt Tiệc Cưới";
            this.Load += new System.EventHandler(this.TiepNhanTiecCuoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.luuTruThongTin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).EndInit();
            this.tableBindingNavigator.ResumeLayout(false);
            this.tableBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LuuTruThongTin luuTruThongTin;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private LuuTruThongTinTableAdapters.TableTableAdapter tableTableAdapter;
        private LuuTruThongTinTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox tenChuReTextBox;
        private System.Windows.Forms.TextBox tenCoDauTextBox;
        private System.Windows.Forms.TextBox dienThoaiTextBox;
        private System.Windows.Forms.DateTimePicker ngayDaiTiecDateTimePicker;
        private System.Windows.Forms.TextBox soLuongBanTextBox;
        private System.Windows.Forms.TextBox soBanDuTruTextBox;
        private System.Windows.Forms.TextBox tienDatCocTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
    }
}

