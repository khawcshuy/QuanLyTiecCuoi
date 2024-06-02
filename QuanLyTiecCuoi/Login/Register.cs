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

namespace QuanLyTiecCuoi.Login
{
    public partial class Register : Form
    {
        public string constring;
        private Size formSize;
        public Register(string _constring)
        {
            InitializeComponent();
            this.constring = _constring;
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            string username = textBoxTenTaiKhoan.Texts.Trim();
            string password = textBoxMatKhau.Texts.Trim();
            string passwordAgain = textBoxMatKhauAgain.Texts.Trim();
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(passwordAgain))
            {
                MessageBox.Show("Vui lòng điền thông tin còn thiếu!");
                return;
            }
            if (password != passwordAgain)
            {
                MessageBox.Show("Mật khẩu vừa nhập không khớp!");
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(constring))
                {
                    conn.Open();
                    string checkUserQuery = "SELECT COUNT(*) FROM USERS WHERE USERNAME = @username";
                    using (SqlCommand checkUserCmd = new SqlCommand(checkUserQuery, conn))
                    {
                        checkUserCmd.Parameters.AddWithValue("@username", username);
                        int userExists = (int)checkUserCmd.ExecuteScalar();

                        if (userExists > 0)
                        {
                            MessageBox.Show("Tên tài khoản đã tồn tại, vui lòng chọn tên khác!");
                            return;
                        }
                    }
                    
                    string query = "INSERT INTO USERS (USERNAME, UPASS) VALUES (@username, @password)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Đăng ký thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Đăng ký thất bại, vui lòng thử lại!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra: " + ex.Message);
            }
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
