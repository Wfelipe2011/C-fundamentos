using System;
using System.Globalization;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            Console.WriteLine("Seja Bem vido ao WFBank");
            Console.WriteLine();

            Console.Write("Entre com número da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre com nome do titular: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial? (s/n): ");
            char ch = char.Parse(Console.ReadLine());
            double initdeposito = 0;
            Conta c = new Conta(nome, conta);
            if (ch == 's')
            {
                Console.Write("Entre com o valor do depósito: ");
                initdeposito = double.Parse(Console.ReadLine(), CI);
                c.Deposito(initdeposito);
            }
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(c);
            Console.WriteLine();
            char x;
            Console.Write("Voce deseja realizar um Saque ou Deposito? (s/d): ");
            x = char.Parse(Console.ReadLine());
            Console.WriteLine();
            while (x != 'n')
            {
                if (x == 'd')
                {
                    Console.Write("Entre com o valor do depósito: ");
                    initdeposito = double.Parse(Console.ReadLine(), CI);
                    c.Deposito(initdeposito);
                    Console.WriteLine("Dados da conta: ");
                    Console.WriteLine(c);
                    Console.WriteLine();
                }
                else if (x == 's')
                {
                    Console.WriteLine("Saque tem uma taxa de R$ 5.00: ");
                    if (c.Saldo < 0)
                    {
                        Console.Write("Saldo insuficiente: " + c.Saldo.ToString("F2"));
                    }else
                    {
                        Console.Write("Entre com o valor para Saque: ");
                        initdeposito = double.Parse(Console.ReadLine(), CI);
                        if (initdeposito + 5 > c.Saldo)
                        {
                            Console.Write("Saldo insuficiente; " + c.Saldo.ToString("F2"));
                        }else
                        {
                            c.Saque(initdeposito);
                            
                            Console.WriteLine("Dados da conta: ");
                            Console.WriteLine(c);
                            Console.WriteLine();
                        }
                        
                    }
                    
                }
                else
                {
                    Console.Write("Erro! Operação invalida. ");
                }

                Console.WriteLine();
                Console.WriteLine("Voce deseja realizar um Saque ou Deposito? (s/d): ");
                Console.Write("Para encerrar aperte (n): ");
                x = char.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            Console.Write("Obrigado pela operação! ");


        }
    }
}
