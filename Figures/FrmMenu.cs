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
using WinAppTriangle;
using WinAppCircle;
using WinAppDeltoid;
using WinAppEllipse;
using WinAppIrregularTrapezoid;
using WinAppRhomboid;
using WinAppRhombus;
using WinAppSemicircle;

namespace Figures
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            FrmSquare squareForm = new FrmSquare();
            squareForm.Show();
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            FrmRectangle rectangleForm = new FrmRectangle();
            rectangleForm.Show();
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            FrmTriangle triangleForm = new FrmTriangle();
            triangleForm.Show();
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            FrmCircle circleForm = new FrmCircle();
            circleForm.Show();
        }

        private void FrmDeltoid_Click(object sender, EventArgs e)
        {
            FrmDeltoid deltoidForm = new FrmDeltoid();
            deltoidForm.Show();
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            FrmEllipse ellipseForm = new FrmEllipse();
            ellipseForm.Show();
        }

        private void btnIrregularTrapezoid_Click(object sender, EventArgs e)
        {
            FrmIrregularTrapezoid irregularTrapezoidForm = new FrmIrregularTrapezoid();
            irregularTrapezoidForm.Show();  
        }

        private void btnRhomboid_Click(object sender, EventArgs e)
        {
            FrmRhomboid rhomboidForm = new FrmRhomboid();
            rhomboidForm.Show();
        }

        private void btnRhombus_Click(object sender, EventArgs e)
        {
            FrmRhombus rhombusForm = new FrmRhombus();
            rhombusForm.Show();
        }

        private void btnSemicircle_Click(object sender, EventArgs e)
        {
            FrmSemicircle semicircleForm = new FrmSemicircle();
            semicircleForm.Show();
        }
    }
}
