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
        private myService _parentForm;
        public string conString;
        private Size formSize;
        public InsertService(myService parentForm)
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

        private void XacNhan_Click(object sender, EventArgs e)
        {
            string ServiceName = textBoxTenDichVu.Texts.Trim();
            string ServiceType = comboBoxLoaiDichVu.Texts.Trim();
            float ServicePrice;


            if (!float.TryParse(textBoxDonGia.Texts.Trim(), out ServicePrice))
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020;
            const int SC_RESTORE = 0xF120;
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            if (m.Msg == WM_SYSCOMMAND)
            {
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }

    }
}
