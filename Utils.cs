using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTesis
{
    public static class utiles
    {
        /// <summary>
        /// Permite solo letras, espacios y teclas de control (Backspace, Delete) en un TextBox.
        /// </summary>
        public static void SoloLetras(KeyPressEventArgs e)
        {
            // Si es un número, cancela la entrada de la tecla
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            else if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
             {
                 e.Handled = true;
             }
        }
    }
}
