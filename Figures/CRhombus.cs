using System;
using System.Drawing;
using System.Windows.Forms;

namespace Figures
{
    internal class CRhombus
    {
        private float mDiagonal1;
        private float mDiagonal2;
        private float mSide;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private const float SF = 10;
        private Pen mPen;

        public CRhombus()
        {
            mDiagonal1 = mDiagonal2 = mSide = 0.0f;
            mPerimeter = mArea = 0.0f;
            mPen = new Pen(Color.MediumVioletRed, 3);
        }

        public void ReadData(TextBox txtDiagonal1, TextBox txtDiagonal2, TextBox txtSide)
        {
            try
            {
                mDiagonal1 = float.Parse(txtDiagonal1.Text);
                mDiagonal2 = float.Parse(txtDiagonal2.Text);
                mSide = float.Parse(txtSide.Text);
            }
            catch
            {
                MessageBox.Show("Invalid input...", "Error");
            }
        }

        public void PerimeterRhombus()
        {
            mPerimeter = 4 * mSide;
        }

        public void AreaRhombus()
        {
            mArea = (mDiagonal1 * mDiagonal2) / 2;
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString("0.00");
            txtArea.Text = mArea.ToString("0.00");
        }

        public void InitializeData(TextBox txtDiagonal1, TextBox txtDiagonal2, TextBox txtSide, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mDiagonal1 = mDiagonal2 = mSide = 0.0f;
            mPerimeter = mArea = 0.0f;

            txtDiagonal1.Text = "";
            txtDiagonal2.Text = "";
            txtSide.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";

            txtDiagonal1.Focus();
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.MediumVioletRed, 3);

            PointF[] points = new PointF[4];

            float cx = 150;
            float cy = 100;

            float d1 = mDiagonal1 * SF;
            float d2 = mDiagonal2 * SF;

            points[0] = new PointF(cx, cy - d2 / 2); 
            points[1] = new PointF(cx + d1 / 2, cy); 
            points[2] = new PointF(cx, cy + d2 / 2); 
            points[3] = new PointF(cx - d1 / 2, cy); 

            mGraph.DrawPolygon(mPen, points);
        }

        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}

