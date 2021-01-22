using System;

namespace Exe_Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();

            Console.Write("Entre com a Largura: ");
            r.Largura = double.Parse(Console.ReadLine());
            Console.Write("Entre com a Altura: " );
            r.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Area: " + r.Area());
            Console.WriteLine("Perimetro: " + r.Perimetro());
            Console.WriteLine("Diagonal: " + r.Diagonal());

            // So falta resolver o probleba da virgula para ponto e adicionar metodo ToString.
        }
    }
}
