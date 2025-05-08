using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figures
{
    internal class CStar
    {
        private float mRadius;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private const float SF = 20;
        private Pen mPen;

        public CStar()
        {
            mRadius = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
            mPen = new Pen(Color.Black);
        }

        public void ReadData(TextBox txtRadius)
        {
            try
            {
                mRadius = float.Parse(txtRadius.Text);
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje de error");
            }
        }

        // Estimaciones simples para estrella de 5 puntas
        public void PerimeterStar()
        {
            float side = 2 * mRadius * (float)Math.Sin(Math.PI / 5); // Aproximación
            mPerimeter = 10 * side; // 10 lados exteriores
        }

        public void AreaStar()
        {
            // Aproximación: área de un pentágono regular + área de 5 triángulos isósceles
            float angle = (float)(Math.PI / 5);
            float apothem = mRadius * (float)Math.Cos(angle);
            float basePentagon = 2 * mRadius * (float)Math.Sin(angle);
            float pentagonArea = 5 * basePentagon * apothem / 2;

            float triangleArea = 5 * 0.5f * basePentagon * (mRadius - apothem);

            mArea = pentagonArea + triangleArea;
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString("0.00");
            txtArea.Text = mArea.ToString("0.00");
        }

        public void InitializeData(TextBox txtRadius, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mRadius = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;

            txtRadius.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";

            txtRadius.Focus();
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Purple, 3);

            float cx = picCanvas.Width / 2;
            float cy = picCanvas.Height / 2;
            float R = mRadius * SF;
            float r = R * 0.38f; // radio interior (aproximado)

            PointF[] points = new PointF[10];
            for (int i = 0; i < 10; i++)
            {
                float angle = (float)(-Math.PI / 2 + i * Math.PI / 5);
                float radius = (i % 2 == 0) ? R : r;
                points[i] = new PointF(
                    cx + radius * (float)Math.Cos(angle),
                    cy + radius * (float)Math.Sin(angle)
                );
            }

            mGraph.DrawPolygon(mPen, points);
        }

        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}

