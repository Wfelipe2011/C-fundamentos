using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 8;
            int c = a;

            bool d = a > b;
            bool e = b != a;// B é Diferente de A

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(d);
            Console.WriteLine(e);

            Console.WriteLine("Digite dois numeros para fazer as comparaçoes");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            bool t = n1 > n2;
            

        }
    }
}
