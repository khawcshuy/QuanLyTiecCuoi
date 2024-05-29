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

namespace QuanLyTiecCuoi.SERVICE
{
    public partial class InsertFood : Form
    {
        private Food _parentForm;
        public string conString;

        public InsertFood(Food parentForm , String _conString)
        {
            InitializeComponent();
            _parentForm = parentForm;
          
            conString = _conString;
            
           
        }
        public string imglocation = "";
        //private string conString = @"Data Source=DESKTOP-M4GHD5G\LUCY;Initial Catalog=QUANLYTIECCUOI;Persist Security Info=True;User ID=sa;Password=140403";

        private void INSERTFOOD_Load(object sender, EventArgs e)
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
            string FoodName = FoodNameAdd.Text;
            float FoodPrice;
            string note = NoteAdd.Text;

          
            if (!float.TryParse(FoodPriceAdd.Text, out FoodPrice))
            {
                MessageBox.Show("Please enter a valid floating-point value for the price of the Venue.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string insert_query = "INSERT INTO FOOD (TENMONAN, DONGIA, PICTURE, NOTE) VALUES (@FoodName, @FoodPrice, @Image, @Note)";

            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand(insert_query, connection))
                {
                    cmd.Parameters.AddWithValue("@FoodName", FoodName);
                    cmd.Parameters.AddWithValue("@FoodPrice", FoodPrice);
                    try
                    {
                        if (!string.IsNullOrEmpty(imglocation))
                        {
                            byte[] imageData = File.ReadAllBytes(imglocation);
                            cmd.Parameters.AddWithValue("@Image", imageData);
                        }
                        else
                        {
                            MessageBox.Show("Please upload an image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    cmd.Parameters.AddWithValue("@Note", note);
                        try
                        {
                            connection.Open();

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Venue added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred while adding the venue: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("You haven't submitted a picture yet", "Error", MessageBoxButtons.OK);
                    }

                }
            }

            _parentForm.LoadDataGridViewFood();


            // Đóng form insert
            this.Close();
        }
    }
}
