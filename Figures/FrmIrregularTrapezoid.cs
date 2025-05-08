using System;
using System.Windows.Forms;
using Figures;
using static System.Windows.Forms.MonthCalendar;

namespace WinAppIrregularTrapezoid
{
    public partial class FrmIrregularTrapezoid : Form
    {
        private CIrregularTrapezoid ObjTrap = new CIrregularTrapezoid();

        private static FrmIrregularTrapezoid _instance;
        public static FrmIrregularTrapezoid GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmIrregularTrapezoid();
            }
            return _instance;
        }
        public FrmIrregularTrapezoid()
        {
            InitializeComponent();
            this.Load += FrmIrregularTrapezoid_Load;
        }

        private void FrmIrregularTrapezoid_Load(object sender, EventArgs e)
        {
            ObjTrap.InitializeData(txtBase1, txtBase2, txtSide1, txtSide2, txtHeight, txtPerimeter, txtArea, picCanvas);
        }

        

        private void btnExit_Click(object sender, EventArgs e)
        {
            ObjTrap.CloseForm(this);
        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            ObjTrap.ReadData(txtBase1, txtBase2, txtSide1, txtSide2, txtHeight);
            ObjTrap.PerimeterTrapezoid();
            ObjTrap.AreaTrapezoid();
            ObjTrap.PrintData(txtPerimeter, txtArea);
            ObjTrap.PlotShape(picCanvas);
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            ObjTrap.InitializeData(txtBase1, txtBase2, txtSide1, txtSide2, txtHeight, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            ObjTrap.CloseForm(this);
        }
    }
}

