using System;
using System.Drawing;
using System.Windows.Forms;

namespace Figures
{
    internal class CTrapezoid
    {
        private float mBaseMajor;
        private float mBaseMinor;
        private float mHeight;
        private float mSide1;
        private float mSide2;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 10;

        public CTrapezoid()
        {
            mBaseMajor = 0.0f;
            mBaseMinor = 0.0f;
            mHeight = 0.0f;
            mSide1 = 0.0f;
            mSide2 = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
            mPen = new Pen(Color.Black);
        }

        public void ReadData(TextBox txtBaseMajor, TextBox txtBaseMinor, TextBox txtHeight, TextBox txtSide1, TextBox txtSide2)
        {
            try
            {
                mBaseMajor = float.Parse(txtBaseMajor.Text);
                mBaseMinor = float.Parse(txtBaseMinor.Text);
                mHeight = float.Parse(txtHeight.Text);
                mSide1 = float.Parse(txtSide1.Text);
                mSide2 = float.Parse(txtSide2.Text);
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje de error");
            }
        }

        public void PerimeterTrapezoid()
        {
            mPerimeter = mBaseMajor + mBaseMinor + mSide1 + mSide2;
        }

        public void AreaTrapezoid()
        {
            mArea = ((mBaseMajor + mBaseMinor) * mHeight) / 2;
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString("0.00");
            txtArea.Text = mArea.ToString("0.00");
        }

        public void InitializeData(TextBox txtBaseMajor, TextBox txtBaseMinor, TextBox txtHeight, TextBox txtSide1, TextBox txtSide2,
                                   TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mBaseMajor = mBaseMinor = mHeight = mSide1 = mSide2 = mPerimeter = mArea = 0.0f;

            txtBaseMajor.Text = "";
            txtBaseMinor.Text = "";
            txtHeight.Text = "";
            txtSide1.Text = "";
            txtSide2.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";

            txtBaseMajor.Focus();
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);

            float x = 50, y = 50;
            float topOffset = (mBaseMajor - mBaseMinor) * SF / 2;

            PointF[] points = new PointF[4];
            points[0] = new PointF(x, y);
            points[1] = new PointF(x + mBaseMinor * SF, y);
            points[2] = new PointF(x + mBaseMajor * SF, y + mHeight * SF);
            points[3] = new PointF(x, y + mHeight * SF); 

            points[0].X += topOffset;
            points[1].X += topOffset;

            mGraph.DrawPolygon(mPen, points);
        }

        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}

