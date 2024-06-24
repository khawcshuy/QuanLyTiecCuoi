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

        private Rectangle panel3OriginalRect;
        private Rectangle TTHDOriginalRect;
        private Rectangle panel5OriginalRect;
        private Rectangle panel1OriginalRect;
        private Rectangle panel2OriginalRect;
        private Rectangle panel6OriginalRect;
        private Rectangle ChonSanhOriginalRect;
        private Rectangle ChonMonAnOriginalRect;
        private Rectangle ChonDichVuOriginalRect;
        private Rectangle XacNhanOriginalRect;
        private Rectangle MenuBookingViewOriginalRect;
        private Rectangle ServiceBookingViewOriginalRect;
        private Rectangle CustomerNameOriginalRect;
        private Rectangle PhoneOriginalRect;
        private Rectangle AddressOriginalRect;
        private Rectangle EmailOriginalRect;
        private Rectangle GroomNameOriginalRect;
        private Rectangle BrideNameOriginalRect;
        private Rectangle NumberTableOriginalRect;
        private Rectangle ReservedTableOriginalRect;
        private Rectangle ShiftPartyOriginalRect;
        private Rectangle MaxTableOriginalRect;
        private Rectangle MinMoneyOriginalRect;
        private Rectangle DateOriginalRect;
        private Rectangle IDTiecOriginalRect;
        private Rectangle OrderDateOriginalRect;
        private Rectangle VenueFeeOriginalRect;
        private Rectangle NumberTableFeeOriginalRect;
        private Rectangle totalMenuOriginalRect;
        private Rectangle totalServiceOriginalRect;
        private Rectangle totalOriginalRect;
        private Rectangle DepositRatioOriginalRect;
        private Rectangle depositOriginalRect;
        private Size originalFormSize;


        private float Label2XRatio;
        private float Label2YRatio;
        private float Label4XRatio;
        private float Label4YRatio;
        private float Label10XRatio;
        private float Label10YRatio;
        private float Label7XRatio;
        private float Label7YRatio;
        private float Label21XRatio;
        private float Label21YRatio;
        private float MenuXRatio;
        private float MenuYRatio;
        private float ServiceXRatio;
        private float ServiceYRatio;
        private float Label24XRatio;
        private float Label24YRatio;
        private float Label26XRatio;
        private float Label26YRatio;
        private float Label25XRatio;
        private float Label25YRatio;
        private float Label23XRatio;
        private float Label23YRatio;
        private float Label12XRatio;
        private float Label12YRatio;
        private float Label11XRatio;
        private float Label11YRatio;
        private float Label13XRatio;
        private float Label13YRatio;
        private float Label30XRatio;
        private float Label30YRatio;
        private float Label18XRatio;
        private float Label18YRatio;
        private float Label19XRatio;
        private float Label19YRatio;
        private float Label17XRatio;
        private float Label17YRatio;
        private float Label5XRatio;
        private float Label5YRatio;
        private float Label9XRatio;
        private float Label9YRatio;
        private float Label20XRatio;
        private float Label20YRatio;
        private float Label27XRatio;
        private float Label27YRatio;
        private float Label22XRatio;
        private float Label22YRatio;
        private float Label15XRatio;
        private float Label15YRatio;
        private float Label3XRatio;
        private float Label3YRatio;
        private float Label6XRatio;
        private float Label6YRatio;
        private float Label8XRatio;
        private float Label8YRatio;
        private float initialFontSizeLabel2;
        private float initialFontSizeLabel4;
        private float initialFontSizeLabel10;
        private float initialFontSizeLabel7;
        private float initialFontSizeLabel21;
        private float initialFontSizeMenu;
        private float initialFontSizeService;
        private float initialFontSizeLabel24;
        private float initialFontSizeLabel26;
        private float initialFontSizeLabel25;
        private float initialFontSizeLabel23;
        private float initialFontSizeLabel12;
        private float initialFontSizeLabel11;
        private float initialFontSizeLabel13;
        private float initialFontSizeLabel30;
        private float initialFontSizeLabel18;
        private float initialFontSizeLabel19;
        private float initialFontSizeLabel17;
        private float initialFontSizeLabel5;
        private float initialFontSizeLabel9;
        private float initialFontSizeLabel20;
        private float initialFontSizeLabel27;
        private float initialFontSizeLabel22;
        private float initialFontSizeLabel15;
        private float initialFontSizeLabel3;
        private float initialFontSizeLabel6;
        private float initialFontSizeLabel8;
        private float initialFormWidth;
        private float initialFormHeight;
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
            originalFormSize = this.Size;
            panel3OriginalRect = new Rectangle(panel3.Location, panel3.Size);
            TTHDOriginalRect = new Rectangle(TTHD.Location, TTHD.Size);
            panel5OriginalRect = new Rectangle(panel5.Location, panel5.Size);
            panel1OriginalRect = new Rectangle(panel1.Location, panel1.Size);
            panel2OriginalRect = new Rectangle(panel2.Location, panel2.Size);
            panel6OriginalRect = new Rectangle(panel6.Location, panel6.Size);
            ChonSanhOriginalRect = new Rectangle(ChonSanh.Location, ChonSanh.Size);
            ChonMonAnOriginalRect = new Rectangle(ChonThucDon.Location, ChonThucDon.Size);
            ChonDichVuOriginalRect = new Rectangle(ChonDichVu.Location, ChonDichVu.Size);
            XacNhanOriginalRect = new Rectangle(XacNhan.Location, XacNhan.Size);
            MenuBookingViewOriginalRect = new Rectangle(MenuBookingView.Location, MenuBookingView.Size);
            ServiceBookingViewOriginalRect = new Rectangle(ServiceBookingView.Location, ServiceBookingView.Size);
            CustomerNameOriginalRect = new Rectangle(CustomerName1.Location, CustomerName1.Size);
            PhoneOriginalRect = new Rectangle(Phone1.Location, Phone1.Size);
            AddressOriginalRect = new Rectangle(Address1.Location, Address1.Size);
            EmailOriginalRect = new Rectangle(Email1.Location, Email1.Size);
            GroomNameOriginalRect = new Rectangle(GroomName1.Location, GroomName1.Size);
            BrideNameOriginalRect = new Rectangle(BrideName1.Location, BrideName1.Size);
            NumberTableOriginalRect = new Rectangle(NumberOfTable1.Location, NumberOfTable1.Size);
            ReservedTableOriginalRect = new Rectangle(ReservedTable1.Location, ReservedTable1.Size);
            ShiftPartyOriginalRect = new Rectangle(ShiftParty.Location, ShiftParty.Size);
            MaxTableOriginalRect = new Rectangle(MaxTable1.Location, MaxTable1.Size);
            MinMoneyOriginalRect = new Rectangle(MinMoneyValue1.Location, MinMoneyValue1.Size);
            DateOriginalRect = new Rectangle(Date.Location, Date.Size);
            IDTiecOriginalRect = new Rectangle(IdTiec.Location, IdTiec.Size);
            OrderDateOriginalRect = new Rectangle(OrderDate.Location, OrderDate.Size);
            VenueFeeOriginalRect = new Rectangle(VenueFee.Location, VenueFee.Size);
            NumberTableFeeOriginalRect = new Rectangle(NumberTableFee.Location, NumberTableFee.Size);
            totalMenuOriginalRect = new Rectangle(totalMenu.Location, totalMenu.Size);
            totalServiceOriginalRect = new Rectangle(totalService.Location, totalService.Size);
            totalOriginalRect = new Rectangle(Total.Location, Total.Size);
            DepositRatioOriginalRect = new Rectangle(DepositeRatio.Location, DepositeRatio.Size);
            depositOriginalRect = new Rectangle(deposit.Location, deposit.Size);


            Label2XRatio = (float)label2.Left / this.ClientSize.Width;
            Label2YRatio = (float)label2.Top / this.ClientSize.Height;
            Label4XRatio = (float)label4.Left / this.ClientSize.Width;
            Label4YRatio = (float)label4.Top / this.ClientSize.Height;
            Label10XRatio = (float)label10.Left / this.ClientSize.Width;
            Label10YRatio = (float)label10.Top / this.ClientSize.Height;
            Label7XRatio = (float)label7.Left / this.ClientSize.Width;
            Label7YRatio = (float)label7.Top / this.ClientSize.Height;
            Label21XRatio = (float)label21.Left / this.ClientSize.Width;
            Label21YRatio = (float)label21.Top / this.ClientSize.Height;
            MenuXRatio = (float)menu.Left / this.ClientSize.Width;
            MenuYRatio = (float)menu.Top / this.ClientSize.Height;
            ServiceXRatio = (float)Service.Left / this.ClientSize.Width;
            ServiceYRatio = (float)Service.Top / this.ClientSize.Height;
            Label24XRatio = (float)label24.Left / this.ClientSize.Width;
            Label24YRatio = (float)label24.Top / this.ClientSize.Height;
            Label26XRatio = (float)label26.Left / this.ClientSize.Width;
            Label26YRatio = (float)label26.Top / this.ClientSize.Height;
            Label25XRatio = (float)label25.Left / this.ClientSize.Width;
            Label25YRatio = (float)label25.Top / this.ClientSize.Height;
            Label23XRatio = (float)label23.Left / this.ClientSize.Width;
            Label23YRatio = (float)label23.Top / this.ClientSize.Height;
            Label12XRatio = (float)label12.Left / this.ClientSize.Width;
            Label12YRatio = (float)label12.Top / this.ClientSize.Height;
            Label11XRatio = (float)label11.Left / this.ClientSize.Width;
            Label11YRatio = (float)label11.Top / this.ClientSize.Height;
            Label13XRatio = (float)label13.Left / this.ClientSize.Width;
            Label13YRatio = (float)label13.Top / this.ClientSize.Height;
            Label30XRatio = (float)label30.Left / this.ClientSize.Width;
            Label30YRatio = (float)label30.Top / this.ClientSize.Height;
            Label19XRatio = (float)label19.Left / this.ClientSize.Width;
            Label19YRatio = (float)label19.Top / this.ClientSize.Height;
            Label18XRatio = (float)label18.Left / this.ClientSize.Width;
            Label18YRatio = (float)label18.Top / this.ClientSize.Height;
            Label17XRatio = (float)label17.Left / this.ClientSize.Width;
            Label17YRatio = (float)label17.Top / this.ClientSize.Height;
            Label5XRatio = (float)label5.Left / this.ClientSize.Width;
            Label5YRatio = (float)label5.Top / this.ClientSize.Height;
            Label9XRatio = (float)label9.Left / this.ClientSize.Width;
            Label9YRatio = (float)label9.Top / this.ClientSize.Height;
            Label20XRatio = (float)label20.Left / this.ClientSize.Width;
            Label20YRatio = (float)label20.Top / this.ClientSize.Height;
            Label27XRatio = (float)label27.Left / this.ClientSize.Width;
            Label27YRatio = (float)label27.Top / this.ClientSize.Height;
            Label22XRatio = (float)label22.Left / this.ClientSize.Width;
            Label22YRatio = (float)label22.Top / this.ClientSize.Height;
            Label15XRatio = (float)label15.Left / this.ClientSize.Width;
            Label15YRatio = (float)label15.Top / this.ClientSize.Height;
            Label3XRatio = (float)label3.Left / this.ClientSize.Width;
            Label3YRatio = (float)label3.Top / this.ClientSize.Height;
            Label6XRatio = (float)label6.Left / this.ClientSize.Width;
            Label6YRatio = (float)label6.Top / this.ClientSize.Height;
            Label8XRatio = (float)label8.Left / this.ClientSize.Width;
            Label8YRatio = (float)label8.Top / this.ClientSize.Height;
            initialFontSizeLabel2 = label2.Font.Size;
            initialFontSizeLabel4 = label4.Font.Size;
            initialFontSizeLabel10 = label10.Font.Size;
            initialFontSizeLabel7 = label7.Font.Size;
            initialFontSizeLabel21 = label21.Font.Size;
            initialFontSizeMenu = menu.Font.Size;
            initialFontSizeService = Service.Font.Size;
            initialFontSizeLabel24 = label24.Font.Size;
            initialFontSizeLabel26 = label26.Font.Size;
            initialFontSizeLabel25 = label25.Font.Size;
            initialFontSizeLabel23 = label23.Font.Size;
            initialFontSizeLabel12 = label12.Font.Size;
            initialFontSizeLabel11 = label11.Font.Size;
            initialFontSizeLabel13 = label13.Font.Size;
            initialFontSizeLabel30 = label30.Font.Size;
            initialFontSizeLabel19 = label19.Font.Size;
            initialFontSizeLabel18 = label18.Font.Size;
            initialFontSizeLabel17 = label17.Font.Size;
            initialFontSizeLabel5 = label5.Font.Size;
            initialFontSizeLabel9= label9.Font.Size;
            initialFontSizeLabel20 = label20.Font.Size;
            initialFontSizeLabel27 = label27.Font.Size;
            initialFontSizeLabel22 = label22.Font.Size;
            initialFontSizeLabel15 = label15.Font.Size;
            initialFontSizeLabel3 = label3.Font.Size;
            initialFontSizeLabel6 = label6.Font.Size;
            initialFontSizeLabel8= label8.Font.Size;
            initialFormWidth = this.ClientSize.Width;
            initialFormHeight = this.ClientSize.Height;
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
            string phoneValue = Phone1.Text.Trim();
            string FindPhone = "SELECT DIENTHOAI FROM KHACHHANGINFOR WHERE DIENTHOAI LIKE '%' + @searchText + '%'";
            if (Phone1.TextLength > 1)
            {
                //    CustomerName.Text = Phone.TextLength.ToString();
                if (!Int64.TryParse(phoneValue, out _))
                {
                    MessageBox.Show("Invalid Phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Phone1.Text = "";
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
            else if (Phone1.TextLength <= 0)
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
                        Phone1.Text = reader["DIENTHOAI"].ToString();
                        CustomerName1.Text = reader["TENKHACHHANG"].ToString();
                        Address1.Text = reader["DIACHI"].ToString();
                        Email1.Text = reader["email"].ToString();
                        SearchResult.Height = 0;


                    }
                    else
                    {
                        MessageBox.Show("Customer not found for the selected phone number.");
                    }


                }
            }

        }

        private void ChonThucDon_Click(object sender, EventArgs e)
        {
            Food foodForm = new Food(conString, this);
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





        public void VenueForm_ConfirmEvent(int VenueSelectedId)
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

                        VenueFee.Text = row["TIENSANH"].ToString();
                        MaxTableOfVenue = (int)row["MaxTable"];
                        MaxTable1.Text = row["MaxTable"].ToString();
                        MinMoneyTableOfVenue = (decimal)row["MINMONEY"];
                        MinMoneyValue1.Text = row["MINMONEY"].ToString();

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

        private void ChonSanh_Click_1(object sender, EventArgs e)
        {
            if (ShiftParty.Text != "Chọn Ca")
            {
                Venue VenueForm = new Venue(this);
                VenueForm.VenueSelectedId = this.VenueSelectedId;
                VenueForm.AvailableVenueDate = Date.Value.Date;
                VenueForm.conString = conString;
                VenueForm.AvailableVenueShift = ShiftParty.Text;
                VenueForm.isChoosing = true;
                VenueForm.Show();
                VenueForm.FromBookingSate = true;
            }
            else
            {
                MessageBox.Show("Vui Lòng Chọn Ca!");
            }
        }


        private void Venue_Click(object sender, EventArgs e)
        {
            if (ShiftParty.Text != "Chọn Ca")
            {
                Venue VenueForm = new Venue(this);
                VenueForm.VenueSelectedId = this.VenueSelectedId;
                VenueForm.AvailableVenueDate = Date.Value.Date;
                VenueForm.conString = conString
                    ;
                VenueForm.AvailableVenueShift = ShiftParty.Text;
                VenueForm.isChoosing = true;
                VenueForm.Show();
                VenueForm.FromBookingSate = true;

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
                ServiceName.DataPropertyName = "TENDICHVU";
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

        private void ChonDichVu_Click(object sender, EventArgs e)
        {
            QuanLyTiecCuoi.Service.myService serviceForm = new QuanLyTiecCuoi.Service.myService(conString, this);
            serviceForm.ConfirmEvent += ServiceForm_ConfirmEvent;
            serviceForm.isBookingForm = true;
            if (ListSelectedService != null)
            {
                serviceForm.SelectedService = ListSelectedService;
            }
            serviceForm.Show();
        }



        private void CountingTable()
        {
            int numberOfTables;
            int reservedTables;

            if (!int.TryParse(NumberOfTable1.Text, out numberOfTables) || NumberOfTable1.Text.Length == 0)
            {
                NumberOfTable1.Text = "0";
                numberOfTables = 0;

            }
            if ((numberOfTables > MaxTableOfVenue && MaxTableOfVenue != 0))
            {
                MessageBox.Show("The venue can only accommodate " + MaxTableOfVenue.ToString() + " tables.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numberOfTables = 0;
                NumberOfTable1.Text = "0";
            }

            if (!int.TryParse(ReservedTable1.Text, out reservedTables) || ReservedTable1.Text.Length == 0)
            {
                ReservedTable1.Text = "0";
                reservedTables = 0;
            }


            if ((reservedTables > MaxTableOfVenue && MaxTableOfVenue != 0))
            {
                MessageBox.Show("The venue can only accommodate " + MaxTableOfVenue.ToString() + " tables.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reservedTables = 0;
                ReservedTable1.Text = "0";
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

            if(ListSelectedFood != null) { 
            string query = "SELECT ID, TENMONAN, DONGIA FROM FOOD WHERE ID IN (" + string.Join(",", ListSelectedFood) + ")";
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

            }
           
            }
            if (ListSelectedService != null) {  
                decimal totalServicePrice = 0.0m;
            string query = "SELECT ID, TENDICHVU, GIADICHVU, LOAIDICHVU FROM DICHVU WHERE ID IN (" + string.Join(",", ListSelectedService) + ")";
            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(query, connection);

                connection.Open();

                ServiceId.DataPropertyName = "ID";
                ServiceType.DataPropertyName = "LOAIDICHVU";
                ServiceName.DataPropertyName = "TENDICHVU";
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
        }

        private void XacNhan_Click(object sender, EventArgs e)
        {
            if (!CheckMenuPrice())
            {
                MessageBox.Show("Please choose more menu items.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string customer = CustomerName1.Text;
                DateTime createDate = DateTime.Now; // You may need to adjust how you get the current date
                string address = Address1.Text;
                string phoneNumber = Phone1.Text;
                string email = Email1.Text;
                string groomName = GroomName1.Text;
                string bride = BrideName1.Text;

                string shift = ShiftParty.Text;
                DateTime dueDate = Date.Value.Date;
                int numberOfTable = int.TryParse(NumberOfTable1.Text, out int result) ? result : 0;
                int reserveTable = int.TryParse(ReservedTable1.Text, out int result1) ? result1 : 0;

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        /*Rectangle panel3OriginalRect = new Rectangle(panel3.Location, panel3.Size);
        Rectangle TTHDOriginalRect = new Rectangle(TTHD.Location, TTHD.Size);
        Rectangle panel5OriginalRect = new Rectangle(panel5.Location, panel5.Size);
        Rectangle panel1OriginalRect = new Rectangle(panel1.Location, panel1.Size);
        Rectangle panel2OriginalRect = new Rectangle(panel2.Location, panel2.Size);
        Rectangle panel6OriginalRect = new Rectangle(panel6.Location, panel6.Size);
        Rectangle ChonSanhOriginalRect = new Rectangle(ChonSanh.Location, ChonSanh.Size);
        Rectangle ChonMonAnOriginalRect = new Rectangle(ChonThucDon.Location, ChonThucDon.Size);
        Rectangle ChonDichVuOriginalRect = new Rectangle(ChonDichVu.Location, ChonDichVu.Size);
        Rectangle XacNhanOriginalRect = new Rectangle(XacNhan.Location, XacNhan.Size);
        Rectangle MenuBookingViewOriginalRect = new Rectangle(MenuBookingView.Location, MenuBookingView.Size);
        Rectangle ServiceBookingViewOriginalRect = new Rectangle(ServiceBookingView.Location, ServiceBookingView.Size);
        Rectangle CustomerNameOriginalRect = new Rectangle(CustomerName1.Location, CustomerName1.Size);
        Rectangle PhoneOriginalRect = new Rectangle(Phone1.Location, Phone1.Size);
        Rectangle AddressOriginalRect = new Rectangle(Address1.Location, Address1.Size);
        Rectangle EmailOriginalRect = new Rectangle(Email1.Location, Email1.Size);
        Rectangle GroomNameOriginalRect = new Rectangle(GroomName1.Location, GroomName1.Size);
        Rectangle BrideNameOriginalRect = new Rectangle(BrideName1.Location, BrideName1.Size);
        Rectangle NumberTableOriginalRect = new Rectangle(NumberOfTable1.Location, NumberOfTable1.Size);
        Rectangle ReservedTableOriginalRect = new Rectangle(ReservedTable1.Location, ReservedTable1.Size);
        Rectangle ShiftPartyOriginalRect = new Rectangle(ShiftParty.Location, ShiftParty.Size);
        Rectangle MaxTableOriginalRect = new Rectangle(MaxTable1.Location, MaxTable1.Size);
        Rectangle MinMoneyOriginalRect = new Rectangle(MinMoneyValue1.Location, MinMoneyValue1.Size);
        Rectangle DateOriginalRect = new Rectangle(Date.Location, Date.Size);
        Rectangle IDTiecOriginalRect = new Rectangle(IdTiec.Location, IdTiec.Size);
        Rectangle OrderDateOriginalRect = new Rectangle(OrderDate.Location, OrderDate.Size);
        Rectangle VenueFeeOriginalRect = new Rectangle(VenueFee.Location, VenueFee.Size);
        Rectangle NumberTableFeeOriginalRect = new Rectangle(NumberTableFee.Location, NumberTableFee.Size);
        Rectangle totalMenuOriginalRect = new Rectangle(totalMenu.Location, totalMenu.Size);
        Rectangle totalServiceOriginalRect = new Rectangle(totalService.Location, totalService.Size);
        Rectangle totalOriginalRect = new Rectangle(Total.Location, Total.Size);
        Rectangle DepositRatioOriginalRect = new Rectangle(DepositeRatio.Location, DepositeRatio.Size);
        Rectangle depositOriginalRect = new Rectangle(deposit.Location, deposit.Size);*/

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
            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);
        }
        
        private void LabelReSize(Label label)
        {
            float widthRatio = (float)this.ClientSize.Width / originalFormSize.Width;
            float heightRatio = (float)this.ClientSize.Height / originalFormSize.Height;
            float newFontSize = 0;
            float LabelXRatio = 0;
            float LabelYRatio = 0;
            if (label.Name == "label2")
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
            }
            else if (label.Name == "label10")
            {
                newFontSize = initialFontSizeLabel10 * Math.Min(widthRatio, heightRatio);
                LabelXRatio = Label10XRatio;
                LabelYRatio = Label10YRatio;
            }
            else if (label.Name == "label7")
            {
                newFontSize = initialFontSizeLabel7 * Math.Min(widthRatio, heightRatio);
                LabelXRatio = Label7XRatio;
                LabelYRatio = Label7YRatio;
            }
            else if (label.Name == "label21")
            {
                newFontSize = initialFontSizeLabel21 * Math.Min(widthRatio, heightRatio);
                LabelXRatio = Label21XRatio;
                LabelYRatio = Label21YRatio;
            }
            else if (label.Name == "menu")
            {
                newFontSize = initialFontSizeMenu * Math.Min(widthRatio, heightRatio);
                LabelXRatio = MenuXRatio;
                LabelYRatio = MenuYRatio;
            }
            else if (label.Name == "Service")
            {
                newFontSize = initialFontSizeService * Math.Min(widthRatio, heightRatio);
                LabelXRatio = ServiceXRatio;
                LabelYRatio = ServiceYRatio;
            }
            else if (label.Name == "label24")
            {
                newFontSize = initialFontSizeLabel24 * Math.Min(widthRatio, heightRatio);
                LabelXRatio = Label24XRatio;
                LabelYRatio = Label24YRatio;
            }
            else if (label.Name == "label26")
            {
                newFontSize = initialFontSizeLabel26 * Math.Min(widthRatio, heightRatio);
                LabelXRatio = Label26XRatio;
                LabelYRatio = Label26YRatio;
            }
            else if (label.Name == "label25")
            {
                newFontSize = initialFontSizeLabel25 * Math.Min(widthRatio, heightRatio);
                LabelXRatio = Label25XRatio;
                LabelYRatio = Label25YRatio;
            }
            else if (label.Name == "label23")
            {
                newFontSize = initialFontSizeLabel23 * Math.Min(widthRatio, heightRatio);
                LabelXRatio = Label23XRatio;
                LabelYRatio = Label23YRatio;
            }
            else if (label.Name == "label12")
            {
                newFontSize = initialFontSizeLabel12 * Math.Min(widthRatio, heightRatio);
                LabelXRatio = Label12XRatio;
                LabelYRatio = Label12YRatio;
            }
            else if (label.Name == "label11")
            {
                newFontSize = initialFontSizeLabel11 * Math.Min(widthRatio, heightRatio);
                LabelXRatio = Label11XRatio;
                LabelYRatio = Label11YRatio;
            }
            else if (label.Name == "label13")
            {
                newFontSize = initialFontSizeLabel13 * Math.Min(widthRatio, heightRatio);
                LabelXRatio = Label13XRatio;
                LabelYRatio = Label13YRatio;
            }
            else if (label.Name == "label30")
            {
                newFontSize = initialFontSizeLabel30 * Math.Min(widthRatio, heightRatio);
                LabelXRatio = Label30XRatio;
                LabelYRatio = Label30YRatio;
            }
            else if (label.Name == "label19")
            {
                newFontSize = initialFontSizeLabel19 * Math.Min(widthRatio, heightRatio);
                LabelXRatio = Label19XRatio;
                LabelYRatio = Label19YRatio;
            }
            else if (label.Name == "label18")
            {
                newFontSize = initialFontSizeLabel18 * Math.Min(widthRatio, heightRatio);
                LabelXRatio = Label18XRatio;
                LabelYRatio = Label18YRatio;
            }
            else if (label.Name == "label17")
            {
                newFontSize = initialFontSizeLabel17 * Math.Min(widthRatio, heightRatio);
                LabelXRatio = Label17XRatio;
                LabelYRatio = Label17YRatio;
            }
            else if (label.Name == "label5")
            {
                newFontSize = initialFontSizeLabel5* Math.Min(widthRatio, heightRatio);
                LabelXRatio = Label5XRatio;
                LabelYRatio = Label5YRatio;
            }
            else if (label.Name == "label9")
            {
                newFontSize = initialFontSizeLabel9 * Math.Min(widthRatio, heightRatio);
                LabelXRatio = Label9XRatio;
                LabelYRatio = Label9YRatio;
            }
            else if (label.Name == "label20")
            {
                newFontSize = initialFontSizeLabel20 * Math.Min(widthRatio, heightRatio);
                LabelXRatio = Label20XRatio;
                LabelYRatio = Label20YRatio;
            }
            else if (label.Name == "label27")
            {
                newFontSize = initialFontSizeLabel27 * Math.Min(widthRatio, heightRatio);
                LabelXRatio = Label27XRatio;
                LabelYRatio = Label27YRatio;
            }
            else if (label.Name == "label22")
            {
                newFontSize = initialFontSizeLabel22 * Math.Min(widthRatio, heightRatio);
                LabelXRatio = Label22XRatio;
                LabelYRatio = Label22YRatio;
            }
            else if (label.Name == "label15")
            {
                newFontSize = initialFontSizeLabel15 * Math.Min(widthRatio, heightRatio);
                LabelXRatio = Label15XRatio;
                LabelYRatio = Label15YRatio;
            }
            else if (label.Name == "label3")
            {
                newFontSize = initialFontSizeLabel3 * Math.Min(widthRatio, heightRatio);
                LabelXRatio = Label3XRatio;
                LabelYRatio = Label3YRatio;
            }
            else if (label.Name == "label6")
            {
                newFontSize = initialFontSizeLabel6 * Math.Min(widthRatio, heightRatio);
                LabelXRatio = Label6XRatio;
                LabelYRatio = Label6YRatio;
            }
            else if (label.Name == "label8")
            {
                newFontSize = initialFontSizeLabel8 * Math.Min(widthRatio, heightRatio);
                LabelXRatio = Label8XRatio;
                LabelYRatio = Label8YRatio;
            }
            if (newFontSize > 0)
                label.Font = new Font(label.Font.FontFamily, newFontSize);

            using (Graphics g = this.CreateGraphics())
            {
                SizeF stringSize = g.MeasureString(label.Text, label.Font);
                label.Size = new Size((int)stringSize.Width + 10, (int)stringSize.Height + 10);
            }
            int newLabelX = (int)(LabelXRatio * this.ClientSize.Width);
            int newLabelY = (int)(LabelYRatio * this.ClientSize.Height);

            label.Location = new Point(newLabelX, newLabelY);
        }

        private void Booking_Resize_1(object sender, EventArgs e)
        {
            if (originalFormSize.Width == 0 || originalFormSize.Height == 0) return;
            float xRatio = (float)this.Width / originalFormSize.Width;
            float yRatio = (float)this.Height / originalFormSize.Height;
            Console.WriteLine(xRatio);
            Console.WriteLine(yRatio);
            ResizeControl(panel3OriginalRect, panel3, xRatio, yRatio);
            ResizeControl(TTHDOriginalRect, TTHD, xRatio, yRatio);
            ResizeControl(panel5OriginalRect, panel5, xRatio, yRatio);
            ResizeControl(panel1OriginalRect, panel1, xRatio, yRatio);
            ResizeControl(panel2OriginalRect, panel2, xRatio, yRatio);
            ResizeControl(panel6OriginalRect, panel6, xRatio, yRatio);
            ResizeControl(ChonSanhOriginalRect, ChonSanh, xRatio, yRatio);
            ResizeControl(ChonMonAnOriginalRect, ChonThucDon, xRatio, yRatio);
            ResizeControl(ChonDichVuOriginalRect, ChonDichVu, xRatio, yRatio);
            ResizeControl(XacNhanOriginalRect, XacNhan, xRatio, yRatio);
            ResizeControl(MenuBookingViewOriginalRect, MenuBookingView, xRatio, yRatio);
            ResizeControl(ServiceBookingViewOriginalRect, ServiceBookingView, xRatio, yRatio);
            ResizeControl(CustomerNameOriginalRect, CustomerName1, xRatio, yRatio);
            ResizeControl(PhoneOriginalRect, Phone1, xRatio, yRatio);
            ResizeControl(AddressOriginalRect, Address1, xRatio, yRatio);
            ResizeControl(EmailOriginalRect, Email1, xRatio, yRatio);
            ResizeControl(GroomNameOriginalRect, GroomName1, xRatio, yRatio);
            ResizeControl(BrideNameOriginalRect, BrideName1, xRatio, yRatio);
            ResizeControl(NumberTableOriginalRect, NumberOfTable1, xRatio, yRatio);
            ResizeControl(ReservedTableOriginalRect, ReservedTable1, xRatio, yRatio);
            ResizeControl(ShiftPartyOriginalRect, ShiftParty, xRatio, yRatio);
            ResizeControl(MaxTableOriginalRect, MaxTable1, xRatio, yRatio);
            ResizeControl(MinMoneyOriginalRect, MinMoneyValue1, xRatio, yRatio);
            ResizeControl(DateOriginalRect, Date, xRatio, yRatio);
            ResizeControl(IDTiecOriginalRect, IdTiec, xRatio, yRatio);
            ResizeControl(OrderDateOriginalRect, OrderDate, xRatio, yRatio);
            ResizeControl(VenueFeeOriginalRect, VenueFee, xRatio, yRatio);
            ResizeControl(NumberTableFeeOriginalRect, NumberTableFee, xRatio, yRatio);
            ResizeControl(totalMenuOriginalRect, totalMenu, xRatio, yRatio);
            ResizeControl(totalServiceOriginalRect, totalService, xRatio, yRatio);
            ResizeControl(totalOriginalRect, Total, xRatio, yRatio);
            ResizeControl(DepositRatioOriginalRect, DepositeRatio, xRatio, yRatio);
            ResizeControl(depositOriginalRect, deposit, xRatio, yRatio);
            LabelReSize(label2);
            LabelReSize(label4);
            LabelReSize(label10);
            LabelReSize(label7);
            LabelReSize(label21);
            LabelReSize(menu);
            LabelReSize(Service);
            LabelReSize(label24);
            LabelReSize(label26);
            LabelReSize(label25);
            LabelReSize(label23);
            LabelReSize(label12);
            LabelReSize(label11);
            LabelReSize(label13);
            LabelReSize(label30);
            LabelReSize(label18);
            LabelReSize(label19);
            LabelReSize(label17);
            LabelReSize(label5);
            LabelReSize(label9);
            LabelReSize(label20);
            LabelReSize(label27);
            LabelReSize(label22);
            LabelReSize(label15);
            LabelReSize(label3);
            LabelReSize(label6);
            LabelReSize(label8);
        }
    }
    }

