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
    public partial class MainProgram : Form
    {
        public MainProgram()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TraCuu traCuuForm = new TraCuu();
            traCuuForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 datTiec = new Form1();
            datTiec.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LapBaoCaoThang lapBaoCao = new LapBaoCaoThang();
            lapBaoCao.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ThayDoiQuyDinh thayDoiQuyDinh = new ThayDoiQuyDinh();
            thayDoiQuyDinh.Show();
        }
    }
}
