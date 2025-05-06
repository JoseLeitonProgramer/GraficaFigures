using System;
using System.Windows.Forms;
using Figures;
using static System.Windows.Forms.MonthCalendar;

namespace WinAppCircle
{
    public partial class FrmCircle : Form
    {
        private CCircle ObjCircle = new CCircle();

        public FrmCircle()
        {
            InitializeComponent();
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

