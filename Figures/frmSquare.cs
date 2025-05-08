using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Figures;

namespace WinAppSquare
{
    public partial class FrmSquare : Form
    {
        private CSquare ObjSquare = new CSquare();

        private static FrmSquare _instance;

        public static FrmSquare GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmSquare();
            }
            return _instance;
        }


        private FrmSquare()
        {
            InitializeComponent();
            this.Load += frmSquare_Load;
        }

        private void frmSquare_Load(object sender, EventArgs e)
        {
            ObjSquare.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjSquare.ReadData(txtSide);
            ObjSquare.PerimeterSquare();
            ObjSquare.AreaSquare();
            ObjSquare.PrintData(txtPerimeter, txtArea);
            ObjSquare.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjSquare.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ObjSquare.CloseForm(this);
        }

        private void picCanvas_Click(object sender, EventArgs e)
        {
       
        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            ObjSquare.ReadData(txtSide);
            ObjSquare.PerimeterSquare();
            ObjSquare.AreaSquare();
            ObjSquare.PrintData(txtPerimeter, txtArea);
            ObjSquare.PlotShape(picCanvas);
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            ObjSquare.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            ObjSquare.CloseForm(this);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void picCanvas_Click_1(object sender, EventArgs e)
        {

        }
    }
}
