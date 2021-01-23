using System;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seja Bem vido ao WFBank");
            Console.WriteLine();

            Console.Write("Entre com número da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre com nome do titular: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial? (s/n): ");
            char ch = char.Parse(Console.ReadLine());
            double initdeposito = 0;
            Conta c = new Conta();
            if (ch == 's')
            {
                Console.Write("Entre com o valor do depósito: ");
                initdeposito = double.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine(c);


        }
    }
}
