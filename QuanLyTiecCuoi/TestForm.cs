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
    public partial class TestForm : Form
    {
        private float initialLabelXRatio;
        private float initialLabelYRatio;
        private float initialFontSize;
        private float initialFormWidth;
        private float initialFormHeight;
        private const float MinFontSize = 8.25f;
        private bool initialValuesSet = false;
        public TestForm()
        {
            InitializeComponent();
            initialFontSize = label1.Font.Size;
            initialFormWidth = this.ClientSize.Width;
            initialFormHeight = this.ClientSize.Height;
            SetInitialValues();
        }

        private void TestForm_Resize(object sender, EventArgs e)
        {
            AdjustLabel(label1);
        }

        private void SetInitialValues()
        {
            initialLabelXRatio = (float)label1.Left / this.ClientSize.Width;
            initialLabelYRatio = (float)label1.Top / this.ClientSize.Height;
            initialValuesSet = true;
        }

        private void AdjustLabel(Label label)
        {
            if (!initialValuesSet) return;
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;
            float widthRatio = (float)this.ClientSize.Width / initialFormWidth;
            float heightRatio = (float)this.ClientSize.Height / initialFormHeight;
            float newFontSize = initialFontSize * Math.Min(widthRatio, heightRatio);
            newFontSize = Math.Max(newFontSize, MinFontSize);
            label.Font = new Font(label.Font.FontFamily, newFontSize);
            label.Size = new Size(formWidth / 2, formHeight / 10);

            using (Graphics g = this.CreateGraphics())
            {
                SizeF stringSize = g.MeasureString(label.Text, label.Font);
                label.Size = new Size((int)stringSize.Width + 10, (int)stringSize.Height + 10);
            }
            int newLabelX = (int)(initialLabelXRatio * this.ClientSize.Width);
            int newLabelY = (int)(initialLabelYRatio * this.ClientSize.Height);

            label.Location = new Point(newLabelX, newLabelY);
        }
    }
}
