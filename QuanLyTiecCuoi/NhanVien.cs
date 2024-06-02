using QuanLyTiecCuoi.NHANVIEN;
using QuanLyTiecCuoi.SERVICE;
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

namespace QuanLyTiecCuoi
{
    public partial class NhanVien : Form
    {
        public string conString;
        public NhanVien(string _constring)
        {
            InitializeComponent();
            this.conString = _constring;
        }

        //private void rjTextBox1_Enter(object sender, EventArgs e)
        //{
        //    //SearchValue.Visible = false;
        //}

        private void NhanVien_Load(object sender, EventArgs e)
        {
            loadNhanVienGridView();
        }

        private void loadNhanVienGridView()
        {
            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();
                string query = "SELECT ID, TENNHANVIEN, SODIENTHOAI, DIACHI, CHUCVU FROM NHANVIEN WHERE TRANGTHAINHANVIEN = 1";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewEmployee.DataSource = dt;
                }
            }

            dataGridViewEmployee.Columns[0].Width = 45;
            dataGridViewEmployee.Columns[0].HeaderText = "ID";
            dataGridViewEmployee.Columns[1].HeaderText = "Tên Nhân Viên";
            dataGridViewEmployee.Columns[1].Width = 175;
            dataGridViewEmployee.Columns[2].HeaderText = "Số Điện Thoại";
            dataGridViewEmployee.Columns[2].Width = 120;
            dataGridViewEmployee.Columns[3].HeaderText = "Địa Chỉ";
            dataGridViewEmployee.Columns[3].Width = 200;
            dataGridViewEmployee.Columns[4].HeaderText = "Chức Vụ";
            dataGridViewEmployee.Columns[4].Width = 100;
        }

      

        private void addEmployee_Click(object sender, EventArgs e)
        {
            InsertNV insertNVForm = new InsertNV(conString, this);
            insertNVForm.ShowDialog();
        }
        private void SaveChangeToDatabase()
        {
            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();

                string updateQuery = @"UPDATE NHANVIEN 
                               SET TENNHANVIEN = @TENNHANVIEN,
                                   SODIENTHOAI = @SODIENTHOAI,
                                   DIACHI = @DIACHI,
                                   CHUCVU = @CHUCVU
                               WHERE ID = @ID";

                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    foreach (DataGridViewRow row in dataGridViewEmployee.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            int id = Convert.ToInt32(row.Cells[0].Value);
                            string tenNhanVien = Convert.ToString(row.Cells[1].Value); 
                            string soDienThoai = Convert.ToString(row.Cells[2].Value); 
                            string diaChi = Convert.ToString(row.Cells[3].Value); 
                            string chucVu = Convert.ToString(row.Cells[4].Value); 

                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@TENNHANVIEN", tenNhanVien);
                            cmd.Parameters.AddWithValue("@SODIENTHOAI", soDienThoai);
                            cmd.Parameters.AddWithValue("@DIACHI", diaChi);
                            cmd.Parameters.AddWithValue("@CHUCVU", chucVu);
                            cmd.Parameters.AddWithValue("@ID", id);

                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }


        private void ChangeInforEmployee_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployee.ReadOnly == true)
            {
                dataGridViewEmployee.ReadOnly = false;
                ChangeInforEmployee.Text = "Lưu Chỉnh Sửa";
                SaveChangeToDatabase();

            }
            else
            {
                dataGridViewEmployee.ReadOnly = true;
                ChangeInforEmployee.Text = "Sửa Nhân Viên";


            }
        }

        private void deleteEmployee_Click(object sender, EventArgs e)
        {
            Int32 selectedCellCount = dataGridViewEmployee.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {
                int currentIndex = dataGridViewEmployee.CurrentCell.RowIndex;

                int ID = Convert.ToInt32(dataGridViewEmployee.Rows[currentIndex].Cells[0].Value);
                string storedProcedureName = "deleteNV";

                using (SqlConnection connection = new SqlConnection(conString))
                {
                    using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@ID", ID);

                        try
                        {
                            connection.Open();

                            command.ExecuteNonQuery();

                            MessageBox.Show("Record updated/deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            loadNhanVienGridView();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred while updating/deleting the record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a record to update/delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {
            string searchText = rjTextBox1.Texts.Trim();
            if (searchText.Length > 0)
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    conn.Open();
                    string query = @"SELECT ID, TENNHANVIEN, SODIENTHOAI, DIACHI, CHUCVU
             FROM NHANVIEN 
             WHERE [ID] LIKE '%' + @searchText + '%' 
             OR [TENNHANVIEN] LIKE '%' + @searchText + '%' 
             OR [SODIENTHOAI] LIKE '%' + @searchText + '%' 
             OR [DIACHI] LIKE '%' + @searchText + '%' 
             OR [CHUCVU] LIKE '%' + @searchText + '%' ";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@searchText", searchText);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dataGridViewEmployee.Columns[0].Width = 45;
                        dataGridViewEmployee.Columns[0].HeaderText = "ID";
                        dataGridViewEmployee.Columns[1].HeaderText = "Tên Nhân Viên";
                        dataGridViewEmployee.Columns[1].Width = 175;
                        dataGridViewEmployee.Columns[2].HeaderText = "Số Điện Thoại";
                        dataGridViewEmployee.Columns[2].Width = 120;
                        dataGridViewEmployee.Columns[3].HeaderText = "Địa Chỉ";
                        dataGridViewEmployee.Columns[3].Width = 200;
                        dataGridViewEmployee.Columns[4].HeaderText = "Chức Vụ";
                        dataGridViewEmployee.Columns[4].Width = 100;
                        dataGridViewEmployee.DataSource = dt;
                    }
                }
            }
            else
            {
                loadNhanVienGridView(); 
            }



        }

     
    }
    
    }
    
