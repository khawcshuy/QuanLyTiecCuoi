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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ReportOfMonth = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.GetMonthYear = new System.Windows.Forms.TextBox();
            this.FindMonth = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportOfMonth
            // 
            this.ReportOfMonth.AutoSize = true;
            this.ReportOfMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportOfMonth.Location = new System.Drawing.Point(13, 9);
            this.ReportOfMonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReportOfMonth.Name = "ReportOfMonth";
            this.ReportOfMonth.Size = new System.Drawing.Size(223, 36);
            this.ReportOfMonth.TabIndex = 2;
            this.ReportOfMonth.Text = "Báo Cáo Tháng";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.chart2);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(662, 48);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(315, 289);
            this.flowLayoutPanel3.TabIndex = 5;
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(3, 3);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(300, 300);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart2";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.chart1);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(407, 343);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(570, 383);
            this.flowLayoutPanel4.TabIndex = 4;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(3, 3);
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
            this.chart1.Size = new System.Drawing.Size(567, 380);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "Doanh Thu 5 Tháng Gần Nhất";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox10.Location = new System.Drawing.Point(241, 206);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(183, 125);
            this.pictureBox10.TabIndex = 22;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox12.Location = new System.Drawing.Point(463, 57);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(183, 125);
            this.pictureBox12.TabIndex = 20;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox8.Location = new System.Drawing.Point(241, 57);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(183, 125);
            this.pictureBox8.TabIndex = 16;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Location = new System.Drawing.Point(19, 206);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(183, 125);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(19, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 125);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.AllowUserToAddRows = false;
            this.dataGridViewReport.AllowUserToDeleteRows = false;
            this.dataGridViewReport.AllowUserToOrderColumns = true;
            this.dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.IdTiec,
            this.CustomerName,
            this.TotalMoney,
            this.InvoiceDate,
            this.DiscountPercent});
            this.dataGridViewReport.Location = new System.Drawing.Point(19, 343);
            this.dataGridViewReport.Name = "dataGridViewReport";
            this.dataGridViewReport.RowHeadersVisible = false;
            this.dataGridViewReport.RowHeadersWidth = 51;
            this.dataGridViewReport.RowTemplate.Height = 24;
            this.dataGridViewReport.Size = new System.Drawing.Size(367, 383);
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
            this.DiscountPercent.HeaderText = "Phần Trăm Giảm Gía";
            this.DiscountPercent.MinimumWidth = 6;
            this.DiscountPercent.Name = "DiscountPercent";
            this.DiscountPercent.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(82, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tổng Doanh Thu";
            // 
            // RevenueValue
            // 
            this.RevenueValue.AutoSize = true;
            this.RevenueValue.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RevenueValue.Location = new System.Drawing.Point(128, 120);
            this.RevenueValue.Name = "RevenueValue";
            this.RevenueValue.Size = new System.Drawing.Size(28, 31);
            this.RevenueValue.TabIndex = 24;
            this.RevenueValue.Text = "0";
            // 
            // TotalVenueValue
            // 
            this.TotalVenueValue.AutoSize = true;
            this.TotalVenueValue.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalVenueValue.Location = new System.Drawing.Point(358, 120);
            this.TotalVenueValue.Name = "TotalVenueValue";
            this.TotalVenueValue.Size = new System.Drawing.Size(28, 31);
            this.TotalVenueValue.TabIndex = 26;
            this.TotalVenueValue.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(252, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tổng số sảnh được sử dụng";
            // 
            // totalPartyValue
            // 
            this.totalPartyValue.AutoSize = true;
            this.totalPartyValue.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPartyValue.Location = new System.Drawing.Point(585, 120);
            this.totalPartyValue.Name = "totalPartyValue";
            this.totalPartyValue.Size = new System.Drawing.Size(28, 31);
            this.totalPartyValue.TabIndex = 28;
            this.totalPartyValue.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(539, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Tổng Số Tiệc";
            // 
            // totalSerivceValue
            // 
            this.totalSerivceValue.AutoSize = true;
            this.totalSerivceValue.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSerivceValue.Location = new System.Drawing.Point(140, 273);
            this.totalSerivceValue.Name = "totalSerivceValue";
            this.totalSerivceValue.Size = new System.Drawing.Size(28, 31);
            this.totalSerivceValue.TabIndex = 30;
            this.totalSerivceValue.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(94, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "Tổng số dịch vụ";
            // 
            // totalFoodValue
            // 
            this.totalFoodValue.AutoSize = true;
            this.totalFoodValue.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalFoodValue.Location = new System.Drawing.Point(358, 273);
            this.totalFoodValue.Name = "totalFoodValue";
            this.totalFoodValue.Size = new System.Drawing.Size(28, 31);
            this.totalFoodValue.TabIndex = 32;
            this.totalFoodValue.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(312, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 16);
            this.label10.TabIndex = 31;
            this.label10.Text = "Tổng số món ăn";
            // 
            // totalTableValue
            // 
            this.totalTableValue.AutoSize = true;
            this.totalTableValue.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTableValue.Location = new System.Drawing.Point(580, 273);
            this.totalTableValue.Name = "totalTableValue";
            this.totalTableValue.Size = new System.Drawing.Size(28, 31);
            this.totalTableValue.TabIndex = 35;
            this.totalTableValue.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(534, 237);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 16);
            this.label11.TabIndex = 34;
            this.label11.Text = "Tổng Số Bàn";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(463, 206);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(183, 125);
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // GetMonthYear
            // 
            this.GetMonthYear.Location = new System.Drawing.Point(780, 20);
            this.GetMonthYear.Name = "GetMonthYear";
            this.GetMonthYear.Size = new System.Drawing.Size(142, 22);
            this.GetMonthYear.TabIndex = 36;
            // 
            // FindMonth
            // 
            this.FindMonth.Location = new System.Drawing.Point(928, 19);
            this.FindMonth.Name = "FindMonth";
            this.FindMonth.Size = new System.Drawing.Size(49, 23);
            this.FindMonth.TabIndex = 37;
            this.FindMonth.Text = "ent";
            this.FindMonth.UseVisualStyleBackColor = true;
            this.FindMonth.Click += new System.EventHandler(this.FindMonth_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(636, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Nhập Tháng/ Năm ";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1001, 759);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FindMonth);
            this.Controls.Add(this.GetMonthYear);
            this.Controls.Add(this.totalTableValue);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.totalFoodValue);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.totalSerivceValue);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.totalPartyValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TotalVenueValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RevenueValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewReport);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.ReportOfMonth);
            this.Name = "Report";
            this.Text = "Bao Cao Thang";
            this.Load += new System.EventHandler(this.Report_Load);
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ReportOfMonth;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox12;
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTiec;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountPercent;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.TextBox GetMonthYear;
        private System.Windows.Forms.Button FindMonth;
        private System.Windows.Forms.Label label2;
    }
}