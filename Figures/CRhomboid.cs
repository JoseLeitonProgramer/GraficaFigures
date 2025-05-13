using System;
using System.Drawing;
using System.Windows.Forms;

namespace Figures
{
    internal class CRhomboid
    {
        private float mBase;
        private float mSide;
        private float mHeight;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private const float SF = 20;
        private Pen mPen;

        public CRhomboid()
        {
            mBase = mSide = mHeight = 0.0f;
            mPerimeter = mArea = 0.0f;
            mPen = new Pen(Color.DarkGreen, 3);
        }

        public void ReadData(TextBox txtBase, TextBox txtSide, TextBox txtHeight)
        {
            try
            {
                mBase = float.Parse(txtBase.Text);
                mSide = float.Parse(txtSide.Text);
                mHeight = float.Parse(txtHeight.Text);
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje de error");
            }
        }

        public void PerimeterRhomboid()
        {
            mPerimeter = 2 * (mBase + mSide);
        }

        public void AreaRhomboid()
        {
            mArea = mBase * mHeight;
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString("0.00");
            txtArea.Text = mArea.ToString("0.00");
        }

        public void InitializeData(TextBox txtBase, TextBox txtSide, TextBox txtHeight, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mBase = mSide = mHeight = 0.0f;
            mPerimeter = mArea = 0.0f;

            txtBase.Text = "";
            txtSide.Text = "";
            txtHeight.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";

            txtBase.Focus();
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.DarkGreen, 3);

            PointF[] points = new PointF[4];
            float offset = 40;

            points[0] = new PointF(offset, 50 + mHeight * SF);
            points[1] = new PointF(offset + mBase * SF, 50 + mHeight * SF);
            points[2] = new PointF(offset + mBase * SF - (mHeight * SF / 2), 50);
            points[3] = new PointF(offset - (mHeight * SF / 2), 50);

            mGraph.DrawPolygon(mPen, points);
        }

        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}

