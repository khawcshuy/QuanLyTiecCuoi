namespace WeedingPartyBooking
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIENTHOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENCHUREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENCODAUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sANHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngày = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giờ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOLUONGBANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHONGTINKHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dATTIECUOIDataSet = new WeedingPartyBooking.DATTIECUOIDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tHONGTINKHACHHANGTableAdapter = new WeedingPartyBooking.DATTIECUOIDataSetTableAdapters.THONGTINKHACHHANGTableAdapter();
            this.dIENTHOAIToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.dIENTHOAIToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillBySoDienThoaiToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillBySoDienThoaiToolStrip = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHONGTINKHACHHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATTIECUOIDataSet)).BeginInit();
            this.fillBySoDienThoaiToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.DIENTHOAI,
            this.tENCHUREDataGridViewTextBoxColumn,
            this.tENCODAUDataGridViewTextBoxColumn,
            this.sANHDataGridViewTextBoxColumn,
            this.Ngày,
            this.Giờ,
            this.sOLUONGBANDataGridViewTextBoxColumn,
            this.CA});
            this.dataGridView1.DataSource = this.tHONGTINKHACHHANGBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(180, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 416);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "STT";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DIENTHOAI
            // 
            this.DIENTHOAI.DataPropertyName = "DIENTHOAI";
            this.DIENTHOAI.HeaderText = "DIENTHOAI";
            this.DIENTHOAI.Name = "DIENTHOAI";
            this.DIENTHOAI.Visible = false;
            // 
            // tENCHUREDataGridViewTextBoxColumn
            // 
            this.tENCHUREDataGridViewTextBoxColumn.DataPropertyName = "TENCHURE";
            this.tENCHUREDataGridViewTextBoxColumn.HeaderText = "Tên Chú Rể";
            this.tENCHUREDataGridViewTextBoxColumn.Name = "tENCHUREDataGridViewTextBoxColumn";
            // 
            // tENCODAUDataGridViewTextBoxColumn
            // 
            this.tENCODAUDataGridViewTextBoxColumn.DataPropertyName = "TENCODAU";
            this.tENCODAUDataGridViewTextBoxColumn.HeaderText = "Tên Cô Dâu";
            this.tENCODAUDataGridViewTextBoxColumn.Name = "tENCODAUDataGridViewTextBoxColumn";
            // 
            // sANHDataGridViewTextBoxColumn
            // 
            this.sANHDataGridViewTextBoxColumn.DataPropertyName = "SANH";
            this.sANHDataGridViewTextBoxColumn.HeaderText = "Sảnh";
            this.sANHDataGridViewTextBoxColumn.Name = "sANHDataGridViewTextBoxColumn";
            // 
            // Ngày
            // 
            this.Ngày.DataPropertyName = "NGAYDAITIEC";
            this.Ngày.HeaderText = "Ngày";
            this.Ngày.Name = "Ngày";
            // 
            // Giờ
            // 
            this.Giờ.DataPropertyName = "Giờ";
            this.Giờ.HeaderText = "Giờ";
            this.Giờ.Name = "Giờ";
            // 
            // sOLUONGBANDataGridViewTextBoxColumn
            // 
            this.sOLUONGBANDataGridViewTextBoxColumn.DataPropertyName = "SOLUONGBAN";
            this.sOLUONGBANDataGridViewTextBoxColumn.HeaderText = "Số Lượng Bàn";
            this.sOLUONGBANDataGridViewTextBoxColumn.Name = "sOLUONGBANDataGridViewTextBoxColumn";
            // 
            // CA
            // 
            this.CA.DataPropertyName = "CA";
            this.CA.HeaderText = "CA";
            this.CA.Name = "CA";
            this.CA.Visible = false;
            // 
            // tHONGTINKHACHHANGBindingSource
            // 
            this.tHONGTINKHACHHANGBindingSource.DataMember = "THONGTINKHACHHANG";
            this.tHONGTINKHACHHANGBindingSource.DataSource = this.dATTIECUOIDataSet;
            // 
            // dATTIECUOIDataSet
            // 
            this.dATTIECUOIDataSet.DataSetName = "DATTIECUOIDataSet";
            this.dATTIECUOIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(544, 565);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tra Cứu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Montserrat ExtraBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 76);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh Sách Tiệc Cưới";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(428, 572);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 20);
            this.textBox1.TabIndex = 3;
            // 
            // tHONGTINKHACHHANGTableAdapter
            // 
            this.tHONGTINKHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // dIENTHOAIToolStripLabel
            // 
            this.dIENTHOAIToolStripLabel.Name = "dIENTHOAIToolStripLabel";
            this.dIENTHOAIToolStripLabel.Size = new System.Drawing.Size(71, 22);
            this.dIENTHOAIToolStripLabel.Text = "DIENTHOAI:";
            this.dIENTHOAIToolStripLabel.Visible = false;
            // 
            // dIENTHOAIToolStripTextBox
            // 
            this.dIENTHOAIToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dIENTHOAIToolStripTextBox.Name = "dIENTHOAIToolStripTextBox";
            this.dIENTHOAIToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            this.dIENTHOAIToolStripTextBox.Visible = false;
            // 
            // fillBySoDienThoaiToolStripButton
            // 
            this.fillBySoDienThoaiToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBySoDienThoaiToolStripButton.Name = "fillBySoDienThoaiToolStripButton";
            this.fillBySoDienThoaiToolStripButton.Size = new System.Drawing.Size(105, 22);
            this.fillBySoDienThoaiToolStripButton.Text = "FillBySoDienThoai";
            this.fillBySoDienThoaiToolStripButton.Visible = false;
            this.fillBySoDienThoaiToolStripButton.Click += new System.EventHandler(this.fillBySoDienThoaiToolStripButton_Click);
            // 
            // fillBySoDienThoaiToolStrip
            // 
            this.fillBySoDienThoaiToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dIENTHOAIToolStripLabel,
            this.dIENTHOAIToolStripTextBox,
            this.fillBySoDienThoaiToolStripButton});
            this.fillBySoDienThoaiToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBySoDienThoaiToolStrip.Name = "fillBySoDienThoaiToolStrip";
            this.fillBySoDienThoaiToolStrip.Size = new System.Drawing.Size(1084, 25);
            this.fillBySoDienThoaiToolStrip.TabIndex = 4;
            this.fillBySoDienThoaiToolStrip.Text = "fillBySoDienThoaiToolStrip";
            // 
            // TraCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.fillBySoDienThoaiToolStrip);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TraCuu";
            this.Text = "TraCuu";
            this.Load += new System.EventHandler(this.TraCuu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHONGTINKHACHHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATTIECUOIDataSet)).EndInit();
            this.fillBySoDienThoaiToolStrip.ResumeLayout(false);
            this.fillBySoDienThoaiToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DATTIECUOIDataSet dATTIECUOIDataSet;
        private System.Windows.Forms.BindingSource tHONGTINKHACHHANGBindingSource;
        private DATTIECUOIDataSetTableAdapters.THONGTINKHACHHANGTableAdapter tHONGTINKHACHHANGTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIENTHOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENCHUREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENCODAUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sANHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngày;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giờ;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOLUONGBANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CA;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripLabel dIENTHOAIToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox dIENTHOAIToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillBySoDienThoaiToolStripButton;
        private System.Windows.Forms.ToolStrip fillBySoDienThoaiToolStrip;
    }
}