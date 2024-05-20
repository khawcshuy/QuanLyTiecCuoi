using QuanLyTiecCuoi.DESIGN;
using QuanLyTiecCuoi.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace QuanLyTiecCuoi
{
    public partial class fLogin : Form
    {
        private string constring;
        public fLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (MainClass.IsValidUser(txbUserName.Text, txbPassWord.Text) == false) {
                System.Windows.Forms.MessageBox.Show("Bạn có thật sự muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.OK);
            }
            else {
                MainForm mainApp = new MainForm(constring);
                this.Hide();
                mainApp.ShowDialog();
                this.Show();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            RJMessageBox.Show("Bạn có muốn thoát khỏi chương trình?", "Exit Message", MessageBoxButtons.OKCancel);
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(RJMessageBox.Show("This is an example of an OK, Cancel Button Message Box.", "OK-Cancel Button", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
            
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txbUserName_Click(object sender, EventArgs e)
        {
            txbUserName.BackColor = Color.White;
            panel2.BackColor = Color.White;
            panel3.BackColor = System.Drawing.SystemColors.Control;
            txbPassWord.BackColor = System.Drawing.SystemColors.Control;
        }

        private void txbPassWord_Click(object sender, EventArgs e)
        {
            txbPassWord.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel2.BackColor = System.Drawing.SystemColors.Control;
            txbUserName.BackColor = System.Drawing.SystemColors.Control;
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            txbPassWord.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            txbPassWord.UseSystemPasswordChar = true;
        }
    }
}
