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
using static System.Windows.Forms.AxHost;

namespace QuanLyTiecCuoi
{
    public partial class Venue : Form
    {


        private Booking _parentForm;


        public Venue(Booking parentForm = null)
        {
            if (parentForm == null)
            {
                InitializeComponent();
            }
            else
            {
                InitializeComponent();
                _parentForm = parentForm;
            }
        }


        //private string conString = @"Data Source=DESKTOP-M4GHD5G\LUCY;Initial Catalog=QUANLYTIECCUOI;Persist Security Info=True;User ID=sa;Password=140403";

        private bool ChangingState;

        public bool isChoosing = false;

        public int VenueSelectedId;


        private string conString = @"Data Source = ADMINISTRATOR; Initial Catalog = QUANLYTIECCUOI; Integrated Security = True";


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
                if (isChoosing)
                {
                    DataGridViewCheckBoxColumn selectColumn = new DataGridViewCheckBoxColumn();
                    selectColumn.HeaderText = "Select";
                    selectColumn.Name = "Select";
                    selectColumn.DataPropertyName = "SELECT"; // Replace "SELECT" with the actual column name in your database
                    selectColumn.ReadOnly = false; // Allow selection
                    dataGridView1.Columns.Add(selectColumn);
                    Confirm.Size = new System.Drawing.Size(180, 40);

                }

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

                    if (isChoosing)
                    {
                        DataGridViewCheckBoxColumn selectColumn = new DataGridViewCheckBoxColumn();
                        selectColumn.HeaderText = "Select";
                        selectColumn.Name = "Select";
                        selectColumn.DataPropertyName = "SELECT"; // Replace "SELECT" with the actual column name in your database
                        selectColumn.ReadOnly = false; // Allow selection
                        dataGridView1.Columns.Add(selectColumn);
                        Confirm.Size = new System.Drawing.Size(180, 40);


                    }
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
            ChangingState = true;
            dataGridView1.ReadOnly = false;
            ChangeVenue.Text = "Chỉnh sửa";
            isEditing = false;



            InsertVenue insertVenueForm = new InsertVenue(this);
            insertVenueForm.ShowDialog();
        }



