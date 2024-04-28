using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Add this line to import the System.IO namespace


namespace QuanLyTiecCuoi
{
    public partial class InsertVenue : Form
    {
        private Venue _parentForm;
       

        public InsertVenue(Venue parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        private void InsertVenue_Load(object sender, EventArgs e)
        {

        }



        private string conString = @"Data Source=ADMINISTRATOR;Initial Catalog=QUANLYTIECCUOI;Integrated Security=True;Connect Timeout=30;";
        public string imglocation = "";


        private void UploadPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imglocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imglocation;
            }
        }



        private void Confirm_Click(object sender, EventArgs e)
        {
            string VenueName = VenueNameAdd.Text;
            string VenueType = VenueTypeAdd.Text;
            float VenuePrice;
            Int64 MaxTable;
            float MinMoney;
            string State = "True"; // Assuming State should always be "True" when adding a new venue
            string note = NoteAdd.Text;

            // Validate and parse MaxTable
            if (!Int64.TryParse(MaxTableAdd.Text, out MaxTable))
            {
                MessageBox.Show("Please enter a valid integer value for the maximum number of tables.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if input is invalid
            }

            // Validate and parse MinMoney
            if (!float.TryParse(MinMoneyAdd.Text, out MinMoney))
            {
                MessageBox.Show("Please enter a valid floating-point value for the minimum money of each table.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if input is invalid
            }
            if (!float.TryParse(VenuePriceAdd.Text, out VenuePrice))
            {
                MessageBox.Show("Please enter a valid floating-point value for the price of the Venue.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if input is invalid
            }

            // SQL query to insert a new venue
            string insert_query = "INSERT INTO SANHINFOR (TENSANH, LOAISANH, MAXTABLE, MINMONEY, TRANGTHAISANH, NOTE, PICTURE,TIENSANH) VALUES (@VenueName, @VenueType, @MaxTable, @MinMoney, @State, @Note, @Image,@VenuePrice)";

            // Create a new connection
            using (SqlConnection connection = new SqlConnection(conString))
            {
                // Create a new command with the insert query and connection
                using (SqlCommand cmd = new SqlCommand(insert_query, connection))
                {
                    // Add parameters to the command
                    cmd.Parameters.AddWithValue("@VenueName", VenueName);
                    cmd.Parameters.AddWithValue("@VenueType", VenueType);
                    cmd.Parameters.AddWithValue("@MaxTable", MaxTable);
                    cmd.Parameters.AddWithValue("@MinMoney", MinMoney);
                    cmd.Parameters.AddWithValue("@State", State);
                    cmd.Parameters.AddWithValue("@Note", note);
                    cmd.Parameters.AddWithValue("@VenuePrice", VenuePrice);

                    byte[] imageData = File.ReadAllBytes(imglocation);

                    // Add image data as parameter
                    cmd.Parameters.AddWithValue("@Image", imageData);

                    try
                    {
                        // Open connection
                        connection.Open();

                        // Execute the command to insert the new venue
                        cmd.ExecuteNonQuery();

                        // Show success message
                        MessageBox.Show("Venue added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Reload data into DataGridView
                       
                    }
                    catch (Exception ex)
                    {
                        // Show error message if an error occurs during insertion
                        MessageBox.Show("An error occurred while adding the venue: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            _parentForm.LoadDataIntoDataGridView();

            // Đóng form insert
            this.Close();
        }

        private void UploadPhoto_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imglocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imglocation;
            }

        }
    }
}
