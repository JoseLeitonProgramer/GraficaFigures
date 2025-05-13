using System;
using System.Drawing;
using System.Windows.Forms;

namespace Figures
{
    internal class CEllipse
    {
        private float mMajorRadius;
        private float mMinorRadius;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private const float SF = 20;
        private Pen mPen;

        public CEllipse()
        {
            mMajorRadius = 0.0f;
            mMinorRadius = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
            mPen = new Pen(Color.DarkViolet);
        }

        public void ReadData(TextBox txtMajorRadius, TextBox txtMinorRadius)
        {
            try
            {
                mMajorRadius = float.Parse(txtMajorRadius.Text);
                mMinorRadius = float.Parse(txtMinorRadius.Text);
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje de error");
            }
        }

        public void PerimeterEllipse()
        {
            
            float a = mMajorRadius;
            float b = mMinorRadius;
            mPerimeter = (float)(Math.PI * (3 * (a + b) - Math.Sqrt((3 * a + b) * (a + 3 * b))));
        }

        public void AreaEllipse()
        {
            mArea = (float)(Math.PI * mMajorRadius * mMinorRadius);
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString("0.00");
            txtArea.Text = mArea.ToString("0.00");
        }

        public void InitializeData(TextBox txtMajorRadius, TextBox txtMinorRadius, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mMajorRadius = 0.0f;
            mMinorRadius = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;

            txtMajorRadius.Text = "";
            txtMinorRadius.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";

            txtMajorRadius.Focus();
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.DarkViolet, 3);

            float width = mMajorRadius * 2 * SF;
            float height = mMinorRadius * 2 * SF;

            float x = (picCanvas.Width - width) / 2;
            float y = (picCanvas.Height - height) / 2;

            mGraph.DrawEllipse(mPen, x, y, width, height);
        }

        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}

