﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Figures;
using static System.Windows.Forms.MonthCalendar;

namespace WinAppRectangle
{
    public partial class FrmRectangle : Form
    {
        private CRectangle ObjRectangle = new CRectangle();

        private static FrmRectangle _instance;

        public static FrmRectangle GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmRectangle();
            }
            return _instance;
        }

        public FrmRectangle()
        {
            InitializeComponent();
            this.Load += frmRectangle_Load;
        }

        private void frmRectangle_Load(object sender, EventArgs e)
        {
            ObjRectangle.InitializeData(txtWidth, txtHeight, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            ObjRectangle.ReadData(txtWidth, txtHeight);
            ObjRectangle.PerimeterRectangle();
            ObjRectangle.AreaRectangle();
            ObjRectangle.PrintData(txtPerimeter, txtArea);
            ObjRectangle.PlotShape(picCanvas);
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            ObjRectangle.InitializeData(txtWidth, txtHeight, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            ObjRectangle.CloseForm(this);
        }

        private void picCanvas_Click(object sender, EventArgs e)
        {

        }
    }
}
