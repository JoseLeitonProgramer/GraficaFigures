using System;
using System.Windows.Forms;
using Figures;
using static System.Windows.Forms.MonthCalendar;

namespace WinAppCircle
{
    public partial class FrmCircle : Form
    {
        private CCircle ObjCircle = new CCircle();

        private static FrmCircle _instance;
        public static FrmCircle GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmCircle();
            }
            return _instance;
        }
        public FrmCircle()
        {
            InitializeComponent();
            this.Load += FrmCircle_Load;
        }

        private void FrmCircle_Load(object sender, EventArgs e)
        {
            ObjCircle.InitializeData(txtRadius, txtPerimeter, txtArea, picCanvas);
        }

     

        private void picCanvas_Click(object sender, EventArgs e)
        {
            // Para interacción futura si lo deseas
        }

       

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            ObjCircle.ReadData(txtRadius);
            ObjCircle.PerimeterCircle();
            ObjCircle.AreaCircle();
            ObjCircle.PrintData(txtPerimeter, txtArea);
            ObjCircle.PlotShape(picCanvas);
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            ObjCircle.InitializeData(txtRadius, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            ObjCircle.CloseForm(this);
        }
    }
}

