using QuanLyTiecCuoi;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanLyTiecCuoi
{
    public partial class Booking : Form
    {
        private string conString;

        public Booking(string _conString)
        {
            InitializeComponent();
            CalculateTotal();
            conString = _conString;
        }
        //private string conString = @"Data Source=DESKTOP-M4GHD5G\LUCY;Initial Catalog=QUANLYTIECCUOI;Persist Security Info=True;User ID=sa;Password=140403";

        private decimal DepositeRatioValue = 10.0m;


        private int MaxTableOfVenue;

        private decimal MinMoneyTableOfVenue;

        private decimal DepositeValue;


        private List<string> ListSelectedService;


        private List<string> ListSelectedFood;

        private int VenueSelectedId { set; get; }




        private void Booking_Load(object sender, EventArgs e)
        {


            string query = "SELECT MAX(ID) +1 AS MaxID FROM TIEC;";
            using (SqlConnection con = new SqlConnection(conString))
            {

                using (SqlCommand cmd = new SqlCommand(query, con))
                {



                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        IdTiec.Text = reader["MaxID"].ToString();

                    }
                    else
                    {
                        MessageBox.Show("Customer not found for the selected phone number.");
                    }


                }
            }

            DepositeRatio.Text = DepositeRatioValue.ToString() + "%";
            CalculateTotal();
            CheckMenuPrice();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Shift_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Total_TextChanged(object sender, EventArgs e)
        {

        }



        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void deposit_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }
        private void Phone_TextChanged(object sender, EventArgs e)
        {
            string phoneValue = Phone.Text.Trim();
            string FindPhone = "SELECT DIENTHOAI FROM KHACHHANGINFOR WHERE DIENTHOAI LIKE '%' + @searchText + '%'";
            if (Phone.TextLength > 1)
            {
                //    CustomerName.Text = Phone.TextLength.ToString();
                if (!Int64.TryParse(phoneValue, out _))
                {
                    MessageBox.Show("Invalid Phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Phone.Text = "";
                }


                using (SqlConnection con = new SqlConnection(conString))
                {

                    using (SqlCommand cmd = new SqlCommand(FindPhone, con))
                    {
                        cmd.Parameters.AddWithValue("@searchText", phoneValue);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        if (table.Rows.Count > 0 && table != null)
                        {
                            PhoneNumber.DataPropertyName = "DIENTHOAI";
                            SearchResult.DataSource = table;
                            SearchResult.Height = SearchResult.Rows.Count * 30;


                        }
                        else
                        {
                            SearchResult.Height = 0;
                        }
                    }
                }
            }
            else if (Phone.TextLength <= 0)
            {
                SearchResult.Height = 0;
            }


        }










        private void SearchResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string phoneNumber = SearchResult.Rows[e.RowIndex].Cells["PhoneNumber"].Value.ToString();
            string query = "SELECT * FROM KHACHHANGINFOR WHERE DIENTHOAI = @PhoneNumber";

            using (SqlConnection con = new SqlConnection(conString))
            {

                using (SqlCommand cmd = new SqlCommand(query, con))
                {


                    cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        Phone.Text = reader["DIENTHOAI"].ToString();
                        CustomerName.Text = reader["TENKHACHHANG"].ToString();
                        Address.Text = reader["DIACHI"].ToString();
                        Email.Text = reader["email"].ToString();
                        SearchResult.Height = 0;


                    }
                    else
                    {
                        MessageBox.Show("Customer not found for the selected phone number.");
                    }


                }
            }

        }



        private void ChooseMenu_Click(object sender, EventArgs e)
        {
            Food foodForm = new Food(conString,this);
            foodForm.ConfirmEvent += FoodForm_ConfirmEvent;
            if (ListSelectedFood != null)
            {
                foodForm.SelectedFoods = ListSelectedFood;
                foodForm._conString = conString;
               
            }
            foodForm.isChoosing = true;

            foodForm.Show();
        }


        private void FoodForm_ConfirmEvent(List<string> selectedFoods)
        {
            ListSelectedFood = selectedFoods;
            string query = "SELECT ID, TENMONAN, DONGIA FROM FOOD WHERE ID IN (" + string.Join(",", selectedFoods) + ")";
            decimal totalMenuPrice = 0.0m;
            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(query, connection);

                connection.Open();

                // Set the DataPropertyName for each column
                FoodId.DataPropertyName = "ID";
                FoodName.DataPropertyName = "TENMONAN";
                FoodPrice.DataPropertyName = "DONGIA";

                DataTable dataTable = new DataTable();

                if (dataTable != null)
                {
                    adapter.Fill(dataTable);
                }
                connection.Close();

                foreach (DataRow row in dataTable.Rows)
                {
                    if (row["DONGIA"] != DBNull.Value && decimal.TryParse(row["DONGIA"].ToString(), out decimal dongia))
                    {
                        totalMenuPrice += dongia;
                    }
                }
                totalMenu.Text = totalMenuPrice.ToString();



                MenuBookingView.DataSource = dataTable;
                CalculateTotal();
                CheckMenuPrice();

            }
        }

        private void MenuBookingView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Venue_TextChanged(object sender, EventArgs e)
        {

        }





        private void VenueForm_ConfirmEvent(int VenueSelectedId)
        {
            string query = "SELECT ID, TENSANH, TIENSANH, MaxTable, MINMONEY FROM SANHINFOR WHERE ID = @VenueId";

            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(query, connection);

                adapter.SelectCommand.Parameters.AddWithValue("@VenueId", VenueSelectedId);

                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();

                    adapter.Fill(dataTable);

                    connection.Close();

                    if (dataTable.Rows.Count > 0)
                    {
                        DataRow row = dataTable.Rows[0];

                        Venue.Text = row["TENSANH"].ToString();
                        VenueFee.Text = row["TIENSANH"].ToString();
                        MaxTableOfVenue = (int)row["MaxTable"];
                        MaxTable.Text = row["MaxTable"].ToString();
                        MinMoneyTableOfVenue = (decimal)row["MINMONEY"];
                        MinMoneyValue.Text = row["MINMONEY"].ToString();

                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy Venue có ID: " + VenueSelectedId, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thực hiện truy vấn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.VenueSelectedId = VenueSelectedId;
                if(MenuBookingView != null)
                { CheckMenuPrice();}    
                
                CalculateTotal();
                CountingTable();
            }
        }





        private void Venue_Click(object sender, EventArgs e)
        {
            if (ShiftParty.Text != "Chọn Ca")
            {
                Venue VenueForm = new Venue(this);
                VenueForm.ConfirmEvent += VenueForm_ConfirmEvent;
                VenueForm.VenueSelectedId = this.VenueSelectedId;
                VenueForm.AvailableVenueDate = Date.Value.Date;
                VenueForm.conString = conString
                    ;
                VenueForm.AvailableVenueShift = ShiftParty.Text;
                VenueForm.isChoosing = true;
                VenueForm.Show();
            }
            else
            {
                MessageBox.Show("Please select  shift");
            }
        }





        private void ServiceForm_ConfirmEvent(List<string> ListService)
        {
            ListSelectedService = ListService;
            decimal totalServicePrice = 0.0m;
            string query = "SELECT ID, TENDICHVU, GIADICHVU, LOAIDICHVU FROM DICHVU WHERE ID IN (" + string.Join(",", ListSelectedService) + ")";

            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(query, connection);

                connection.Open();

                ServiceId.DataPropertyName = "ID";
                ServiceType.DataPropertyName = "LOAIDICHVU";
                ServiceName.DataPropertyName = "TENMONAN";
                ServicePrice.DataPropertyName = "GIADICHVU";

                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                connection.Close();
                foreach (DataRow row in dataTable.Rows)
                {
                    if (row["GIADICHVU"] != DBNull.Value && decimal.TryParse(row["GIADICHVU"].ToString(), out decimal dongia))
                    {
                        totalServicePrice += dongia;
                    }
                }
                totalService.Text = totalServicePrice.ToString();
                ServiceBookingView.DataSource = dataTable;
                CalculateTotal();
            }
        }


        private void ChooseService_Click(object sender, EventArgs e)
        {

            QuanLyTiecCuoi.Service.Service serviceForm = new QuanLyTiecCuoi.Service.Service(this,conString);
            serviceForm.ConfirmEvent += ServiceForm_ConfirmEvent;
            if (ListSelectedFood != null)
            {
                serviceForm.SelectedService = ListSelectedService;
            }
            serviceForm.conString = conString;
            serviceForm.Show();
        }



        private void CountingTable()
        {
            int numberOfTables;
            int reservedTables;

            if (!int.TryParse(NumberOfTable.Text, out numberOfTables) || NumberOfTable.Text.Length == 0)
            {
                NumberOfTable.Text = "0";
                numberOfTables = 0;

            }
            if ((numberOfTables > MaxTableOfVenue && MaxTableOfVenue != 0))
            {
                MessageBox.Show("The venue can only accommodate " + MaxTableOfVenue.ToString() + " tables.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numberOfTables = 0;
                NumberOfTable.Text = "0";
            }

            if (!int.TryParse(ReservedTable.Text, out reservedTables) || ReservedTable.Text.Length == 0)
            {
                ReservedTable.Text = "0";
                reservedTables = 0;
            }


            if ((reservedTables > MaxTableOfVenue && MaxTableOfVenue != 0))
            {
                MessageBox.Show("The venue can only accommodate " + MaxTableOfVenue.ToString() + " tables.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reservedTables = 0;
                ReservedTable.Text = "0";
            }

            if (numberOfTables + reservedTables > MaxTableOfVenue && MaxTableOfVenue != 0)
            {
                MessageBox.Show("The venue can only accommodate " + MaxTableOfVenue.ToString() + " tables.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (numberOfTables + reservedTables > MaxTableOfVenue && MaxTableOfVenue != 0)
            {
                MessageBox.Show("The venue can only accommodate " + MaxTableOfVenue.ToString() + " tables.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                NumberTableFee.Text = (numberOfTables + reservedTables).ToString();
            }
            CalculateTotal();
        }

        private void NumberOfTable_TextChanged(object sender, EventArgs e)
        {

            CountingTable();
        }
        private void ReservedTable_TextChanged(object sender, EventArgs e)
        {
            CountingTable();
        }


        //CHECK GIÁ BÀN HỢP LỆ, GIÁ THỰC ĐƠN PHẢI LỚN HƠN GIÁ MỖI BÀN MÀ SẢNH ĐÓ QUY ĐỊNH

        private bool CheckMenuPrice()
        {
            decimal totalMenuPriceValue = 0.0m;

            if (totalMenu.Text.Length > 0 && !decimal.TryParse(totalMenu.Text, out totalMenuPriceValue))
            {
                MessageBox.Show("Please enter a valid menu total.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (totalMenuPriceValue < MinMoneyTableOfVenue && totalMenuPriceValue !=0)
                {
                    MessageBox.Show("Please choose more for the menu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    totalMenu.ForeColor = Color.Red;
                    return false;
                }
                else
                {
                    totalMenu.ForeColor = Color.Black;
                    return true;
                }
            }
        }




        private void CalculateTotal()
        {


            if (!string.IsNullOrEmpty(totalService.Text) || !string.IsNullOrEmpty(NumberTableFee.Text) || !string.IsNullOrEmpty(totalMenu.Text))
            {
                decimal value1 = 0.0m;
                decimal value2 = 0.0m;
                decimal value3 = 0.0m;
                decimal value4 = 0.0m;
                decimal total = 0.0m;

                if (!string.IsNullOrEmpty(totalService.Text) && decimal.TryParse(totalService.Text, out value1))
                {
                    total += value1;
                }

                if (!string.IsNullOrEmpty(totalMenu.Text) && decimal.TryParse(totalMenu.Text, out value3) && decimal.TryParse(NumberTableFee.Text, out value2))
                {
                    total += value3 * value2;
                }

                if (!string.IsNullOrEmpty(VenueFee.Text) && decimal.TryParse(VenueFee.Text, out value4))
                {
                    total += value4;
                }

                Total.Text = total.ToString();


                DepositeValue = total * DepositeRatioValue / 100.0m;



                deposit.Text = DepositeValue.ToString();
            }
        }


        // Nhập tiền cọc
        private void DepositeRatio_TextChanged(object sender, EventArgs e)
        {

            string Deposite = DepositeRatio.Text.Replace("%", "");

            if (!decimal.TryParse(Deposite, out DepositeRatioValue) && DepositeRatio.Text.Length > 0)
            {
                MessageBox.Show("Deposite Value is not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DepositeRatio.Text = "10%";
                DepositeRatioValue = 10.0m;
            }
            CalculateTotal();

        }


        private void Discount_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

      
        private void Confirm_Click(object sender, EventArgs e)
        {


            if (!CheckMenuPrice())
            {
                MessageBox.Show("Please choose more menu items.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string customer = CustomerName.Text;
                DateTime createDate = DateTime.Now; // You may need to adjust how you get the current date
                string address = Address.Text;
                string phoneNumber = Phone.Text;
                string email = Email.Text;
                string groomName = GroomName.Text;
                string bride = BrideName.Text;

                string shift = ShiftParty.Text;
                DateTime dueDate = Date.Value.Date;
                int numberOfTable = int.TryParse(NumberOfTable.Text, out int result) ? result : 0;
                int reserveTable = int.TryParse(ReservedTable.Text, out int result1) ? result1 : 0;

                string listIdFood = string.Empty;
                string listIdService = string.Empty;


                foreach (DataGridViewRow row in MenuBookingView.Rows)
                {
                    if (!row.IsNewRow)
                    {
                    
                        string foodId = row.Cells[0].Value.ToString();
                        listIdFood += foodId + ",";

                    }
                }

                foreach (DataGridViewRow row in ServiceBookingView.Rows)
                {
                    if (!row.IsNewRow)
                    {

                        string serviceId = row.Cells["ServiceId"].Value.ToString();
                        listIdService += serviceId + ",";

                    }
                }

                if (!string.IsNullOrEmpty(listIdFood))
                {
                    listIdFood = listIdFood.TrimEnd(',');
                    listIdService = listIdService.TrimEnd(',');
                }
                if (string.IsNullOrEmpty(customer) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(phoneNumber) ||
                    string.IsNullOrEmpty(groomName) || string.IsNullOrEmpty(bride) || string.IsNullOrEmpty(shift) ||
                    string.IsNullOrEmpty(NumberTableFee.Text.ToString()) || string.IsNullOrEmpty(listIdFood))
                {
                    MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    using (SqlConnection connection = new SqlConnection(conString))
                    {
                        using (SqlCommand command = new SqlCommand("BookingParty", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;

                            // Add parameters to the stored procedure
                            command.Parameters.AddWithValue("@Customer", customer);
                            command.Parameters.AddWithValue("@CreateDate", createDate);
                            command.Parameters.AddWithValue("@Adress", address);
                            command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                            command.Parameters.AddWithValue("@Email", email);
                            command.Parameters.AddWithValue("@GroomName", groomName);
                            command.Parameters.AddWithValue("@Bride", bride);
                            command.Parameters.AddWithValue("@IdVenue", VenueSelectedId);
                            command.Parameters.AddWithValue("@Shift", shift);
                            command.Parameters.AddWithValue("@DueDate", dueDate);
                            command.Parameters.AddWithValue("@NumberOfTable", numberOfTable);
                            command.Parameters.AddWithValue("@ReserveTable", reserveTable);
                            command.Parameters.AddWithValue("@Deposit", DepositeValue);
                            command.Parameters.AddWithValue("@ListIdFood", listIdFood);
                            command.Parameters.AddWithValue("@ListIdService", listIdService);
                            
                            try
                            {
                                connection.Open();
                                command.ExecuteNonQuery();
                                MessageBox.Show("Booking successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("An error occurred while booking: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //    List<int> listfood = [1,2,3]
            //    list <int>
            //    using (SqlConnection connection = new SqlConnection(conString))
            //    {
            //        using (SqlCommand command = new SqlCommand("BookingParty", connection))
            //        {
            //            command.CommandType = CommandType.StoredProcedure;

            //            // Add parameters to the stored procedure
            //            command.Parameters.AddWithValue("@Customer", "customer");
            //            command.Parameters.AddWithValue("@CreateDate", DateTime.Today.Date);
            //            command.Parameters.AddWithValue("@Adress", "address");
            //            command.Parameters.AddWithValue("@PhoneNumber", "phoneNumber");
            //            command.Parameters.AddWithValue("@Email", "email");
            //            command.Parameters.AddWithValue("@GroomName", "groomName");
            //            command.Parameters.AddWithValue("@Bride", "bride");
            //            command.Parameters.AddWithValue("@IdVenue", 1);
            //            command.Parameters.AddWithValue("@Shift", "Sáng");
            //            command.Parameters.AddWithValue("@DueDate", DateTime.Today.Date);
            //            command.Parameters.AddWithValue("@NumberOfTable", 10);
            //            command.Parameters.AddWithValue("@ReserveTable", 20);
            //            command.Parameters.AddWithValue("@Deposit", 2000000);
            //            command.Parameters.AddWithValue("@ListIdFood", listfood);
            //            command.Parameters.AddWithValue("@ListIdService", listIdService);

            //            try
            //            {
            //                connection.Open();
            //                command.ExecuteNonQuery();
            //                MessageBox.Show("Booking successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            }
            //            catch (Exception ex)
            //            {
            //                MessageBox.Show("An error occurred while booking: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            }
            //        }
              }

        private void ServiceBookingView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

