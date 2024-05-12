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

namespace WeedingPartyBooking
{
    public partial class LapBaoCaoThang : Form
    {
        string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=DATTIECUOI;Integrated Security=True";
        public LapBaoCaoThang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LapBaoCao LapBaoCao = new LapBaoCao();
            LapBaoCao.Show();
        }

        private void LapBaoCaoThang_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT NGAYLAP, SOLUONGTIEC, TENNGUOILAP, DOANHTHU, TILE FROM BAOCAO", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 112;   
            dataGridView1.Columns[1].HeaderText = "Ngày Lập Báo Cáo";
            dataGridView1.Columns[1].Width = 135;
            dataGridView1.Columns[2].HeaderText = "Số Lượng Tiệc Cưới";
            dataGridView1.Columns[2].Width = 155;
            dataGridView1.Columns[3].HeaderText = "Tên Người Lập";
            dataGridView1.Columns[3].Width = 165;
            dataGridView1.Columns[4].HeaderText = "Doanh Thu";
            dataGridView1.Columns[4].Width = 140;
            dataGridView1.Columns[5].HeaderText = "Tỉ Lệ";
            dataGridView1.Columns[5].Width = 130;
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridView1.Rows[e.RowIndex].Cells["stt"].Value = (e.RowIndex + 1).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TongDoanhThu tongDoanhThu = new TongDoanhThu();
            tongDoanhThu.Show();
        }
    }
}
