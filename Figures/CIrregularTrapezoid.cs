using System;
using System.Drawing;
using System.Windows.Forms;

namespace Figures
{
    internal class CIrregularTrapezoid
    {
        private float mBase1;
        private float mBase2;
        private float mSide1;
        private float mSide2;
        private float mHeight;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private const float SF = 20;
        private Pen mPen;

        public CIrregularTrapezoid()
        {
            mBase1 = mBase2 = mSide1 = mSide2 = mHeight = 0.0f;
            mPerimeter = mArea = 0.0f;
            mPen = new Pen(Color.SaddleBrown, 3);
        }

        public void ReadData(TextBox txtBase1, TextBox txtBase2, TextBox txtSide1, TextBox txtSide2, TextBox txtHeight)
        {
            try
            {
                mBase1 = float.Parse(txtBase1.Text);
                mBase2 = float.Parse(txtBase2.Text);
                mSide1 = float.Parse(txtSide1.Text);
                mSide2 = float.Parse(txtSide2.Text);
                mHeight = float.Parse(txtHeight.Text);
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje de error");
            }
        }

        public void PerimeterTrapezoid()
        {
            mPerimeter = mBase1 + mBase2 + mSide1 + mSide2;
        }

        public void AreaTrapezoid()
        {
            mArea = ((mBase1 + mBase2) / 2) * mHeight;
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString("0.00");
            txtArea.Text = mArea.ToString("0.00");
        }

        public void InitializeData(TextBox txtBase1, TextBox txtBase2, TextBox txtSide1, TextBox txtSide2, TextBox txtHeight, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mBase1 = mBase2 = mSide1 = mSide2 = mHeight = 0.0f;
            mPerimeter = mArea = 0.0f;

            txtBase1.Text = "";
            txtBase2.Text = "";
            txtSide1.Text = "";
            txtSide2.Text = "";
            txtHeight.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";

            txtBase1.Focus();
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.SaddleBrown, 3);

            PointF[] points = new PointF[4];
            float topOffset = (picCanvas.Width - mBase2 * SF) / 2;
            float bottomOffset = (picCanvas.Width - mBase1 * SF) / 2;

            points[0] = new PointF(bottomOffset, 50 + mHeight * SF);                      // Inferior izquierda
            points[1] = new PointF(bottomOffset + mBase1 * SF, 50 + mHeight * SF);        // Inferior derecha
            points[2] = new PointF(topOffset + mBase2 * SF, 50);                          // Superior derecha
            points[3] = new PointF(topOffset, 50);                                        // Superior izquierda

            mGraph.DrawPolygon(mPen, points);
        }

        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}

