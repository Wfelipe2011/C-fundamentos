using ConsoleApp3;
using System;
using System.Globalization;

namespace ConversaoDolar
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CI);
            Console.Write("Quantos dólares voce vai comprar? ");
            double qtd = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine("Valor a ser pago em reais com o IOF de 6% = " + ConversorDaMoeda.Conversor(cotacao, qtd).ToString("F2", CI));
        }
    }
}
