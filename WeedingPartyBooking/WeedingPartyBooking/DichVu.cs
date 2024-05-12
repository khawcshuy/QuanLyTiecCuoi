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
    public partial class DichVu : Form
    {
        string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=DATTIECUOI;Integrated Security=True";
        public DichVu()
        {
            InitializeComponent();
        }

        private void DichVu_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT ID, TENDICHVU, SOLUONG, DONGIA FROM DICHVU", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[0].HeaderText = "STT";
            dataGridView1.Columns[0].Name = "iDDataGridViewTextBoxColumn";
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].Width = 130;
            dataGridView1.Columns[1].HeaderText = "Tên Dịch Vụ";
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[2].HeaderText = "Số Lượng";
            dataGridView1.Columns[3].Width = 145;
            dataGridView1.Columns[2].Name = "sOLUONGDataGridViewTextBoxColumn";
            dataGridView1.Columns[3].HeaderText = "Đơn Giá";
            dataGridView1.Columns[3].ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int tendichvuID = Convert.ToInt32(selectedRow.Cells["iDDataGridViewTextBoxColumn"].Value);
                int soluong = Convert.ToInt32(selectedRow.Cells["sOLUONGDataGridViewTextBoxColumn"].Value);
                //decimal dongia = Convert.ToDecimal(selectedRow.Cells["dataGridViewTextBoxColumn4"].Value);

                if (soluong > 0)
                {
                    //decimal thanhtien = soluong * dongia;
                    using (var connection = new SqlConnection(connectionString)) 
                    {
                        connection.Open();
                        using (var command = new SqlCommand("INSERT INTO DICHVUINUSE (DICHVUINUSE, SLDVINUSE) VALUES (@DICHVUINUSE, @SLDVINUSE)", connection))
                        {
                            command.Parameters.AddWithValue("@DICHVUINUSE", tendichvuID);
                            command.Parameters.AddWithValue("@SLDVINUSE", soluong);
                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Thêm dịch vụ thành công!");
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            for (int item = 0; item <= dataGridView1.Rows.Count - 1; item++)
            {
                SqlCommand cmd2 = new SqlCommand("UPDATE DICHVU SET TENDICHVU = @TENDICHVU, SOLUONG = @SOLUONG, DONGIA = @DONGIA WHERE ID = @ID", conn);
                cmd2.Parameters.AddWithValue("@TENDICHVU", dataGridView1.Rows[item].Cells[1].Value);
                cmd2.Parameters.AddWithValue("@SOLUONG", dataGridView1.Rows[item].Cells[2].Value);
                cmd2.Parameters.AddWithValue("@DONGIA", dataGridView1.Rows[item].Cells[3].Value);
                cmd2.Parameters.AddWithValue("ID", dataGridView1.Rows[item].Cells[0].Value);
                conn.Open();
                cmd2.ExecuteNonQuery();
                conn.Close();
            }
            MessageBox.Show("Sửa Thông Tin Dịch Vụ Thành Công!");
        }
    }
}
