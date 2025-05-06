using System;
using System.Drawing;
using System.Windows.Forms;

namespace Figures
{
    internal class CSemicircle
    {
        private float mRadius;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private const float SF = 10; // Scale factor
        private Pen mPen;

        public CSemicircle()
        {
            mRadius = mPerimeter = mArea = 0.0f;
            mPen = new Pen(Color.DarkCyan, 3);
        }

        public void ReadData(TextBox txtRadius)
        {
            try
            {
                mRadius = float.Parse(txtRadius.Text);
            }
            catch
            {
                MessageBox.Show("Invalid input...", "Error");
            }
        }

        public void PerimeterSemicircle()
        {
            // Perímetro = πr + 2r
            mPerimeter = (float)(Math.PI * mRadius + 2 * mRadius);
        }

        public void AreaSemicircle()
        {
            // Área = (π * r²) / 2
            mArea = (float)(Math.PI * Math.Pow(mRadius, 2) / 2);
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString("0.00");
            txtArea.Text = mArea.ToString("0.00");
        }

        public void InitializeData(TextBox txtRadius, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mRadius = mPerimeter = mArea = 0.0f;

            txtRadius.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";

            txtRadius.Focus();
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.DarkCyan, 3);

            float r = mRadius * SF;
            float cx = 100;
            float cy = 100;

            // Dibuja semicírculo con línea base horizontal
            mGraph.DrawArc(mPen, cx, cy, 2 * r, 2 * r, 180, 180); // arco superior
            mGraph.DrawLine(mPen, cx, cy + r, cx + 2 * r, cy + r); // línea recta inferior
        }

        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}

