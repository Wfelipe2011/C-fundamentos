
using System;

namespace area_Triangulo_O_O
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

       public double Area()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C)); // Ou
            // double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            // return raiz; 

        }
    }
}
