using System;
using System.Windows.Forms;
using Figures;
using static System.Windows.Forms.MonthCalendar;

namespace WinAppDeltoid
{
    public partial class FrmDeltoid : Form
    {
        private CDeltoid ObjDeltoid = new CDeltoid();

        private static FrmDeltoid _instance;
        public static FrmDeltoid GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmDeltoid();
            }
            return _instance;
        }

        public FrmDeltoid()
        {
            InitializeComponent();
            this.Load += FrmDeltoid_Load;
        }

        private void FrmDeltoid_Load(object sender, EventArgs e)
        {
            ObjDeltoid.InitializeData(txtDiagMajor, txtDiagMinor, txtSideA, txtSideB, txtPerimeter, txtArea, picCanvas);
        }

        

        private void picCanvas_Click(object sender, EventArgs e)
        {
            // Opcional: para interacción futura
        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            ObjDeltoid.ReadData(txtDiagMajor, txtDiagMinor, txtSideA, txtSideB);
            ObjDeltoid.PerimeterDeltoid();
            ObjDeltoid.AreaDeltoid();
            ObjDeltoid.PrintData(txtPerimeter, txtArea);
            ObjDeltoid.PlotShape(picCanvas);
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            ObjDeltoid.InitializeData(txtDiagMajor, txtDiagMinor, txtSideA, txtSideB, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            ObjDeltoid.CloseForm(this);
        }
    }
}
