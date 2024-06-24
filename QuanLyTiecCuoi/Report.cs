using Microsoft.SqlServer.Server;
using QuanLyTiecCuoi.QUANLYTIECCUOIDataSet1TableAdapters;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyTiecCuoi
{
    public partial class Report : Form
    {
        public string conString;
        private string NvName ;
        private int idNV;


        private Rectangle panel1OriginalRect;
        private Rectangle panel2OriginalRect;
        private Rectangle panel3OriginalRect;
        private Rectangle panel4OriginalRect;
        private Rectangle dataGridViewReportOriginalRect;
        private Rectangle MonthYearOriginalRect;
        private Rectangle SearchByMonthOriginalRect;
        private Rectangle Chart1OriginalRect;
        private Rectangle Chart2OriginalRect;
        private System.Drawing.Size originalFormSize;


        private float ReportOfMonthXRatio;
        private float ReportOfMonthYRatio;
        private float Label2XRatio;
        private float Label2YRatio;
        private float Label4XRatio;
        private float Label4YRatio;
        private float Label6XRatio;
        private float Label6YRatio;
        private float Label1XRatio;
        private float Label1YRatio;
        private float Label5XRatio;
        private float Label5YRatio;
        private float Label3XRatio;
        private float Label3YRatio;
        private float Label8XRatio;
        private float Label8YRatio;
        private float Label10XRatio;
        private float Label10YRatio;
        private float Label11XRatio;
        private float Label11YRatio;
        private float TotalVenueValueXRatio;
        private float TotalVenueValueYRatio;
        private float totalPartyValueXRatio;
        private float totalPartyValueYRatio;
        private float RevenueValueXRatio;
        private float RevenueValueYRatio;
        private float totalServiceValueXRatio;
        private float totalServiceValueYRatio;
        private float totalFoodValueXRatio;
        private float totalFoodValueYRatio;
        private float totalTableValueXRatio;
        private float totalTableValueYRatio;
        private float initialFontSizeReportOfMonth;
        private float initialFontSizeLabel2;
        private float initialFontSizeLabel4;
        private float initialFontSizeLabel6;
        private float initialFontSizeLabel1;
        private float initialFontSizeLabel5;
        private float initialFontSizeLabel3;
        private float initialFontSizeLabel8;
        private float initialFontSizeLabel10;
        private float initialFontSizeLabel11;
        private float initialFontSizeTotalVenueValue;
        private float initialFontSizetotalPartyValue;
        private float initialFontSizeRevenueValue;
        private float initialFontSizetotalServiceValue;
        private float initialFontSizetotalFoodValue;
        private float initialFontSizetotalTableValue;
        public Report(string conString, string NvName)
        {
            InitializeComponent();
            this.conString = conString;
            this.NvName = NvName;
            LimitMonthYear();
            if(NvName == "admin")
            {
                NhanVien.Visible = false;
                NhanVienName.Visible = false;
            }
            else
            {
                NhanVienName.Text = NvName;
            }
            idNV = GetIdNV();

        }

        private int GetIdNV()
        {

            string query = "SELECT NV.ID, NV.TENNHANVIEN FROM NHANVIEN NV INNER JOIN USERS U ON NV.IDUSERS = U.ID WHERE U.USERNAME = @nhanvien";

            using (SqlConnection con = new SqlConnection(conString))
            {
                // Mở kết nối
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Thêm tham số cho truy vấn
                    cmd.Parameters.AddWithValue("@nhanvien", NvName);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            idNV = (int)reader["ID"];
                            NhanVienName.Text = reader["TENNHANVIEN"].ToString();
                        }
                    }
                }
            }

            return idNV;
        }

        private void LimitMonthYear()
        {
            string query;
            if (NvName == "admin")
            {
                query = "SELECT MAX(NGAYXUATHOADON) AS MaxDate, MIN(NGAYXUATHOADON) AS MinDate FROM HOADON";
            }
            else
            {
                query = @"
            SELECT 
                MAX(NGAYXUATHOADON) AS MaxDate, 
                MIN(NGAYXUATHOADON) AS MinDate 
            FROM 
                HOADON HD 
            INNER JOIN 
                NHANVIEN NV ON HD.IDNHANVIEN = NV.ID
            WHERE 
                NV.ID = @idNV";
            }

            DateTime maxDate = DateTime.MinValue;
            DateTime minDate = DateTime.MaxValue;

            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (NvName != "admin")
                    {
                        command.Parameters.AddWithValue("@idNV", idNV);
                    }

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal("MaxDate")))
                            {
                                DateTime currentMaxDate = reader.GetDateTime(reader.GetOrdinal("MaxDate"));
                                if (currentMaxDate > maxDate)
                                {
                                    maxDate = currentMaxDate;
                                }
                            }

                            if (!reader.IsDBNull(reader.GetOrdinal("MinDate")))
                            {
                                DateTime currentMinDate = reader.GetDateTime(reader.GetOrdinal("MinDate"));
                                if (currentMinDate < minDate)
                                {
                                    minDate = currentMinDate;
                                }
                            }
                        }
                    }
                }
            }

            if (maxDate != DateTime.MinValue && minDate != DateTime.MaxValue)
            {
                MonthYear.Format = DateTimePickerFormat.Custom;
                MonthYear.CustomFormat = "MM/yyyy";
                MonthYear.MaxDate = maxDate;
                MonthYear.MinDate = minDate;
            }
        }




        private void listView1_load(object sender, EventArgs e)
        {

        }

        private void Report_Load(object sender, EventArgs e)
        {
            ProdPeferiod();
            LoadGridViewReport();
            GetNearest5month();
            CalculateDailyRevenueRatio();
            originalFormSize = this.Size;
            panel1OriginalRect = new Rectangle(panel1.Location, panel1.Size);
            panel2OriginalRect = new Rectangle(panel2.Location, panel2.Size);
            panel3OriginalRect = new Rectangle(panel3.Location, panel3.Size);
            panel4OriginalRect = new Rectangle(panel4.Location, panel4.Size);
            dataGridViewReportOriginalRect = new Rectangle(dataGridViewReport.Location, dataGridViewReport.Size);
            MonthYearOriginalRect = new Rectangle(MonthYear.Location, MonthYear.Size);
            SearchByMonthOriginalRect = new Rectangle(SearchByMonth.Location, SearchByMonth.Size);
            Chart1OriginalRect = new Rectangle(chart1.Location, chart1.Size);
            Chart2OriginalRect = new Rectangle(chart2.Location, chart2.Size);


            ReportOfMonthXRatio = (float)ReportOfMonth.Left / this.ClientSize.Width;
            ReportOfMonthYRatio = (float)ReportOfMonth.Top / this.ClientSize.Height;
            Label2XRatio = (float)label2.Left / this.ClientSize.Width;
            Label2YRatio = (float)label2.Top / this.ClientSize.Height;
            Label4XRatio = (float)label4.Left / this.ClientSize.Width;
            Label4YRatio = (float)label4.Top / this.ClientSize.Height;
            Label6XRatio = (float)label6.Left / this.ClientSize.Width;
            Label6YRatio = (float)label6.Top / this.ClientSize.Height;
            Label1XRatio = (float)label1.Left / this.ClientSize.Width;
            Label1YRatio = (float)label1.Top / this.ClientSize.Height;
            Label5XRatio = (float)label5.Left / this.ClientSize.Width;
            Label5YRatio = (float)label5.Top / this.ClientSize.Height;
            Label3XRatio = (float)label3.Left / this.ClientSize.Width;
            Label3YRatio = (float)label3.Top / this.ClientSize.Height;
            Label8XRatio = (float)label8.Left / this.ClientSize.Width;
            Label8YRatio = (float)label8.Top / this.ClientSize.Height;
            Label10XRatio = (float)label10.Left / this.ClientSize.Width;
            Label10YRatio = (float)label10.Top / this.ClientSize.Height;
            Label11XRatio = (float)label11.Left / this.ClientSize.Width;
            Label11YRatio = (float)label11.Top / this.ClientSize.Height;
            TotalVenueValueXRatio = (float)TotalVenueValue.Left / this.ClientSize.Width;
            TotalVenueValueYRatio = (float)TotalVenueValue.Top / this.ClientSize.Height;
            totalPartyValueXRatio = (float)totalPartyValue.Left / this.ClientSize.Width;
            totalPartyValueYRatio = (float)totalPartyValue.Top / this.ClientSize.Height;
            RevenueValueXRatio = (float)RevenueValue.Left / this.ClientSize.Width;
            RevenueValueYRatio = (float)RevenueValue.Top / this.ClientSize.Height;
            totalServiceValueXRatio = (float)totalSerivceValue.Left / this.ClientSize.Width;
            totalServiceValueYRatio = (float)totalSerivceValue.Top / this.ClientSize.Height;
            totalFoodValueXRatio = (float)totalFoodValue.Left / this.ClientSize.Width;
            totalFoodValueYRatio = (float)totalFoodValue.Top / this.ClientSize.Height;
            totalTableValueXRatio = (float)totalTableValue.Left / this.ClientSize.Width;
            totalTableValueYRatio = (float)totalTableValue.Top / this.ClientSize.Height;
            initialFontSizeReportOfMonth = ReportOfMonth.Font.Size;
            initialFontSizeLabel2 = label2.Font.Size;
            initialFontSizeLabel4 = label4.Font.Size;
            initialFontSizeLabel6 = label6.Font.Size;
            initialFontSizeLabel1= label1.Font.Size;
            initialFontSizeLabel5 = label5.Font.Size;
            initialFontSizeLabel3 = label3.Font.Size;
            initialFontSizeLabel8 = label8.Font.Size;
            initialFontSizeLabel10 = label10.Font.Size;
            initialFontSizeLabel11 = label11.Font.Size;
            initialFontSizeTotalVenueValue = TotalVenueValue.Font.Size;
            initialFontSizetotalPartyValue = totalPartyValue.Font.Size;
            initialFontSizeRevenueValue = RevenueValue.Font.Size;
            initialFontSizetotalServiceValue = totalSerivceValue.Font.Size;
            initialFontSizetotalFoodValue = totalFoodValue.Font.Size;
            initialFontSizetotalTableValue = totalTableValue.Font.Size;
        }




        private void ProdPeferiod(string Thang = null, string Nam = null)
        {
            if (Thang == null)
            {
                Thang = DateTime.Now.Month.ToString();

            }
            if (Nam == null)
            {
                Nam = DateTime.Now.Year.ToString();
            }

            using (SqlConnection con = new SqlConnection(conString))
            {

                using (SqlCommand cmd = new SqlCommand("ProdPeferiod", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NAM", Nam);
                    cmd.Parameters.AddWithValue("@THANG", Thang);
                    if (NvName != "admin")
                    {
 cmd.Parameters.AddWithValue("@IDNHANVIEN", idNV);

                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@IDNHANVIEN", DBNull.Value);
                    }
                   



                    var totalParam = new SqlParameter("@TOTAL", SqlDbType.Money) { Direction = ParameterDirection.Output };
                    var totalVenueParam = new SqlParameter("@TOTALVENUE", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    var totalPartyParam = new SqlParameter("@TOTALPARTY", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    var totalServiceUsedParam = new SqlParameter("@TOTALSERVICEUSED", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    var totalFoodUsedParam = new SqlParameter("@TOTALFOODUSED", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    var totalTableUsedParam = new SqlParameter("@TOTALTABLEUSED", SqlDbType.Int) { Direction = ParameterDirection.Output };


                    cmd.Parameters.Add(totalParam);
                    cmd.Parameters.Add(totalVenueParam);
                    cmd.Parameters.Add(totalPartyParam);
                    cmd.Parameters.Add(totalServiceUsedParam);
                    cmd.Parameters.Add(totalFoodUsedParam);
                    cmd.Parameters.Add(totalTableUsedParam);

                    con.Open();
                    cmd.ExecuteNonQuery();

                    var total = totalParam.Value != DBNull.Value ? (decimal)totalParam.Value : 0;
                    var totalVenue = totalVenueParam.Value != DBNull.Value ? (int)totalVenueParam.Value : 0;
                    var totalParty = totalPartyParam.Value != DBNull.Value ? (int)totalPartyParam.Value : 0;
                    var totalServiceUsed = totalServiceUsedParam.Value != DBNull.Value ? (int)totalServiceUsedParam.Value : 0;
                    var totalFoodUsed = totalFoodUsedParam.Value != DBNull.Value ? (int)totalFoodUsedParam.Value : 0;
                    var totalTableUsed = totalTableUsedParam.Value != DBNull.Value ? (int)totalTableUsedParam.Value : 0;


                    RevenueValue.Text = total.ToString("N2");
                    ReportOfMonth.Text = "Báo cáo tháng " + Thang;
                    TotalVenueValue.Text = totalVenue.ToString();
                    totalFoodValue.Text = totalParty.ToString();
                    totalSerivceValue.Text = totalServiceUsed.ToString();
                    totalPartyValue.Text = totalFoodUsed.ToString();
                    totalTableValue.Text = totalTableUsed.ToString();



                }
            }
        }


        private void LoadGridViewReport(string Thang = null, string Nam = null)
        {
            if (Thang == null)
            {
                Thang = DateTime.Now.Month.ToString();
            }
            if (Nam == null)
            {
                Nam = DateTime.Now.Year.ToString();
            }

            string query = @"
        SELECT H.ID, IDTIEC, TONGTIEN, NGAYXUATHOADON, GIAMGIA, K.TENKHACHHANG 
        FROM HOADON H
        INNER JOIN TIEC T ON H.IDTIEC = T.ID
        INNER JOIN KHACHHANGINFOR K ON T.IDTHONGTINKHACHHANG = K.ID
        WHERE MONTH(H.NGAYXUATHOADON) = @THANG 
        AND YEAR(H.NGAYXUATHOADON) = @NAM";

            if (NvName != "admin")
            {
                query = @"
            SELECT H.ID, IDTIEC, TONGTIEN, NGAYXUATHOADON, GIAMGIA, K.TENKHACHHANG 
            FROM HOADON H
            INNER JOIN TIEC T ON H.IDTIEC = T.ID
            INNER JOIN KHACHHANGINFOR K ON T.IDTHONGTINKHACHHANG = K.ID
            INNER JOIN NHANVIEN NV ON H.IDNHANVIEN = NV.ID
            WHERE NV.ID = @idNv
            AND MONTH(H.NGAYXUATHOADON) = @THANG 
            AND YEAR(H.NGAYXUATHOADON) = @NAM";
            }

            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@THANG", Thang);
                    cmd.Parameters.AddWithValue("@NAM", Nam);

                    if (NvName != "admin")
                    {
                        cmd.Parameters.AddWithValue("@idNv", idNV);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    ID.DataPropertyName = "ID";
                    IdTiec.DataPropertyName = "IDTIEC";
                    CustomerName.DataPropertyName = "TENKHACHHANG";
                    TotalMoney.DataPropertyName = "TONGTIEN";
                    InvoiceDate.DataPropertyName = "NGAYXUATHOADON";
                    DiscountPercent.DataPropertyName = "GIAMGIA";

                    dataGridViewReport.DataSource = dataTable;
                }
            }
        }


        private void GetNearest5month(string Thang = null, string Nam = null)
        {
            if (Thang == null)
            {
                Thang = DateTime.Now.Month.ToString();
            }
            if (Nam == null)
            {
                Nam = DateTime.Now.Year.ToString();
            }

            int currentMonth = int.Parse(Thang);
            int currentYear = int.Parse(Nam);

            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand("GetNearest5month", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NAM", currentYear);
                    cmd.Parameters.AddWithValue("@THANG", currentMonth);
                    if (NvName != "admin")
                    {
                        cmd.Parameters.AddWithValue("@IDNHANVIEN", idNV);

                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@IDNHANVIEN", DBNull.Value);
                    }


                    cmd.Parameters.Add("@DTThang1", SqlDbType.Money).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@DTThang2", SqlDbType.Money).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@DTThang3", SqlDbType.Money).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@DTThang4", SqlDbType.Money).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@DTThang5", SqlDbType.Money).Direction = ParameterDirection.Output;

                    cmd.Parameters.Add("@SoLuongTiec1", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@SoLuongTiec2", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@SoLuongTiec3", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@SoLuongTiec4", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@SoLuongTiec5", SqlDbType.Int).Direction = ParameterDirection.Output;

                    cmd.Parameters.Add("@Month1", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Year1", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Month2", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Year2", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Month3", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Year3", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Month4", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Year4", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Month5", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Year5", SqlDbType.Int).Direction = ParameterDirection.Output;

                    con.Open();
                    cmd.ExecuteNonQuery();

                    

                    decimal?[] DTThangValues = new decimal?[5];
                    int?[] SoLuongTiecValues = new int?[5];
                    int?[] MonthValues = new int?[5];
                    int?[] YearValues = new int?[5];

                    for (int i = 0; i < 5; i++)
                    {
                        DTThangValues[i] = cmd.Parameters["@DTThang" + (i + 1)].Value == DBNull.Value ? null : (decimal?)cmd.Parameters["@DTThang" + (i + 1)].Value;
                        SoLuongTiecValues[i] = cmd.Parameters["@SoLuongTiec" + (i + 1)].Value == DBNull.Value ? null : (int?)cmd.Parameters["@SoLuongTiec" + (i + 1)].Value;
                        MonthValues[i] = cmd.Parameters["@Month" + (i + 1)].Value == DBNull.Value ? null : (int?)cmd.Parameters["@Month" + (i + 1)].Value;
                        YearValues[i] = cmd.Parameters["@Year" + (i + 1)].Value == DBNull.Value ? null : (int?)cmd.Parameters["@Year" + (i + 1)].Value;
                    }

                    var chartData = new List<Tuple<string, decimal, int, int, int>>();
                    


                    for (int i = 0; i < 5; i++)
                    {
                        if (DTThangValues[i].HasValue && SoLuongTiecValues[i].HasValue && MonthValues[i].HasValue && YearValues[i].HasValue)
                        {
                            string monthLabel = $"{new DateTime(YearValues[i].Value, MonthValues[i].Value, 1):MMMM yyyy}";
                            chartData.Add(Tuple.Create(monthLabel, DTThangValues[i].Value, SoLuongTiecValues[i].Value, MonthValues[i].Value, YearValues[i].Value));
                        }
                    }
                    chartData = chartData.OrderBy(data => new DateTime(data.Item5, data.Item4, 1)).ToList();
                    chart1.Series.Clear();
                   var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
                    {
                        Name = "Doanh Thu Mỗi Tháng",
                        IsValueShownAsLabel = true,
                        ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
                    };
                    chart1.Series.Add(series1);

                    var series2 = new System.Windows.Forms.DataVisualization.Charting.Series
                    {
                        Name = "Số Lượng Tiệc",
                        IsValueShownAsLabel = true,
                        ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
                    };
                    chart1.Series.Add(series2);

                    foreach (var data in chartData)
                    {
                        if (data.Item2 != 0)
                        {
                            var point = series1.Points.AddXY($"{data.Item1}", data.Item2);
                        }

                    }
                }
            }
        }

        private void CalculateDailyRevenueRatio(string Thang = null, string Nam = null)
        {
            if (Thang == null)
            {
                Thang = DateTime.Now.Month.ToString();
            }
            if (Nam == null)
            {
                Nam = DateTime.Now.Year.ToString();
            }

            int currentMonth = int.Parse(Thang);
            int currentYear = int.Parse(Nam);

            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand("CalculateDailyRevenueRatio", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Month", currentMonth);
                    cmd.Parameters.AddWithValue("@Year", currentYear);
                    if (NvName != "admin")
                    {
                        cmd.Parameters.AddWithValue("@IDNHANVIEN", idNV);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@IDNHANVIEN", DBNull.Value);
                    }

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    chart2.Series.Clear();
                    var series = new System.Windows.Forms.DataVisualization.Charting.Series
                    {
                        Name = "Daily Revenue Ratio",
                        IsValueShownAsLabel = true,
                        ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line 
                    };
                    chart2.Series.Add(series);
                  
                    chart2.Titles.Add("Biểu đồ tỉ lệ doanh thu theo ngày trong tháng");

                    while (reader.Read())
                    {
                        int dayOfMonth = reader.GetInt32(0);
                        decimal revenueRatio = (decimal)reader["DailyRevenue"]; 

                        series.Points.AddXY($"Day {dayOfMonth}", revenueRatio);
                    }

                    reader.Close();
                }
            }
        }


        private void SearchByMonth_Click(object sender, EventArgs e)
        {
            string SearchMonthYear = MonthYear.Value.ToString();
            string Nam = null;
            string Thang = null;

            if (!string.IsNullOrEmpty(SearchMonthYear))
            {
                
                        Thang = SearchMonthYear.Split('/')[0];
                        Nam = SearchMonthYear.Split('/')[1];
                Console.WriteLine(Thang);
                Console.WriteLine(Nam);
                CalculateDailyRevenueRatio(Thang, Nam);
                GetNearest5month(Thang, Nam);
                LoadGridViewReport(Thang, Nam);
                ProdPeferiod(Thang, Nam);

            }
           
          

            


        }
        private void LabelReSize(System.Windows.Forms.Label label)
        {
            float widthRatio = (float)this.ClientSize.Width / originalFormSize.Width;
            float heightRatio = (float)this.ClientSize.Height / originalFormSize.Height;
            float newFontSize = 0;
            float LabelXRatio = 0;
            float LabelYRatio = 0;
            if (label.Name == "ReportOfMonth")
            {
                newFontSize = initialFontSizeReportOfMonth * Math.Min(widthRatio, heightRatio);
                LabelXRatio = ReportOfMonthXRatio;
                LabelYRatio = ReportOfMonthYRatio;
            }
            else if (label.Name == "label2")
            {
                newFontSize = initialFontSizeLabel2 * Math.Min(widthRatio, heightRatio);
                LabelXRatio = Label2XRatio;
                LabelYRatio = Label2YRatio;
            }
            else if (label.Name == "label4")
            {
                newFontSize = initialFontSizeLabel4 * Math.Min(widthRatio, heightRatio);
                LabelXRatio = Label4XRatio;
                LabelYRatio = Label4YRatio;
                label.Font = new Font(label.Font.FontFamily, newFontSize, System.Drawing.FontStyle.Bold);
            }
            else if (label.Name == "TotalVenueValue")
            {
                newFontSize = initialFontSizeTotalVenueValue * Math.Min(widthRatio, heightRatio);
                LabelXRatio = TotalVenueValueXRatio;
                LabelYRatio = TotalVenueValueYRatio;
                label.Font = new Font(label.Font.FontFamily, newFontSize, System.Drawing.FontStyle.Bold);
            }
            else if (label.Name == "label6")
            {
                newFontSize = initialFontSizeLabel6 * Math.Min(widthRatio, heightRatio);
                LabelXRatio = Label6XRatio;
                LabelYRatio = Label6YRatio;
                label.Font = new Font(label.Font.FontFamily, newFontSize, System.Drawing.FontStyle.Bold);
            }
            else if (label.Name == "totalPartyValue")
            {
                newFontSize = initialFontSizetotalPartyValue * Math.Min(widthRatio, heightRatio);
                LabelXRatio = totalPartyValueXRatio;
                LabelYRatio = totalPartyValueYRatio;
                label.Font = new Font(label.Font.FontFamily, newFontSize, System.Drawing.FontStyle.Bold);
            }
            else if (label.Name == "label1")
            {
                newFontSize = initialFontSizeLabel1 * Math.Min(widthRatio, heightRatio);
                LabelXRatio = Label1XRatio;
                LabelYRatio = Label1YRatio;
                label.Font = new Font(label.Font.FontFamily, newFontSize, System.Drawing.FontStyle.Bold);
            }
            else if (label.Name == "label5")
            {
                newFontSize = initialFontSizeLabel5 * Math.Min(widthRatio, heightRatio);
                LabelXRatio = Label5XRatio;
                LabelYRatio = Label5YRatio;
                label.Font = new Font(label.Font.FontFamily, newFontSize, System.Drawing.FontStyle.Bold);
            }
            else if (label.Name == "RevenueValue")
            {
                newFontSize = initialFontSizeRevenueValue * Math.Min(widthRatio, heightRatio);
                LabelXRatio = RevenueValueXRatio;
                LabelYRatio = RevenueValueYRatio;
                label.Font = new Font(label.Font.FontFamily, newFontSize, System.Drawing.FontStyle.Bold);
            }
            else if (label.Name == "label3")
            {
                newFontSize = initialFontSizeLabel3 * Math.Min(widthRatio, heightRatio);
                LabelXRatio = Label3XRatio;
                LabelYRatio = Label3YRatio;
            }
            else if (label.Name == "label8")
            {
                newFontSize = initialFontSizeLabel8 * Math.Min(widthRatio, heightRatio);
                LabelXRatio = Label8XRatio;
                LabelYRatio = Label8YRatio;
                label.Font = new Font(label.Font.FontFamily, newFontSize, System.Drawing.FontStyle.Bold);
            }
            else if (label.Name == "label10")
            {
                newFontSize = initialFontSizeLabel10 * Math.Min(widthRatio, heightRatio);
                LabelXRatio = Label10XRatio;
                LabelYRatio = Label10YRatio;
                label.Font = new Font(label.Font.FontFamily, newFontSize, System.Drawing.FontStyle.Bold);
            }
            else if (label.Name == "label11")
            {
                newFontSize = initialFontSizeLabel11 * Math.Min(widthRatio, heightRatio);
                LabelXRatio = Label11XRatio;
                LabelYRatio = Label11YRatio;
                label.Font = new Font(label.Font.FontFamily, newFontSize, System.Drawing.FontStyle.Bold);
            }
            else if (label.Name == "totalSerivceValue")
            {
                newFontSize = initialFontSizetotalServiceValue * Math.Min(widthRatio, heightRatio);
                LabelXRatio = totalServiceValueXRatio;
                LabelYRatio = totalServiceValueYRatio;
                label.Font = new Font(label.Font.FontFamily, newFontSize, System.Drawing.FontStyle.Bold);
            }
            else if (label.Name == "totalFoodValue")
            {
                newFontSize = initialFontSizetotalFoodValue * Math.Min(widthRatio, heightRatio);
                LabelXRatio = totalFoodValueXRatio;
                LabelYRatio = totalFoodValueYRatio;
                label.Font = new Font(label.Font.FontFamily, newFontSize, System.Drawing.FontStyle.Bold);
            }
            else if (label.Name == "totalTableValue")
            {
                newFontSize = initialFontSizetotalTableValue * Math.Min(widthRatio, heightRatio);
                LabelXRatio = totalTableValueXRatio;
                LabelYRatio = totalTableValueYRatio;
                label.Font = new Font(label.Font.FontFamily, newFontSize, System.Drawing.FontStyle.Bold);
            }
            if (newFontSize > 0)
            {
                if (label.Name == "label4") return;
                if (label.Name == "TotalVenueValue") return;
                if (label.Name == "label6") return;
                if (label.Name == "label1") return;
                if (label.Name == "label5") return;
                if (label.Name == "RevenueValue") return;
                if (label.Name == "totalPartyValue") return;
                if (label.Name == "label8") return;
                if (label.Name == "label10") return;
                if (label.Name == "label11") return;
                if (label.Name == "totalSerivceValue") return;
                if (label.Name == "totalFoodValue") return;
                if (label.Name == "totalTableValue") return;
                label.Font = new Font(label.Font.FontFamily, newFontSize);
            }

            using (Graphics g = this.CreateGraphics())
            {
                SizeF stringSize = g.MeasureString(label.Text, label.Font);
                label.Size = new System.Drawing.Size((int)stringSize.Width + 10, (int)stringSize.Height + 10);
            }
            int newLabelX = (int)(LabelXRatio * this.ClientSize.Width);
            int newLabelY = (int)(LabelYRatio * this.ClientSize.Height);

            label.Location = new System.Drawing.Point(newLabelX, newLabelY);
        }
        private void Report_Resize(object sender, EventArgs e)
        {
            if (originalFormSize.Width == 0 || originalFormSize.Height == 0) return;
            float xRatio = (float)this.Width / originalFormSize.Width;
            float yRatio = (float)this.Height / originalFormSize.Height;
            ResizeControl(panel1OriginalRect, panel1, xRatio, yRatio);
            ResizeControl(panel2OriginalRect, panel2, xRatio, yRatio);
            ResizeControl(panel3OriginalRect, panel3, xRatio, yRatio);
            ResizeControl(panel4OriginalRect, panel4, xRatio, yRatio);
            ResizeControl(dataGridViewReportOriginalRect, dataGridViewReport, xRatio, yRatio);
            ResizeControl(MonthYearOriginalRect, MonthYear, xRatio, yRatio);
            ResizeControl(SearchByMonthOriginalRect, SearchByMonth, xRatio, yRatio);
            ResizeControl(Chart1OriginalRect, chart1, xRatio, yRatio);
            ResizeControl(Chart2OriginalRect, chart2, xRatio, yRatio);
            LabelReSize(ReportOfMonth);
            LabelReSize(label2);
            LabelReSize(label4);
            LabelReSize(TotalVenueValue);
            LabelReSize(label6);
            LabelReSize(totalPartyValue);
            LabelReSize(label1);
            LabelReSize(RevenueValue);
            LabelReSize(label5);
            LabelReSize(label3);
            LabelReSize(label8);
            LabelReSize(label10);
            LabelReSize(label11);
            LabelReSize(totalSerivceValue);
            LabelReSize(totalFoodValue);
            LabelReSize(totalTableValue);
        }

        private void ResizeControl(Rectangle originalRect, Control control, float xRatio, float yRatio)
        {
            int newX = (int)(originalRect.X * xRatio);
            int newY = (int)(originalRect.Y * yRatio);
            int newWidth = (int)(originalRect.Width * xRatio);
            int newHeight = (int)(originalRect.Height * yRatio);
            newX = Math.Max(newX, 0);
            newY = Math.Max(newY, 0);
            newWidth = Math.Max(newWidth, 10);
            newHeight = Math.Max(newHeight, 10);

            if (newX + newWidth > this.ClientSize.Width)
            {
                newWidth = this.ClientSize.Width - newX;
            }
            if (newY + newHeight > this.ClientSize.Height)
            {
                newHeight = this.ClientSize.Height - newY;
            }
            control.Location = new System.Drawing.Point(newX, newY);
            control.Size = new System.Drawing.Size(newWidth, newHeight);
        }
    }
}