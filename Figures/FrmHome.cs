using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinAppRectangle;
using WinAppSquare;
using WinAppStar;
using WinAppTrapezoid;
using WinAppTriangle;
using WinAppCircle;
using WinAppEllipse;
using WinAppSemicircle;
using WinAppIrregularTrapezoid;
using WinAppRhombus;
using WinAppRhomboid;
using WinAppDeltoid;

namespace Figures
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void cuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSquare squareForm = FrmSquare.GetInstance();
            squareForm.MdiParent = this;
            squareForm.Show();
            squareForm.BringToFront();
        }

        private void trapezioToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {

        }

        private void rectanguloToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmRectangle rectangleForm = FrmRectangle.GetInstance();
            rectangleForm.MdiParent = this;
            rectangleForm.Show();
            rectangleForm.BringToFront();
        }

        private void estrellaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStar starForm = FrmStar.GetInstance();
            starForm.MdiParent = this;
            starForm.Show();
            starForm.BringToFront();
        }

        private void trapecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrapezoid trapezoidForm = FrmTrapezoid.GetInstance();
            trapezoidForm.MdiParent = this;
            trapezoidForm.Show();
            trapezoidForm.BringToFront();
        }

        private void trianguloEquilateroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTriangle triangleForm = FrmTriangle.GetInstance();
            triangleForm.MdiParent = this;
            triangleForm.Show();
            triangleForm.BringToFront();
        }

        private void trapezoideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIrregularTrapezoid trapezoidForm = FrmIrregularTrapezoid.GetInstance();
            trapezoidForm.MdiParent = this;
            trapezoidForm.Show();
            trapezoidForm.BringToFront();
        }

        private void romboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRhombus rhombusForm = FrmRhombus.GetInstance();
            rhombusForm.MdiParent = this;
            rhombusForm.Show();
            rhombusForm.BringToFront();
        }

        private void romboideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRhomboid rhomboidForm = FrmRhomboid.GetInstance();
            rhomboidForm.MdiParent = this;
            rhomboidForm.Show();
            rhomboidForm.BringToFront();
        }

        private void deltoideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDeltoid deltoidForm = FrmDeltoid.GetInstance();
            deltoidForm.MdiParent = this;
            deltoidForm.Show();
            deltoidForm.BringToFront();
        }

        private void circuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCircle circleForm = FrmCircle.GetInstance();
            circleForm.MdiParent = this;
            circleForm.Show();
            circleForm.BringToFront();
        }

        private void semiCirculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSemicircle semicircleForm = FrmSemicircle.GetInstance();
            semicircleForm.MdiParent = this;
            semicircleForm.Show();
            semicircleForm.BringToFront();
        }

        private void elipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEllipse ellipseForm = FrmEllipse.GetInstance();
            ellipseForm.MdiParent = this;
            ellipseForm.Show();
            ellipseForm.BringToFront();
        }
    }
}
