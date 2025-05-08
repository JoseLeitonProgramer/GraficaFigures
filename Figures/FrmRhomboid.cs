using System;
using System.Windows.Forms;
using Figures;
using static System.Windows.Forms.MonthCalendar;

namespace WinAppRhomboid
{
    public partial class FrmRhomboid : Form
    {
        private CRhomboid ObjRhomboid = new CRhomboid();

        private static FrmRhomboid _instance;
        public static FrmRhomboid GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmRhomboid();
            }
            return _instance;
        }
        public FrmRhomboid()
        {
            InitializeComponent();
            this.Load += FrmRhomboid_Load;
        }

        private void FrmRhomboid_Load(object sender, EventArgs e)
        {
            ObjRhomboid.InitializeData(txtBase, txtSide, txtHeight, txtPerimeter, txtArea, picCanvas);
        }

   


        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            ObjRhomboid.ReadData(txtBase, txtSide, txtHeight);
            ObjRhomboid.PerimeterRhomboid();
            ObjRhomboid.AreaRhomboid();
            ObjRhomboid.PrintData(txtPerimeter, txtArea);
            ObjRhomboid.PlotShape(picCanvas);
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            ObjRhomboid.InitializeData(txtBase, txtSide, txtHeight, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            ObjRhomboid.CloseForm(this);
        }
    }
}

