using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class ConversorDaMoeda
    {

        
        public static double Conversor(double valor, double qtd)
        {
            double total = valor * qtd;
            return total + (total * 0.06);
        }


    }
}
