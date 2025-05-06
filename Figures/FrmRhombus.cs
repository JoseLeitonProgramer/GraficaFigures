using System;
using System.Windows.Forms;
using Figures;
using static System.Windows.Forms.MonthCalendar;

namespace WinAppRhombus
{
    public partial class FrmRhombus : Form
    {
        private CRhombus ObjRhombus = new CRhombus();

        public FrmRhombus()
        {
            InitializeComponent();
        }

        private void FrmRhombus_Load(object sender, EventArgs e)
        {
            ObjRhombus.InitializeData(txtDiagonal1, txtDiagonal2, txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            ObjRhombus.ReadData(txtDiagonal1, txtDiagonal2, txtSide);
            ObjRhombus.PerimeterRhombus();
            ObjRhombus.AreaRhombus();
            ObjRhombus.PrintData(txtPerimeter, txtArea);
            ObjRhombus.PlotShape(picCanvas);
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            ObjRhombus.InitializeData(txtDiagonal1, txtDiagonal2, txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            ObjRhombus.CloseForm(this);
        }
    }
}

