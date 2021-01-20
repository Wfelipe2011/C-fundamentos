using System;

namespace Par_Impar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Bem vindo ao Par ou Impar");
            Console.WriteLine("----------------------");
            Console.WriteLine("Digite um numero e descubra se ele é Par ou Impar!");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("Par!");
            }else
            {
                Console.WriteLine("Impar!");
            }
        }
    }
}
