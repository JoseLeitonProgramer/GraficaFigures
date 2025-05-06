using System;
using System.Windows.Forms;
using Figures;
using static System.Windows.Forms.MonthCalendar;

namespace WinAppTriangle
{
    public partial class FrmTriangle : Form
    {
        private CTriangle ObjTriangle = new CTriangle();

        public FrmTriangle()
        {
            InitializeComponent();
        }

        private void FrmTriangle_Load(object sender, EventArgs e)
        {
            ObjTriangle.InitializeData(txtBase, txtHeight, txtPerimeter, txtArea, picCanvas);
        }


        private void picCanvas_Click(object sender, EventArgs e)
        {
            // Por si deseas dibujar interactivo más adelante
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            ObjTriangle.ReadData(txtBase, txtHeight);
            ObjTriangle.PerimeterTriangle();
            ObjTriangle.AreaTriangle();
            ObjTriangle.PrintData(txtPerimeter, txtArea);
            ObjTriangle.PlotShape(picCanvas);
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            ObjTriangle.InitializeData(txtBase, txtHeight, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            ObjTriangle.CloseForm(this);
        }
    }
}

