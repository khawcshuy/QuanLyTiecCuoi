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
        public InsertNV( string conString_, NhanVien parentForm)
        {
            InitializeComponent();

            this.conString = conString_;
            _parentForm = parentForm;
        }

        private void InsertNV_Load(object sender, EventArgs e)
        {

        }



        private void ConfirmAddButton_Click(object sender, EventArgs e)
        {
            // Get the values from the input fields
            string employeeNameValue = employeeNameAdd.Text;
            string employeeAddressValue = employeeAdressAdd.Text;
            string employeePhoneValue = employeePhoneAdd.Text;
            string employeePositionValue = employeePositionAdd.Text;
            string username = userName.Text;
            string password = Password.Text;

            // Check if any required field is empty
            if (string.IsNullOrEmpty(employeeNameValue) ||
                string.IsNullOrEmpty(employeeAddressValue) ||
                string.IsNullOrEmpty(employeePhoneValue) ||
                string.IsNullOrEmpty(employeePositionValue))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method without executing the SQL command
            }

            // Proceed with adding the new employee
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("AddNhanVien", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Set parameter values
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



    }
}

