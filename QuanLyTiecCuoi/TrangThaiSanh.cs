using QuanLyTiecCuoi.DESIGN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace QuanLyTiecCuoi
{
    public partial class TrangThaiSanh : Form
    {
        private string conString;
        public TrangThaiSanh(string conString)
        {
            InitializeComponent();
            this.conString = conString;
            pictureBoxVenueImage.Paint += new PaintEventHandler(pictureBoxVenueImage_Paint);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxVenueImage_Paint(object sender, PaintEventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            int borderWidth = 4;
            Color borderColor = Color.FromArgb(0, 36, 107);
            ControlPaint.DrawBorder(e.Graphics, pb.ClientRectangle, borderColor, borderWidth, ButtonBorderStyle.Solid,
                    borderColor, borderWidth, ButtonBorderStyle.Solid,
                    borderColor, borderWidth, ButtonBorderStyle.Solid,
                    borderColor, borderWidth, ButtonBorderStyle.Solid);
            
        }
        private void TrangThaiSanh_Load(object sender, EventArgs e)
        {
            splitContainer1.Panel1.Controls.Clear();

            using (SqlConnection connection = new SqlConnection(conString))
            {
                string query = "SELECT * FROM TIEC";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int idTiec = Convert.ToInt32(reader["ID"]);
                        //string ID = reader["TenTiec"].ToString();
                        AddCustomControlToPanel(idTiec);
                    }
                }
            }
        }

        private void AddCustomControlToPanel(int idTiec)
        {
            Widget widget = new Widget();
            widget.IDTIEC.Text = idTiec.ToString();
            splitContainer1.Panel1.Controls.Add(widget);


        }
        private void IconButtonBill_Click(object sender, EventArgs e)
        {

        }

        private void LabelTenSanh_Click(object sender, EventArgs e)
        {

        }

        private void PictureBoxVenueImage_Click(object sender, EventArgs e)
        {

        }

        // MO FORM XUAT HOA DON
        private void iconButtonBill_Click_1(object sender, EventArgs e)
        {

        }

        private void widget1_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
