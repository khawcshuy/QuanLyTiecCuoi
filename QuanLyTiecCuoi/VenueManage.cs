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
    public partial class VenueManage : Form
    {
        public VenueManage()
        {
            InitializeComponent();
        }

        private void VenueManage_Load(object sender, EventArgs e)
        {
            // Kết nối đến cơ sở dữ liệu
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True";

            SqlConnection con = new SqlConnection(conString);

            // Truy vấn SQL để lấy tất cả thông tin từ bảng SANHINFOR
            string query = "SELECT * FROM SANHINFOR";

            // Tạo đối tượng SqlDataAdapter và DataTable
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();

            // Mở kết nối và đổ dữ liệu vào DataTable
            try
            {
                con.Open();
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            // Gán DataTable làm nguồn dữ liệu cho DataGridView
            dataGridView1.DataSource = dataTable;
        }
    }
}
