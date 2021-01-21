using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Hello World!");
            Console.WriteLine("----------------");
            Console.WriteLine("for (inicio ; condiçao ; incremento {" +
                "comando 1 " +
                "comand0 2}");
            Console.WriteLine("--------------");
            Console.WriteLine();
            Console.Write("Quantos numeros inteiros voçê vai digitar?: ");
            int x = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= x; i++)
            {
                Console.Write($"Valor #{i}: ");
                int y = int.Parse(Console.ReadLine());
                //sum = sum + y; jeito arcaico de se fazer
                sum += y; // jeito moderno 
            }
            Console.WriteLine($"Soma = {sum}");
        }
    }
}
