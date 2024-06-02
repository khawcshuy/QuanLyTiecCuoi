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
        private Size formSize;
        public InsertFood(Food parentForm , String _conString)
        {
            InitializeComponent();
            _parentForm = parentForm;
            conString = _conString;
            pictureBox1.Paint += new PaintEventHandler(pictureBox1_Paint);
        }
        public string imglocation = "";
        //private string conString = @"Data Source=DESKTOP-M4GHD5G\LUCY;Initial Catalog=QUANLYTIECCUOI;Persist Security Info=True;User ID=sa;Password=140403";

        private void INSERTFOOD_Load(object sender, EventArgs e)
        {

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

        private void UploadAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imglocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imglocation;
            }
        }

        private void XacNhan_Click(object sender, EventArgs e)
        {
            string FoodName = textBoxTenMonAn.Texts.Trim();
            float FoodPrice;
            string note = textBoxGhiChu.Texts.Trim();


            if (!float.TryParse(textBoxDonGia.Texts.Trim(), out FoodPrice))
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

        private void rjButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            if (pb.Image == null)
            {
                // Draw a border
                int borderWidth = 2;
                Color borderColor = Color.FromArgb(255, 12, 74);

            
                ControlPaint.DrawBorder(e.Graphics, pb.ClientRectangle, borderColor, borderWidth, ButtonBorderStyle.Solid,
                    borderColor, borderWidth, ButtonBorderStyle.Solid,
                    borderColor, borderWidth, ButtonBorderStyle.Solid,
                    borderColor, borderWidth, ButtonBorderStyle.Solid);
            }
        }
    }
}
