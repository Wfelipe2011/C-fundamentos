using System;
using System.Globalization;

namespace Controle_Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            //CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade em Estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto : " + p );
            Console.WriteLine();

            Console.Write("Digite o numero a ser adicionado ao estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtd);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + p);
            Console.WriteLine();
            
            Console.Write("Digite o numero a ser removido do estoque: ");
            int rem = int.Parse(Console.ReadLine());
            
            p.RemoverProdutos(rem);
            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + p);

        }
    }
}
