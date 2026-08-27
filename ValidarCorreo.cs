using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;



namespace AppTesis
{
    public class ValidarCorreo
    {
        public static bool EsEmailValido(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            // Exige: Texto + @ + Texto + . + Extensión (mínimo 2 letras como com, es, net)
            string patron = @"^[^@\s]+@[^@\s]+\.[a-zA-Z]{2,}$";

            return Regex.IsMatch(email.Trim(), patron);
        }
    }
}
