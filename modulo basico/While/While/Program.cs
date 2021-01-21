using System;
using System.Globalization;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Estrutura While:");

            CultureInfo CI = CultureInfo.InvariantCulture;// para ponto e não a virgula do numero separar

            Console.Write("Digite um numero: ");
            double x = double.Parse(Console.ReadLine(), CI);
            while ( x >= 0)
            {
                
                double raiz = Math.Sqrt(x);
                Console.WriteLine($"A raiz de {x} é {raiz}!");
                Console.WriteLine("-------------------");
                Console.Write("Digite um numero: ");
                x = double.Parse(Console.ReadLine(), CI);
            }
            Console.WriteLine("Numero Negativo!");
        }
    }
}
