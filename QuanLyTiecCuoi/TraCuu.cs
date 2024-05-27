﻿using QuanLyTiecCuoi.Login;
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

namespace QuanLyTiecCuoi
{
    public partial class TraCuu : Form
    {
        public string constring;
        public TraCuu(string _constring)
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(224, 247, 250);
            dataGridView1.BackgroundColor = Color.FromArgb(224, 247, 250);
            //lblSoDienThoai.ForeColor = Color.FromArgb(1, 87, 155);
            lblSoDienThoai.BackColor = Color.FromArgb(224, 247, 250);
            // Textbox (rjTextBox1)
            searchTextbox.BackColor = Color.FromArgb(255, 255, 255);
            searchTextbox.ForeColor = Color.FromArgb(1, 87, 155);
            // Button (button1)
            button1.BackColor = Color.FromArgb(79, 195, 247);
            button1.ForeColor = Color.FromArgb(255, 255, 255);

            // Panel (panel1)
            panel1.BackColor = Color.FromArgb(224, 247, 250);
            this.constring = _constring;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(224, 247, 250);
            dataGridView1.GridColor = Color.LightGray; // Set a neutral grid color

            // Subscribe to the Paint event for custom border
            dataGridView1.Paint += new PaintEventHandler(dataGridView1_Paint);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(224, 247, 250);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 139);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 12, FontStyle.Bold);
        }

        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            // Define the custom border color
            Color borderColor = Color.FromArgb(224, 247, 250); // Light Blue

            // Define the border width
            int borderWidth = 2;

            // Draw the border
            using (Pen pen = new Pen(borderColor, borderWidth))
            {
                Rectangle rect = new Rectangle(0, 0, dgv.Width, dgv.Height);
                e.Graphics.DrawRectangle(pen, rect);
            }
        }
        private void TraCuu_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand("SELECT T.ID, TENCHURE, TENCODAU, S.TENSANH, NGAYTOCHUC, CA, SOLUONGBAN FROM TIEC T, SANHINFOR S WHERE T.IDLOAISANH = S.ID", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[0].HeaderText = "STT";
            dataGridView1.Columns[1].HeaderText = "Tên Chú Rể";
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].HeaderText = "Tên Cô Dâu";
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].HeaderText = "Sảnh";
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].HeaderText = "Ngày Tổ Chức";
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].HeaderText = "Giờ";
            dataGridView1.Columns[5].Width = 50;
            dataGridView1.Columns[6].HeaderText = "Số Lượng Bàn";
            dataGridView1.Columns[6].Width = 170;
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "CA")
            {
                DataGridViewCell caCell = dataGridView1.Rows[e.RowIndex].Cells["CA"];
                if (caCell.Value != null)
                {
                    string caValue = caCell.Value.ToString();
                    if (caValue == "Tối")
                    {
                        e.Value = "18:30";
                    }
                    else
                    {
                        e.Value = "11:30";
                    }
                }
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string sodienthoai = searchTextbox.Texts.Trim();
            if (!string.IsNullOrEmpty(sodienthoai))
            {
                using (SqlConnection conn = new SqlConnection(constring))
                {
                    conn.Open();
                    string query = @"SELECT T.ID, TENCHURE, TENCODAU, S.TENSANH, NGAYTOCHUC, CA, SOLUONGBAN 
                             FROM TIEC T
                             INNER JOIN KHACHHANGINFOR K ON T.IDTHONGTINKHACHHANG = K.ID
                             INNER JOIN SANHINFOR S ON T.IDLOAISANH = S.ID
                             WHERE K.DIENTHOAI = @PhoneNumber";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PhoneNumber", sodienthoai);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dataGridView1.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("Không Tìm Thấy Thông Tin Khách Hàng!");
                        }
                        reader.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui Lòng Nhập Số Điện Thoại!");
            }
        }
    }
}
