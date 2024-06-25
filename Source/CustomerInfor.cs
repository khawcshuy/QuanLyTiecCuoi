using System;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;


public class CustomerInfo
{
    public string CustomerName { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Groom { get; set; }
    public string Bride { get; set; }
    public DateTime OrderDate { get; set; }
    public DateTime DueDate { get; set; }

    public float Deposit { get; set; }


    // Constructor để khởi tạo một đối tượng CustomerInfo từ một SqlDataReader
    public CustomerInfo(SqlDataReader reader)
    {
        CustomerName = reader["TENKHACHHANG"].ToString();
        Address = reader["DIACHI"].ToString();
        Email = reader["EMAIL"].ToString();
        Phone = reader["DIENTHOAI"].ToString();
        Groom = reader["TENCODAU"].ToString();
        Bride = reader["TENCHURE"].ToString();
        OrderDate = (DateTime)reader["NGAYLAP"];
        DueDate = (DateTime)reader["NGAYTOCHUC"];
        Deposit = (float)reader.GetDecimal(reader.GetOrdinal("TIENCOC"));
    }
    private void LoadCustomerInfo(CustomerInfo customer)
    {
        CustomerName.Text = customer.CustomerName;
        Address.Text = customer.Address;
        Email.Text = customer.Email;
        Phone.Text = customer.Phone;
        Groom.Text = customer.Groom;
        Bride.Text = customer.Bride;
        OrderDate.Value = customer.OrderDate;
        Date.Value = customer.DueDate;
        deposit.Text = customer.Deposit.ToString();
    }
    private CustomerInfo LoadCustomerInfo(string customerId)
    {
        CustomerInfo customerInfo = null;

        using (SqlConnection con = new SqlConnection(conString))
        {
            con.Open();
            string query = "SELECT * FROM KHACHHANGINFOR WHERE ID = @customerId";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@customerId", customerId);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        customerInfo = new CustomerInfo(reader);
                        LoadCustomerInfo(customerInfo);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin khách hàng!");
                    }
                }
            }
        }

        return customerInfo;
    }
}
