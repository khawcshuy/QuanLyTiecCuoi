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
        public Report(string conSring)
        {
            InitializeComponent();
            this.conString = conSring;
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

                    // Retrieve the values from the output parameters and handle nulls
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
            string query = "SELECT H.ID, IDTIEC, TONGTIEN, NGAYXUATHOADON,GIAMGIA, K.TENKHACHHANG FROM HOADON H, TIEC T, KHACHHANGINFOR K" +
                " WHERE T.ID = H.IDTIEC AND K.ID = T.IDTHONGTINKHACHHANG AND MONTH(NGAYXUATHOADON) = @THANG AND YEAR(NGAYXUATHOADON) = @NAM";
            using (SqlConnection con = new SqlConnection(conString))
            {

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@THANG", Thang);
                cmd.Parameters.AddWithValue("@NAM", Nam);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                ID.DataPropertyName = "ID";
                IdTiec.DataPropertyName
                    = "IDTIEC";
                CustomerName.DataPropertyName = "TENKHACHHANG";
                TotalMoney.DataPropertyName = "TONGTIEN";
                InvoiceDate.DataPropertyName = "NGAYXUATHOADON";
                DiscountPercent.DataPropertyName = "GIAMGIA";

                dataGridViewReport.DataSource = dataTable;


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

                    // Add output parameters
                    cmd.Parameters.Add("@DTThang", SqlDbType.Money).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@DTThang1", SqlDbType.Money).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@DTThang2", SqlDbType.Money).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@DTThang3", SqlDbType.Money).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@DTThang4", SqlDbType.Money).Direction = ParameterDirection.Output;


                    cmd.Parameters.Add("@SoLuongTiec1", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@SoLuongTiec2", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@SoLuongTiec3", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@SoLuongTiec4", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@SoLuongTiec5", SqlDbType.Int).Direction = ParameterDirection.Output;

                    con.Open();
                    cmd.ExecuteNonQuery();

                    // Retrieve the output values
                    decimal DTThang = (decimal)cmd.Parameters["@DTThang"].Value;
                    decimal DTThang1 = (decimal)cmd.Parameters["@DTThang1"].Value;
                    decimal DTThang2 = (decimal)cmd.Parameters["@DTThang2"].Value;
                    decimal DTThang3 = (decimal)cmd.Parameters["@DTThang3"].Value;
                    decimal DTThang4 = (decimal)cmd.Parameters["@DTThang4"].Value;
                    int SoLuongTiec1 = (int)cmd.Parameters["@SoLuongTiec1"].Value;
                    int SoLuongTiec2 = (int)cmd.Parameters["@SoLuongTiec2"].Value;
                    int SoLuongTiec3 = (int)cmd.Parameters["@SoLuongTiec3"].Value;
                    int SoLuongTiec4 = (int)cmd.Parameters["@SoLuongTiec4"].Value;
                    int SoLuongTiec5 = (int)cmd.Parameters["@SoLuongTiec5"].Value;
                    // Generate month labels
                    chart1.Series.Clear();

                    // Generate month labels
                    string[] monthLabels = new string[5];
                    for (int i = 0; i < 5; i++)
                    {
                        int month = currentMonth - i;
                        int year = currentYear;

                        if (month <= 0)
                        {
                            month += 12;
                            year--;
                        }

                        // Kiểm tra tính hợp lệ của tháng và năm trước khi tạo đối tượng DateTime
                        if (year > 0 && month > 0 && month <= 12)
                        {
                            monthLabels[i] = new DateTime(year, month, 1).ToString("MMMM yyyy");
                        }
                        else
                        {
                            // Xử lý trường hợp không hợp lệ (ví dụ: tháng <= 0 hoặc tháng > 12)
                            monthLabels[i] = "Invalid Date";
                        }
                    }


                    // Bind the data to the chart
                    var chartData = new List<Tuple<string, decimal, int>>
{
    Tuple.Create(monthLabels[0], DTThang, SoLuongTiec1),
    Tuple.Create(monthLabels[1], DTThang1, SoLuongTiec2),
    Tuple.Create(monthLabels[2], DTThang2, SoLuongTiec3),
    Tuple.Create(monthLabels[3], DTThang3, SoLuongTiec4),
    Tuple.Create(monthLabels[4], DTThang4, SoLuongTiec5)
};

                    // Create Series1 for column chart
                    var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
                    {
                        Name = "Doanh Thu Mỗi Tháng",
                        IsValueShownAsLabel = true,
                        ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
                    };
                    chart1.Series.Add(series1);

                    // Create Series2 for line chart (events)
                    var series2 = new System.Windows.Forms.DataVisualization.Charting.Series
                    {
                        Name = "Số Lượng Tiệc",
                        IsValueShownAsLabel = true,
                        ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
                    };
                    chart1.Series.Add(series2);

                    foreach (var data in chartData)
                    {
                        // Add data to Series1 (column chart)
                        if (data.Item2 != 0)
                        {
                            var point = series1.Points.AddXY(data.Item1, data.Item2);
                        }

                        // Add data to Series2 (line chart)
                        if (data.Item3 != 0)
                        {
                            var point = series2.Points.AddXY(data.Item1, data.Item3);
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

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Clear existing data in the pie chart
                    chart2.Series.Clear();
                    var series = new System.Windows.Forms.DataVisualization.Charting.Series
                    {
                        Name = "Daily Revenue Ratio",
                        IsValueShownAsLabel = true,
                        ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
                    };
                    chart2.Series.Add(series);

                    // Add data to the pie chart
                    while (reader.Read())
                    {
                        int dayOfMonth = reader.GetInt32(0);
                        decimal dailyRevenue = reader.GetDecimal(1);
                        decimal revenueRatio = reader.GetDecimal(2);

                        if (dailyRevenue != 0)  // Only add if daily revenue is not 0
                        {
                            series.Points.AddXY($"Day {dayOfMonth}", revenueRatio);
                        }
                    }

                    reader.Close();
                }
            }
        }

        private void FindMonth_Click(object sender, EventArgs e)
        {
            string SearchMonthYear = GetMonthYear.Text.Trim();
            int? Nam = null; // Sử dụng kiểu int? để cho phép giá trị null
            int? Thang = null; // Sử dụng kiểu int? để cho phép giá trị null

            if (!string.IsNullOrEmpty(SearchMonthYear))
            {
                if (SearchMonthYear.Length >= 1 && SearchMonthYear.Length <= 2 && int.TryParse(SearchMonthYear, out int month) && month <= 12)
                {
                    Thang = month;
                }
                else if (SearchMonthYear.Length == 4 && int.TryParse(SearchMonthYear, out int year))
                {
                    Nam = year;
                }
                else if (SearchMonthYear.Length == 6 && int.TryParse(SearchMonthYear.Substring(0, 2), out int monthPart) && int.TryParse(SearchMonthYear.Substring(2), out int yearPart))
                {
                    if (monthPart <= 12)
                    {
                        Thang = monthPart;
                        Nam = yearPart;
                    }
                }
            }

            ProdPeferiod(Thang.HasValue ? Thang.ToString() : null, Nam.HasValue ? Nam.ToString() : null);
            LoadGridViewReport(Thang.HasValue ? Thang.ToString() : null, Nam.HasValue ? Nam.ToString() : null);
            GetNearest5month(Thang.HasValue ? Thang.ToString() : null, Nam.HasValue ? Nam.ToString() : null);
            CalculateDailyRevenueRatio(Thang.HasValue ? Thang.ToString() : null, Nam.HasValue ? Nam.ToString() : null);
        }

    }
}