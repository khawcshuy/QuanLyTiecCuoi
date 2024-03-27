using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Đặt_Tiệc_Cưới
{
    public partial class TiepNhanTiecCuoi : Form
    {
        public KiemTraThongTin kttt;
        public TiepNhanTiecCuoi()
        {
            InitializeComponent();
            kttt = new KiemTraThongTin();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.luuTruThongTin);

        }

        private void TiepNhanTiecCuoi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'luuTruThongTin.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.luuTruThongTin.Table);

        }

        private void tenChuReLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kttt.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tenChuRe = tenChuReTextBox.Text;
            string tenCoDau = tenCoDauTextBox.Text;
            string dienThoai = dienThoaiTextBox.Text;
            DateTime ngayDaiTiec = ngayDaiTiecDateTimePicker.Value;
            string ca = comboBox1.SelectedItem.ToString();
            string sanh = comboBox2.SelectedItem.ToString();
            long soLuongBan = long.Parse(soLuongBanTextBox.Text);
            int banDuTru = int.Parse(soBanDuTruTextBox.Text);
            decimal tienCoc = decimal.Parse(tienDatCocTextBox.Text);
            kttt.InsertDataIntoDatabase(tenChuRe, tenCoDau, dienThoai, ngayDaiTiec, ca, sanh, soLuongBan, banDuTru, tienCoc);
        }
    }
}
