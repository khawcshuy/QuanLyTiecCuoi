using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiecCuoi
{
    public partial class Venue : Form
    {
        public Venue()
        {
            InitializeComponent();
        }


        private string conString = @"Data Source=ADMINISTRATOR;Initial Catalog=QUANLYTIECCUOI;Integrated Security=True;Connect Timeout=30;";

        private bool isEditing = false;

        private void Venue_Load(object sender, EventArgs e)
        {
            String query = "SELECT * FROM SANHINFOR";

            using (SqlConnection connection = new SqlConnection(conString))
            {
                // Tạo một đối tượng DataAdapter và SelectCommand
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(query, connection);

                // Mở kết nối
                connection.Open();

                // Tạo một DataTable để chứa dữ liệu
                DataTable dataTable = new DataTable();

                // Sử dụng DataAdapter để lấy dữ liệu từ cơ sở dữ liệu và điền vào DataTable
                adapter.Fill(dataTable);

                // Đóng kết nối
                connection.Close();
                VenueId.DataPropertyName = "ID";
                Image.DataPropertyName = "PICTURE";
                VenueName.DataPropertyName = "TENSANH";
                VenueType.DataPropertyName = "LOAISANH";
                VenueState.DataPropertyName = "TRANGTHAISANH";
                MaxTable.DataPropertyName = "MAXTABLE";
                MinTable.DataPropertyName = "MINMONEY";
                Note.DataPropertyName = "NOTE";

                // Tìm cột hình ảnh trong DataGridView
                DataGridViewImageColumn imageColumn = dataGridView1.Columns["Image"] as DataGridViewImageColumn;

                // Đảm bảo rằng cột hình ảnh được tìm thấy và thiết lập ImageLayout thành Zoom
                if (imageColumn != null)
                {
                    imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                }

                // Gán DataTable làm nguồn dữ liệu cho dataGridView1
                dataGridView1.DataSource = dataTable;

            }
        }



      
        // Method to load data into the DataGridView
        public void LoadDataIntoDataGridView()
        {
            string query = "SELECT * FROM SANHINFOR";

            using (SqlConnection connection = new SqlConnection(conString))
            {
                // Create a data adapter and set the select command
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(query, connection);

                // Create a DataTable to store the data
                DataTable dataTable = new DataTable();

                try
                {
                    // Open the connection
                    connection.Open();

                    // Fill the DataTable with data from the database
                    adapter.Fill(dataTable);

                    // Close the connection
                    connection.Close();

                    // Add a column for the image data


                    // Set the DataPropertyName for each column in the DataGridView
                    VenueId.DataPropertyName = "ID";
                    Image.DataPropertyName = "PICTURE";
                    VenueName.DataPropertyName = "TENSANH";
                    VenueType.DataPropertyName = "LOAISANH";
                    VenueState.DataPropertyName = "TRANGTHAISANH";
                    MaxTable.DataPropertyName = "MAXTABLE";
                    MinTable.DataPropertyName = "MINMONEY";
                    Note.DataPropertyName = "NOTE";

                    // Set the AutoSizeRowsMode and AutoSizeColumnsMode for the DataGridView
                    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    // Assign the DataTable as the data source for the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that occur during data loading
                    MessageBox.Show("An error occurred while loading data into the DataGridView: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        // Method to handle the click event of the "AddVenue" button
        private void AddVenue_Click(object sender, EventArgs e)
        {
            // Corrected variable name to insertVenueForm
            InsertVenue insertVenueForm = new InsertVenue(this);
            insertVenueForm.ShowDialog();
        }





        private void SearchVenue_TextChanged(object sender, EventArgs e)
        {
            string searchText = SearchVenue.Text.Trim();

            string query = "SELECT * FROM SANHINFOR WHERE [ID] LIKE '%' + @searchText + '%' OR [TENSANH] LIKE '%' + @searchText + '%' OR [LOAISANH] LIKE '%' + @searchText + '%' OR [TRANGTHAISANH] LIKE '%' + @searchText + '%' OR [MINMONEY] LIKE '%' + @searchText + '%' OR [MAXTABLE] LIKE '%' + @searchText + '%'";

            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@searchText", searchText);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);


                    dataGridView1.DataSource = table;
                }
            }
        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy chỉ mục của hàng đang được chọn
                int currentIndex = dataGridView1.CurrentCell.RowIndex;

                // Lấy giá trị của cột ID từ hàng được chọn
                string ID = dataGridView1.Rows[currentIndex].Cells["VenueId"].Value.ToString();

                // Tạo câu lệnh SQL để xóa dữ liệu từ bảng SANHINFOR
                string deleteStr = "DELETE FROM SANHINFOR WHERE ID = @ID";

                // Tạo kết nối SQL và lệnh SQL để thực thi xóa
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    using (SqlCommand deleteCmd = new SqlCommand(deleteStr, connection))
                    {
                        // Thêm tham số @ID vào lệnh SQL
                        deleteCmd.Parameters.AddWithValue("@ID", ID);

                        try
                        {
                            // Mở kết nối
                            connection.Open();

                            // Thực thi lệnh SQL xóa
                            deleteCmd.ExecuteNonQuery();

                            // Hiển thị thông báo khi xóa thành công
                            MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Tải lại dữ liệu vào DataGridView sau khi xóa
                            LoadDataIntoDataGridView();
                        }
                        catch (Exception ex)
                        {
                            // Hiển thị thông báo lỗi nếu có lỗi xảy ra khi xóa
                            MessageBox.Show("An error occurred while deleting the record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                // Hiển thị thông báo nếu không có hàng nào được chọn
                MessageBox.Show("Please select a record to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void ChangeVenue_Click(object sender, EventArgs e)
        {
            if (!isEditing) 
            {
                dataGridView1.ReadOnly = false;
                ChangeVenue.Text = "Lưu chỉnh sửa";
                isEditing = true;
            }
            else
            {

                SaveChangesToDatabase();
            }
        }

        private void SaveChangesToDatabase()
        {
            int currentIndex = dataGridView1.CurrentCell.RowIndex;
            string IDChange = Convert.ToString(dataGridView1.Rows[currentIndex].Cells["VenueId"].Value);
            string VenueNameChange = Convert.ToString(dataGridView1.Rows[currentIndex].Cells["VenueName"].Value);
            string VenueTypeChange = Convert.ToString(dataGridView1.Rows[currentIndex].Cells["VenueType"].Value);
            string VenueStateChange = Convert.ToString(dataGridView1.Rows[currentIndex].Cells["VenueState"].Value);
            string MaxTableChange = Convert.ToString(dataGridView1.Rows[currentIndex].Cells["MaxTable"].Value);
            string MinTableChange = Convert.ToString(dataGridView1.Rows[currentIndex].Cells["MinTable"].Value);
            string NoteChange = Convert.ToString(dataGridView1.Rows[currentIndex].Cells["Note"].Value);

            using (SqlConnection connection = new SqlConnection(conString))
            {
                string updateStr = "UPDATE SANHINFOR SET TENSANH = @VenueName, LOAISANH = @VenueType, TRANGTHAISANH = @VenueState, MaxTable = @MaxTable, MinMoney = @MinTable, Note = @Note WHERE ID = @ID";

                using (SqlCommand updateCmd = new SqlCommand(updateStr, connection))
                {
                    updateCmd.Parameters.AddWithValue("@ID", IDChange);
                    updateCmd.Parameters.AddWithValue("@VenueName", VenueNameChange);
                    updateCmd.Parameters.AddWithValue("@VenueType", VenueTypeChange);
                    updateCmd.Parameters.AddWithValue("@VenueState", VenueStateChange);
                    updateCmd.Parameters.AddWithValue("@MaxTable", MaxTableChange);
                    updateCmd.Parameters.AddWithValue("@MinTable", MinTableChange);
                    updateCmd.Parameters.AddWithValue("@Note", NoteChange);

                    try
                    {
                        connection.Open();

                        updateCmd.ExecuteNonQuery();

                        MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadDataIntoDataGridView();

                        dataGridView1.ReadOnly = false;
                        ChangeVenue.Text = "Chỉnh sửa";
                        isEditing = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while updating the record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
       
            if (isEditing && dataGridView1.Columns[e.ColumnIndex].Name == "Image" && e.RowIndex != -1)
            { 
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.gif;*.png)|*.BMP;*.JPG;*.JPEG;*.GIF;*.PNG";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = dialog.FileName;
                    byte[] imageData = File.ReadAllBytes(imagePath);
                    dataGridView1.Rows[e.RowIndex].Cells["Image"].Value = imageData;
                }
            }
        }
    }
}

