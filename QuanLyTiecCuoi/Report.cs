using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiecCuoi
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void listView1_load(object sender, EventArgs e)
        {
            LsParty.Columns[0].Width = (int) (LsParty.Width * 0.2);
            LsParty.Columns[1].Width = (int)(LsParty.Width * 0.2);
            LsParty.Columns[2].Width = (int)(LsParty.Width * 0.2);
            LsParty.Columns[3].Width = (int)(LsParty.Width * 0.2);
            LsParty.Columns[4].Width = (int)(LsParty.Width * 0.2);
            LsParty.View = View.Details;
            LsParty.GridLines = true;
            LsParty.FullRowSelect = true;
        }
    }
}
