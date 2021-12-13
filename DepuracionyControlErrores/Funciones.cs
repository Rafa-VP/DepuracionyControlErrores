using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepuracionyControlErrores
{
    class Funciones
    {
        public int factorial (int num)
        {
            int fac = 1;
            for(int i=1; i<=num; i++)
            {
                fac *= i;
            }
            return fac;
        }
        public int division_para_cero(int num) {
            int i = 10, j=5, resultado=0;
            if (num > 100) j = 12;
            while (i > 1)
            {
                resultado += (num * i) / j;
                i--;
                j--;
            }
            return resultado;
        }
        public int divide(int num1, int num2)
        {
            if (num2 == 0)
            {
                throw new Exception("Debes ingresar un valor distinto a cero");
            }
            return num1 / num2;
        }
    }
}
