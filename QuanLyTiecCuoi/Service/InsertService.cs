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
        public string conString;
        public InsertService(Service parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }
        public string imglocation = "";
        
        private void InsertService_Load(object sender, EventArgs e)
        {

        }

        //private void UploadPhoto_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog dialog = new OpenFileDialog();
        //    dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg";
        //    if (dialog.ShowDialog() == DialogResult.OK)
        //    {
        //        imglocation = dialog.FileName.ToString();
        //        pictureBox1.ImageLocation = imglocation;
        //    }
        //}

        private void Confirm_Click(object sender, EventArgs e)
        {
            string ServiceName = ServiceNameAdd.Text;
            string ServiceType = ServiceTypeAdd.Text;
            float ServicePrice;


            if (!float.TryParse(ServicePriceAdd.Text, out ServicePrice))
            {
                MessageBox.Show("Please enter a valid floating-point value for the price of the Venue.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if input is invalid
            }

            string insert_query = "INSERT INTO DICHVU (TENDICHVU, LOAIDICHVU,GIADICHVU)  VALUES(@ServiceName,@ServiceType,@ServicePrice)";

            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand(insert_query, connection))
                {
                    cmd.Parameters.AddWithValue("@ServiceName", ServiceName);
                    cmd.Parameters.AddWithValue("@ServiceType", ServiceType);
                    cmd.Parameters.AddWithValue("@ServicePrice", ServicePrice);
;

                   
                        try
                        {
                            connection.Open();

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Service added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred while adding the Service: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                 

                }
            }

            _parentForm.LoadDataGridViewService();


            this.Close();
        }

      
    }
}
