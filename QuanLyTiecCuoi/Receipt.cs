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
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void load_recepit(object sender, EventArgs e)
        {
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True";

            SqlConnection con = new SqlConnection(conString);

            string query = "Select kh.MAKHACHHANG, kh.NGAYLAP, kh.TENKHACHHANG, kh.TENCHURE, kh.TENCODAU, kh.DIACHI, kh.DIENTHOAI, kh.EMAIL, kh.NGAYTOCHUC, kh.SOLUONGBAN, kh.BANDUTRU FROM KHACHHANGINFO kh  Where MAKHACHHANG =  "
        }
        //private void btnSearch_Click(object sender, EventArgs e)
        //{
        //    string customerID = customerID.Text;
        //    load_recepit(customerID);
        //}
    }
}
