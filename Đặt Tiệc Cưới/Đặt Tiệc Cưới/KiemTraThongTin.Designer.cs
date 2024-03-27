namespace Đặt_Tiệc_Cưới
{
    partial class KiemTraThongTin
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
            this.luuTruThongTin = new Đặt_Tiệc_Cưới.LuuTruThongTin();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new Đặt_Tiệc_Cưới.LuuTruThongTinTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new Đặt_Tiệc_Cưới.LuuTruThongTinTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenChuReDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenCoDauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienThoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDaiTiecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soBanDuTruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienDatCocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.luuTruThongTin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(247, 529);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 57);
            this.button1.TabIndex = 2;
            this.button1.Text = "Xóa Tiệc Cưới";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(670, 529);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 57);
            this.button2.TabIndex = 3;
            this.button2.Text = "Sửa Tiệc Cưới";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 50);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thông Tin Đặt Tiệc Cưới";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(324, 29);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(472, 101);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tenChuReDataGridViewTextBoxColumn,
            this.tenCoDauDataGridViewTextBoxColumn,
            this.dienThoaiDataGridViewTextBoxColumn,
            this.ngayDaiTiecDataGridViewTextBoxColumn,
            this.caDataGridViewTextBoxColumn,
            this.sanhDataGridViewTextBoxColumn,
            this.soLuongBanDataGridViewTextBoxColumn,
            this.soBanDuTruDataGridViewTextBoxColumn,
            this.tienDatCocDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(52, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1043, 325);
            this.dataGridView1.TabIndex = 6;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenChuReDataGridViewTextBoxColumn
            // 
            this.tenChuReDataGridViewTextBoxColumn.DataPropertyName = "TenChuRe";
            this.tenChuReDataGridViewTextBoxColumn.HeaderText = "TenChuRe";
            this.tenChuReDataGridViewTextBoxColumn.Name = "tenChuReDataGridViewTextBoxColumn";
            // 
            // tenCoDauDataGridViewTextBoxColumn
            // 
            this.tenCoDauDataGridViewTextBoxColumn.DataPropertyName = "TenCoDau";
            this.tenCoDauDataGridViewTextBoxColumn.HeaderText = "TenCoDau";
            this.tenCoDauDataGridViewTextBoxColumn.Name = "tenCoDauDataGridViewTextBoxColumn";
            // 
            // dienThoaiDataGridViewTextBoxColumn
            // 
            this.dienThoaiDataGridViewTextBoxColumn.DataPropertyName = "DienThoai";
            this.dienThoaiDataGridViewTextBoxColumn.HeaderText = "DienThoai";
            this.dienThoaiDataGridViewTextBoxColumn.Name = "dienThoaiDataGridViewTextBoxColumn";
            // 
            // ngayDaiTiecDataGridViewTextBoxColumn
            // 
            this.ngayDaiTiecDataGridViewTextBoxColumn.DataPropertyName = "NgayDaiTiec";
            this.ngayDaiTiecDataGridViewTextBoxColumn.HeaderText = "NgayDaiTiec";
            this.ngayDaiTiecDataGridViewTextBoxColumn.Name = "ngayDaiTiecDataGridViewTextBoxColumn";
            // 
            // caDataGridViewTextBoxColumn
            // 
            this.caDataGridViewTextBoxColumn.DataPropertyName = "Ca";
            this.caDataGridViewTextBoxColumn.HeaderText = "Ca";
            this.caDataGridViewTextBoxColumn.Name = "caDataGridViewTextBoxColumn";
            // 
            // sanhDataGridViewTextBoxColumn
            // 
            this.sanhDataGridViewTextBoxColumn.DataPropertyName = "Sanh";
            this.sanhDataGridViewTextBoxColumn.HeaderText = "Sanh";
            this.sanhDataGridViewTextBoxColumn.Name = "sanhDataGridViewTextBoxColumn";
            // 
            // soLuongBanDataGridViewTextBoxColumn
            // 
            this.soLuongBanDataGridViewTextBoxColumn.DataPropertyName = "SoLuongBan";
            this.soLuongBanDataGridViewTextBoxColumn.HeaderText = "SoLuongBan";
            this.soLuongBanDataGridViewTextBoxColumn.Name = "soLuongBanDataGridViewTextBoxColumn";
            // 
            // soBanDuTruDataGridViewTextBoxColumn
            // 
            this.soBanDuTruDataGridViewTextBoxColumn.DataPropertyName = "SoBanDuTru";
            this.soBanDuTruDataGridViewTextBoxColumn.HeaderText = "SoBanDuTru";
            this.soBanDuTruDataGridViewTextBoxColumn.Name = "soBanDuTruDataGridViewTextBoxColumn";
            // 
            // tienDatCocDataGridViewTextBoxColumn
            // 
            this.tienDatCocDataGridViewTextBoxColumn.DataPropertyName = "TienDatCoc";
            this.tienDatCocDataGridViewTextBoxColumn.HeaderText = "TienDatCoc";
            this.tienDatCocDataGridViewTextBoxColumn.Name = "tienDatCocDataGridViewTextBoxColumn";
            // 
            // KiemTraThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 613);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Name = "KiemTraThongTin";
            this.Text = "KiemTraThongTin";
            this.Load += new System.EventHandler(this.KiemTraThongTin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.luuTruThongTin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LuuTruThongTin luuTruThongTin;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private LuuTruThongTinTableAdapters.TableTableAdapter tableTableAdapter;
        private LuuTruThongTinTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenChuReDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenCoDauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienThoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDaiTiecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sanhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soBanDuTruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienDatCocDataGridViewTextBoxColumn;
    }
}