        private void SelectedVenue(bool isChoosing)
        {
            if (!isChoosing)
            {
                // Lấy chỉ mục hàng dựa trên VenueSelectedId
              
                
                    DataGridViewCell selectedCell = dataGridView1.Rows[VenueSelectedId].Cells["SELECT"];

                    if (selectedCell != null)
                    {
                        // Đảo giá trị của ô SELECT
                        selectedCell.Value = !(bool)selectedCell.Value;
                    }
                
                else
                {
                    Console.WriteLine($"Failed to convert '{VenueSelectedId}' to a valid row index.");
                }
            }
            else
            {
                // Nếu isChoosing là true, không có gì cần phải làm ở đây
            }
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

                SaveChangesToDatabase(ChangingState);
            }
        }

        private void SaveChangesToDatabase(bool ChangingState = false)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();

                // Duyệt qua từng hàng trong DataGridView
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // Kiểm tra hàng không phải là hàng mới và không phải là hàng dùng để thêm mới
                    if (!row.IsNewRow && row.Cells["VenueId"].Value != null)
                    {
                        string IDChange = Convert.ToString(row.Cells["VenueId"].Value);
                        string VenueNameChange = Convert.ToString(row.Cells["VenueName"].Value);
                        string VenueTypeChange = Convert.ToString(row.Cells["VenueType"].Value);
                        string VenueStateChange = Convert.ToString(row.Cells["VenueState"].Value);
                        string MaxTableChange = Convert.ToString(row.Cells["MaxTable"].Value);
                        string MinTableChange = Convert.ToString(row.Cells["MinTable"].Value);
                        string NoteChange = Convert.ToString(row.Cells["Note"].Value);
                        byte[] imageData = null; // Initialize imageData variable
                        object cellValue = row.Cells["image"].Value; // Get the value of the cell
                        string updateStr = "UPDATE SANHINFOR SET TENSANH = @VenueName, LOAISANH = @VenueType, TRANGTHAISANH = @VenueState, MaxTable = @MaxTable, MinMoney = @MinTable, Note = @Note, PICTURE = @ImageData WHERE ID = @ID";



                        // Check if the cell value is not DBNull
                        if (cellValue != DBNull.Value)
                        {
                            // If the value is not DBNull, cast it to byte[]
                            imageData = (byte[])cellValue;
                             updateStr = "UPDATE SANHINFOR SET TENSANH = @VenueName, LOAISANH = @VenueType, TRANGTHAISANH = @VenueState, MaxTable = @MaxTable, MinMoney = @MinTable, Note = @Note, PICTURE = @ImageData WHERE ID = @ID";

                        }
                        else
                        {
                            // If the value is DBNull, use an empty byte array
                            imageData = new byte[0];
                             updateStr = "UPDATE SANHINFOR SET TENSANH = @VenueName, LOAISANH = @VenueType, TRANGTHAISANH = @VenueState, MaxTable = @MaxTable, MinMoney = @MinTable, Note = @Note WHERE ID = @ID";

                        }


                        using (SqlCommand updateCmd = new SqlCommand(updateStr, connection))
                        {
                            updateCmd.Parameters.AddWithValue("@ID", IDChange);
                            updateCmd.Parameters.AddWithValue("@VenueName", VenueNameChange);
                            updateCmd.Parameters.AddWithValue("@VenueType", VenueTypeChange);
                            updateCmd.Parameters.AddWithValue("@VenueState", VenueStateChange);
                            updateCmd.Parameters.AddWithValue("@MaxTable", MaxTableChange);
                            updateCmd.Parameters.AddWithValue("@MinTable", MinTableChange);
                            updateCmd.Parameters.AddWithValue("@Note", NoteChange);
                            updateCmd.Parameters.AddWithValue("@ImageData", imageData);

                            try
                            {
                                updateCmd.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("An error occurred while updating the record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }

                if(!ChangingState)
                {
                    MessageBox.Show("All records updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ChangingState = false;
                }
                LoadDataIntoDataGridView();

                dataGridView1.ReadOnly = false;
                ChangeVenue.Text = "Chỉnh sửa";
                isEditing = false;
            }
        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {


            if (isEditing && dataGridView1.Columns[e.ColumnIndex].Name == "Image" && e.RowIndex != -1 && !isChoosing)
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

            if (isChoosing)
            {
                // Đặt chế độ chọn thành FullRowSelect để chỉ chọn một dòng
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                int currentRowIndex = e.RowIndex;
                if (currentRowIndex >= 0 && currentRowIndex < dataGridView1.Rows.Count)
                {
                    // Lấy ô "SELECT" của dòng hiện tại
                    DataGridViewCell selectedCell = dataGridView1.Rows[currentRowIndex].Cells["SELECT"];

                    // Kiểm tra nếu ô không phải là null
                    if (selectedCell != null)
                    {
                        // Đặt giá trị của ô thành true
                        selectedCell.Value = true;

                        // Vòng lặp để đặt giá trị của tất cả các ô khác trong cột "SELECT" thành false
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Index != currentRowIndex)
                            {
                                DataGridViewCell otherCell = row.Cells["SELECT"];
                                if (otherCell != null)
                                {
                                    otherCell.Value = false;
                                }
                            }
                        }
                    }
                }
            }

        }


        public delegate void ConfirmEventHandler(int VenueSelectedId);

        // Define an event based on the delegate
        public event ConfirmEventHandler ConfirmEvent; 

        private void Confirm_Click(object sender, EventArgs e)
        {
           
            // Iterate through the DataGridView to collect selected food IDs
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells["SELECT"].Value))
                {
                    int.TryParse(row.Cells["VenueId"].Value.ToString(), out VenueSelectedId); // Assuming the ID column name is "ID"
                }
            }

            // Raise the event and pass the list
            ConfirmEvent?.Invoke(VenueSelectedId);

            // Close the Food form
            this.Close();
        }
    }
}

