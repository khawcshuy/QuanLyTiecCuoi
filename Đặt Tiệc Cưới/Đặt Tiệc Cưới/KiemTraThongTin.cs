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

namespace Đặt_Tiệc_Cưới
{
    public partial class KiemTraThongTin : Form
    {
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True";
        public KiemTraThongTin()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.luuTruThongTin);

        }

        private void KiemTraThongTin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'luuTruThongTin.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.luuTruThongTin.Table);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        public void InsertDataIntoDatabase(string tenChuRe, string tenCoDau, string dienThoai, DateTime ngayDaiTiec, string Ca, string Sanh, long soLuongBan, int SoBanDuTru, decimal tienCoc)
        {
            try
            {
                string query = @"INSERT INTO [dbo].[Table] (TenChuRe, TenCoDau, DienThoai, NgayDaiTiec, Ca, Sanh, SoLuongBan, SoBanDuTru, TienDatCoc)
                        VALUES (@TenChuRe, @TenCoDau, @DienThoai, @NgayDaiTiec, @Ca, @Sanh, @SoLuongBan, @SoBanDuTru, @TienDatCoc)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TenChuRe", tenChuRe);
                        command.Parameters.AddWithValue("@TenCoDau", tenCoDau);
                        command.Parameters.AddWithValue("@DienThoai", dienThoai);
                        command.Parameters.AddWithValue("@NgayDaiTiec", ngayDaiTiec);
                        command.Parameters.AddWithValue("@Ca", Ca);
                        command.Parameters.AddWithValue("@Sanh", Sanh);
                        command.Parameters.AddWithValue("@SoLuongBan", soLuongBan);
                        command.Parameters.AddWithValue("@SoBanDuTru", SoBanDuTru);
                        command.Parameters.AddWithValue("@TienDatCoc", tienCoc);

                        connection.Open();
                        command.ExecuteNonQuery();

                        MessageBox.Show("Đặt Tiệc Cưới Thành Công!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có Lỗi Xảy Ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
