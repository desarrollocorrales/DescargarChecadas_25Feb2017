using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DescargarChecadas
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            catch (Exception Ex)
            {
                //Ex.
                MessageBox.Show(Ex.ToString(), "Descarga Checadores", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
