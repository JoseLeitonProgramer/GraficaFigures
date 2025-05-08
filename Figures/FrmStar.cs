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

namespace WinAppStar
{
    public partial class FrmStar : Form
    {
        private CStar ObjStar = new CStar();

        private static FrmStar _instance;

        public static FrmStar GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmStar();
            }
            return _instance;
        }

        private FrmStar()
        {
            InitializeComponent();
            this.Load += FrmStar_Load;
        }

        private void FrmStar_Load(object sender, EventArgs e)
        {
            ObjStar.InitializeData(txtRadius, txtPerimeter, txtArea, picCanvas);
        }

        private void picCanvas_Click(object sender, EventArgs e)
        {
         
        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            ObjStar.ReadData(txtRadius);
            ObjStar.PerimeterStar();
            ObjStar.AreaStar();
            ObjStar.PrintData(txtPerimeter, txtArea);
            ObjStar.PlotShape(picCanvas);
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            ObjStar.InitializeData(txtRadius, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            ObjStar.CloseForm(this);
        }
    }
}
