using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiecCuoi
{
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }
        private string conString = @"Data Source=DESKTOP-M4GHD5G\LUCY;Initial Catalog=QUANLYTIECCUOI;Persist Security Info=True;User ID=sa;Password=140403";

        private void Booking_Load(object sender, EventArgs e)
        {

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

        private void Discount_TextChanged(object sender, EventArgs e)
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
                                SearchResult.Height = SearchResult.Rows.Count*30;


                            }
                            else
                            {
                                SearchResult.Height = 0;
                            }
                        }
                    }
}
            else if(Phone.TextLength <= 0)
            {
                SearchResult.Height = 0;
            }


        }







        private void Confirm_Click(object sender, EventArgs e)
        {
            string  CustomerNameValue = CustomerName.Text;
            
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

        private List<string> ListSelectedFood;

        private void ChooseMenu_Click(object sender, EventArgs e)
        {
            Food foodForm = new Food(this);
            foodForm.ConfirmEvent += FoodForm_ConfirmEvent;
            if(ListSelectedFood != null)
            {    
            foodForm.SelectedFoods = ListSelectedFood;
}           foodForm.isChoosing = true;
            foodForm.Show();
        }


        private void FoodForm_ConfirmEvent(List<string> selectedFoods)
        {
            ListSelectedFood = selectedFoods;
            // Construct the SQL query with a WHERE clause to filter by selected food IDs
            string query = "SELECT ID, TENMONAN, DONGIA FROM FOOD WHERE ID IN (" + string.Join(",", selectedFoods) + ")";

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

                adapter.Fill(dataTable);

                connection.Close();

                // Set the ImageLayout property of the DataGridViewImageColumn
              

                // Set the DataGridView's DataSource to the retrieved DataTable
                MenuBookingView.DataSource = dataTable;
            }
        }

        private void MenuBookingView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
