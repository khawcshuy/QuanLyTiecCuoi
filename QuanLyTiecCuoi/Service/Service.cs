using QuanLyTiecCuoi.FOOD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiecCuoi.Service
{
    public partial class Service : Form
    {
        public Service()
        {
            InitializeComponent();
        }
        private string conString = @"Data Source=DESKTOP-M4GHD5G\LUCY;Initial Catalog=QUANLYTIECCUOI;Persist Security Info=True;User ID=sa;Password=140403";
        private bool isEditing = false;
        private void Service_Load(object sender, EventArgs e)
        {
            String query = "SELECT * FROM DICHVU"; // Thay đổi từ FOOD sang DICHVU

            using (SqlConnection connection = new SqlConnection(conString))
            {
                // Tạo một đối tượng DataAdapter và SelectCommand
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(query, connection);

                // Mở kết nối
                connection.Open();
                ServiceId.DataPropertyName = "ID";
                ServiceName.DataPropertyName = "TENDICHVU"; // Thay đổi từ TENMONAN sang TENDICHVU
                ServicePrice.DataPropertyName = "GIADICHVU"; // Thay đổi từ DONGIA sang GIADICHVU
                ServiceType.DataPropertyName = "LOAIDICHVU";
                ServiceNote.DataPropertyName = "NOTE"; // Kiểm tra xem cột NOTE có tồn tại trong bảng DICHVU không

                // Tạo một DataTable để chứa dữ liệu
                DataTable dataTable = new DataTable();

                // Sử dụng DataAdapter để lấy dữ liệu từ cơ sở dữ liệu và điền vào DataTable
                adapter.Fill(dataTable);

                // Đóng kết nối
                connection.Close();


                // Gán DataTable làm nguồn dữ liệu cho dataGridView1
                dataGridViewService.DataSource = dataTable;
            }
        }


        public void LoadDataGridViewService()
        {
            String query = "SELECT * FROM DICHVU"; // Thay đổi từ FOOD sang DICHVU

            using (SqlConnection connection = new SqlConnection(conString))
            {
                // Tạo một đối tượng DataAdapter và SelectCommand
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(query, connection);

                // Mở kết nối
                connection.Open();
                ServiceId.DataPropertyName = "ID";
                ServiceName.DataPropertyName = "TENDICHVU"; // Thay đổi từ TENMONAN sang TENDICHVU
                ServicePrice.DataPropertyName = "GIADICHVU"; // Thay đổi từ DONGIA sang GIADICHVU
                ServiceType.DataPropertyName = "LOAIDICHVU";
                ServiceNote.DataPropertyName = "NOTE"; // Kiểm tra xem cột NOTE có tồn tại trong bảng DICHVU không

                // Tạo một DataTable để chứa dữ liệu
                DataTable dataTable = new DataTable();

                // Sử dụng DataAdapter để lấy dữ liệu từ cơ sở dữ liệu và điền vào DataTable
                adapter.Fill(dataTable);

                // Đóng kết nối
                connection.Close();


                // Gán DataTable làm nguồn dữ liệu cho dataGridView1
                dataGridViewService.DataSource = dataTable;
            }
        }


        private void SaveChangesToDatabase()
        {
            int currentIndex = dataGridViewService.CurrentCell.RowIndex;
            string IDChange = Convert.ToString(dataGridViewService.Rows[currentIndex].Cells["ServiceId"].Value);
            string ServiceNameChange = Convert.ToString(dataGridViewService.Rows[currentIndex].Cells["ServiceName"].Value);
            string ServicePriceChange = Convert.ToString(dataGridViewService.Rows[currentIndex].Cells["ServicePrice"].Value);
            string NoteChange = Convert.ToString(dataGridViewService.Rows[currentIndex].Cells["ServiceNote"].Value);
            string ServiceTypeChange = Convert.ToString(dataGridViewService.Rows[currentIndex].Cells["ServiceType"].Value);

            using (SqlConnection connection = new SqlConnection(conString))
            {
                string updateStr = "UPDATE DICHVU SET TENDICHVU = @ServiceNameChange, GIADICHVU = @ServicePriceChange, NOTE = @Note, LOAIDICHVU = @ServiceTypeChange WHERE ID = @ID"; // Thay đổi từ FOOD sang DICHVU, TENDICHVU, GIADICHVU, NOTE

                using (SqlCommand updateCmd = new SqlCommand(updateStr, connection))
                {
                    updateCmd.Parameters.AddWithValue("@ID", IDChange);
                    updateCmd.Parameters.AddWithValue("@ServiceNameChange", ServiceNameChange);
                    updateCmd.Parameters.AddWithValue("@ServicePriceChange", ServicePriceChange);

                    updateCmd.Parameters.AddWithValue("@Note", NoteChange);

                    try
                    {
                        connection.Open();

                        updateCmd.ExecuteNonQuery();

                        MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadDataGridViewService();

                        dataGridViewService.ReadOnly = false;
                        ChangeService.Text = "Chỉnh sửa";
                        isEditing = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while updating the record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ChangeService_Click(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                dataGridViewService.ReadOnly = false;
                ChangeService.Text = "Lưu chỉnh sửa";
                isEditing = true;
            }
            else
            {
                SaveChangesToDatabase();
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if (dataGridView1.SelectedRows.Count > 0)
        //    {
        //        int currentIndex = dataGridView1.CurrentCell.RowIndex;
        //        string ID = dataGridView1.Rows[currentIndex].Cells["FoodId"].Value.ToString();

        //        string deleteStr = "DELETE FROM DICHVU WHERE ID = @ID";

        //        using (SqlConnection connection = new SqlConnection(conString))
        //        {
        //            using (SqlCommand deleteCmd = new SqlCommand(deleteStr, connection))
        //            {
        //                deleteCmd.Parameters.AddWithValue("@ID", ID);

        //                try
        //                {
        //                    connection.Open();
        //                    deleteCmd.ExecuteNonQuery();
        //                    MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                    LoadDataGridViewFood();
        //                }
        //                catch (Exception ex)
        //                {
        //                    MessageBox.Show("An error occurred while deleting the record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                }
        //            }
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please select a record to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}

        private void dataGridViewFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isEditing && dataGridViewService.Columns[e.ColumnIndex].Name == "FoodPicture" && e.RowIndex != -1)
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.gif;*.png)|*.BMP;*.JPG;*.JPEG;*.GIF;*.PNG";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = dialog.FileName;
                    byte[] imageData = File.ReadAllBytes(imagePath);
                    dataGridViewService.Rows[e.RowIndex].Cells["PictureFood"].Value = imageData;
                }
            }
        }

        private void AddFood_Click(object sender, EventArgs e)
        {
            InsertService insertServiceForm = new InsertService(this);
            insertServiceForm.ShowDialog();
        }

        private void SearchService_TextChanged(object sender, EventArgs e)
        {
            string searchText = SearchService.Text.Trim();

            string query = "SELECT * FROM DICHVU WHERE [ID] LIKE '%' + @searchText + '%' OR [TENDICHVU] LIKE '%' + @searchText + '%' OR [GIADICHVU] LIKE '%' + @searchText + '%' OR [NOTE] LIKE '%' + @searchText"; // Thay đổi từ FOOD sang DICHVU, TENDICHVU, GIADICHVU

            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@searchText", searchText);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridViewService.DataSource = table;
                }
            }
        }

       
    }
}
