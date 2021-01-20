using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {// Operadores Logicos 

            bool c1 = 2 > 3 && 4 != 5; // Operador 'E' false + True = false
            Console.WriteLine("Operador 'E' false + True = false");
            Console.WriteLine(c1);

            bool c2 = 2 > 3 || 4 != 5; // Operador 'OU' false + true = true
            Console.WriteLine("Operador 'OU' false + true = true");
            Console.WriteLine(c2);

            bool c3 = !(2 > 3) && 4 != 5;
            // c3 = 2 Nao é maior que 3'E' 4 é deferente de 4
            Console.WriteLine("!(2 > 3) && 4 != 5;");
            Console.WriteLine("2 Nao é maior que 3'E' 4 é deferente de 5");
            Console.WriteLine(c3);
        }
    }
}
