using System;
using System.Drawing;
using System.Windows.Forms;

namespace Figures
{
    internal class CDeltoid
    {
        private float mDiagonalMajor;
        private float mDiagonalMinor;
        private float mSideA; // Un par de lados iguales
        private float mSideB; // Otro par de lados iguales
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private const float SF = 10; // Scale factor
        private Pen mPen;

        public CDeltoid()
        {
            mDiagonalMajor = 0.0f;
            mDiagonalMinor = 0.0f;
            mSideA = 0.0f;
            mSideB = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
            mPen = new Pen(Color.DarkGreen);
        }

        public void ReadData(TextBox txtDiagMajor, TextBox txtDiagMinor, TextBox txtSideA, TextBox txtSideB)
        {
            try
            {
                mDiagonalMajor = float.Parse(txtDiagMajor.Text);
                mDiagonalMinor = float.Parse(txtDiagMinor.Text);
                mSideA = float.Parse(txtSideA.Text);
                mSideB = float.Parse(txtSideB.Text);
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje de error");
            }
        }

        public void PerimeterDeltoid()
        {
            mPerimeter = 2 * mSideA + 2 * mSideB;
        }

        public void AreaDeltoid()
        {
            mArea = (mDiagonalMajor * mDiagonalMinor) / 2;
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString("0.00");
            txtArea.Text = mArea.ToString("0.00");
        }

        public void InitializeData(TextBox txtDiagMajor, TextBox txtDiagMinor, TextBox txtSideA, TextBox txtSideB, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mDiagonalMajor = 0.0f;
            mDiagonalMinor = 0.0f;
            mSideA = 0.0f;
            mSideB = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;

            txtDiagMajor.Text = "";
            txtDiagMinor.Text = "";
            txtSideA.Text = "";
            txtSideB.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";

            txtDiagMajor.Focus();
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.DarkGreen, 3);

            // Coordenadas aproximadas para representar un deltoide
            float xCenter = picCanvas.Width / 2;
            float yCenter = picCanvas.Height / 2;

            float dx = (mDiagonalMajor * SF) / 2;
            float dy = (mDiagonalMinor * SF) / 2;

            PointF top = new PointF(xCenter, yCenter - dy);
            PointF right = new PointF(xCenter + dx, yCenter);
            PointF bottom = new PointF(xCenter, yCenter + dy);
            PointF left = new PointF(xCenter - dx, yCenter);

            PointF[] points = { top, right, bottom, left };

            mGraph.DrawPolygon(mPen, points);
        }

        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}

