using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiecCuoi.Service
{
    public partial class InsertService : Form
    {
        private Service _parentForm;
        public InsertService(Service parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }
        public string imglocation = "";
        private string conString = @"Data Source=DESKTOP-M4GHD5G\LUCY;Initial Catalog=QUANLYTIECCUOI;Persist Security Info=True;User ID=sa;Password=140403";

        private void InsertService_Load(object sender, EventArgs e)
        {

        }

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
            string ServiceName = ServiceNameAdd.Text;
            string ServiceType = ServiceTypeAdd.Text;
            float ServicePrice;
            string note = NoteAdd.Text;

            // Validate and parse MaxTable

            if (!float.TryParse(ServicePriceAdd.Text, out ServicePrice))
            {
                MessageBox.Show("Please enter a valid floating-point value for the price of the Venue.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if input is invalid
            }

            // SQL query to insert a new venue
            string insert_query = "INSERT INTO DICHVU (TENDICHVU, LOAIDICHVU,GIADICHVU, NOTE, PICTURE)  VALUES(@ServiceName,@ServiceType ,@Note, @Image)";

            // Create a new connection
            using (SqlConnection connection = new SqlConnection(conString))
            {
                // Create a new command with the insert query and connection
                using (SqlCommand cmd = new SqlCommand(insert_query, connection))
                {
                    // Add parameters to the command
                    cmd.Parameters.AddWithValue("@ServiceName", ServiceName);
                    cmd.Parameters.AddWithValue("@ServiceType", ServiceType);
                    cmd.Parameters.AddWithValue("@Note", note);

                    try
                    {
                        // Check if an image is provided
                        if (!string.IsNullOrEmpty(imglocation))
                        {
                            byte[] imageData = File.ReadAllBytes(imglocation);
                            cmd.Parameters.AddWithValue("@Image", imageData);
                        }
                        else
                        {
                            // Inform the user to submit an image
                            MessageBox.Show("Please upload an image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; // Exit the method
                        }

                        try
                        {
                            // Open connection
                            connection.Open();

                            // Execute the command to insert the new venue
                            cmd.ExecuteNonQuery();

                            // Show success message
                            MessageBox.Show("Service added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Reload data into DataGridView

                        }
                        catch (Exception ex)
                        {
                            // Show error message if an error occurs during insertion
                            MessageBox.Show("An error occurred while adding the Service: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("You haven't submitted a picture yet", "Error", MessageBoxButtons.OK);
                    }

                    // Add image data as parameter
                }
            }

            _parentForm.LoadDataGridViewService();


            // Đóng form insert
            this.Close();
        }

      
    }
}
