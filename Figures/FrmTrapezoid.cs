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
using static System.Windows.Forms.MonthCalendar;

namespace WinAppTrapezoid
{
    public partial class FrmTrapezoid : Form
    {
        private CTrapezoid ObjTrapezoid = new CTrapezoid();

        private static FrmTrapezoid _instance;

        public static FrmTrapezoid GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmTrapezoid();
            }
            return _instance;
        }

        private FrmTrapezoid()
        {
            InitializeComponent();
            this.Load += FrmTrapezoid_Load;
        }

        private void FrmTrapezoid_Load(object sender, EventArgs e)
        {
            ObjTrapezoid.InitializeData(txtBaseMajor, txtBaseMinor, txtHeight, txtSide1, txtSide2, txtPerimeter, txtArea, picCanvas);
        }

        private void picCanvas_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            ObjTrapezoid.ReadData(txtBaseMajor, txtBaseMinor, txtHeight, txtSide1, txtSide2);
            ObjTrapezoid.PerimeterTrapezoid();
            ObjTrapezoid.AreaTrapezoid();
            ObjTrapezoid.PrintData(txtPerimeter, txtArea);
            ObjTrapezoid.PlotShape(picCanvas);
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            ObjTrapezoid.InitializeData(txtBaseMajor, txtBaseMinor, txtHeight, txtSide1, txtSide2, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            ObjTrapezoid.CloseForm(this);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

