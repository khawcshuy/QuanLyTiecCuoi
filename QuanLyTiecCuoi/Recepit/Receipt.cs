using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyTiecCuoi
{

    public partial class Receipt : Form
    {
        private decimal PenaltyRatioValue = 0.1m;

        private string conString;

        private Form _parenform;

       
        public Receipt(string conString, Form parenform, int idtiec)
        {
            InitializeComponent();
            this.conString = conString;
            _parenform = parenform;
            tiecId.Text = idtiec.ToString();
        }


        public class CustomerInfo
        {
            public string Customerid { get; set; }
            public string CustomerName { get; set; }
            public string Address { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string Groom { get; set; }
            public string Bride { get; set; }
            public DateTime OrderDate { get; set; }
            public DateTime DueDate { get; set; }

            public int numberOftable {  get; set; }

            public decimal Deposit { get; set; }

            public int IdTiec { get; private set; }

            // Constructor để khởi tạo một đối tượng CustomerInfo từ một SqlDataReader
            public CustomerInfo(SqlDataReader reader)
            {
                Customerid = reader["ID"].ToString();
                CustomerName = reader["TENKHACHHANG"].ToString();
                Address = reader["DIACHI"].ToString();
                Email = reader["EMAIL"].ToString();
                Phone = reader["DIENTHOAI"].ToString();
                Groom = reader["TENCODAU"].ToString();
                Bride = reader["TENCHURE"].ToString();
                OrderDate = (DateTime)reader["NGAYLAP"];
                DueDate = (DateTime)reader["NGAYTOCHUC"];
                Deposit = (decimal)reader.GetDecimal(reader.GetOrdinal("TIENCOC"));
                numberOftable = (Int32)reader["SOLUONGBAN"];
                IdTiec = (Int32)reader["IDTIEC"];
            }
        }

        private CustomerInfo LoadCustomerInfo(string IdTiec)
        {
            int parsedIdTiec;

            CustomerInfo customerInfo = null;
            if (!int.TryParse(IdTiec, out parsedIdTiec))
            {
                MessageBox.Show("ID Tiệc không hợp lệ. Vui lòng nhập lại!");
                return customerInfo;
            }
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                string query = "SELECT *,T.ID AS IDTIEC FROM KHACHHANGINFOR I inner join TIEC T ON I.ID = T.IDTHONGTINKHACHHANG  WHERE T.ID = @IdTiec";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@IdTiec", parsedIdTiec);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            customerInfo = new CustomerInfo(reader);
                            LoadCustomerInfoToUI(customerInfo);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin khách hàng!");
                        }
                    }
                }
            }

            return customerInfo;
        }

        private void LoadCustomerInfoToUI(CustomerInfo customer)
        {
            CustomerName.Text = customer.CustomerName;
            Address.Text = customer.Address;
            Email.Text = customer.Email;
            Phone.Text = customer.Phone;
            Groom.Text = customer.Groom;
            Bride.Text = customer.Bride;
            OrderDate.Value = customer.OrderDate;
            Date.Value = customer.DueDate;
            deposit.Text = customer.Deposit.ToString();
            NumberofTable.Text = customer.numberOftable.ToString();
            IdKhachhang.Text = customer.Customerid.ToString();
        }
        private decimal loadFood(string customerId)
        {
            decimal total = 0.0m;
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                string query = "SELECT F.TENMONAN, F.DONGIA, F.NOTE FROM FOOD F JOIN FOODINUSE FI" +
                    " ON F.ID = FI.IDTHUCDON JOIN TIEC T ON FI.IDTIEC = T.ID" +
                    " WHERE T.IDTHONGTINKHACHHANG = @customerId";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@customerId", customerId);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        decimal dongia = (decimal)row["DONGIA"];
                        total += dongia;

                       
                    }

                    if (dt.Rows.Count > 0)
                    {
                        Menuview.DataSource = dt;

                        Menuview.Columns[0].HeaderText = "Tên Món Ăn";
                        Menuview.Columns[1].HeaderText = "Đơn Giá";
                        Menuview.Columns[2].HeaderText = "Ghi Chú";
                        totalMenu.Text = total.ToString();

                    }
                    else
                    {
                        Menuview.DataSource = null;
                        Menuview.Columns.Clear();
                    }
                }
            }
            return total;
        }


        private decimal LoadService(string customerId)
        {
            decimal totalSer = 0.0m;
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                string query = "SELECT DV.TENDICHVU , DV.LOAIDICHVU , DV.GIADICHVU " +
                               "FROM TIEC T JOIN DICHVUINUSE DI ON T.ID = DI.IDTIEC " +
                               "JOIN DICHVU DV ON DI.IDDICHVU = DV.ID " +
                               "WHERE T.IDTHONGTINKHACHHANG = @customerID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@customerID", customerId);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);


                    if (dt.Rows.Count > 0) // Kiểm tra nếu DataTable có ít nhất một dòng dữ liệu
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            totalSer += (decimal)row["GIADICHVU"];
                           
                        }
                        ServiceView.DataSource = dt;

                        ServiceView.Columns["TENDICHVU"].HeaderText = "Tên Dịch Vụ";
                        ServiceView.Columns["LOAIDICHVU"].HeaderText = "Loại Dịch Vụ";
                        ServiceView.Columns["GIADICHVU"].HeaderText = "Giá Dịch Vụ";
                        totalService.Text = totalSer.ToString();


                        foreach (DataGridViewColumn column in ServiceView.Columns)
                        {
                            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        }
                    }
                    else
                    {
                        ServiceView.DataSource = null;
                        ServiceView.Columns.Clear();
                    }
                }
            }
            return totalSer;
        }





        
     
        



        private decimal LoadHD(string customerId)
        {
            decimal VenuePrice = 0.0m; // Khởi tạo VenuePrice ban đầu

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                string query = "SELECT * FROM SANHINFOR S INNER JOIN TIEC T ON S.ID = T.IDLOAISANH WHERE T.IDTHONGTINKHACHHANG = @customerId";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@customerId", customerId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) 
                        {
                            VenuePrice = reader.GetDecimal(reader.GetOrdinal("MINMONEY"));
                            VenueFee.Text = VenuePrice.ToString();
                        }
                        else
                        {
                            VenueFee.Text = "0";
                        }
                    }
                }
            }

            return VenuePrice;

            
        }


        



        
        public static int CalculateDaysLate(DateTime partyDate)
        {
            DateTime currentDate = DateTime.Today;

            TimeSpan difference = currentDate - partyDate;

            int days = difference.Days;
            if (days < 0)
            {
                days = 0;
            }
            return days;
        }



        private void RecalculateTotal(CustomerInfo customer)
        {
            

           

            DateTime partyDate = customer.DueDate;

            decimal Venue = LoadHD(customer.Customerid);

            decimal totalFood = loadFood(customer.Customerid);

            decimal totalService = LoadService(customer.Customerid);

            decimal TienPhat = (PenaltyRatioValue * (decimal)CalculateDaysLate(partyDate));

            int discount;
            if (!int.TryParse(Discount.Text, out discount))
            {
                discount = 0;
            }

            decimal total = (customer.numberOftable * totalFood) + totalService + Venue;
            decimal totalHD = total + total * TienPhat;
            Total.Text = totalHD.ToString();
            decimal Paid = totalHD - customer.Deposit;

            Paidment.Text = Paid.ToString();
        }


        private void btnSearchClick_Click(object sender, EventArgs e)
        {
            string IdTiec = tiecId.Text;

            CustomerInfo customer = LoadCustomerInfo(IdTiec);
            if (customer == null)
            {
                return;
            }
            RecalculateTotal(customer);
            decimal totalFood = 0.0m;
            decimal totalSer = 0.0m;
            DateTime partyDate = DateTime.Today;
        
            
            totalFood = loadFood(customer.Customerid);
            partyDate = customer.DueDate;
            totalSer = LoadService(customer.Customerid);
            LoadHD(customer.Customerid);
            PenaltyRatio.Text = PenaltyRatioValue.ToString();
            DateLate.Text = CalculateDaysLate(partyDate).ToString();
            


        }
        


        

        private void PenaltyRatio_TextChanged(object sender, EventArgs e)
        {
            CustomerInfo customer = LoadCustomerInfo(tiecId.Text);
            if (decimal.TryParse(PenaltyRatio.Text, out decimal newRatio))
            {
                // Cập nhật giá trị của biến tỉ số phạt
                PenaltyRatioValue = newRatio;
        

            }
            else
            {
                MessageBox.Show("Vui lòng nhập một giá trị số hợp lệ cho tỉ số phạt.");
            }
            RecalculateTotal(customer);
        }

        public class hoaDon
        {
            public string idNhanvien { get; set; }
            public string idTiec { get; set; }

            public float Total { get; set; }

            public DateTime ngayxuatHD { get; set; }

        }
        private void SaveHoaDon(int customerId, int idTiec, float totalBill, float paid)
        {
            int discount;
            if (!int.TryParse(Discount.Text, out discount))
            {
                discount = 0;
            }

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();

                // Check if a record with the given idTiec already exists
                string checkQuery = "SELECT COUNT(*) FROM HOADON WHERE IDTIEC = @idTiec";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                {
                    checkCmd.Parameters.AddWithValue("@idTiec", idTiec);
                    int existingRecords = (int)checkCmd.ExecuteScalar();

                    if (existingRecords > 0)
                    {
                        // Prompt for confirmation if the record already exists
                        DialogResult result = MessageBox.Show("A record with the given ID already exists. Do you want to overwrite it?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.No)
                        {
                            // If the user chooses not to overwrite, exit the method
                            return;
                        }
                        else
                        {
                            // Update the existing record
                            string updateQuery = "UPDATE HOADON SET IDNHANVIEN = @idNhanVien, TONGTIEN = @tongTien, NGAYXUATHOADON = @ngayXuatHoadon, THUCTRA = @paid, GIAMGIA = @discount WHERE IDTIEC = @idTiec";
                            using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                            {
                                updateCmd.Parameters.AddWithValue("@idNhanVien", "1");
                                updateCmd.Parameters.AddWithValue("@tongTien", totalBill);
                                updateCmd.Parameters.AddWithValue("@ngayXuatHoadon", DateTime.Now);
                                updateCmd.Parameters.AddWithValue("@paid", paid);
                                updateCmd.Parameters.AddWithValue("@discount", discount);
                                updateCmd.Parameters.AddWithValue("@idTiec", idTiec);
                                updateCmd.ExecuteNonQuery();
                            }
                        }
                    }
                    else
                    {
                        // Insert a new record
                        string insertQuery = "INSERT INTO HOADON (IDNHANVIEN, IDTIEC, TONGTIEN, NGAYXUATHOADON, THUCTRA, GIAMGIA) VALUES (@idNhanVien, @idTiec, @tongTien, @ngayXuatHoadon, @paid, @discount)";
                        using (SqlCommand insertCmd = new SqlCommand(insertQuery, con))
                        {
                            insertCmd.Parameters.AddWithValue("@idNhanVien", "1");
                            insertCmd.Parameters.AddWithValue("@idTiec", idTiec);
                            insertCmd.Parameters.AddWithValue("@tongTien", totalBill);
                            insertCmd.Parameters.AddWithValue("@ngayXuatHoadon", DateTime.Now);
                            insertCmd.Parameters.AddWithValue("@paid", paid);
                            insertCmd.Parameters.AddWithValue("@discount", discount);
                            insertCmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }



        public event EventHandler ConfirmClicked;
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            int customerId = Int16.Parse(tiecId.Text);
            float totalBill = float.Parse(Total.Text); 
            int IdTiecValue = Int16.Parse(IdKhachhang.Text);
            float Paid  = float.Parse(Paidment.Text);

            SaveHoaDon(customerId, IdTiecValue, totalBill, Paid);

            MessageBox.Show("Đã lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ConfirmClicked?.Invoke(this, EventArgs.Empty);

            this.Close();
        }

        private void Discount_TextChanged(object sender, EventArgs e)
        {
            string customerId = tiecId.Text;
            CustomerInfo customer = LoadCustomerInfo(customerId);
            DateTime partyDate = customer.DueDate;

            decimal Venue = LoadHD(customerId);

            decimal totalFood = loadFood(customerId);

            decimal totalService = LoadService(customerId);

            decimal TienPhat = (PenaltyRatioValue * (decimal)CalculateDaysLate(partyDate));



            decimal discount;
            if (!decimal.TryParse(Discount.Text, out discount))
            {
                discount = 0;
                Discount.Text = "0";
            }

            decimal total = (customer.numberOftable * totalFood) + totalService + Venue;
            total = total - total*discount/100;
            decimal totalHD = total + total * TienPhat;
            Total.Text = totalHD.ToString();
            decimal Paid = totalHD - customer.Deposit;

            Paidment.Text = Paid.ToString();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            if(_parenform != null)
            {
                string IdTiec = tiecId.Text;

                CustomerInfo customer = LoadCustomerInfo(IdTiec);
                if (customer == null)
                {
                    return;
                }
                RecalculateTotal(customer);
                decimal totalFood = 0.0m;
                decimal totalSer = 0.0m;
                DateTime partyDate = DateTime.Today;


                totalFood = loadFood(customer.Customerid);
                partyDate = customer.DueDate;
                totalSer = LoadService(customer.Customerid);
                LoadHD(customer.Customerid);
                PenaltyRatio.Text = PenaltyRatioValue.ToString();
                DateLate.Text = CalculateDaysLate(partyDate).ToString();

            }
        }

        private void customerID_TextChanged(object sender, EventArgs e)
        {
            //string SearchText = tiecId.Text.Trim();
            //string FindIdTiec = "SELECT T.ID , TENKHACHHANG FROM TIEC T, KHACHHANGINFOR K WHERE T.IDTHONGTINKHACHHANG = K.ID AND( K.DIENTHOAI LIKE '%' + @searchText + '%' OR T.ID LIKE '%' + @searchText + '%' OR TENKHACHHANG LIKE '%' + @searchText + '%' )";

            //if (tiecId.TextLength > 1)
            //{
            //    using (SqlConnection con = new SqlConnection(conString))
            //    {

            //        using (SqlCommand cmd = new SqlCommand(FindIdTiec, con))
            //        {
            //            cmd.Parameters.AddWithValue("@searchText", SearchText);
            //            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //            DataTable table = new DataTable();
            //            adapter.Fill(table);
            //            if (table.Rows.Count > 0 && table != null)
            //            {
            //                IdTiec.DataPropertyName = "ID";
            //                CustomerNameFind.DataPropertyName = "TENKHACHHANG";
            //                SearchTiecAndKhachHang.DataSource = table;
            //                int rowHeight = 30;
            //                int headerHeight = 20; 

            //                SearchTiecAndKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            //                SearchTiecAndKhachHang.ColumnHeadersHeight = headerHeight;

            //                int totalHeight = SearchTiecAndKhachHang.Rows.Count * rowHeight + headerHeight;
            //                SearchTiecAndKhachHang.Height = totalHeight;
            //            }
            //            else
            //            {
            //                SearchTiecAndKhachHang.Height = 0;
            //            }
            //        }
            //    }
            //}
            //else if (Phone.TextLength <= 0)
            //{
            //    SearchTiecAndKhachHang.Height = 0;
            //}
        }

        private void SearchTiecAndKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string id = SearchTiecAndKhachHang.Rows[e.RowIndex].Cells["IdTiec"].Value.ToString();

                SearchTiecAndKhachHang.Height = 0;
                
                tiecId.Text = id;
            }


            string IdTiec = tiecId.Text;

            CustomerInfo customer = LoadCustomerInfo(IdTiec);
            if (customer == null)
            {
                return;
            }
            RecalculateTotal(customer);
            decimal totalFood = 0.0m;
            decimal totalSer = 0.0m;
            DateTime partyDate = DateTime.Today;


            totalFood = loadFood(customer.Customerid);
            partyDate = customer.DueDate;
            totalSer = LoadService(customer.Customerid);
            LoadHD(customer.Customerid);
            PenaltyRatio.Text = PenaltyRatioValue.ToString();
            DateLate.Text = CalculateDaysLate(partyDate).ToString();


        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}



