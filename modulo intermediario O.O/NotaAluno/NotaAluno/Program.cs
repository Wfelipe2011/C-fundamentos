using System;
using System.Globalization;

namespace NotaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            double n1, n2, n3, media;
            Console.Write("Nome do aluno: ");
            string x = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            n1 = double.Parse(Console.ReadLine(), CI);
            n2 = double.Parse(Console.ReadLine(), CI);
            n3 = double.Parse(Console.ReadLine(), CI);

            media = Media.NotaMedia(n1, n2, n3);

            Console.WriteLine("Nota Final = " + media.ToString("F2"), CI);
            Console.WriteLine(Media.Situacao(media));
        }
    }
}
