namespace WeedingPartyBooking
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxTenChuRe = new System.Windows.Forms.TextBox();
            this.textBoxTenCoDau = new System.Windows.Forms.TextBox();
            this.textBoxDienThoai = new System.Windows.Forms.TextBox();
            this.textBoxTienDatCoc = new System.Windows.Forms.TextBox();
            this.textBoxSoLuongBan = new System.Windows.Forms.TextBox();
            this.textBoxSoBanDuTru = new System.Windows.Forms.TextBox();
            this.dateTimePickerNgayDaiTiec = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCa = new System.Windows.Forms.ComboBox();
            this.comboBoxSanh = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENMONANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dONGIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mONANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dATTIECUOIMONAN = new WeedingPartyBooking.DATTIECUOIMONAN();
            this.dATTIECUOIMONANINUSE = new WeedingPartyBooking.DATTIECUOIMONANINUSE();
            this.mONANINUSEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mONANINUSETableAdapter = new WeedingPartyBooking.DATTIECUOIMONANINUSETableAdapters.MONANINUSETableAdapter();
            this.fillByMonAnToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByMonAnToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mONANTableAdapter = new WeedingPartyBooking.DATTIECUOIMONANTableAdapters.MONANTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATTIECUOIMONAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATTIECUOIMONANINUSE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONANINUSEBindingSource)).BeginInit();
            this.fillByMonAnToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(518, 598);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Đặt Tiệc Cưới";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxTenChuRe
            // 
            this.textBoxTenChuRe.Location = new System.Drawing.Point(386, 86);
            this.textBoxTenChuRe.Name = "textBoxTenChuRe";
            this.textBoxTenChuRe.Size = new System.Drawing.Size(127, 20);
            this.textBoxTenChuRe.TabIndex = 1;
            // 
            // textBoxTenCoDau
            // 
            this.textBoxTenCoDau.Location = new System.Drawing.Point(386, 128);
            this.textBoxTenCoDau.Name = "textBoxTenCoDau";
            this.textBoxTenCoDau.Size = new System.Drawing.Size(127, 20);
            this.textBoxTenCoDau.TabIndex = 2;
            // 
            // textBoxDienThoai
            // 
            this.textBoxDienThoai.Location = new System.Drawing.Point(386, 169);
            this.textBoxDienThoai.Name = "textBoxDienThoai";
            this.textBoxDienThoai.Size = new System.Drawing.Size(127, 20);
            this.textBoxDienThoai.TabIndex = 3;
            // 
            // textBoxTienDatCoc
            // 
            this.textBoxTienDatCoc.Location = new System.Drawing.Point(565, 86);
            this.textBoxTienDatCoc.Name = "textBoxTienDatCoc";
            this.textBoxTienDatCoc.Size = new System.Drawing.Size(127, 20);
            this.textBoxTienDatCoc.TabIndex = 4;
            // 
            // textBoxSoLuongBan
            // 
            this.textBoxSoLuongBan.Location = new System.Drawing.Point(565, 128);
            this.textBoxSoLuongBan.Name = "textBoxSoLuongBan";
            this.textBoxSoLuongBan.Size = new System.Drawing.Size(127, 20);
            this.textBoxSoLuongBan.TabIndex = 5;
            // 
            // textBoxSoBanDuTru
            // 
            this.textBoxSoBanDuTru.Location = new System.Drawing.Point(565, 169);
            this.textBoxSoBanDuTru.Name = "textBoxSoBanDuTru";
            this.textBoxSoBanDuTru.Size = new System.Drawing.Size(127, 20);
            this.textBoxSoBanDuTru.TabIndex = 6;
            // 
            // dateTimePickerNgayDaiTiec
            // 
            this.dateTimePickerNgayDaiTiec.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgayDaiTiec.Location = new System.Drawing.Point(742, 86);
            this.dateTimePickerNgayDaiTiec.Name = "dateTimePickerNgayDaiTiec";
            this.dateTimePickerNgayDaiTiec.Size = new System.Drawing.Size(104, 20);
            this.dateTimePickerNgayDaiTiec.TabIndex = 7;
            // 
            // comboBoxCa
            // 
            this.comboBoxCa.FormattingEnabled = true;
            this.comboBoxCa.Items.AddRange(new object[] {
            "Trưa",
            "Tối"});
            this.comboBoxCa.Location = new System.Drawing.Point(742, 128);
            this.comboBoxCa.Name = "comboBoxCa";
            this.comboBoxCa.Size = new System.Drawing.Size(104, 21);
            this.comboBoxCa.TabIndex = 8;
            // 
            // comboBoxSanh
            // 
            this.comboBoxSanh.FormattingEnabled = true;
            this.comboBoxSanh.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.comboBoxSanh.Location = new System.Drawing.Point(742, 169);
            this.comboBoxSanh.Name = "comboBoxSanh";
            this.comboBoxSanh.Size = new System.Drawing.Size(104, 21);
            this.comboBoxSanh.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(669, 381);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 35);
            this.button3.TabIndex = 11;
            this.button3.Text = "Đặt Món Ăn";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.tENMONANDataGridViewTextBoxColumn,
            this.dONGIADataGridViewTextBoxColumn,
            this.nOTEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mONANBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(370, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(494, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "STT";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tENMONANDataGridViewTextBoxColumn
            // 
            this.tENMONANDataGridViewTextBoxColumn.DataPropertyName = "TENMONAN";
            this.tENMONANDataGridViewTextBoxColumn.HeaderText = "Tên Món Ăn";
            this.tENMONANDataGridViewTextBoxColumn.Name = "tENMONANDataGridViewTextBoxColumn";
            this.tENMONANDataGridViewTextBoxColumn.Width = 150;
            // 
            // dONGIADataGridViewTextBoxColumn
            // 
            this.dONGIADataGridViewTextBoxColumn.DataPropertyName = "DONGIA";
            this.dONGIADataGridViewTextBoxColumn.HeaderText = "Đơn Giá";
            this.dONGIADataGridViewTextBoxColumn.Name = "dONGIADataGridViewTextBoxColumn";
            // 
            // nOTEDataGridViewTextBoxColumn
            // 
            this.nOTEDataGridViewTextBoxColumn.DataPropertyName = "NOTE";
            this.nOTEDataGridViewTextBoxColumn.HeaderText = "Ghi Chú";
            this.nOTEDataGridViewTextBoxColumn.Name = "nOTEDataGridViewTextBoxColumn";
            // 
            // mONANBindingSource
            // 
            this.mONANBindingSource.DataMember = "MONAN";
            this.mONANBindingSource.DataSource = this.dATTIECUOIMONAN;
            // 
            // dATTIECUOIMONAN
            // 
            this.dATTIECUOIMONAN.DataSetName = "DATTIECUOIMONAN";
            this.dATTIECUOIMONAN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dATTIECUOIMONANINUSE
            // 
            this.dATTIECUOIMONANINUSE.DataSetName = "DATTIECUOIMONANINUSE";
            this.dATTIECUOIMONANINUSE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mONANINUSEBindingSource
            // 
            this.mONANINUSEBindingSource.DataMember = "MONANINUSE";
            this.mONANINUSEBindingSource.DataSource = this.dATTIECUOIMONANINUSE;
            // 
            // mONANINUSETableAdapter
            // 
            this.mONANINUSETableAdapter.ClearBeforeFill = true;
            // 
            // fillByMonAnToolStrip
            // 
            this.fillByMonAnToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByMonAnToolStripButton});
            this.fillByMonAnToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByMonAnToolStrip.Name = "fillByMonAnToolStrip";
            this.fillByMonAnToolStrip.Size = new System.Drawing.Size(1324, 25);
            this.fillByMonAnToolStrip.TabIndex = 13;
            this.fillByMonAnToolStrip.Text = "fillByMonAnToolStrip";
            this.fillByMonAnToolStrip.Visible = false;
            // 
            // fillByMonAnToolStripButton
            // 
            this.fillByMonAnToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByMonAnToolStripButton.Name = "fillByMonAnToolStripButton";
            this.fillByMonAnToolStripButton.Size = new System.Drawing.Size(79, 22);
            this.fillByMonAnToolStripButton.Text = "FillByMonAn";
            this.fillByMonAnToolStripButton.Click += new System.EventHandler(this.fillByMonAnToolStripButton_Click);
            // 
            // mONANTableAdapter
            // 
            this.mONANTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(473, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 32);
            this.button2.TabIndex = 14;
            this.button2.Text = "Đặt Dịch Vụ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(370, 431);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(494, 150);
            this.dataGridView2.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 671);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.fillByMonAnToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBoxSanh);
            this.Controls.Add(this.comboBoxCa);
            this.Controls.Add(this.dateTimePickerNgayDaiTiec);
            this.Controls.Add(this.textBoxSoBanDuTru);
            this.Controls.Add(this.textBoxSoLuongBan);
            this.Controls.Add(this.textBoxTienDatCoc);
            this.Controls.Add(this.textBoxDienThoai);
            this.Controls.Add(this.textBoxTenCoDau);
            this.Controls.Add(this.textBoxTenChuRe);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATTIECUOIMONAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATTIECUOIMONANINUSE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONANINUSEBindingSource)).EndInit();
            this.fillByMonAnToolStrip.ResumeLayout(false);
            this.fillByMonAnToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxTenChuRe;
        private System.Windows.Forms.TextBox textBoxTenCoDau;
        private System.Windows.Forms.TextBox textBoxDienThoai;
        private System.Windows.Forms.TextBox textBoxTienDatCoc;
        private System.Windows.Forms.TextBox textBoxSoLuongBan;
        private System.Windows.Forms.TextBox textBoxSoBanDuTru;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayDaiTiec;
        private System.Windows.Forms.ComboBox comboBoxCa;
        private System.Windows.Forms.ComboBox comboBoxSanh;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DATTIECUOIMONANINUSE dATTIECUOIMONANINUSE;
        private System.Windows.Forms.BindingSource mONANINUSEBindingSource;
        private DATTIECUOIMONANINUSETableAdapters.MONANINUSETableAdapter mONANINUSETableAdapter;
        private DATTIECUOIMONAN dATTIECUOIMONAN;
        private System.Windows.Forms.BindingSource mONANBindingSource;
        private DATTIECUOIMONANTableAdapters.MONANTableAdapter mONANTableAdapter;
        private System.Windows.Forms.ToolStrip fillByMonAnToolStrip;
        private System.Windows.Forms.ToolStripButton fillByMonAnToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENMONANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dONGIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

