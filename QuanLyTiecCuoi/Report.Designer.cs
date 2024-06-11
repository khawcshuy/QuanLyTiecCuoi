namespace QuanLyTiecCuoi
{
    partial class Report
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ReportOfMonth = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewReport = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTiec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.RevenueValue = new System.Windows.Forms.Label();
            this.TotalVenueValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.totalPartyValue = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totalSerivceValue = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.totalFoodValue = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.totalTableValue = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchByMonth = new QuanLyTiecCuoi.UIDesign.RJButton();
            this.MonthYear = new QuanLyTiecCuoi.UIDesign.DatePickerUI();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReportOfMonth
            // 
            this.ReportOfMonth.AutoSize = true;
            this.ReportOfMonth.Font = new System.Drawing.Font("Montserrat ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportOfMonth.Location = new System.Drawing.Point(319, 6);
            this.ReportOfMonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReportOfMonth.Name = "ReportOfMonth";
            this.ReportOfMonth.Size = new System.Drawing.Size(294, 47);
            this.ReportOfMonth.TabIndex = 2;
            this.ReportOfMonth.Text = "Báo Cáo Tháng";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Location = new System.Drawing.Point(1195, 725);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(552, 693);
            this.flowLayoutPanel3.TabIndex = 5;
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(1308, 150);
            this.chart2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            series1.IsValueShownAsLabel = true;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(552, 693);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "Tỉ lệ doanh thu từng ngày";
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Tỉ Lệ Doanh Thu Ngày";
            this.chart2.Titles.Add(title1);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Location = new System.Drawing.Point(24, 150);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(991, 369);
            this.flowLayoutPanel4.TabIndex = 4;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(24, 150);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series2";
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(1279, 369);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "Doanh Thu 5 Tháng Gần Nhất";
            title2.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title2.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "Doanh Thu";
            this.chart1.Titles.Add(title2);
            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.AllowUserToAddRows = false;
            this.dataGridViewReport.AllowUserToDeleteRows = false;
            this.dataGridViewReport.AllowUserToOrderColumns = true;
            this.dataGridViewReport.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.IdTiec,
            this.CustomerName,
            this.TotalMoney,
            this.InvoiceDate,
            this.DiscountPercent});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewReport.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewReport.GridColor = System.Drawing.Color.White;
            this.dataGridViewReport.Location = new System.Drawing.Point(299, 530);
            this.dataGridViewReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewReport.Name = "dataGridViewReport";
            this.dataGridViewReport.RowHeadersVisible = false;
            this.dataGridViewReport.RowHeadersWidth = 51;
            this.dataGridViewReport.RowTemplate.Height = 24;
            this.dataGridViewReport.Size = new System.Drawing.Size(1004, 294);
            this.dataGridViewReport.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // IdTiec
            // 
            this.IdTiec.HeaderText = "Mã Tiệc";
            this.IdTiec.MinimumWidth = 6;
            this.IdTiec.Name = "IdTiec";
            this.IdTiec.Width = 125;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Tên Khách Hàng";
            this.CustomerName.MinimumWidth = 6;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Width = 125;
            // 
            // TotalMoney
            // 
            this.TotalMoney.HeaderText = "Tổng Tiền";
            this.TotalMoney.MinimumWidth = 6;
            this.TotalMoney.Name = "TotalMoney";
            this.TotalMoney.Width = 125;
            // 
            // InvoiceDate
            // 
            this.InvoiceDate.HeaderText = "Ngày Xuất Hóa Đơn";
            this.InvoiceDate.MinimumWidth = 6;
            this.InvoiceDate.Name = "InvoiceDate";
            this.InvoiceDate.Width = 125;
            // 
            // DiscountPercent
            // 
            this.DiscountPercent.HeaderText = "Phần Trăm Giảm Giá";
            this.DiscountPercent.MinimumWidth = 6;
            this.DiscountPercent.Name = "DiscountPercent";
            this.DiscountPercent.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tổng Doanh Thu";
            // 
            // RevenueValue
            // 
            this.RevenueValue.AutoSize = true;
            this.RevenueValue.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RevenueValue.Location = new System.Drawing.Point(64, 28);
            this.RevenueValue.Name = "RevenueValue";
            this.RevenueValue.Size = new System.Drawing.Size(28, 31);
            this.RevenueValue.TabIndex = 24;
            this.RevenueValue.Text = "0";
            // 
            // TotalVenueValue
            // 
            this.TotalVenueValue.AutoSize = true;
            this.TotalVenueValue.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalVenueValue.Location = new System.Drawing.Point(64, 28);
            this.TotalVenueValue.Name = "TotalVenueValue";
            this.TotalVenueValue.Size = new System.Drawing.Size(30, 33);
            this.TotalVenueValue.TabIndex = 26;
            this.TotalVenueValue.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tổng Số Sảnh";
            // 
            // totalPartyValue
            // 
            this.totalPartyValue.AutoSize = true;
            this.totalPartyValue.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPartyValue.Location = new System.Drawing.Point(64, 28);
            this.totalPartyValue.Name = "totalPartyValue";
            this.totalPartyValue.Size = new System.Drawing.Size(30, 33);
            this.totalPartyValue.TabIndex = 28;
            this.totalPartyValue.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "Tổng Số Tiệc";
            // 
            // totalSerivceValue
            // 
            this.totalSerivceValue.AutoSize = true;
            this.totalSerivceValue.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSerivceValue.Location = new System.Drawing.Point(64, 75);
            this.totalSerivceValue.Name = "totalSerivceValue";
            this.totalSerivceValue.Size = new System.Drawing.Size(28, 31);
            this.totalSerivceValue.TabIndex = 30;
            this.totalSerivceValue.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 25);
            this.label8.TabIndex = 29;
            this.label8.Text = "Tổng Số Dịch Vụ";
            // 
            // totalFoodValue
            // 
            this.totalFoodValue.AutoSize = true;
            this.totalFoodValue.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalFoodValue.Location = new System.Drawing.Point(64, 145);
            this.totalFoodValue.Name = "totalFoodValue";
            this.totalFoodValue.Size = new System.Drawing.Size(28, 31);
            this.totalFoodValue.TabIndex = 32;
            this.totalFoodValue.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(194, 25);
            this.label10.TabIndex = 31;
            this.label10.Text = "Tổng Số Món Ăn";
            // 
            // totalTableValue
            // 
            this.totalTableValue.AutoSize = true;
            this.totalTableValue.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTableValue.Location = new System.Drawing.Point(64, 219);
            this.totalTableValue.Name = "totalTableValue";
            this.totalTableValue.Size = new System.Drawing.Size(28, 31);
            this.totalTableValue.TabIndex = 35;
            this.totalTableValue.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 25);
            this.label11.TabIndex = 34;
            this.label11.Text = "Tổng Số Bàn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(930, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 32);
            this.label2.TabIndex = 38;
            this.label2.Text = "Nhập Tháng / Năm:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TotalVenueValue);
            this.panel1.Location = new System.Drawing.Point(24, 78);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 66);
            this.panel1.TabIndex = 40;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.totalPartyValue);
            this.panel2.Location = new System.Drawing.Point(369, 78);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(645, 66);
            this.panel2.TabIndex = 41;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.RevenueValue);
            this.panel3.Location = new System.Drawing.Point(1023, 78);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(819, 66);
            this.panel3.TabIndex = 42;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.totalSerivceValue);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.totalFoodValue);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.totalTableValue);
            this.panel4.Location = new System.Drawing.Point(24, 530);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(267, 293);
            this.panel4.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-4, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 32);
            this.label3.TabIndex = 44;
            this.label3.Text = "Total Counter";
            // 
            // SearchByMonth
            // 
            this.SearchByMonth.BackColor = System.Drawing.Color.GhostWhite;
            this.SearchByMonth.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.SearchByMonth.BorderColor = System.Drawing.Color.Black;
            this.SearchByMonth.BorderColor1 = System.Drawing.Color.Black;
            this.SearchByMonth.BorderRadius = 10;
            this.SearchByMonth.BorderRadius1 = 10;
            this.SearchByMonth.BorderSize = 2;
            this.SearchByMonth.BorderSize1 = 2;
            this.SearchByMonth.FlatAppearance.BorderSize = 0;
            this.SearchByMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchByMonth.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByMonth.ForeColor = System.Drawing.Color.Black;
            this.SearchByMonth.Location = new System.Drawing.Point(1645, 15);
            this.SearchByMonth.Margin = new System.Windows.Forms.Padding(4);
            this.SearchByMonth.Name = "SearchByMonth";
            this.SearchByMonth.Size = new System.Drawing.Size(120, 49);
            this.SearchByMonth.TabIndex = 44;
            this.SearchByMonth.Text = "Enter";
            this.SearchByMonth.TextColor = System.Drawing.Color.Black;
            this.SearchByMonth.UseVisualStyleBackColor = false;
            this.SearchByMonth.Click += new System.EventHandler(this.SearchByMonth_Click);
            // 
            // MonthYear
            // 
            this.MonthYear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MonthYear.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.MonthYear.BorderSize = 0;
            this.MonthYear.CustomFormat = "MM/yyyy";
            this.MonthYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.MonthYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MonthYear.Location = new System.Drawing.Point(1249, 26);
            this.MonthYear.Name = "MonthYear";
            this.MonthYear.Size = new System.Drawing.Size(332, 38);
            this.MonthYear.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.MonthYear.TabIndex = 45;
            this.MonthYear.TextColor = System.Drawing.Color.White;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1859, 838);
            this.Controls.Add(this.MonthYear);
            this.Controls.Add(this.SearchByMonth);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.dataGridViewReport);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.ReportOfMonth);
            this.Controls.Add(this.panel4);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Report";
            this.Text = "Bao Cao Thang";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ReportOfMonth;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.DataGridView dataGridViewReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RevenueValue;
        private System.Windows.Forms.Label TotalVenueValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label totalPartyValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label totalSerivceValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label totalFoodValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label totalTableValue;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private UIDesign.RJButton SearchByMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTiec;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountPercent;
        private UIDesign.DatePickerUI MonthYear;
    }
}