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
            this.myToggleButton1 = new QuanLyTiecCuoi.myToggleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IDTIEC = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.myToggleButton1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.IDTIEC);
            this.panel1.Location = new System.Drawing.Point(15, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 233);
            this.panel1.TabIndex = 0;
            // 
            // myToggleButton1
            // 
            this.myToggleButton1.AutoSize = true;
            this.myToggleButton1.Location = new System.Drawing.Point(27, 184);
            this.myToggleButton1.MinimumSize = new System.Drawing.Size(45, 22);
            this.myToggleButton1.Name = "myToggleButton1";
            this.myToggleButton1.OffBackColor = System.Drawing.Color.Gray;
            this.myToggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.myToggleButton1.OnBackColor = System.Drawing.Color.Lime;
            this.myToggleButton1.OnToggleColor = System.Drawing.Color.MintCream;
            this.myToggleButton1.Size = new System.Drawing.Size(45, 22);
            this.myToggleButton1.TabIndex = 2;
            this.myToggleButton1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(195, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // IDTIEC
            // 
            this.IDTIEC.AutoSize = true;
            this.IDTIEC.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTIEC.Location = new System.Drawing.Point(21, 24);
            this.IDTIEC.Name = "IDTIEC";
            this.IDTIEC.Size = new System.Drawing.Size(86, 31);
            this.IDTIEC.TabIndex = 0;
            this.IDTIEC.Text = "Sảnh A";
            this.IDTIEC.Click += new System.EventHandler(this.StateName_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label IDTIEC;
        private System.Windows.Forms.PictureBox pictureBox1;
        private myToggleButton myToggleButton1;
    }
}
