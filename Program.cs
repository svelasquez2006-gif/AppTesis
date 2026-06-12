using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTesis
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //funcion para que la base de datos datee
            string rutaEjecucion = AppDomain.CurrentDomain.BaseDirectory;
            string rutaRaiz = Directory.GetParent(rutaEjecucion).Parent.Parent.FullName;
            AppDomain.CurrentDomain.SetData("DataDirectory", rutaRaiz);

            Application.Run(new FormPrincipal());
        }
        
    }
}
