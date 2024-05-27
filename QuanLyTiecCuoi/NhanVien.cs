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
    public partial class NhanVien : Form
    {
        public string constring;
        public NhanVien(string _constring)
        {
            InitializeComponent();
            this.constring = _constring;
        }

        private void rjTextBox1_Enter(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand("SELECT ID, TENNHANVIEN, SODIENTHOAI, DIACHI, CHUCVU FROM NHANVIEN", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 45;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Tên Nhân Viên";
            dataGridView1.Columns[1].Width = 175;
            dataGridView1.Columns[2].HeaderText = "Số Điện Thoại";
            dataGridView1.Columns[2].Width = 120;
            dataGridView1.Columns[3].HeaderText = "Địa Chỉ";
            dataGridView1.Columns[3].Width = 200;
            dataGridView1.Columns[4].HeaderText = "Chức Vụ";
            dataGridView1.Columns[4].Width = 100;
        }
    }
}
