using System;
using System.Windows.Forms;
using Figures;
using static System.Windows.Forms.MonthCalendar;

namespace WinAppSemicircle
{
    public partial class FrmSemicircle : Form
    {
        private CSemicircle ObjSemicircle = new CSemicircle();

        private static FrmSemicircle _instance;
        public static FrmSemicircle GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmSemicircle();
            }
            return _instance;
        }
        public FrmSemicircle()
        {
            InitializeComponent();
            this.Load += FrmSemicircle_Load;
        }

        private void FrmSemicircle_Load(object sender, EventArgs e)
        {
            ObjSemicircle.InitializeData(txtRadius, txtPerimeter, txtArea, picCanvas);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            ObjSemicircle.ReadData(txtRadius);
            ObjSemicircle.PerimeterSemicircle();
            ObjSemicircle.AreaSemicircle();
            ObjSemicircle.PrintData(txtPerimeter, txtArea);
            ObjSemicircle.PlotShape(picCanvas);
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            ObjSemicircle.InitializeData(txtRadius, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            ObjSemicircle.CloseForm(this);
        }
    }
}

