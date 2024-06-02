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
        private Size formSize;
        public string conString;
        public InsertVenue(Venue parentForm, String _conString)
        {
            InitializeComponent();
            _parentForm = parentForm;
            conString = _conString;
            pictureBox1.Paint += new PaintEventHandler(pictureBox1_Paint);
        }

        private void InsertVenue_Load(object sender, EventArgs e)
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

        private void XacNhan_Click(object sender, EventArgs e)
        {
            string VenueName = textBoxTenSanh.Texts.Trim();
            string VenueType = comboBoxLoaiSanh.Texts.Trim();
            float VenuePrice;
            Int64 MaxTable;
            float MinMoney;
            string State = "True"; 
            string note = textBoxGhiChu.Texts.Trim();

            // Validate and parse MaxTable
            if (!Int64.TryParse(textBoxMaxTable.Texts.Trim(), out MaxTable))
            {
                MessageBox.Show("Please enter a valid integer value for the maximum number of tables.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            // Validate and parse MinMoney
            if (!float.TryParse(textBoxMinTable.Texts.Trim(), out MinMoney))
            {
                MessageBox.Show("Please enter a valid floating-point value for the minimum money of each table.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            if (!float.TryParse(textBoxGiaThue.Texts.Trim(), out VenuePrice))
            {
                MessageBox.Show("Please enter a valid floating-point value for the price of the Venue.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            string insert_query = "INSERT INTO SANHINFOR (TENSANH, LOAISANH, MAXTABLE, MINMONEY, TRANGTHAISANH, NOTE, PICTURE,TIENSANH) VALUES (@VenueName, @VenueType, @MaxTable, @MinMoney, @State, @Note, @Image,@VenuePrice)";
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
                    cmd.Parameters.AddWithValue("@Image", imageData);
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
            }
            _parentForm.LoadDataIntoDataGridView();
            this.Close();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            if (pb.Image == null)
            {
                int borderWidth = 2;
                Color borderColor = Color.FromArgb(0, 168, 102);
                ControlPaint.DrawBorder(e.Graphics, pb.ClientRectangle, borderColor, borderWidth, ButtonBorderStyle.Solid,
                    borderColor, borderWidth, ButtonBorderStyle.Solid,
                    borderColor, borderWidth, ButtonBorderStyle.Solid,
                    borderColor, borderWidth, ButtonBorderStyle.Solid);
            }
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

        private void rjButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
