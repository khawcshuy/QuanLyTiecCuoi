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
using QuanLyTiecCuoi.Service;


namespace QuanLyTiecCuoi.Service
{
    public partial class Service : Form
    {
        private Booking _parentForm;

        public Service(Booking parentForm = null)
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




        public List<string> SelectedService;

        public bool isChoosing = false;

        private bool ChangingState = false;

        private bool isEditing = false;
        //private string conString = @"Data Source=DESKTOP-M4GHD5G\LUCY;Initial Catalog=QUANLYTIECCUOI;Persist Security Info=True;User ID=sa;Password=140403";

        private string conString = @"Data Source = ADMINISTRATOR; Initial Catalog = QUANLYTIECCUOI; Integrated Security = True";
        private void Service_Load(object sender, EventArgs e)
        {
            LoadDataGridViewService();
        }


        public void LoadDataGridViewService()
        {
            String query = "SELECT * FROM DICHVU"; 

            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(query, connection);

                connection.Open();
                ServiceId.DataPropertyName = "ID";
                ServiceName.DataPropertyName = "TENDICHVU"; 
                ServicePrice.DataPropertyName = "GIADICHVU"; 
                ServiceType.DataPropertyName = "LOAIDICHVU";
                ServiceNote.DataPropertyName = "NOTE";

                DataTable dataTable = new DataTable();
                bool selectColumnExists = false;
                if (isChoosing)
                {
                    foreach (DataGridViewColumn column in dataGridViewService.Columns)
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
                        selectColumn.DataPropertyName = "SELECT"; // Replace "SELECT" with the actual column name in your database
                        selectColumn.ReadOnly = false; // Allow selection
                        dataGridViewService.Columns.Add(selectColumn);
                        Confirm.Size = new System.Drawing.Size(180, 40);
                    }
                }
                adapter.Fill(dataTable);
                if (SelectedService != null)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        if (SelectedService.Contains(row["ServiceId"].ToString()))
                        {
                            row["select"] = true;
                        }
                    }
                }
                connection.Close();


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



        public delegate void ConfirmEventHandler(List<string> SelectedService);

        // Define an event based on the delegate
        public event ConfirmEventHandler ConfirmEvent;


        private void Confirm_Click(object sender, EventArgs e)
        {
            SelectedService = new List<string>();
            // Iterate through the DataGridView to collect selected food IDs
            foreach (DataGridViewRow row in dataGridViewService.Rows)
            {
                if (Convert.ToBoolean(row.Cells["SELECT"].Value))
                {
                    string ServiceID = row.Cells["ServiceId"].Value.ToString(); // Assuming the ID column name is "ID"
                    SelectedService.Add(ServiceID);
                }
            }

            // Raise the event and pass the list
            ConfirmEvent?.Invoke(SelectedService);

            // Close the Food form
            this.Close();
        }

        private void dataGridViewService_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            if (isChoosing)
            {
                dataGridViewService.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                int currentRowIndex = e.RowIndex;
                if (currentRowIndex >= 0 && currentRowIndex < dataGridViewService.Rows.Count)
                {
                    DataGridViewCell selectedCell = dataGridViewService.Rows[currentRowIndex].Cells["SELECT"];

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
            }
        }
    }
}
