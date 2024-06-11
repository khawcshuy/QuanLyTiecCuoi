using FontAwesome.Sharp;
using QuanLyTiecCuoi.DESIGN;
using QuanLyTiecCuoi.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        public string constring;
        public fLogin(string _conString)
        {
            InitializeComponent();
            this.constring = _conString;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (MainClass.IsValidUser(txbUserName.Text, txbPassWord.Text) == false) 
            {
                label1.Visible = true;
                pictureBox4.Visible = true;
                txbUserName.ForeColor = Color.Red;
                txbPassWord.ForeColor = Color.Red;
            }
            else 
            {
                if (txbUserName.Text == "admin")
                {
                    AdminMainForm mainApp = new AdminMainForm(constring);
                    this.Hide();
                    mainApp.FormClosed += MainForm_FormClosed;
                    mainApp.Show();
                }
                else
                {
                    NVMainForm mainApp = new NVMainForm(constring);
                    this.Hide();
                    mainApp.FormClosed += MainForm_FormClosed;
                    mainApp.Show();
                }
            }

        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Close the login form when MainForm is closed
            this.Close();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(RJMessageBox.Show("Bạn có muốn thoát khỏi chương trình?", "Exit Message", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
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
            txbUserName.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            txbUserName.BackColor = Color.White;
            panel2.BackColor = Color.White;
            panel3.BackColor = System.Drawing.SystemColors.Control;
            txbPassWord.BackColor = System.Drawing.SystemColors.Control;
        }

        private void txbPassWord_Click(object sender, EventArgs e)
        {
            txbPassWord.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
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

        private void Register_Click(object sender, EventArgs e)
        {
            Register registerform = new Register(constring);
            registerform.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
