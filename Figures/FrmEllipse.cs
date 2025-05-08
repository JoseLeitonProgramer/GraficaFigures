using System;
using System.Windows.Forms;
using Figures;
using static System.Windows.Forms.MonthCalendar;

namespace WinAppEllipse
{
    public partial class FrmEllipse : Form
    {
        private CEllipse ObjEllipse = new CEllipse();

        private static FrmEllipse _instance;
        public static FrmEllipse GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmEllipse();
            }
            return _instance;
        }
        public FrmEllipse()
        {
            InitializeComponent();
            this.Load += FrmEllipse_Load;
        }

        private void FrmEllipse_Load(object sender, EventArgs e)
        {
            ObjEllipse.InitializeData(txtMajorRadius, txtMinorRadius, txtPerimeter, txtArea, picCanvas);
        }

       

        private void picCanvas_Click(object sender, EventArgs e)
        {
            // Opcional para interacción futura
        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            ObjEllipse.ReadData(txtMajorRadius, txtMinorRadius);
            ObjEllipse.PerimeterEllipse();
            ObjEllipse.AreaEllipse();
            ObjEllipse.PrintData(txtPerimeter, txtArea);
            ObjEllipse.PlotShape(picCanvas);
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            ObjEllipse.InitializeData(txtMajorRadius, txtMinorRadius, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            ObjEllipse.CloseForm(this);
        }
    }
}

