using QuanLyTiecCuoi.SERVICE;
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

        private Booking _parentForm;
        public string _conString;


        public Food(string conString, Booking parentForm = null)
        {
            InitializeComponent(); 

           
            _parentForm = parentForm;
            _conString = conString; 
        }


        public List<string> SelectedFoods;
      
        public bool isChoosing = false;

        private bool ChangingState = false;

        private bool isEditing = false;




        private void SelectedFood()
        {
            if (SelectedFoods != null)
            {
                foreach (string indexString in SelectedFoods)
                {
                    if (int.TryParse(indexString, out int rowIndex))
                    {
                        // Check if rowIndex is within the valid range of rows in the DataGridView
                        if (rowIndex >= 0 && rowIndex < dataGridViewFood.Rows.Count)
                        {
                            // Check if the "SELECT" column exists
                            if (dataGridViewFood.Columns.Contains("SELECT"))
                            {
                                DataGridViewCell selectedCell = dataGridViewFood.Rows[rowIndex].Cells["SELECT"];

                                if (selectedCell != null)
                                {
                                    if (selectedCell.Value != null && (bool)selectedCell.Value)
                                    {
                                        selectedCell.Value = false;
                                    }
                                    else
                                    {
                                        selectedCell.Value = true;
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("The column 'SELECT' does not exist.");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Row index {rowIndex} is out of range.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Failed to convert '{indexString}' to an integer.");
                    }
                }
            }
        }

        private void Food_Load(object sender, EventArgs e)
        {
            LoadDataGridViewFood();
        }


        public void LoadDataGridViewFood()
        {
            String query = "SELECT ID,Picture,DONGIA,NOTE TENMONAN FROM FOOD where TRANGTHAIMONAN = 1";

            using (SqlConnection connection = new SqlConnection(_conString))
            {
                // Create a NpgsqlDataAdapter and SelectCommand
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(query, connection);

                connection.Open();
                bool selectColumnExists = false;
                if (_parentForm != null)
                {
                    foreach (DataGridViewColumn column in dataGridViewFood.Columns)
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
                        dataGridViewFood.Columns.Add(selectColumn);
                        Confirm.Size = new System.Drawing.Size(180, 40);
                    }
                }

                FoodId.DataPropertyName = "ID";
                PictureFood.DataPropertyName = "Picture";
                FoodName.DataPropertyName = "TENMONAN";
                FoodPrice.DataPropertyName = "DONGIA";
                FoodNote.DataPropertyName = "NOTE";

                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                connection.Close();

                DataGridViewImageColumn imageColumn = dataGridViewFood.Columns["PictureFood"] as DataGridViewImageColumn;

                if (imageColumn != null)
                {
                    imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                }

                dataGridViewFood.DataSource = dataTable;
                if (_parentForm != null)
                {
                    SelectedFood();
                }
            }
        }



        private void SearchFood_TextChanged(object sender, EventArgs e)
        {
            string searchText = SearchFood.Text.Trim();

            string query = "SELECT * FROM FOOD WHERE [ID] LIKE '%' + @searchText + '%' OR [TENMONAN] LIKE '%' + @searchText + '%' OR [DONGIA] LIKE '%' + @searchText + '%' OR [NOTE] LIKE '%' + @searchText";

            using (SqlConnection connection = new SqlConnection(_conString))
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
            using (SqlConnection connection = new SqlConnection(_conString))
            {
                connection.Open();

                foreach (DataGridViewRow row in dataGridViewFood.Rows)
                {
                    if (!row.IsNewRow && row.Cells["FoodId"].Value != null)
                    {
                        int IDChange = Convert.ToInt32(row.Cells["FoodId"].Value);
                        string FoodNameChange = Convert.ToString(row.Cells["FoodName"].Value);
                        string FoodPriceChange = Convert.ToString(row.Cells["FoodPrice"].Value);
                        string NoteChange = Convert.ToString(row.Cells["FoodNote"].Value);
                        string updateStr = "UPDATE FOOD SET TENMONAN = @FoodNameChange, DONGIA = @FoodPriceChange, Note = @Note, Picture = @image WHERE ID = @ID";
                        byte[] imageData = null; 
                        object cellValue = row.Cells["PictureFood"].Value; 

                        if (cellValue != DBNull.Value)
                        {
       
                            imageData = (byte[])cellValue;
                            updateStr = "UPDATE FOOD SET TENMONAN = @FoodNameChange, DONGIA = @FoodPriceChange, Note = @Note, Picture = @image WHERE ID = @ID";
                        }
                        else
                        {
                            // If the value is DBNull, use an empty byte array
                            imageData = new byte[0];
                            updateStr = "UPDATE FOOD SET TENMONAN = @FoodNameChange, DONGIA = @FoodPriceChange, Note = @Note WHERE ID = @ID";
                        }



                        using (SqlCommand updateCmd = new SqlCommand(updateStr, connection))
                        {
                            updateCmd.Parameters.AddWithValue("@ID", IDChange);
                            updateCmd.Parameters.AddWithValue("@FoodNameChange", FoodNameChange);
                            updateCmd.Parameters.AddWithValue("@FoodPriceChange", FoodPriceChange);
                             updateCmd.Parameters.AddWithValue("@image", imageData);
                            updateCmd.Parameters.AddWithValue("@Note", NoteChange);

                           
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
            }
            if (!ChangingState)
            {
                MessageBox.Show("All records updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ChangingState = false;
            }
            LoadDataGridViewFood();

            dataGridView1.ReadOnly = false;
            ChangeVenue.Text = "Chỉnh sửa";
            isEditing = false;
        }


       
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
            Int32 selectedCellCount = dataGridViewFood.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {
                int currentIndex = dataGridViewFood.CurrentCell.RowIndex;

                int ID = Convert.ToInt32(dataGridViewFood.Rows[currentIndex].Cells["FoodId"].Value);

                string storedProcedureName = "CheckAndUpdateFoodStatus";

                using (SqlConnection connection = new SqlConnection(_conString))
                {
                    using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@IDfood", ID);

                        try
                        {
                            connection.Open();

                            command.ExecuteNonQuery();

                            MessageBox.Show("Record updated/deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadDataGridViewFood();
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

        public string imglocation = "";


        private void dataGridViewFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isEditing && dataGridViewFood.Columns[e.ColumnIndex].Name == "PictureFood" && e.RowIndex != -1)
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.gif;*.png)|*.BMP;*.JPG;*.JPEG;*.GIF;*.PNG";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = dialog.FileName;
                    byte[] imageData = File.ReadAllBytes(imagePath);
                    dataGridViewFood.Rows[e.RowIndex].Cells["PictureFood"].Value = imageData;
                }
            }
                
            if(isChoosing)
            { 
                dataGridViewFood.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                int currentRowIndex = e.RowIndex;
                if (currentRowIndex >= 0 && currentRowIndex < dataGridViewFood.Rows.Count)
                {
                    DataGridViewCell selectedCell = dataGridViewFood.Rows[currentRowIndex].Cells["SELECT"];

                    // Check if the cell is not null
                    if (selectedCell != null)
                    {
                        // Check if the value of the cell is true
                        if (selectedCell.Value != null && (bool)selectedCell.Value)
                        {
                            // If it's true, set it to false
                            selectedCell.Value = false;
                        }
                        else
                        {
                            // If it's false or null, set it to true
                            selectedCell.Value = true;
                        }
                    }
                }
              
            }
        }

        private void AddFood_Click(object sender, EventArgs e)
        {
            // Corrected variable name to insertVenueForm
            InsertFood insertFoodForm = new InsertFood(this, _conString);
            insertFoodForm.ShowDialog();
        }

        public delegate void ConfirmEventHandler(List<string> selectedFoods);

        // Define an event based on the delegate
        public event ConfirmEventHandler ConfirmEvent;



        private void Confirm_Click_1(object sender, EventArgs e)
        {

            SelectedFoods = new List<string>();
            // Iterate through the DataGridView to collect selected food IDs
            foreach (DataGridViewRow row in dataGridViewFood.Rows)
            {
                if (Convert.ToBoolean(row.Cells["SELECT"].Value))
                {
                    string foodID = row.Cells["FoodId"].Value.ToString(); // Assuming the ID column name is "ID"
                    SelectedFoods.Add(foodID);
                }
            }

            // Raise the event and pass the list
            ConfirmEvent?.Invoke(SelectedFoods);

            // Close the Food form
            this.Close();
        }
    }
}
