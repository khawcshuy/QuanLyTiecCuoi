using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using QuanLyTiecCuoi.Service;
using QuanLyTiecCuoi.SERVICE;

namespace QuanLyTiecCuoi.DESIGN
{
    public partial class AdminMainForm : Form
    {
        public string conString;
        //Fields
        private IconButton currentButton;
        private Panel leftBorderButton;
        private Form currentChildForm;
        private Random random;
        private int tempIndex;
        //OtherFields
        private int borderSize = 2;
        private Size formSize;
        private bool IsCollapse = false;
        //Constructor
        public AdminMainForm(string _conString)
        {
            InitializeComponent();
            CollapseMenu();
            random = new Random();
            leftBorderButton = new Panel();
            leftBorderButton.Size = new Size(7, 70);
            panelMenu.Controls.Add(leftBorderButton);
            this.conString = _conString;
            this.Padding = new Padding(borderSize); //Border Size
            this.BackColor = Color.FromArgb(98, 102, 244); //Border Color
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //Methods

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                if (currentButton != (IconButton)senderBtn)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (IconButton)senderBtn;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.TextAlign = ContentAlignment.MiddleCenter;
                    currentButton.IconColor = color;
                    currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                    if (IsCollapse == true)
                    {
                        currentButton.ImageAlign = ContentAlignment.MiddleCenter;
                    }
                    else
                    {
                        currentButton.ImageAlign = ContentAlignment.MiddleLeft;
                    }
                    currentButton.IconColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    panelTitleBar.BackColor = color;
                    btnClose.BackColor = color;
                    btnMaximize.BackColor = color;
                    btnMinimize.BackColor = color;
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }

        }

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(180, 127, 122);
            public static Color color5 = Color.FromArgb(249, 108, 155);
            public static Color color6 = Color.FromArgb(100, 161, 251);
            public static Color color7 = Color.FromArgb(41, 28, 185);
        }

        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(98, 102, 244);
                currentButton.ForeColor = Color.Gainsboro;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.IconColor = Color.Gainsboro;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                if (IsCollapse == true)
                {
                    currentButton.ImageAlign = ContentAlignment.MiddleCenter;
                }
                else
                {
                    currentButton.ImageAlign = ContentAlignment.MiddleLeft;
                }
            }

        }
        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }



        private void iconButtonDashBoard_Click(object sender, EventArgs e)
        {
            Form ReportForm = new Report(conString);
            ReportForm.Text = "DASHBOARD";
            OpenChildForm(ReportForm, sender);
        }


        private void iconButtonMenu_Click_1(object sender, EventArgs e)
        {
            Form MenuForm = new Food(conString);
            MenuForm.Text = "MENU";
            OpenChildForm(MenuForm, sender);
        }

        private void iconButtonService_Click_1(object sender, EventArgs e)
        {
            Form ServiceForm = new myService(conString);
            ServiceForm.Text = "SERVICE";
            OpenChildForm(ServiceForm, sender);
        }

        private void iconButtonVenue_Click_1(object sender, EventArgs e)
        {
            Form VenueForm = new Venue(null, conString);
            VenueForm.Text = "VENUE";
            OpenChildForm(VenueForm, sender);
        }

        private void iconButtonBooking_Click_1(object sender, EventArgs e)
        {
            Form bookingForm = new Booking(conString);
            bookingForm.Text = "BOOKING";
            OpenChildForm(bookingForm, sender);
        }
        private void ButtonHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderButton.Visible = false;
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            ActivateButton(btnSender);
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void iconButtonVenueState_Click_1(object sender, EventArgs e)
        {
            Form trangThaiSanhForm = new TrangThaiSanh(conString);
            trangThaiSanhForm.Text = "STATE";
            OpenChildForm(trangThaiSanhForm, sender);
        }
        private void NavigationList_Click_1(object sender, EventArgs e)
        {
            Form traCuuForm = new TraCuu(conString);
            traCuuForm.Text = "SEARCH";
            OpenChildForm(traCuuForm, sender);
        }

        private void BtnCustomer_Click(object sender, EventArgs e)
        {
            Form nhanVienForm = new NhanVien(conString);
            nhanVienForm.Text = "EMPLOYEE";
            OpenChildForm(nhanVienForm, sender);
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Overridden methods
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020;
            const int SC_RESTORE = 0xF120;
            const int WM_NCHITTEST = 0x0084;
            const int resizeAreaSize = 10;
            #region Form Resize
            const int HTCLIENT = 1;
            const int HTLEFT = 10;
            const int HTRIGHT = 11;
            const int HTTOP = 12;
            const int HTTOPLEFT = 13;
            const int HTTOPRIGHT = 14;
            const int HTBOTTOM = 15;
            const int HTBOTTOMLEFT = 16;
            const int HTBOTTOMRIGHT = 17;
            if (m.Msg == WM_NCHITTEST)
            {
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)
                {
                    if ((int)m.Result == HTCLIENT)
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize)
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            if (m.Msg == WM_SYSCOMMAND)
            {
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }

        //Event methods
        private void MainForm_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        //Private methods
        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized: //Maximized form (After)
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal: //Restored form (After)
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            formSize = this.ClientSize;
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                formSize = this.ClientSize;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = formSize;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void CollapseMenu()
        {
            if (this.panelMenu.Width > 200) //Collapse menu
            {
                panelMenu.Width = 100;
                pictureBoxLogo.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
                IsCollapse = true;
            }
            else
            { //Expand menu
                panelMenu.Width = 230;
                pictureBoxLogo.Visible = true;
                btnMenu.Dock = DockStyle.None;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
                IsCollapse = false;
            }
        }

        private void RestoreMainForm()
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                Form openForm = Application.OpenForms[i];

                // Use the != operator and the is keyword separately
                if (!(openForm is AdminMainForm))
                {
                    openForm.Close();
                }
            }
            DisableButton();
            leftBorderButton.Visible = false;
            currentButton = null;
            lblTitle.Text = "DASHBOARD";
            panelTitleBar.BackColor = Color.FromArgb(98, 102, 244);
            btnMinimize.BackColor = Color.FromArgb(98, 102, 244);
            btnMaximize.BackColor = Color.FromArgb(98, 102, 244);
            btnClose.BackColor = Color.FromArgb(98, 102, 244);
        }
       
        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            RestoreMainForm();
        }

        private void iconSignOut_Click(object sender, EventArgs e)
        {
            fLogin login = new fLogin(conString);
            login.Show();
            this.Hide();
            login.FormClosed += (s, args) => this.Close();
        }

       
    }
}
