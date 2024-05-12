using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;

namespace WeedingPartyBooking
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=DATTIECUOI;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private bool IsString(string value)
        {
            return value.All(char.IsLetter) || value.All(char.IsWhiteSpace);
        }

        private bool IsNumeric(string value)
        {
            return value.All(char.IsDigit);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTenChuRe.Text))
            {
                MessageBox.Show("Cần nhập thông tin tên chú rể!");
                return; 
            }

            if (!IsString(textBoxTenChuRe.Text))
            {
                MessageBox.Show("Tên chú rể chỉ được chứa chữ cái và khoảng trắng!");
                return; 
            }

            if (string.IsNullOrWhiteSpace(textBoxTenCoDau.Text))
            {
                MessageBox.Show("Cần nhập thông tin tên cô dâu!");
                return; 
            }

            if (!IsString(textBoxTenCoDau.Text))
            {
                MessageBox.Show("Tên cô dâu chỉ được chứa chữ cái và khoảng trắng!");
                return; 
            }

            if (string.IsNullOrWhiteSpace(textBoxDienThoai.Text))
            {
                MessageBox.Show("Cần nhập thông tin điện thoại!");
                return; 
            }

            if (!IsNumeric(textBoxDienThoai.Text))
            {
                MessageBox.Show("Điện Thoại chỉ được chứa số!");
                return; 
            }

            if (comboBoxCa.SelectedItem == null)
            {
                MessageBox.Show("Cần chọn ca!");
                return; 
            }

            if (comboBoxSanh.SelectedItem == null)
            {
                MessageBox.Show("Cần chọn sảnh!");
                return; 
            }

            decimal tienDatCoc;
            if (!decimal.TryParse(textBoxTienDatCoc.Text, out tienDatCoc) || tienDatCoc <= 0)
            {
                MessageBox.Show("Cần nhập số tiền đặt cọc hợp lệ!");
                return; 
            }

            int soLuongBan;
            if (!int.TryParse(textBoxSoLuongBan.Text, out soLuongBan) || soLuongBan <= 0)
            {
                MessageBox.Show("Cần nhập số Lượng Bàn hợp lệ!");
                return; 
            }

            int soBanDuTru;
            if (!int.TryParse(textBoxSoBanDuTru.Text, out soBanDuTru) || soBanDuTru < 0)
            {
                MessageBox.Show("Cần nhập số Bàn Dự Trữ hợp lệ!");
                return;
            }
            string queryCheckDuplicate = "SELECT COUNT(*) FROM THONGTINKHACHHANG WHERE CA = @CA AND NGAYDAITIEC = @NGAYDAITIEC";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmdCheckDuplicate = new SqlCommand(queryCheckDuplicate, con))
                {
                    cmdCheckDuplicate.Parameters.AddWithValue("@CA", comboBoxCa.Text);
                    cmdCheckDuplicate.Parameters.AddWithValue("@NGAYDAITIEC", dateTimePickerNgayDaiTiec.Value.Date);

                    try
                    {
                        con.Open();
                        int count = (int)cmdCheckDuplicate.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Đã có người đặt tiệc! Vui lòng chọn ngày hoặc ca khác.");
                            return; 
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                        return; 
                    }
                }
            string query = "INSERT INTO THONGTINKHACHHANG (TENCHURE, TENCODAU, DIENTHOAI, NGAYDAITIEC, CA, SANH, TIENDATCOC, SOLUONGBAN, SOBANDUTRU) " +
                           "VALUES (@TENCHURE, @TENCODAU, @DIENTHOAI, @NGAYDAITIEC, @CA, @SANH, @TIENDATCOC, @SOLUONGBAN, @SOBANDUTRU)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@TENCHURE", textBoxTenChuRe.Text);
                    cmd.Parameters.AddWithValue("@TENCODAU", textBoxTenCoDau.Text);
                    cmd.Parameters.AddWithValue("@DIENTHOAI", textBoxDienThoai.Text);
                    cmd.Parameters.AddWithValue("@NGAYDAITIEC", dateTimePickerNgayDaiTiec.Value.Date);
                    cmd.Parameters.AddWithValue("@CA", comboBoxCa.Text);
                    cmd.Parameters.AddWithValue("@SANH", comboBoxSanh.Text);
                    cmd.Parameters.AddWithValue("@TIENDATCOC", decimal.Parse(textBoxTienDatCoc.Text));
                    cmd.Parameters.AddWithValue("@SOLUONGBAN", int.Parse(textBoxSoLuongBan.Text));
                    cmd.Parameters.AddWithValue("@SOBANDUTRU", int.Parse(textBoxSoBanDuTru.Text));

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            using (SqlConnection connection = new SqlConnection(connectionString))
                            {
                                connection.Open();
                                string commandText = "DBCC CHECKIDENT ('MONAN', RESEED, 0);";
                                SqlCommand command = new SqlCommand(commandText, connection);
                                command.ExecuteNonQuery();
                            }
                            MessageBox.Show("Đặt Tiệc Cưới Thành Công!");
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng nhập thông tin!");
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MonAn monAnForm = new MonAn();
            monAnForm.FormClosed += MonAnForm_FormClosed;
            monAnForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dATTIECUOIMONAN.MONAN' table. You can move, or remove it, as needed.
            this.mONANTableAdapter.Fill(this.dATTIECUOIMONAN.MONAN);
            this.mONANTableAdapter.FillByMonAn(this.dATTIECUOIMONAN.MONAN);
            this.mONANINUSETableAdapter.Fill(this.dATTIECUOIMONANINUSE.MONANINUSE);
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT DICHVUINUSE.IDDV, DICHVU.TENDICHVU, DICHVUINUSE.SLDVINUSE, DICHVU.DONGIA FROM DICHVU, DICHVUINUSE WHERE DICHVU.ID = DICHVUINUSE.DICHVUINUSE", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            dataGridView2.Columns[0].HeaderText = "STT";
            dataGridView2.Columns[1].HeaderText = "Tên Dịch Vụ";
            dataGridView2.Columns[1].Width = 150;
            dataGridView2.Columns[2].HeaderText = "Số Lượng";
            dataGridView2.Columns[3].HeaderText = "Đơn Giá";
        }
        private void MonAnForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            fillByMonAnToolStripButton_Click(sender, e);
        }
        private void fillByMonAnToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.mONANTableAdapter.FillByMonAn(this.dATTIECUOIMONAN.MONAN);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DichVu newDichVu = new DichVu();
            newDichVu.Show();
        }
    }
}
