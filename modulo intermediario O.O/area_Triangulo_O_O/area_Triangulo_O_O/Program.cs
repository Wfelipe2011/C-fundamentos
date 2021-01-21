using System;

namespace area_Triangulo_O_O
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();
            
            Console.WriteLine("Digite os lados do Triangulo X: ");

            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite os lados do Triangulo Y: ");

            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double areaX = x.Area();

            double areaY = y.Area();

            Console.WriteLine($"Area do Triangulo X é: {areaX}");
            Console.WriteLine($"Area do Triangulo Y é: {areaY}");
            if ( areaX > areaY)
            {
                Console.WriteLine("Area X é a maior!");
            }else
            {
                Console.WriteLine("Area Y é a maior!");
            }
        }
    }
}
