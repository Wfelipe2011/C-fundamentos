using System;

namespace Sintaxe_Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Word: ");
            Console.WriteLine(" Math.Sqrt()- Raiz ");
            // Debug Break point, marcaçao F9
            // Debug Para iniciar F5 e F10 para ir proximo passo.
            // Debug O F11 ele entra dentro da funçao
            // As funçoes sao chamadas de metodos.
            // Reaproveitamento
            Console.WriteLine("--------------- ");
            Console.WriteLine("Digite 3 numeros: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3);

            Console.WriteLine("O maior é " + resultado);

        }

        static int Maior(int a, int b, int c)
        {// int ´t o tipo da funçao, Maior é nome. a, b, c sao os parametros
            int m;
            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;
        }





    }
}
