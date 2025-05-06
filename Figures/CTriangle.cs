using System;
using System.Drawing;
using System.Windows.Forms;

namespace Figures
{
    internal class CTriangle
    {
        private float mBase;
        private float mHeight;
        private float mHypotenuse;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private const float SF = 20;
        private Pen mPen;

        public CTriangle()
        {
            mBase = 0.0f;
            mHeight = 0.0f;
            mHypotenuse = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
            mPen = new Pen(Color.Black);
        }

        public void ReadData(TextBox txtBase, TextBox txtHeight)
        {
            try
            {
                mBase = float.Parse(txtBase.Text);
                mHeight = float.Parse(txtHeight.Text);
                mHypotenuse = (float)Math.Sqrt(mBase * mBase + mHeight * mHeight);
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje de error");
            }
        }

        public void PerimeterTriangle()
        {
            mPerimeter = mBase + mHeight + mHypotenuse;
        }

        public void AreaTriangle()
        {
            mArea = (mBase * mHeight) / 2;
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString("0.00");
            txtArea.Text = mArea.ToString("0.00");
        }

        public void InitializeData(TextBox txtBase, TextBox txtHeight, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mBase = 0.0f; mHeight = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;

            txtBase.Text = ""; txtHeight.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";

            txtBase.Focus();
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Green, 3);

            PointF p1 = new PointF(0, mHeight * SF);
            PointF p2 = new PointF(mBase * SF, mHeight * SF);
            PointF p3 = new PointF(0, 0);

            mGraph.DrawPolygon(mPen, new PointF[] { p1, p2, p3 });
        }

        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}

