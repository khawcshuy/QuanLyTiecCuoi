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

        public string conString;
        public Venue(Booking parentForm = null, string conString = null)
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

            this.conString = conString;
        }


        //private string conString = @"Data Source=DESKTOP-M4GHD5G\LUCY;Initial Catalog=QUANLYTIECCUOI;Persist Security Info=True;User ID=sa;Password=140403";
        public DateTime AvailableVenueDate;

        public string AvailableVenueShift;

        private bool ChangingState;

        public bool isChoosing = false;

        public int VenueSelectedId;


        //private string conString = @"Data Source = ADMINISTRATOR; Initial Catalog = QUANLYTIECCUOI; Integrated Security = True";


        private bool isEditing = false;

        private void Venue_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
            }




        public void LoadDataIntoDataGridView()
        {
            string query = "SELECT ID,PICTURE, TENSANH,LOAISANH,MAXTABLE,MINMONEY,NOTE FROM SANHINFOR where TRANGTHAISANH = 1 ";
            if (_parentForm != null)
            {
                 query = "SELECT ID,PICTURE, TENSANH,LOAISANH,MAXTABLE,MINMONEY,NOTE FROM SANHINFOR WHERE ID NOT IN (SELECT IDLOAISANH FROM TIEC WHERE NGAYTOCHUC = @Ngay AND CA = @Ca ) AND TRANGTHAISANH = 1 ";

                using (SqlConnection connection = new SqlConnection(conString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Ngay", AvailableVenueDate.Date);

                        command.Parameters.AddWithValue("@Ca", AvailableVenueShift);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        VenueId.DataPropertyName = "ID";
                        Image.DataPropertyName = "PICTURE";
                        VenueName.DataPropertyName = "TENSANH";
                        VenueType.DataPropertyName = "LOAISANH";
                        MaxTable.DataPropertyName = "MAXTABLE";
                        MinTable.DataPropertyName = "MINMONEY";
                        Note.DataPropertyName = "NOTE";



                        bool selectColumnExists = false;
                      
                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                if (column.Name == "Select")
                                {
                                    selectColumnExists = true;
                                    break;
                                }
                            }

                            if (!selectColumnExists)
                            {
                                DataGridViewCheckBoxColumn selectColumn = new DataGridViewCheckBoxColumn();
                                selectColumn.HeaderText = "Select";
                                selectColumn.Name = "Select";
                                selectColumn.DataPropertyName = "SELECT"; 
                                selectColumn.ReadOnly = false;
                                dataGridView1.Columns.Add(selectColumn);
                                Confirm.Size = new System.Drawing.Size(180, 40);
                            }
                      
                        SelectRowById();
                        dataGridView1.DataSource = table;
                    }
                }
            }
            else {
           

            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(query, connection);

                // Create a DataTable to store the data
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();

                    adapter.Fill(dataTable);

                    // Close the connection
                    connection.Close();


                   
                    VenueId.DataPropertyName = "ID";
                    Image.DataPropertyName = "PICTURE";
                    VenueName.DataPropertyName = "TENSANH";
                    VenueType.DataPropertyName = "LOAISANH";
                    MaxTable.DataPropertyName = "MAXTABLE";
                    MinTable.DataPropertyName = "MINMONEY";
                    Note.DataPropertyName = "NOTE";

                        dataGridView1.DataSource = dataTable;
                    }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading data into the DataGridView: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            }
            if (Image != null)
            {
                Image.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
        }

        private void SelectRowById()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int rowId;
                if (int.TryParse(row.Cells["ID"].Value.ToString(), out rowId))
                {
                    // Kiểm tra xem ID của hàng có trùng với ID đã chọn hay không
                    if (rowId == VenueSelectedId)
                    {
                        // Lấy ô checkbox từ cột "SELECT"
                        DataGridViewCheckBoxCell checkBoxCell = row.Cells["SELECT"] as DataGridViewCheckBoxCell;
                        if (checkBoxCell != null)
                        {
                            // Thiết lập giá trị của ô checkbox thành true
                            checkBoxCell.Value = true;
                        }

                        // Thoát khỏi vòng lặp sau khi tìm thấy và thiết lập giá trị
                        return;
                    }
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
            Int32 selectedCellCount = dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
            if (    selectedCellCount > 0)
            {
                int currentIndex = dataGridView1.CurrentCell.RowIndex;

                int ID = Convert.ToInt32(dataGridView1.Rows[currentIndex].Cells["VenueId"].Value);

                string storedProcedureName = "CheckAndUpdateSanhStatus"; 

                using (SqlConnection connection = new SqlConnection(conString))
                {
                    using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure; 

                        command.Parameters.AddWithValue("@IDSanh", ID); 

                        try
                        {
                            connection.Open();

                            command.ExecuteNonQuery();

                            MessageBox.Show("Record updated/deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadDataIntoDataGridView();
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

 
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow && row.Cells["VenueId"].Value != null)
                    {
                        string IDChange = Convert.ToString(row.Cells["VenueId"].Value);
                        string VenueNameChange = Convert.ToString(row.Cells["VenueName"].Value);
                        string VenueTypeChange = Convert.ToString(row.Cells["VenueType"].Value);
                        string VenueStateChange = Convert.ToString(row.Cells["VenueState"].Value);
                        string MaxTableChange = Convert.ToString(row.Cells["MaxTable"].Value);
                        string MinTableChange = Convert.ToString(row.Cells["MinTable"].Value);
                        string NoteChange = Convert.ToString(row.Cells["Note"].Value);
                        byte[] imageData = null; 
                        object cellValue = row.Cells["image"].Value;
                        string updateStr = "UPDATE SANHINFOR SET TENSANH = @VenueName, LOAISANH = @VenueType, TRANGTHAISANH = @VenueState, MaxTable = @MaxTable, MinMoney = @MinTable, Note = @Note, PICTURE = @ImageData WHERE ID = @ID";



                        if (cellValue != DBNull.Value)
                        {
                            imageData = (byte[])cellValue;
                             updateStr = "UPDATE SANHINFOR SET TENSANH = @VenueName, LOAISANH = @VenueType, TRANGTHAISANH = @VenueState, MaxTable = @MaxTable, MinMoney = @MinTable, Note = @Note, PICTURE = @ImageData WHERE ID = @ID";

                        }
                        else
                        {
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
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                int currentRowIndex = e.RowIndex;
                if (currentRowIndex >= 0 && currentRowIndex < dataGridView1.Rows.Count)
                {
                    DataGridViewCell selectedCell = dataGridView1.Rows[currentRowIndex].Cells["SELECT"];

                    if (selectedCell != null)
                    {
                        selectedCell.Value = true;

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

        public event ConfirmEventHandler ConfirmEvent; 

        private void Confirm_Click(object sender, EventArgs e)
        {
           
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells["SELECT"].Value))
                {
                    int.TryParse(row.Cells["VenueId"].Value.ToString(), out VenueSelectedId); 
                }
            }

            ConfirmEvent?.Invoke(VenueSelectedId);

            this.Close();
        }
    }
}

