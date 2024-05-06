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
        private float PenaltyRatioValue = 0.1f;

        private string conString = @"Data Source=ADMINISTRATOR;Initial Catalog=QUANLYTIECCUOI;Integrated Security=True;Connect Timeout=30;";


        public Receipt()
        {
            InitializeComponent();
        }

        public class CustomerInfo
        {
            public string CustomerName { get; set; }
            public string Address { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string Groom { get; set; }
            public string Bride { get; set; }
            public DateTime OrderDate { get; set; }
            public DateTime DueDate { get; set; }

            public int numberOftable {  get; set; }

            public float Deposit { get; set; }

            public int IdTiec { get; private set; }

            // Constructor để khởi tạo một đối tượng CustomerInfo từ một SqlDataReader
            public CustomerInfo(SqlDataReader reader)
            {
                CustomerName = reader["TENKHACHHANG"].ToString();
                Address = reader["DIACHI"].ToString();
                Email = reader["EMAIL"].ToString();
                Phone = reader["DIENTHOAI"].ToString();
                Groom = reader["TENCODAU"].ToString();
                Bride = reader["TENCHURE"].ToString();
                OrderDate = (DateTime)reader["NGAYLAP"];
                DueDate = (DateTime)reader["NGAYTOCHUC"];
                Deposit = (float)reader.GetDecimal(reader.GetOrdinal("TIENCOC"));
                numberOftable = (Int32)reader["SOLUONGBAN"];
                IdTiec = (Int32)reader["IDTIEC"];
            }
        }

        private CustomerInfo LoadCustomerInfo(string customerId)
        {
            CustomerInfo customerInfo = null;

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                string query = "SELECT *,T.ID AS IDTIEC FROM KHACHHANGINFOR I inner join TIEC T ON I.ID = T.IDTHONGTINKHACHHANG  WHERE I.ID = @customerId";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@customerId", customerId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            customerInfo = new CustomerInfo(reader);
                            LoadCustomerInfoToUI(customerInfo); // Thêm dữ liệu khách hàng vào giao diện
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
            // Gán dữ liệu khách hàng vào các thành phần của giao diện
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
            IdTiec.Text = customer.IdTiec.ToString();
        }
        private float loadFood(string customerId)
        {
            float total = 0;
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
                        // Lấy giá trị từ cột DONGIA của mỗi dòng và cộng dồn vào biến totalMenu
                        total += Convert.ToSingle(row["DONGIA"]);
                        object noteValue = row["NOTE"];

                        // Kiểm tra nếu giá trị là null, thay thế bằng một khoảng trắng
                        if (noteValue == DBNull.Value)
                        {
                            row["NOTE"] = ""; // Thay thế bằng khoảng trắng
                        }
                    }

                    if (dt.Rows.Count > 0)
                    {
                        Menuview.DataSource = dt;

                        // Đặt lại tên của các cột
                        Menuview.Columns[0].HeaderText = "Tên Món Ăn";
                        Menuview.Columns[1].HeaderText = "Đơn Giá";
                        Menuview.Columns[2].HeaderText = "Ghi Chú";
                        totalMenu.Text = total.ToString();

                    }
                    else
                    {
                        // Xóa dữ liệu cũ của DataGridView và chỉ hiển thị tên cột
                        Menuview.DataSource = null;
                        Menuview.Columns.Clear();
                    }
                }
            }
            return total;
        }


        private float LoadService(string customerId)
        {
            float totalSer = 0;
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
                            // Lấy giá trị từ cột DONGIA của mỗi dòng và cộng dồn vào biến totalMenu
                            totalSer += Convert.ToSingle(row["GIADICHVU"]);
                           
                        }
                        ServiceView.DataSource = dt;

                        // Đặt lại tên của các cột
                        ServiceView.Columns["TENDICHVU"].HeaderText = "Tên Dịch Vụ";
                        ServiceView.Columns["LOAIDICHVU"].HeaderText = "Loại Dịch Vụ";
                        ServiceView.Columns["GIADICHVU"].HeaderText = "Giá Dịch Vụ";
                        totalService.Text = totalSer.ToString();


                        // Thiết lập AutoSizeMode để cột tự động điều chỉnh độ rộng
                        foreach (DataGridViewColumn column in ServiceView.Columns)
                        {
                            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        }
                    }
                    else
                    {
                        // Xóa dữ liệu cũ của DataGridView và chỉ hiển thị tên cột
                        ServiceView.DataSource = null;
                        ServiceView.Columns.Clear();
                    }
                }
            }
            return totalSer;
        }





        
     
        



        private float LoadHD(string customerId)
        {
            float VenuePrice = 0; // Khởi tạo VenuePrice ban đầu

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                string query = "SELECT * FROM SANHINFOR S INNER JOIN TIEC T ON S.ID = T.IDLOAISANH WHERE T.IDTHONGTINKHACHHANG = @customerId";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@customerId", customerId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) // Kiểm tra nếu có dòng dữ liệu được trả về
                        {
                            // Ép kiểu giá trị từ cột MINMONEY sang float và gán cho VenuePrice
                            VenuePrice = (float)reader.GetDecimal(reader.GetOrdinal("MINMONEY"));
                            VenueFee.Text = VenuePrice.ToString();
                        }
                        else
                        {
                            VenueFee.Text = "0";
                             // Thoát khỏi phương thức nếu không tìm thấy dữ liệu
                        }
                    }
                }
            }

            return VenuePrice;

            
        }


        



        
        public static int CalculateDaysLate(DateTime partyDate)
        {
            // Lấy ngày hiện tại
            DateTime currentDate = DateTime.Today;

            // Tính số ngày trễ bằng cách trừ ngày tổ chức tiệc từ ngày hiện tại
            TimeSpan difference = currentDate - partyDate;

            int days = difference.Days;
            if (days < 0)
            {
                days = 0;
            }
            // Trả về số ngày trễ, lấy giá trị tuyệt đối để đảm bảo kết quả không âm
            return days;
        }


        
        private void RecalculateTotal()
        {
            string customerId = customerID.Text;
            CustomerInfo customer = LoadCustomerInfo(customerId);
            DateTime partyDate = customer.DueDate;

            float Venue = LoadHD(customerId);

            float totalFood = loadFood(customerId);

            float totalService = LoadService(customerId);

            float TienPhat = (PenaltyRatioValue * (float)CalculateDaysLate(partyDate));

           

            int discount;
            if (!int.TryParse(Discount.Text, out discount))
            {
                discount = 0;
            } 

            float total = (customer.numberOftable * totalFood) + totalService + Venue;
            float totalHD = total + total*TienPhat;
            Total.Text = totalHD.ToString();
            float Paid = totalHD - customer.Deposit;

            Paidment.Text = Paid.ToString();
        }

        private void btnSearchClick_Click(object sender, EventArgs e)
        {
            RecalculateTotal();
            float totalFood = 0;
            float totalSer = 0;
            DateTime partyDate = DateTime.Today;
            string customerId = customerID.Text;
            totalFood = loadFood(customerId);
            CustomerInfo customer = LoadCustomerInfo(customerId);
            partyDate = customer.DueDate;
            totalSer = LoadService(customerId);
            LoadHD(customerId);
            PenaltyRatio.Text = PenaltyRatioValue.ToString();
            DateLate.Text = CalculateDaysLate(partyDate).ToString();
            


        }
        


        

        private void PenaltyRatio_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(PenaltyRatio.Text, out float newRatio))
            {
                // Cập nhật giá trị của biến tỉ số phạt
                PenaltyRatioValue = newRatio;
                RecalculateTotal();

            }
            else
            {
                MessageBox.Show("Vui lòng nhập một giá trị số hợp lệ cho tỉ số phạt.");
            }
            RecalculateTotal();
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




        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            int customerId = Int16.Parse(customerID.Text);
            float totalBill = float.Parse(Total.Text); 
            int IdTiecValue = Int16.Parse(IdTiec.Text);
            float Paid  = float.Parse(Paidment.Text);

            SaveHoaDon(customerId, IdTiecValue, totalBill, Paid);

            // Hiển thị thông báo "đã lưu thành công"
            MessageBox.Show("Đã lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Discount_TextChanged(object sender, EventArgs e)
        {
            string customerId = customerID.Text;
            CustomerInfo customer = LoadCustomerInfo(customerId);
            DateTime partyDate = customer.DueDate;

            float Venue = LoadHD(customerId);

            float totalFood = loadFood(customerId);

            float totalService = LoadService(customerId);

            float TienPhat = (PenaltyRatioValue * (float)CalculateDaysLate(partyDate));



            int discount;
            if (!int.TryParse(Discount.Text, out discount))
            {
                discount = 0;
                Discount.Text = "0";
            }

            float total = (customer.numberOftable * totalFood) + totalService + Venue;
            total = total - total*discount/100;
            float totalHD = total + total * TienPhat;
            Total.Text = totalHD.ToString();
            float Paid = totalHD - customer.Deposit;

            Paidment.Text = Paid.ToString();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {

        }
    }
}



