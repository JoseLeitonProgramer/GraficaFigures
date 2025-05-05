using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figures
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Selección entre Rectángulo o Cuadrado
            string selection = "square";  // Cambia entre "rectangle" o "square" según tu preferencia

            if (selection == "rectangle")
            {
                Application.Run(new WinAppRectangle.FrmRectangle());
            }
            else if (selection == "square")
            {
                Application.Run(new WinAppSquare.FrmSquare());
            }
            else
            {
                MessageBox.Show("Selección no válida", "Error");
            }
        }
    }
}

