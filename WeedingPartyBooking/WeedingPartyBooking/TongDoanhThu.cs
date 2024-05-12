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

namespace WeedingPartyBooking
{
    public partial class TongDoanhThu : Form
    {
        public TongDoanhThu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn tháng!");
                return;
            }
            int selectedMonth = comboBox1.SelectedIndex + 1; 
            decimal totalRevenue = 0;
            string query = "SELECT SUM(DOANHTHU) FROM BAOCAO WHERE THANG = @Month";
            string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=DATTIECUOI;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Month", selectedMonth);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        totalRevenue = Convert.ToDecimal(result);
                    }
                }
            }
            textBox1.Text = totalRevenue.ToString();
        }
    }
}
