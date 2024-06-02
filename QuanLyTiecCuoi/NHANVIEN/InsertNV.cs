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

namespace QuanLyTiecCuoi.NHANVIEN
{
    public partial class InsertNV : Form
    {
        private NhanVien _parentForm;
        public string conString;
        private Size formSize;
        public InsertNV( string conString_, NhanVien parentForm)
        {
            InitializeComponent();

            this.conString = conString_;
            _parentForm = parentForm;
        }

        private void InsertNV_Load(object sender, EventArgs e)
        {

        }

        private void XacNhan_Click(object sender, EventArgs e)
        {
            string employeeNameValue = textBoxTenNhanVien.Texts.Trim();
            string employeeAddressValue = textBoxDiaChi.Texts.Trim();
            string employeePhoneValue = textBoxSoDienThoai.Texts.Trim();
            string employeePositionValue = textBoxChucVu.Texts.Trim();
            string username = textBoxTenTaiKhoan.Texts.Trim();
            string password = textBoxMatKhau.Texts.Trim();

            if (string.IsNullOrEmpty(employeeNameValue) ||
                string.IsNullOrEmpty(employeeAddressValue) ||
                string.IsNullOrEmpty(employeePhoneValue) ||
                string.IsNullOrEmpty(employeePositionValue))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("AddNhanVien", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@TENNHANVIEN", employeeNameValue);
                    command.Parameters.AddWithValue("@SODIENTHOAI", employeePhoneValue);
                    command.Parameters.AddWithValue("@DIACHI", employeeAddressValue);
                    command.Parameters.AddWithValue("@CHUCVU", employeePositionValue);

                    if (!string.IsNullOrEmpty(username))
                    {
                        command.Parameters.AddWithValue("@TAIKHOAN", username);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@TAIKHOAN", DBNull.Value);
                    }

                    if (!string.IsNullOrEmpty(password))
                    {
                        command.Parameters.AddWithValue("@MATKHAU", password);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@MATKHAU", DBNull.Value);
                    }

                    try
                    {

                        command.ExecuteNonQuery();
                        MessageBox.Show("NhanVien added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            this.Close();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020;
            const int SC_RESTORE = 0xF120;
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            if (m.Msg == WM_SYSCOMMAND)
            {
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }

    }
}

