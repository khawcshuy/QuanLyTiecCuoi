namespace QuanLyTiecCuoi.DESIGN
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.iconButtonVenue = new FontAwesome.Sharp.IconButton();
            this.iconButtonService = new FontAwesome.Sharp.IconButton();
            this.iconButtonMenu = new FontAwesome.Sharp.IconButton();
            this.iconButtonBooking = new FontAwesome.Sharp.IconButton();
            this.iconButtonDashBoard = new FontAwesome.Sharp.IconButton();
            this.ButtonHome = new System.Windows.Forms.PictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonHome)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(45)))), ((int)(((byte)(93)))));
            this.panelMenu.Controls.Add(this.iconButtonVenue);
            this.panelMenu.Controls.Add(this.iconButtonService);
            this.panelMenu.Controls.Add(this.iconButtonMenu);
            this.panelMenu.Controls.Add(this.iconButtonBooking);
            this.panelMenu.Controls.Add(this.iconButtonDashBoard);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(240, 658);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.ButtonHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(240, 180);
            this.panelLogo.TabIndex = 1;
            // 
            // iconButtonVenue
            // 
            this.iconButtonVenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(45)))), ((int)(((byte)(93)))));
            this.iconButtonVenue.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonVenue.FlatAppearance.BorderSize = 0;
            this.iconButtonVenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonVenue.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.iconButtonVenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.iconButtonVenue.IconChar = FontAwesome.Sharp.IconChar.Church;
            this.iconButtonVenue.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.iconButtonVenue.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonVenue.IconSize = 32;
            this.iconButtonVenue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonVenue.Location = new System.Drawing.Point(0, 460);
            this.iconButtonVenue.Name = "iconButtonVenue";
            this.iconButtonVenue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconButtonVenue.Size = new System.Drawing.Size(240, 70);
            this.iconButtonVenue.TabIndex = 6;
            this.iconButtonVenue.Text = "Venue";
            this.iconButtonVenue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonVenue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonVenue.UseVisualStyleBackColor = false;
            this.iconButtonVenue.Click += new System.EventHandler(this.iconButtonVenue_Click);
            // 
            // iconButtonService
            // 
            this.iconButtonService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(45)))), ((int)(((byte)(93)))));
            this.iconButtonService.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonService.FlatAppearance.BorderSize = 0;
            this.iconButtonService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonService.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.iconButtonService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.iconButtonService.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.iconButtonService.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.iconButtonService.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonService.IconSize = 32;
            this.iconButtonService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonService.Location = new System.Drawing.Point(0, 390);
            this.iconButtonService.Name = "iconButtonService";
            this.iconButtonService.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconButtonService.Size = new System.Drawing.Size(240, 70);
            this.iconButtonService.TabIndex = 4;
            this.iconButtonService.Text = "Service";
            this.iconButtonService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonService.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonService.UseVisualStyleBackColor = false;
            this.iconButtonService.Click += new System.EventHandler(this.iconButtonService_Click);
            // 
            // iconButtonMenu
            // 
            this.iconButtonMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(45)))), ((int)(((byte)(93)))));
            this.iconButtonMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonMenu.FlatAppearance.BorderSize = 0;
            this.iconButtonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMenu.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.iconButtonMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.iconButtonMenu.IconChar = FontAwesome.Sharp.IconChar.ListUl;
            this.iconButtonMenu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.iconButtonMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonMenu.IconSize = 32;
            this.iconButtonMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMenu.Location = new System.Drawing.Point(0, 320);
            this.iconButtonMenu.Name = "iconButtonMenu";
            this.iconButtonMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconButtonMenu.Size = new System.Drawing.Size(240, 70);
            this.iconButtonMenu.TabIndex = 3;
            this.iconButtonMenu.Text = "Menu";
            this.iconButtonMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonMenu.UseVisualStyleBackColor = false;
            this.iconButtonMenu.Click += new System.EventHandler(this.iconButtonMenu_Click);
            // 
            // iconButtonBooking
            // 
            this.iconButtonBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(45)))), ((int)(((byte)(93)))));
            this.iconButtonBooking.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonBooking.FlatAppearance.BorderSize = 0;
            this.iconButtonBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonBooking.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.iconButtonBooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.iconButtonBooking.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iconButtonBooking.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.iconButtonBooking.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonBooking.IconSize = 32;
            this.iconButtonBooking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonBooking.Location = new System.Drawing.Point(0, 250);
            this.iconButtonBooking.Name = "iconButtonBooking";
            this.iconButtonBooking.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconButtonBooking.Size = new System.Drawing.Size(240, 70);
            this.iconButtonBooking.TabIndex = 2;
            this.iconButtonBooking.Text = "Booking";
            this.iconButtonBooking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonBooking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonBooking.UseVisualStyleBackColor = false;
            this.iconButtonBooking.Click += new System.EventHandler(this.iconButtonBooking_Click);
            // 
            // iconButtonDashBoard
            // 
            this.iconButtonDashBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(45)))), ((int)(((byte)(93)))));
            this.iconButtonDashBoard.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonDashBoard.FlatAppearance.BorderSize = 0;
            this.iconButtonDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDashBoard.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.iconButtonDashBoard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.iconButtonDashBoard.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.iconButtonDashBoard.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.iconButtonDashBoard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDashBoard.IconSize = 32;
            this.iconButtonDashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonDashBoard.Location = new System.Drawing.Point(0, 180);
            this.iconButtonDashBoard.Name = "iconButtonDashBoard";
            this.iconButtonDashBoard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconButtonDashBoard.Size = new System.Drawing.Size(240, 70);
            this.iconButtonDashBoard.TabIndex = 1;
            this.iconButtonDashBoard.Text = "Dashboard";
            this.iconButtonDashBoard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonDashBoard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonDashBoard.UseVisualStyleBackColor = false;
            this.iconButtonDashBoard.Click += new System.EventHandler(this.iconButtonDashBoard_Click);
            // 
            // ButtonHome
            // 
            this.ButtonHome.Image = ((System.Drawing.Image)(resources.GetObject("ButtonHome.Image")));
            this.ButtonHome.Location = new System.Drawing.Point(0, 0);
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.Size = new System.Drawing.Size(240, 180);
            this.ButtonHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonHome.TabIndex = 0;
            this.ButtonHome.TabStop = false;
            this.ButtonHome.Click += new System.EventHandler(this.ButtonHome_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(240, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(872, 658);
            this.panelDesktop.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(872, 658);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1112, 658);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wedding";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ButtonHome)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconButtonDashBoard;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton iconButtonBooking;
        private FontAwesome.Sharp.IconButton iconButtonService;
        private FontAwesome.Sharp.IconButton iconButtonMenu;
        private FontAwesome.Sharp.IconButton iconButtonVenue;
        private System.Windows.Forms.PictureBox ButtonHome;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}