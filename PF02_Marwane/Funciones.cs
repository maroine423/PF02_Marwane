using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PF02_Marwane
{
    public class Funciones
    {
        public static long CalcularFactorial(int n)
        {
            if (n < 0)
                return -1;

            long factorial = 1;

            for (int numero = 2; numero <= n; numero++)
            {
                factorial *= numero;
            }

            return factorial;
        }
        public static bool EsContrasenyaValida(string contrasenya)
        {
            if (string.IsNullOrEmpty(contrasenya))
                return false;

            if (contrasenya.Length < 8)
                return false;

            if (!contrasenya.Contains("#"))
                return false;

            return true;
        }


    }
}