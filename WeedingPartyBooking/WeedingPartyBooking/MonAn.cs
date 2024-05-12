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
    public partial class MonAn : Form
    {
        string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=DATTIECUOI;Integrated Security=True";
        public MonAn()
        {
            InitializeComponent();
        }

        private void MonAn_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT ID, TENMONAN, DONGIA, NOTE FROM MONAN", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[0].HeaderText = "STT";
            dataGridView1.Columns[0].Name = "iDDataGridViewTextBoxColumn";
            dataGridView1.Columns[1].Width = 130;
            dataGridView1.Columns[1].HeaderText = "Tên Món Ăn";
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[2].HeaderText = "Đơn Giá";
            dataGridView1.Columns[3].Width = 145;
            dataGridView1.Columns[3].HeaderText = "Ghi Chú";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                if (selectedRow.Cells["iDDataGridViewTextBoxColumn"].Value != null)
                {
                    string idValue = selectedRow.Cells["iDDataGridViewTextBoxColumn"].Value.ToString();
                    int monanID;
                    if (int.TryParse(idValue, out monanID))
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            string insertQuery = "INSERT INTO MONANINUSE (MONANINUSE) VALUES (@MonanID)";
                            SqlCommand command = new SqlCommand(insertQuery, connection);
                            command.Parameters.AddWithValue("@MonanID", monanID);

                            try
                            {
                                command.ExecuteNonQuery();
                                MessageBox.Show("Thêm Thông Tin Món Ăn Thành Công!");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Không thể thêm: " + ex.Message);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: ID value is not in a valid format.");
                    }
                }
                else
                {
                    MessageBox.Show("Error: ID value is null.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn món ăn cần thêm!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            for (int item = 0; item <= dataGridView1.Rows.Count - 1;item++)
            {
                SqlCommand cmd2 = new SqlCommand("UPDATE MONAN SET TENMONAN = @TENMONAN, DONGIA = @DONGIA, NOTE = @NOTE WHERE ID = @ID", conn);
                cmd2.Parameters.AddWithValue("@TENMONAN", dataGridView1.Rows[item].Cells[1].Value);
                cmd2.Parameters.AddWithValue("@DONGIA", dataGridView1.Rows[item].Cells[2].Value);
                cmd2.Parameters.AddWithValue("@NOTE", dataGridView1.Rows[item].Cells[3].Value);
                cmd2.Parameters.AddWithValue("ID", dataGridView1.Rows[item].Cells[0].Value);
                conn.Open();
                cmd2.ExecuteNonQuery();
                conn.Close();
            }
            MessageBox.Show("Sửa Thông Tin Món Ăn Thành Công!");
        }
    }
}
