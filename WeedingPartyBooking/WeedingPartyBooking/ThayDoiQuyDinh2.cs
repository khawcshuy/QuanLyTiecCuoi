using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeedingPartyBooking
{
    public partial class ThayDoiQuyDinh2 : Form
    {
        public ThayDoiQuyDinh2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MonAn monAn = new MonAn();
            monAn.button1.Visible = false;
            monAn.dataGridView1.ReadOnly = false;
            monAn.button2.Visible = true;
            monAn.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DichVu dichVu = new DichVu();
            dichVu.button1.Visible = false;
            dichVu.dataGridView1.ReadOnly = false;
            dichVu.button2.Visible = true;
            dichVu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
