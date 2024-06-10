using QuanLyTiecCuoi.DESIGN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace QuanLyTiecCuoi
{
    public partial class TrangThaiSanh : Form
    {
        private string conString;
        private int idTiecValue = -1 ;
        public TrangThaiSanh(string conString)
        {
            InitializeComponent();
            this.conString = conString;
            pictureBoxVenueImage.Paint += new PaintEventHandler(pictureBoxVenueImage_Paint);
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
        //    private void TrangThaiSanh_Load(object sender, EventArgs e)
        //    {
        //        splitContainer1.Panel1.Controls.Clear();

        //        string query = @"
        //SELECT S.TENSANH, S.PICTURE, S.ID as iD,
        //       CASE WHEN T.IDLOAISANH IS NOT NULL AND T.NGAYTOCHUC = CAST(GETDATE() AS DATE) THEN 1 ELSE 0 END AS TrangThai
        //FROM SANHINFOR S
        //LEFT JOIN TIEC T ON S.ID = T.IDLOAISANH";

        //        using (SqlConnection connection = new SqlConnection(conString))
        //        {
        //            using (SqlCommand command = new SqlCommand(query, connection))
        //            {
        //                connection.Open();
        //                using (SqlDataReader reader = command.ExecuteReader())
        //                {
        //                    while (reader.Read())
        //                    {
        //                        bool state = Convert.ToBoolean(reader["TrangThai"]);
        //                        string venueName = reader["TENSANH"].ToString();
        //                        byte[] venuePicData = reader["PICTURE"] as byte[];

        //                        int id = Convert.ToInt32(reader["id"]);
        //                        if (state)
        //                        {



        //                            AddCustomControlToPanel(venueName, state, venuePicData, id);
        //                        }
        //                        else
        //                        {
        //                            AddCustomControlToPanel(venueName, state, venuePicData, -1);
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }

        private void TrangThaiSanh_Load(object sender, EventArgs e)
        {
            splitContainer1.Panel1.Controls.Clear();
            bool state;

            string query = @"
    SELECT S.TENSANH, S.PICTURE, ID FROM SANHINFOR S";

            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string venueName = reader["TENSANH"].ToString();
                            byte[] venuePicData = reader["PICTURE"] as byte[];
                            int idSanh = Convert.ToInt32(reader["id"]);
                            int id = Checkstate(idSanh);
                            if (id != 0)
                            {     
                                state = true;
                            }
                            else
                            {
                                state = false;
                            }

                          AddCustomControlToPanel(venueName, state, venuePicData, id);
                          
                             
                        }
                    }
                }
            }
        }
        private int Checkstate(int idSanh)

        {
            int idTiec = 0;
            string query = "SELECT ID AS TIECID FROM TIEC   where IDLOAISANH = @idSanh and NGAYTOCHUC = CAST(GETDATE() AS DATE)";
            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idSanh", idSanh);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                             idTiec = Convert.ToInt32(reader["TIECID"]);
                            
                        }
                    }
                }
            }
            return idTiec;

        }

        private void AddCustomControlToPanel(string venueName, bool state, byte[] pictureData,int id)
        {
            Widget widget = new Widget();
            widget.VenueNameWidget.Text = venueName;
            widget.State.Checked = state;

            if (pictureData != null)
            {
                using (MemoryStream ms = new MemoryStream(pictureData))
                {
                    widget.VenuePicture.Image = System.Drawing.Image.FromStream(ms);
                }
            }

            AddClickEventToControls(widget,id, pictureData);

            splitContainer1.Panel1.Controls.Add(widget);
            widget.Dock = DockStyle.Top;
        }

        private void Widget_Click(object sender, EventArgs e, int id, byte[] pictureData)
        {
            Widget clickedWidget = sender as Widget;
            if (clickedWidget != null)
            {
                bool state = clickedWidget.State.Checked;
                string VenueName = clickedWidget.VenueNameWidget.Text;
                if (state)
                {
                    LoadInforVenue(id, state, pictureData, VenueName);
                }
            }
            else
            {
                System.Windows.Forms.Control control = sender as System.Windows.Forms.Control;
                while (control != null && !(control is Widget))
                {
                    control = control.Parent;
                }

                if (control is Widget parentWidget)
                {
                    bool state = parentWidget.State.Checked;
                    string VenueName = parentWidget.VenueNameWidget.Text;
                    if (state)
                    {
                        LoadInforVenue(id, state, pictureData, VenueName);
                    }
                }
            }
        }


        private void AddClickEventToControls(System.Windows.Forms.Control control, int id, byte[] pictureData)
        {
            if (control is Widget)
            {
                Widget widget = (Widget)control;
                widget.Click += (sender, e) => Widget_Click(sender, e, id, pictureData);
                
            }
            else
            {
                control.Click += (sender, e) => Widget_Click(sender, e, id, pictureData);

                foreach (System.Windows.Forms.Control childControl in control.Controls)
                {
                    AddClickEventToControls(childControl, id, pictureData);
                }
            }
        }






        private void LoadInforVenue(int ID, bool state, byte[] pictureData, string VenueName)
        {
            string query = @"
       SELECT T.ID AS IDTIEC, T.TENCHURE, T.TENCODAU, T.IDTHONGTINKHACHHANG, KH.TENKHACHHANG, KH.DIENTHOAI  
FROM TIEC T 
LEFT JOIN KHACHHANGINFOR KH ON T.IDTHONGTINKHACHHANG = KH.ID 
WHERE @ID = T.ID
";

            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", ID);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string tenChuRe = reader["TENCHURE"].ToString();
                            string tenCoDau = reader["TENCODAU"].ToString();
                            string idThongTinKhachHang = reader["IDTHONGTINKHACHHANG"].ToString();
                            string tenKhachHang = reader["TENKHACHHANG"].ToString();
                            string dienThoai = reader["DIENTHOAI"].ToString();
                            string idTiec = reader["IDTIEC"].ToString();

                            textBoxMaKH.Texts = idThongTinKhachHang;
                            textBoxCustomerName.Texts = tenKhachHang;
                            textBoxPhone.Texts = dienThoai;
                            textBoxGroom.Texts = tenChuRe;
                            textBoxBride.Texts = tenCoDau;
                            myToggleButton1.Checked=state;
                            labelTenSanh.Text = VenueName;
                            textBoxIdTiec.Texts = idTiec;
                            if (pictureData != null)
                            {
                                using (MemoryStream ms = new MemoryStream(pictureData))
                                {
                                    pictureBoxVenueImage.Image = System.Drawing.Image.FromStream(ms);
                                }
                            }
                           

                        }

                    }
                }
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BillExport_Click(object sender, EventArgs e)
        {
            int idTiecCHeckOut = Convert.ToInt32(textBoxIdTiec.Texts);
            Receipt receiptForm = new Receipt(conString, this, idTiecCHeckOut);
            receiptForm.ShowDialog();
        }

    }
}
