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
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SearchTiecAndKhachHang = new System.Windows.Forms.DataGridView();
            this.IdTiec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerNameFind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TTHD.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menuview)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchTiecAndKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 36);
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
            this.TTHD.Location = new System.Drawing.Point(19, 76);
            this.TTHD.Margin = new System.Windows.Forms.Padding(4);
            this.TTHD.Name = "TTHD";
            this.TTHD.Size = new System.Drawing.Size(957, 195);
            this.TTHD.TabIndex = 1;
            // 
            // IdKhachhang
            // 
            this.IdKhachhang.Location = new System.Drawing.Point(646, 164);
            this.IdKhachhang.Margin = new System.Windows.Forms.Padding(4);
            this.IdKhachhang.Name = "IdKhachhang";
            this.IdKhachhang.Size = new System.Drawing.Size(241, 22);
            this.IdKhachhang.TabIndex = 23;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(508, 168);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(101, 17);
            this.label23.TabIndex = 22;
            this.label23.Text = "Id Khách Hàng";
            // 
            // Bride
            // 
            this.Bride.Location = new System.Drawing.Point(647, 124);
            this.Bride.Margin = new System.Windows.Forms.Padding(4);
            this.Bride.Name = "Bride";
            this.Bride.Size = new System.Drawing.Size(241, 22);
            this.Bride.TabIndex = 21;
            // 
            // Groom
            // 
            this.Groom.Location = new System.Drawing.Point(647, 94);
            this.Groom.Margin = new System.Windows.Forms.Padding(4);
            this.Groom.Name = "Groom";
            this.Groom.Size = new System.Drawing.Size(241, 22);
            this.Groom.TabIndex = 20;
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(647, 58);
            this.Phone.Margin = new System.Windows.Forms.Padding(4);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(241, 22);
            this.Phone.TabIndex = 19;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(647, 12);
            this.Email.Margin = new System.Windows.Forms.Padding(4);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(241, 22);
            this.Email.TabIndex = 18;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(197, 165);
            this.Address.Margin = new System.Windows.Forms.Padding(4);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(241, 22);
            this.Address.TabIndex = 17;
            // 
            // CustomerName
            // 
            this.CustomerName.Location = new System.Drawing.Point(197, 130);
            this.CustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(241, 22);
            this.CustomerName.TabIndex = 16;
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(197, 94);
            this.Date.Margin = new System.Windows.Forms.Padding(4);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(241, 22);
            this.Date.TabIndex = 15;
            // 
            // OrderDate
            // 
            this.OrderDate.Location = new System.Drawing.Point(197, 52);
            this.OrderDate.Margin = new System.Windows.Forms.Padding(4);
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.Size = new System.Drawing.Size(241, 22);
            this.OrderDate.TabIndex = 14;
            // 
            // admin
            // 
            this.admin.Location = new System.Drawing.Point(197, 12);
            this.admin.Margin = new System.Windows.Forms.Padding(4);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(241, 22);
            this.admin.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(508, 21);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 17);
            this.label17.TabIndex = 10;
            this.label17.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(509, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tên cô dâu";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(508, 97);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 17);
            this.label15.TabIndex = 8;
            this.label15.Text = "Tên chú rể";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(16, 169);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(51, 17);
            this.label19.TabIndex = 7;
            this.label19.Text = "Địa chỉ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(508, 59);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(91, 17);
            this.label18.TabIndex = 6;
            this.label18.Text = "Số điện thoại";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(16, 95);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(117, 17);
            this.label22.TabIndex = 4;
            this.label22.Text = "Ngày tổ chức tiệc";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(16, 53);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(91, 17);
            this.label21.TabIndex = 3;
            this.label21.Text = "Ngày đặt tiệc";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(16, 134);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(95, 17);
            this.label30.TabIndex = 2;
            this.label30.Text = "Người đặt tiệc";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(16, 21);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(124, 17);
            this.label20.TabIndex = 1;
            this.label20.Text = "Người lập hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(23, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "THÔNG TIN HÓA ĐƠN";
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.Location = new System.Drawing.Point(656, 27);
            this.label123.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(56, 16);
            this.label123.TabIndex = 5;
            this.label123.Text = "Mã Tiệc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(23, 293);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 20);
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
            this.panel2.Location = new System.Drawing.Point(19, 303);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(567, 345);
            this.panel2.TabIndex = 13;
            // 
            // ServiceView
            // 
            this.ServiceView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServiceView.Location = new System.Drawing.Point(8, 210);
            this.ServiceView.Margin = new System.Windows.Forms.Padding(4);
            this.ServiceView.Name = "ServiceView";
            this.ServiceView.RowHeadersWidth = 51;
            this.ServiceView.Size = new System.Drawing.Size(543, 134);
            this.ServiceView.TabIndex = 17;
            // 
            // Menuview
            // 
            this.Menuview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Menuview.Location = new System.Drawing.Point(8, 33);
            this.Menuview.Margin = new System.Windows.Forms.Padding(4);
            this.Menuview.Name = "Menuview";
            this.Menuview.RowHeadersWidth = 51;
            this.Menuview.Size = new System.Drawing.Size(543, 154);
            this.Menuview.TabIndex = 16;
            // 
            // Service
            // 
            this.Service.AutoSize = true;
            this.Service.Location = new System.Drawing.Point(9, 191);
            this.Service.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Service.Name = "Service";
            this.Service.Size = new System.Drawing.Size(51, 16);
            this.Service.TabIndex = 15;
            this.Service.Text = "Dịch vụ";
            // 
            // menu
            // 
            this.menu.AutoSize = true;
            this.menu.Location = new System.Drawing.Point(9, 14);
            this.menu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(63, 16);
            this.menu.TabIndex = 14;
            this.menu.Text = "Thực đơn";
            // 
            // tiecId
            // 
            this.tiecId.Location = new System.Drawing.Point(732, 23);
            this.tiecId.Margin = new System.Windows.Forms.Padding(4);
            this.tiecId.Name = "tiecId";
            this.tiecId.Size = new System.Drawing.Size(173, 22);
            this.tiecId.TabIndex = 17;
            this.tiecId.TextChanged += new System.EventHandler(this.customerID_TextChanged);
            // 
            // btnSearchClick
            // 
            this.btnSearchClick.Location = new System.Drawing.Point(912, 21);
            this.btnSearchClick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchClick.Name = "btnSearchClick";
            this.btnSearchClick.Size = new System.Drawing.Size(63, 23);
            this.btnSearchClick.TabIndex = 18;
            this.btnSearchClick.Text = "enter";
            this.btnSearchClick.UseVisualStyleBackColor = true;
            this.btnSearchClick.Click += new System.EventHandler(this.btnSearchClick_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.panel4.Location = new System.Drawing.Point(9, 10);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(991, 685);
            this.panel4.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(617, 292);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
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
            this.panel3.Location = new System.Drawing.Point(607, 303);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(371, 345);
            this.panel3.TabIndex = 14;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(307, 295);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(19, 16);
            this.label24.TabIndex = 36;
            this.label24.Text = "%";
            // 
            // Discount
            // 
            this.Discount.Location = new System.Drawing.Point(131, 287);
            this.Discount.Margin = new System.Windows.Forms.Padding(4);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(168, 22);
            this.Discount.TabIndex = 35;
            this.Discount.TextChanged += new System.EventHandler(this.Discount_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 295);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 16);
            this.label16.TabIndex = 34;
            this.label16.Text = "Giảm Giá";
            // 
            // Paidment
            // 
            this.Paidment.Location = new System.Drawing.Point(131, 317);
            this.Paidment.Margin = new System.Windows.Forms.Padding(4);
            this.Paidment.Name = "Paidment";
            this.Paidment.Size = new System.Drawing.Size(168, 22);
            this.Paidment.TabIndex = 33;
            // 
            // deposit
            // 
            this.deposit.Location = new System.Drawing.Point(131, 257);
            this.deposit.Margin = new System.Windows.Forms.Padding(4);
            this.deposit.Name = "deposit";
            this.deposit.Size = new System.Drawing.Size(168, 22);
            this.deposit.TabIndex = 32;
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(131, 223);
            this.Total.Margin = new System.Windows.Forms.Padding(4);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(168, 22);
            this.Total.TabIndex = 31;
            // 
            // DateLate
            // 
            this.DateLate.Location = new System.Drawing.Point(131, 170);
            this.DateLate.Margin = new System.Windows.Forms.Padding(4);
            this.DateLate.Name = "DateLate";
            this.DateLate.Size = new System.Drawing.Size(168, 22);
            this.DateLate.TabIndex = 30;
            // 
            // PenaltyRatio
            // 
            this.PenaltyRatio.Location = new System.Drawing.Point(131, 138);
            this.PenaltyRatio.Margin = new System.Windows.Forms.Padding(4);
            this.PenaltyRatio.Name = "PenaltyRatio";
            this.PenaltyRatio.Size = new System.Drawing.Size(168, 22);
            this.PenaltyRatio.TabIndex = 29;
            this.PenaltyRatio.TextChanged += new System.EventHandler(this.PenaltyRatio_TextChanged);
            // 
            // totalService
            // 
            this.totalService.Location = new System.Drawing.Point(131, 106);
            this.totalService.Margin = new System.Windows.Forms.Padding(4);
            this.totalService.Name = "totalService";
            this.totalService.Size = new System.Drawing.Size(168, 22);
            this.totalService.TabIndex = 28;
            // 
            // totalMenu
            // 
            this.totalMenu.Location = new System.Drawing.Point(131, 74);
            this.totalMenu.Margin = new System.Windows.Forms.Padding(4);
            this.totalMenu.Name = "totalMenu";
            this.totalMenu.Size = new System.Drawing.Size(168, 22);
            this.totalMenu.TabIndex = 27;
            // 
            // NumberofTable
            // 
            this.NumberofTable.Location = new System.Drawing.Point(131, 42);
            this.NumberofTable.Margin = new System.Windows.Forms.Padding(4);
            this.NumberofTable.Name = "NumberofTable";
            this.NumberofTable.Size = new System.Drawing.Size(168, 22);
            this.NumberofTable.TabIndex = 26;
            // 
            // VenueFee
            // 
            this.VenueFee.Location = new System.Drawing.Point(131, 10);
            this.VenueFee.Margin = new System.Windows.Forms.Padding(4);
            this.VenueFee.Name = "VenueFee";
            this.VenueFee.Size = new System.Drawing.Size(168, 22);
            this.VenueFee.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 325);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 16);
            this.label14.TabIndex = 24;
            this.label14.Text = "Còn lại";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 265);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 16);
            this.label13.TabIndex = 23;
            this.label13.Text = "Tiền Cọc";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 229);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "Tổng tiền:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 178);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Số ngày trễ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 146);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Tỉ số phạt";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 114);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Đơn giá dịch vụ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 14);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tiền Sảnh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 82);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Đơn giá thực đơn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Số bàn tiệc:";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ConfirmButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ConfirmButton.Location = new System.Drawing.Point(810, 716);
            this.ConfirmButton.Margin = new System.Windows.Forms.Padding(4);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(176, 38);
            this.ConfirmButton.TabIndex = 21;
            this.ConfirmButton.Text = "Xác Nhận";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
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
            this.SearchTiecAndKhachHang.Location = new System.Drawing.Point(732, 49);
            this.SearchTiecAndKhachHang.Name = "SearchTiecAndKhachHang";
            this.SearchTiecAndKhachHang.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SearchTiecAndKhachHang.RowHeadersVisible = false;
            this.SearchTiecAndKhachHang.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.SearchTiecAndKhachHang.RowTemplate.Height = 24;
            this.SearchTiecAndKhachHang.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchTiecAndKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SearchTiecAndKhachHang.Size = new System.Drawing.Size(174, 0);
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
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1001, 759);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.panel4);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Receipt";
            this.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
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
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchTiecAndKhachHang)).EndInit();
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
        private Button ConfirmButton;
        private TextBox IdKhachhang;
        private Label label23;
        private TextBox Discount;
        private Label label16;
        private Label label24;
        private DataGridView SearchTiecAndKhachHang;
        private DataGridViewTextBoxColumn IdTiec;
        private DataGridViewTextBoxColumn CustomerNameFind;
    }




}