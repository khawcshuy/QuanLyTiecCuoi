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

namespace QuanLyTiecCuoi
{
    public partial class Food : Form
    {
        public Food()
        {
            InitializeComponent();
        }
        private string conString = @"Data Source=DESKTOP-M4GHD5G\LUCY;Initial Catalog=QUANLYTIECCUOI;Persist Security Info=True;User ID=sa;Password=140403";

        
        private void Food_Load(object sender, EventArgs e)
        {
            String query = "SELECT * FROM FOOD";

            using (SqlConnection connection = new SqlConnection(conString))
            {
                // Tạo một đối tượng DataAdapter và SelectCommand
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(query, connection);

                // Mở kết nối
                connection.Open();
                FoodId.DataPropertyName = "ID";
                PictureFood.DataPropertyName = "PICTURE";
                FoodName.DataPropertyName = "TENMONAN";
                FoodPrice.DataPropertyName = "DONGIA";
                FoodNote.DataPropertyName = "NOTE";
                
                // Tạo một DataTable để chứa dữ liệu
                DataTable dataTable = new DataTable();

                // Sử dụng DataAdapter để lấy dữ liệu từ cơ sở dữ liệu và điền vào DataTable
                adapter.Fill(dataTable);

                // Đóng kết nối
                connection.Close();
               

                // Tìm cột hình ảnh trong DataGridView
                DataGridViewImageColumn imageColumn = dataGridView1.Columns["Image"] as DataGridViewImageColumn;

                // Đảm bảo rằng cột hình ảnh được tìm thấy và thiết lập ImageLayout thành Zoom
                if (imageColumn != null)
                {
                    imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                }

                // Gán DataTable làm nguồn dữ liệu cho dataGridView1
                dataGridViewFood.DataSource = dataTable;

            }
        }


        public void LoadDataGridViewFood()
        {
            String query = "SELECT * FROM FOOD";

            using (SqlConnection connection = new SqlConnection(conString))
            {
                // Tạo một đối tượng DataAdapter và SelectCommand
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(query, connection);

                // Mở kết nối
                connection.Open();
                FoodId.DataPropertyName = "ID";
                PictureFood.DataPropertyName = "PICTURE";
                FoodName.DataPropertyName = "TENMONAN";
                FoodPrice.DataPropertyName = "DONGIA";
                FoodNote.DataPropertyName = "NOTE";

                // Tạo một DataTable để chứa dữ liệu
                DataTable dataTable = new DataTable();

                // Sử dụng DataAdapter để lấy dữ liệu từ cơ sở dữ liệu và điền vào DataTable
                adapter.Fill(dataTable);

                // Đóng kết nối
                connection.Close();


                // Tìm cột hình ảnh trong DataGridView
                DataGridViewImageColumn imageColumn = dataGridView1.Columns["Image"] as DataGridViewImageColumn;

                // Đảm bảo rằng cột hình ảnh được tìm thấy và thiết lập ImageLayout thành Zoom
                if (imageColumn != null)
                {
                    imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                }

                // Gán DataTable làm nguồn dữ liệu cho dataGridView1
                dataGridViewFood.DataSource = dataTable;

            }
        }



        private void SearchFood_TextChanged(object sender, EventArgs e)
        {
            string searchText = SearchFood.Text.Trim();

            string query = "SELECT * FROM FOOD WHERE [ID] LIKE '%' + @searchText + '%' OR [TENMONAN] LIKE '%' + @searchText + '%' OR [DONGIA] LIKE '%' + @searchText + '%' OR [NOTE] LIKE '%' + @searchText";

            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@searchText", searchText);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);


                    dataGridViewFood.DataSource = table;
                }
            }
        }


        private void SaveChangesToDatabase()
        {
            int currentIndex = dataGridViewFood.CurrentCell.RowIndex;
            string IDChange = Convert.ToString(dataGridViewFood.Rows[currentIndex].Cells["FoodId"].Value);
            string FoodNameChange = Convert.ToString(dataGridViewFood.Rows[currentIndex].Cells["FoodName"].Value);
            string FoodPriceChange = Convert.ToString(dataGridViewFood.Rows[currentIndex].Cells["FoodPrice"].Value); 
            string NoteChange = Convert.ToString(dataGridViewFood.Rows[currentIndex].Cells["FoodNote"].Value);

            using (SqlConnection connection = new SqlConnection(conString))
            {
                string updateStr = "UPDATE FOOD SET TENMONAN = @FoodNameChange, DONGIA = @FoodPriceChange, Note = @Note WHERE ID = @ID";

                using (SqlCommand updateCmd = new SqlCommand(updateStr, connection))
                {
                    updateCmd.Parameters.AddWithValue("@ID", IDChange);
                    updateCmd.Parameters.AddWithValue("@FoodNameChange", FoodNameChange);
                    updateCmd.Parameters.AddWithValue("@FoodPriceChange", FoodPriceChange);

                    updateCmd.Parameters.AddWithValue("@Note", NoteChange);

                    try
                    {
                        connection.Open();

                        updateCmd.ExecuteNonQuery();

                        MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadDataGridViewFood();

                        dataGridViewFood.ReadOnly = false;
                        ChangeFood.Text = "Chỉnh sửa";
                        isEditing = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while updating the record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private bool isEditing = false;
        private void button2_Click(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                dataGridViewFood.ReadOnly = false;
                ChangeFood.Text = "Lưu chỉnh sửa";
                isEditing = true;
            }
            else
            {

                SaveChangesToDatabase();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy chỉ mục của hàng đang được chọn
                int currentIndex = dataGridView1.CurrentCell.RowIndex;

                // Lấy giá trị của cột ID từ hàng được chọn
                string ID = dataGridView1.Rows[currentIndex].Cells["FoodId"].Value.ToString();

                // Tạo câu lệnh SQL để xóa dữ liệu từ bảng SANHINFOR
                string deleteStr = "DELETE FROM FOOD WHERE ID = @ID";

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
                            LoadDataGridViewFood();
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

        public string imglocation = "";


        private void dataGridViewFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isEditing && dataGridViewFood.Columns[e.ColumnIndex].Name == "FoodPicture" && e.RowIndex != -1)
          {
             OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.gif;*.png)|*.BMP;*.JPG;*.JPEG;*.GIF;*.PNG";

              if (dialog.ShowDialog() == DialogResult.OK)
               {
                  string imagePath = dialog.FileName;
                  byte[] imageData = File.ReadAllBytes(imagePath);
                dataGridView1.Rows[e.RowIndex].Cells["FoodPicture"].Value = imageData;
           }
           }
        }

        private void AddFood_Click(object sender, EventArgs e)
        {
            // Corrected variable name to insertVenueForm
            InsertFood insertFoodForm = new InsertFood(this);
            insertFoodForm.ShowDialog();
        }
    }
}
