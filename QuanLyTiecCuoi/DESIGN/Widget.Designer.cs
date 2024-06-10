namespace QuanLyTiecCuoi.DESIGN
{
    partial class Widget
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Widget));
            this.panel1 = new System.Windows.Forms.Panel();
            this.VenuePicture = new System.Windows.Forms.PictureBox();
            this.VenueNameWidget = new System.Windows.Forms.Label();
            this.State = new QuanLyTiecCuoi.myToggleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VenuePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.State);
            this.panel1.Controls.Add(this.VenuePicture);
            this.panel1.Controls.Add(this.VenueNameWidget);
            this.panel1.Location = new System.Drawing.Point(15, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 233);
            this.panel1.TabIndex = 0;
            // 
            // VenuePicture
            // 
            this.VenuePicture.Image = ((System.Drawing.Image)(resources.GetObject("VenuePicture.Image")));
            this.VenuePicture.Location = new System.Drawing.Point(195, 24);
            this.VenuePicture.Name = "VenuePicture";
            this.VenuePicture.Size = new System.Drawing.Size(185, 182);
            this.VenuePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VenuePicture.TabIndex = 1;
            this.VenuePicture.TabStop = false;
            // 
            // VenueNameWidget
            // 
            this.VenueNameWidget.AutoSize = true;
            this.VenueNameWidget.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VenueNameWidget.Location = new System.Drawing.Point(21, 24);
            this.VenueNameWidget.Name = "VenueNameWidget";
            this.VenueNameWidget.Size = new System.Drawing.Size(86, 31);
            this.VenueNameWidget.TabIndex = 0;
            this.VenueNameWidget.Text = "Sảnh A";
            this.VenueNameWidget.Click += new System.EventHandler(this.StateName_Click);
            // 
            // State
            // 
            this.State.AutoCheck = false;
            this.State.AutoSize = true;
            this.State.Location = new System.Drawing.Point(27, 184);
            this.State.MinimumSize = new System.Drawing.Size(45, 22);
            this.State.Name = "State";
            this.State.OffBackColor = System.Drawing.Color.Gray;
            this.State.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.State.OnBackColor = System.Drawing.Color.Lime;
            this.State.OnToggleColor = System.Drawing.Color.MintCream;
            this.State.Size = new System.Drawing.Size(45, 22);
            this.State.TabIndex = 2;
            this.State.UseVisualStyleBackColor = true;
            // 
            // Widget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Widget";
            this.Size = new System.Drawing.Size(437, 258);
            this.Load += new System.EventHandler(this.Widget_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VenuePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label VenueNameWidget;
        public System.Windows.Forms.PictureBox VenuePicture;
        public myToggleButton State;
    }
}
