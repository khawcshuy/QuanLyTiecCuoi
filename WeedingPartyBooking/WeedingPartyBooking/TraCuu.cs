using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WeedingPartyBooking
{
    public partial class TraCuu : Form
    {
        public TraCuu()
        {
            InitializeComponent();
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            DataGridViewTextBoxColumn caColumn = new DataGridViewTextBoxColumn();
        }

        private void TraCuu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dATTIECUOIDataSet.THONGTINKHACHHANG' table. You can move, or remove it, as needed.
            this.tHONGTINKHACHHANGTableAdapter.Fill(this.dATTIECUOIDataSet.THONGTINKHACHHANG);

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Giờ")
            {
                DataGridViewCell caCell = dataGridView1.Rows[e.RowIndex].Cells["Ca"];
                if (caCell.Value != null)
                {
                    string caValue = caCell.Value.ToString();
                    if (caValue == "Trưa")
                    {
                        e.Value = "11:30";
                    }
                    else if (caValue == "Tối")
                    {
                        e.Value = "18:30";
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string soDienThoai = textBox1.Text;
            this.tHONGTINKHACHHANGTableAdapter.FillBySoDienThoai(this.dATTIECUOIDataSet.THONGTINKHACHHANG, soDienThoai);
            if (this.dATTIECUOIDataSet.THONGTINKHACHHANG.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy thông tin khách hàng");
                this.tHONGTINKHACHHANGTableAdapter.Fill(this.dATTIECUOIDataSet.THONGTINKHACHHANG);
            }
        }

        private void fillBySoDienThoaiToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tHONGTINKHACHHANGTableAdapter.FillBySoDienThoai(this.dATTIECUOIDataSet.THONGTINKHACHHANG, dIENTHOAIToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
