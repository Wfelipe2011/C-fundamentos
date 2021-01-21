using System;

namespace Exe_Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();

            Console.Write("Entre com a Largura: ");
            r.Largura = int.Parse(Console.ReadLine());
            Console.Write("Entre com a Altura: " );
            r.Altura = int.Parse(Console.ReadLine());

            Console.WriteLine("Area: " + r.Area());
            Console.WriteLine("Perimetro: ");
            Console.WriteLine("Diagonal: ");
        }
    }
}
