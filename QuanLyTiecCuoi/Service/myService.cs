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
using Microsoft.IdentityModel.Tokens;
using QuanLyTiecCuoi.Service;


namespace QuanLyTiecCuoi.Service
{
    public partial class myService : Form
    {
        private Form _parentForm;
        public string conString;
        private Rectangle btnAddOriginalRect;
        private Rectangle btnEditOriginalRect;
        private Rectangle btnDeleteOriginalRect;
        private Rectangle searchServicenameOriginalRect;
        private Rectangle datagridviewServiceOriginalRect;
        private Rectangle panel2OriginalRect;
        private Size originalFormSize;
        public bool isBookingForm = false;
        public myService(string _conString, Form parentForm = null)
        {
            InitializeComponent();

            conString = _conString;
            _parentForm = parentForm;
        }


        public List<string> SelectedService { get; set; }



        private bool isEditing = false;
       // private Booking booking;

        //private string conString = @"Data Source=DESKTOP-M4GHD5G\LUCY;Initial Catalog=QUANLYTIECCUOI;Persist Security Info=True;User ID=sa;Password=140403";

        //private string conString = @"Data Source = ADMINISTRATOR; Initial Catalog = QUANLYTIECCUOI; Integrated Security = True";


        private void Service_Load(object sender, EventArgs e)
        {
           
            LoadDataGridViewService();
            originalFormSize = this.Size;
            btnAddOriginalRect = new Rectangle(btnAdd.Location, btnAdd.Size);
            btnEditOriginalRect = new Rectangle(btnEdit.Location, btnEdit.Size);
            btnDeleteOriginalRect = new Rectangle(btnDelete.Location, btnDelete.Size);
            searchServicenameOriginalRect = new Rectangle(searchServicename.Location, searchServicename.Size);
            datagridviewServiceOriginalRect = new Rectangle(dataGridViewService.Location, dataGridViewService.Size);
            panel2OriginalRect = new Rectangle(panel2.Location, panel2.Size);
        }


        public void LoadDataGridViewService()
        {
            
            String query = "SELECT * FROM DICHVU WHERE TRANGTHAIDICHVU = 1"; 

            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(query, connection);

                connection.Open();
                ServiceId.DataPropertyName = "ID";
                ServiceName.DataPropertyName = "TENDICHVU"; 
                ServicePrice.DataPropertyName = "GIADICHVU"; 
                ServiceType.DataPropertyName = "LOAIDICHVU";
                DataTable dataTable = new DataTable();
               
                bool selectColumnExists = false;
                Confirm.Visible = false;
                connection.Close();
                dataGridViewService.DataSource = dataTable;
                if (_parentForm != null && isBookingForm)
                {
                    Confirm.Visible = true;
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
                        selectColumn.DataPropertyName = "Select"; // Replace "SELECT" with the actual column name in your database
                        selectColumn.ReadOnly = false; // Allow selection
                        dataGridViewService.Columns.Add(selectColumn);
                      
                    }



                }
                adapter.Fill(dataTable);
                if (SelectedService != null && isBookingForm )
                {
                    foreach (DataGridViewRow dataGridViewRow in dataGridViewService.Rows)
                    {
                        string id = dataGridViewRow.Cells["ServiceId"].Value.ToString();

                        if (SelectedService.Contains(id))
                        {
                            dataGridViewRow.Cells["Select"].Value = true;
                        }
                    }

                }




