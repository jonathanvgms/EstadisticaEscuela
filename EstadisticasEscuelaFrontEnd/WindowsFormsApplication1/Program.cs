using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using EstadisticasEscuelaFrontEnd.Login;
using EstadisticasEscuelaFrontEnd.Modelo;

namespace EstadisticasEscuelaFrontEnd
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Escritorio());
        }
    }
}
