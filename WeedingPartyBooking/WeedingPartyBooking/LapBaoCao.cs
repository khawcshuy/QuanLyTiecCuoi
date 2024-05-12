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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WeedingPartyBooking
{
    public partial class LapBaoCao : Form
    {
        string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=DATTIECUOI;Integrated Security=True";
        public LapBaoCao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO BAOCAO (NGAYLAP, SOLUONGTIEC, TENNGUOILAP, DOANHTHU, TILE, THANG) " +
                           "VALUES (@NGAYLAP, @SOLUONGTIEC, @TENNGUOILAP, @DOANHTHU, @TILE, @THANG)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@NGAYLAP", dateTimePickerNgayLap.Value.Date);
                    cmd.Parameters.AddWithValue("@SOLUONGTIEC", int.Parse(textBoxSoLuongTiec.Text));
                    cmd.Parameters.AddWithValue("@TENNGUOILAP", textBoxTenNguoiLap.Text);
                    cmd.Parameters.AddWithValue("@DOANHTHU", decimal.Parse(textBoxDoanhThu.Text));
                    cmd.Parameters.AddWithValue("@TILE", int.Parse(textBoxTiLe.Text));
                    cmd.Parameters.AddWithValue("@THANG", int.Parse(textBoxThang.Text));
                    try
                    {
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Báo Cáo Thành Công!");
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng nhập thêm thông tin!");
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}
