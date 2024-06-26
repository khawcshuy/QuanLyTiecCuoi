using System.Windows.Forms;

namespace QuanLyTiecCuoi
{
    partial class Receipt
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.TTHD = new System.Windows.Forms.Panel();
            this.IdKhachhang = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.Bride = new System.Windows.Forms.TextBox();
            this.Groom = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.OrderDate = new System.Windows.Forms.DateTimePicker();
            this.admin = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label123 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ServiceView = new System.Windows.Forms.DataGridView();
            this.Menuview = new System.Windows.Forms.DataGridView();
            this.Service = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.Label();
            this.tiecId = new System.Windows.Forms.TextBox();
            this.btnSearchClick = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.XacNhan = new QuanLyTiecCuoi.UIDesign.RJButton();
            this.SearchTiecAndKhachHang = new System.Windows.Forms.DataGridView();
            this.IdTiec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerNameFind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.Discount = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Paidment = new System.Windows.Forms.TextBox();
            this.deposit = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.TextBox();
            this.DateLate = new System.Windows.Forms.TextBox();
            this.PenaltyRatio = new System.Windows.Forms.TextBox();
            this.totalService = new System.Windows.Forms.TextBox();
            this.totalMenu = new System.Windows.Forms.TextBox();
            this.NumberofTable = new System.Windows.Forms.TextBox();
            this.VenueFee = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TTHD.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menuview)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchTiecAndKhachHang)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "LẬP HÓA ĐƠN";
            // 
            // TTHD
            // 
            this.TTHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TTHD.Controls.Add(this.IdKhachhang);
            this.TTHD.Controls.Add(this.label23);
            this.TTHD.Controls.Add(this.Bride);
            this.TTHD.Controls.Add(this.Groom);
            this.TTHD.Controls.Add(this.Phone);
            this.TTHD.Controls.Add(this.Email);
            this.TTHD.Controls.Add(this.Address);
            this.TTHD.Controls.Add(this.CustomerName);
            this.TTHD.Controls.Add(this.Date);
            this.TTHD.Controls.Add(this.OrderDate);
            this.TTHD.Controls.Add(this.admin);
            this.TTHD.Controls.Add(this.label17);
            this.TTHD.Controls.Add(this.label3);
            this.TTHD.Controls.Add(this.label15);
            this.TTHD.Controls.Add(this.label19);
            this.TTHD.Controls.Add(this.label18);
            this.TTHD.Controls.Add(this.label22);
            this.TTHD.Controls.Add(this.label21);
            this.TTHD.Controls.Add(this.label30);
            this.TTHD.Controls.Add(this.label20);
            this.TTHD.Location = new System.Drawing.Point(7, 54);
            this.TTHD.Name = "TTHD";
            this.TTHD.Size = new System.Drawing.Size(808, 190);
            this.TTHD.TabIndex = 1;
            // 
            // IdKhachhang
            // 
            this.IdKhachhang.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdKhachhang.Location = new System.Drawing.Point(553, 150);
            this.IdKhachhang.Name = "IdKhachhang";
            this.IdKhachhang.Size = new System.Drawing.Size(182, 22);
            this.IdKhachhang.TabIndex = 23;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(439, 153);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(109, 14);
            this.label23.TabIndex = 22;
            this.label23.Text = "Mã Khách Hàng:";
            // 
            // Bride
            // 
            this.Bride.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bride.Location = new System.Drawing.Point(553, 116);
            this.Bride.Name = "Bride";
            this.Bride.Size = new System.Drawing.Size(182, 22);
            this.Bride.TabIndex = 21;
            // 
            // Groom
            // 
            this.Groom.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Groom.Location = new System.Drawing.Point(553, 83);
            this.Groom.Name = "Groom";
            this.Groom.Size = new System.Drawing.Size(182, 22);
            this.Groom.TabIndex = 20;
            // 
            // Phone
            // 
            this.Phone.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.Location = new System.Drawing.Point(553, 49);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(182, 22);
            this.Phone.TabIndex = 19;
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(553, 15);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(182, 22);
            this.Email.TabIndex = 18;
            // 
            // Address
            // 
            this.Address.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(195, 150);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(182, 22);
            this.Address.TabIndex = 17;
            // 
            // CustomerName
            // 
            this.CustomerName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerName.Location = new System.Drawing.Point(195, 116);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(182, 22);
            this.CustomerName.TabIndex = 16;
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(195, 83);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(182, 20);
            this.Date.TabIndex = 15;
            // 
            // OrderDate
            // 
            this.OrderDate.Location = new System.Drawing.Point(195, 49);
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.Size = new System.Drawing.Size(182, 20);
            this.OrderDate.TabIndex = 14;
            // 
            // admin
            // 
            this.admin.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin.Location = new System.Drawing.Point(195, 15);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(182, 22);
            this.admin.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(503, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 14);
            this.label17.TabIndex = 10;
            this.label17.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(462, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tên Cô Dâu:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(463, 85);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 14);
            this.label15.TabIndex = 8;
            this.label15.Text = "Tên Chú Rể:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(64, 153);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 14);
            this.label19.TabIndex = 7;
            this.label19.Text = "Địa Chỉ:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(450, 50);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(98, 14);
            this.label18.TabIndex = 6;
            this.label18.Text = "Số Điện Thoại:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(63, 83);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(126, 14);
            this.label22.TabIndex = 4;
            this.label22.Text = "Ngày Tổ Chức Tiệc:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(63, 50);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(98, 14);
            this.label21.TabIndex = 3;
            this.label21.Text = "Ngày Đặt Tiệc:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(63, 119);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(102, 14);
            this.label30.TabIndex = 2;
            this.label30.Text = "Người Đặt Tiệc:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(62, 18);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(133, 14);
            this.label20.TabIndex = 1;
            this.label20.Text = "Người Lập Hóa Đơn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "THÔNG TIN HÓA ĐƠN";
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label123.Location = new System.Drawing.Point(633, 15);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(65, 16);
            this.label123.TabIndex = 5;
            this.label123.Text = "Mã Tiệc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "DANH SÁCH CHI PHÍ";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ServiceView);
            this.panel2.Controls.Add(this.Menuview);
            this.panel2.Controls.Add(this.Service);
            this.panel2.Controls.Add(this.menu);
            this.panel2.Location = new System.Drawing.Point(10, 265);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(468, 324);
            this.panel2.TabIndex = 13;
            // 
            // ServiceView
            // 
            this.ServiceView.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ServiceView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ServiceView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ServiceView.DefaultCellStyle = dataGridViewCellStyle2;
            this.ServiceView.GridColor = System.Drawing.SystemColors.Control;
            this.ServiceView.Location = new System.Drawing.Point(6, 187);
            this.ServiceView.Name = "ServiceView";
            this.ServiceView.RowHeadersVisible = false;
            this.ServiceView.RowHeadersWidth = 51;
            this.ServiceView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ServiceView.Size = new System.Drawing.Size(457, 125);
            this.ServiceView.TabIndex = 17;
            // 
            // Menuview
            // 
            this.Menuview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Menuview.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Menuview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Menuview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Menuview.DefaultCellStyle = dataGridViewCellStyle4;
            this.Menuview.GridColor = System.Drawing.SystemColors.Control;
            this.Menuview.Location = new System.Drawing.Point(3, 32);
            this.Menuview.Name = "Menuview";
            this.Menuview.RowHeadersVisible = false;
            this.Menuview.RowHeadersWidth = 51;
            this.Menuview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Menuview.Size = new System.Drawing.Size(460, 125);
            this.Menuview.TabIndex = 16;
            // 
            // Service
            // 
            this.Service.AutoSize = true;
            this.Service.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Service.Location = new System.Drawing.Point(7, 166);
            this.Service.Name = "Service";
            this.Service.Size = new System.Drawing.Size(55, 13);
            this.Service.TabIndex = 15;
            this.Service.Text = "Dịch vụ";
            // 
            // menu
            // 
            this.menu.AutoSize = true;
            this.menu.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.Location = new System.Drawing.Point(7, 11);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(66, 13);
            this.menu.TabIndex = 14;
            this.menu.Text = "Thực đơn";
            // 
            // tiecId
            // 
            this.tiecId.Location = new System.Drawing.Point(696, 15);
            this.tiecId.Name = "tiecId";
            this.tiecId.Size = new System.Drawing.Size(45, 20);
            this.tiecId.TabIndex = 17;
            this.tiecId.TextChanged += new System.EventHandler(this.customerID_TextChanged);
            // 
            // btnSearchClick
            // 
            this.btnSearchClick.Location = new System.Drawing.Point(746, 9);
            this.btnSearchClick.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchClick.Name = "btnSearchClick";
            this.btnSearchClick.Size = new System.Drawing.Size(69, 34);
            this.btnSearchClick.TabIndex = 18;
            this.btnSearchClick.Text = "Enter";
            this.btnSearchClick.UseVisualStyleBackColor = true;
            this.btnSearchClick.Click += new System.EventHandler(this.btnSearchClick_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.XacNhan);
            this.panel4.Controls.Add(this.SearchTiecAndKhachHang);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnSearchClick);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.tiecId);
            this.panel4.Controls.Add(this.TTHD);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label123);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Location = new System.Drawing.Point(-1, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(823, 656);
            this.panel4.TabIndex = 20;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // XacNhan
            // 
            this.XacNhan.BackColor = System.Drawing.Color.White;
            this.XacNhan.BackgroundColor = System.Drawing.Color.White;
            this.XacNhan.BorderColor = System.Drawing.Color.Black;
            this.XacNhan.BorderColor1 = System.Drawing.Color.Black;
            this.XacNhan.BorderRadius = 15;
            this.XacNhan.BorderRadius1 = 15;
            this.XacNhan.BorderSize = 3;
            this.XacNhan.BorderSize1 = 3;
            this.XacNhan.FlatAppearance.BorderSize = 0;
            this.XacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XacNhan.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XacNhan.ForeColor = System.Drawing.Color.Black;
            this.XacNhan.Location = new System.Drawing.Point(607, 595);
            this.XacNhan.Name = "XacNhan";
            this.XacNhan.Size = new System.Drawing.Size(154, 52);
            this.XacNhan.TabIndex = 22;
            this.XacNhan.Text = "Xác Nhận";
            this.XacNhan.TextColor = System.Drawing.Color.Black;
            this.XacNhan.UseVisualStyleBackColor = false;
            this.XacNhan.Click += new System.EventHandler(this.XacNhan_Click);
            // 
            // SearchTiecAndKhachHang
            // 
            this.SearchTiecAndKhachHang.AllowUserToAddRows = false;
            this.SearchTiecAndKhachHang.AllowUserToDeleteRows = false;
            this.SearchTiecAndKhachHang.AllowUserToResizeColumns = false;
            this.SearchTiecAndKhachHang.AllowUserToResizeRows = false;
            this.SearchTiecAndKhachHang.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchTiecAndKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchTiecAndKhachHang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.SearchTiecAndKhachHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SearchTiecAndKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchTiecAndKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTiec,
            this.CustomerNameFind});
            this.SearchTiecAndKhachHang.Cursor = System.Windows.Forms.Cursors.Default;
            this.SearchTiecAndKhachHang.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchTiecAndKhachHang.Location = new System.Drawing.Point(549, 40);
            this.SearchTiecAndKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.SearchTiecAndKhachHang.Name = "SearchTiecAndKhachHang";
            this.SearchTiecAndKhachHang.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SearchTiecAndKhachHang.RowHeadersVisible = false;
            this.SearchTiecAndKhachHang.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.SearchTiecAndKhachHang.RowTemplate.Height = 24;
            this.SearchTiecAndKhachHang.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchTiecAndKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SearchTiecAndKhachHang.Size = new System.Drawing.Size(130, 0);
            this.SearchTiecAndKhachHang.TabIndex = 19;
            this.SearchTiecAndKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SearchTiecAndKhachHang_CellContentClick);
            // 
            // IdTiec
            // 
            this.IdTiec.HeaderText = "ID Tiệc";
            this.IdTiec.MinimumWidth = 6;
            this.IdTiec.Name = "IdTiec";
            this.IdTiec.Width = 60;
            // 
            // CustomerNameFind
            // 
            this.CustomerNameFind.HeaderText = "Tên KH";
            this.CustomerNameFind.MinimumWidth = 6;
            this.CustomerNameFind.Name = "CustomerNameFind";
            this.CustomerNameFind.Width = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(498, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "TÍNH TIỀN";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label24);
            this.panel3.Controls.Add(this.Discount);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.Paidment);
            this.panel3.Controls.Add(this.deposit);
            this.panel3.Controls.Add(this.Total);
            this.panel3.Controls.Add(this.DateLate);
            this.panel3.Controls.Add(this.PenaltyRatio);
            this.panel3.Controls.Add(this.totalService);
            this.panel3.Controls.Add(this.totalMenu);
            this.panel3.Controls.Add(this.NumberofTable);
            this.panel3.Controls.Add(this.VenueFee);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(484, 265);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(329, 324);
            this.panel3.TabIndex = 14;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(302, 266);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(15, 13);
            this.label24.TabIndex = 36;
            this.label24.Text = "%";
            // 
            // Discount
            // 
            this.Discount.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discount.Location = new System.Drawing.Point(174, 262);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(127, 22);
            this.Discount.TabIndex = 35;
            this.Discount.TextChanged += new System.EventHandler(this.Discount_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(50, 265);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 14);
            this.label16.TabIndex = 34;
            this.label16.Text = "Giảm Giá:";
            // 
            // Paidment
            // 
            this.Paidment.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paidment.Location = new System.Drawing.Point(174, 295);
            this.Paidment.Name = "Paidment";
            this.Paidment.Size = new System.Drawing.Size(127, 22);
            this.Paidment.TabIndex = 33;
            // 
            // deposit
            // 
            this.deposit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deposit.Location = new System.Drawing.Point(174, 233);
            this.deposit.Name = "deposit";
            this.deposit.Size = new System.Drawing.Size(127, 22);
            this.deposit.TabIndex = 32;
            // 
            // Total
            // 
            this.Total.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(174, 203);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(127, 22);
            this.Total.TabIndex = 31;
            // 
            // DateLate
            // 
            this.DateLate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLate.Location = new System.Drawing.Point(174, 171);
            this.DateLate.Name = "DateLate";
            this.DateLate.Size = new System.Drawing.Size(127, 22);
            this.DateLate.TabIndex = 30;
            // 
            // PenaltyRatio
            // 
            this.PenaltyRatio.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PenaltyRatio.Location = new System.Drawing.Point(174, 139);
            this.PenaltyRatio.Name = "PenaltyRatio";
            this.PenaltyRatio.Size = new System.Drawing.Size(127, 22);
            this.PenaltyRatio.TabIndex = 29;
            this.PenaltyRatio.TextChanged += new System.EventHandler(this.PenaltyRatio_TextChanged);
            // 
            // totalService
            // 
            this.totalService.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalService.Location = new System.Drawing.Point(174, 106);
            this.totalService.Name = "totalService";
            this.totalService.Size = new System.Drawing.Size(127, 22);
            this.totalService.TabIndex = 28;
            // 
            // totalMenu
            // 
            this.totalMenu.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalMenu.Location = new System.Drawing.Point(174, 75);
            this.totalMenu.Name = "totalMenu";
            this.totalMenu.Size = new System.Drawing.Size(127, 22);
            this.totalMenu.TabIndex = 27;
            // 
            // NumberofTable
            // 
            this.NumberofTable.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberofTable.Location = new System.Drawing.Point(174, 42);
            this.NumberofTable.Name = "NumberofTable";
            this.NumberofTable.Size = new System.Drawing.Size(127, 22);
            this.NumberofTable.TabIndex = 26;
            // 
            // VenueFee
            // 
            this.VenueFee.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VenueFee.Location = new System.Drawing.Point(174, 9);
            this.VenueFee.Name = "VenueFee";
            this.VenueFee.Size = new System.Drawing.Size(127, 22);
            this.VenueFee.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(50, 297);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 14);
            this.label14.TabIndex = 24;
            this.label14.Text = "Còn Lại:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(50, 237);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 14);
            this.label13.TabIndex = 23;
            this.label13.Text = "Tiền Cọc:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(50, 206);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 14);
            this.label12.TabIndex = 22;
            this.label12.Text = "Tổng Tiền:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(50, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 14);
            this.label11.TabIndex = 21;
            this.label11.Text = "Số Ngày Trễ:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(50, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 14);
            this.label10.TabIndex = 20;
            this.label10.Text = "Tỉ Số Phạt:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(50, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 14);
            this.label9.TabIndex = 19;
            this.label9.Text = "Đơn Giá Dịch Vụ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(50, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 14);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tiền Sảnh:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 14);
            this.label7.TabIndex = 17;
            this.label7.Text = "Đơn Giá Thực Đơn:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 14);
            this.label6.TabIndex = 16;
            this.label6.Text = "Số Bàn Tiệc:";
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 653);
            this.Controls.Add(this.panel4);
            this.Name = "Receipt";
            this.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Text = "Lập Hóa Đơn";
            this.Load += new System.EventHandler(this.Receipt_Load);
            this.TTHD.ResumeLayout(false);
            this.TTHD.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menuview)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchTiecAndKhachHang)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel TTHD;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label123;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label menu;
        private System.Windows.Forms.Label Service;
        private System.Windows.Forms.DataGridView ServiceView;
        private System.Windows.Forms.DataGridView Menuview;

        private System.Windows.Forms.TextBox tiecId;
        private System.Windows.Forms.TextBox admin;
        private System.Windows.Forms.DateTimePicker OrderDate;
        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Bride;
        private System.Windows.Forms.TextBox Groom;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.Button btnSearchClick;
        private Panel panel4;
        private Label label5;
        private Panel panel3;
        private TextBox Paidment;
        private TextBox deposit;
        private TextBox Total;
        private TextBox DateLate;
        private TextBox PenaltyRatio;
        private TextBox totalService;
        private TextBox totalMenu;
        private TextBox NumberofTable;
        private TextBox VenueFee;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox IdKhachhang;
        private Label label23;
        private TextBox Discount;
        private Label label16;
        private Label label24;
        private DataGridView SearchTiecAndKhachHang;
        private DataGridViewTextBoxColumn IdTiec;
        private DataGridViewTextBoxColumn CustomerNameFind;
        private UIDesign.RJButton XacNhan;
    }




}