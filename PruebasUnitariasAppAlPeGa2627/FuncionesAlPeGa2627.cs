using System;
using System.Collections.Generic;
using System.Text;

namespace ActividadTDDAppAlPeGa2627
{
    public class FuncionesAlPeGa2627
    {
        public long CalcularFactorial(int n) 
        {
            if (n < 0)
                return -1;

            long resultado = 1;

            for (int i = 2; i <= n; i++)
            {
                resultado *= i;
            }
            return resultado;
        }

        public bool EsContrasenyaValida(string contrasenya)
        { 
            if (contrasenya == "")
                return false;

            if (contrasenya == null)
                return false;

            if (contrasenya.Length < 8)
                return false;

            if(!contrasenya.Contains("#"))
                return false;

            return true;
        }
    }
}