                if (dataGridViewService.Columns["TrangThaiDichVu"] != null)
                {
                    dataGridViewService.Columns["TrangThaiDichVu"].Visible = false;
                }
                if (dataGridViewService.Columns["ServiceId"] != null)
                {
                    dataGridViewService.Columns["ServiceId"].Width = 100; // Set width as per your requirement
                }
                if (dataGridViewService.Columns["ServiceName"] != null)
                {
                    dataGridViewService.Columns["ServiceName"].Width = 225; // Set width as per your requirement
                }
                if (dataGridViewService.Columns["ServiceType"] != null)
                {
                    dataGridViewService.Columns["ServiceType"].Width = 175; // Set width as per your requirement
                }
                if (dataGridViewService.Columns["ServicePrice"] != null)
                {
                    dataGridViewService.Columns["ServicePrice"].Width = 150; // Set width as per your requirement
                }
                if (dataGridViewService.Columns["Picture"] != null)
                {
                    dataGridViewService.Columns["Picture"].HeaderText = "Picture";
                    dataGridViewService.Columns["Picture"].Width = 172;
                }
            }
           
        }


        private void SaveChangesToDatabase()
        {
            int currentIndex = dataGridViewService.CurrentCell.RowIndex;
            string IDChange = Convert.ToString(dataGridViewService.Rows[currentIndex].Cells["ServiceId"].Value);
            string ServiceNameChange = Convert.ToString(dataGridViewService.Rows[currentIndex].Cells["ServiceName"].Value);
            string ServicePriceChange = Convert.ToString(dataGridViewService.Rows[currentIndex].Cells["ServicePrice"].Value);
            string ServiceTypeChange = Convert.ToString(dataGridViewService.Rows[currentIndex].Cells["ServiceType"].Value);

            if (string.IsNullOrEmpty(IDChange) && string.IsNullOrEmpty(ServiceNameChange) && string.IsNullOrEmpty(ServicePriceChange) && string.IsNullOrEmpty(ServiceTypeChange))
            { return;
            }
            else
                using (SqlConnection connection = new SqlConnection(conString))
            {
                string updateStr = "UPDATE DICHVU SET TENDICHVU = @ServiceNameChange, GIADICHVU = @ServicePriceChange, LOAIDICHVU = @ServiceTypeChange WHERE ID = @ID"; // Thay đổi từ FOOD sang DICHVU, TENDICHVU, GIADICHVU, NOTE

                using (SqlCommand updateCmd = new SqlCommand(updateStr, connection))
                {
                    updateCmd.Parameters.AddWithValue("@ID", IDChange);
                    updateCmd.Parameters.AddWithValue("@ServiceNameChange", ServiceNameChange);
                    updateCmd.Parameters.AddWithValue("@ServicePriceChange", ServicePriceChange);
                    updateCmd.Parameters.AddWithValue("ServiceTypeChange", ServiceTypeChange);

                    try
                    {
                        connection.Open();

                        updateCmd.ExecuteNonQuery();

                        MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadDataGridViewService();

                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while updating the record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            dataGridViewService.ReadOnly = false;
            isEditing = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                dataGridViewService.ReadOnly = false;
                dataGridViewService.SelectionMode = DataGridViewSelectionMode.CellSelect;
                btnEdit.Text = "Lưu Chỉnh Sửa";
                isEditing = true;
            }
            else
            {
                btnEdit.Text = "Chỉnh Sửa";
                dataGridViewService.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                SaveChangesToDatabase();
            }
        }
  

        private void AddFood_Click(object sender, EventArgs e)
        {
            InsertService insertServiceForm = new InsertService(this);
            insertServiceForm.conString = conString;
            insertServiceForm.ShowDialog();
        }

        private void searchFoodname__TextChanged(object sender, EventArgs e)
        {
            string searchText = searchServicename.Texts.Trim();

            string query = "SELECT * FROM DICHVU WHERE [ID] LIKE '%' + @searchText + '%' OR [TENDICHVU] LIKE '%' + @searchText + '%' OR [GIADICHVU] LIKE '%' + @searchText + '%'"; // Thay đổi từ FOOD sang DICHVU, TENDICHVU, GIADICHVU

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

        public event ConfirmEventHandler ConfirmEvent;


        private void Confirm_Click(object sender, EventArgs e)
        {
            SelectedService = new List<string>();
            foreach (DataGridViewRow row in dataGridViewService.Rows)
            {
                if (Convert.ToBoolean(row.Cells["SELECT"].Value))
                {
                    string ServiceID = row.Cells["ServiceId"].Value.ToString(); 
                    SelectedService.Add(ServiceID);
                }
            }
            if (SelectedService.Count == 0)
            {
                MessageBox.Show("Please choose a service.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ConfirmEvent?.Invoke(SelectedService);

            this.Close();
        }

        private void dataGridViewService_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 
            if (_parentForm != null && isBookingForm)

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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            InsertService insertServiceForm = new InsertService(this);
            insertServiceForm.conString = conString;
            insertServiceForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 selectedCellCount = dataGridViewService.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {
                int currentIndex = dataGridViewService.CurrentCell.RowIndex;

                int ID = Convert.ToInt32(dataGridViewService.Rows[currentIndex].Cells["ServiceId"].Value);

                string storedProcedureName = "CheckAndUpdateServiceStatus";

                using (SqlConnection connection = new SqlConnection(conString))
                {
                    using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@IDDICHVU", ID);

                        try
                        {
                            connection.Open();

                            command.ExecuteNonQuery();

                            MessageBox.Show("Record updated/deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                           LoadDataGridViewService();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Int32 selectedCellCount = dataGridViewService.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {
                int currentIndex = dataGridViewService.CurrentCell.RowIndex;

                int ID = Convert.ToInt32(dataGridViewService.Rows[currentIndex].Cells["ServiceId"].Value);

                string storedProcedureName = "CheckAndUpdateServiceStatus";

                using (SqlConnection connection = new SqlConnection(conString))
                {
                    using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@IDDICHVU", ID);

                        try
                        {
                            connection.Open();

                            command.ExecuteNonQuery();

                            MessageBox.Show("Record updated/deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadDataGridViewService();
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

        private void myService_Resize(object sender, EventArgs e)
        {
            if (originalFormSize.Width == 0 || originalFormSize.Height == 0) return;
            float xRatio = (float)this.Width / originalFormSize.Width;
            float yRatio = (float)this.Height / originalFormSize.Height;
            ResizeControl(btnAddOriginalRect, btnAdd, xRatio, yRatio);
            ResizeControl(btnEditOriginalRect, btnEdit, xRatio, yRatio);
            ResizeControl(btnDeleteOriginalRect, btnDelete, xRatio, yRatio);
            ResizeControl(searchServicenameOriginalRect, searchServicename, xRatio, yRatio);
            ResizeControl(datagridviewServiceOriginalRect, dataGridViewService, xRatio, yRatio);
            ResizeControl(panel2OriginalRect, panel2, xRatio, yRatio);
        }

        private void ResizeControl(Rectangle originalRect, Control control, float xRatio, float yRatio)
        {
            int newX = (int)(originalRect.X * xRatio);
            int newY = (int)(originalRect.Y * yRatio);
            int newWidth = (int)(originalRect.Width * xRatio);
            int newHeight = (int)(originalRect.Height * yRatio);
            newX = Math.Max(newX, 0);
            newY = Math.Max(newY, 0);
            newWidth = Math.Max(newWidth, 10); // Minimum width
            newHeight = Math.Max(newHeight, 10); // Minimum height

            if (newX + newWidth > this.ClientSize.Width)
            {
                newWidth = this.ClientSize.Width - newX;
            }
            if (newY + newHeight > this.ClientSize.Height)
            {
                newHeight = this.ClientSize.Height - newY;
            }
            Console.WriteLine($"Resizing {control.Name}: New Location ({newX}, {newY}), New Size ({newWidth}, {newHeight})");
            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
