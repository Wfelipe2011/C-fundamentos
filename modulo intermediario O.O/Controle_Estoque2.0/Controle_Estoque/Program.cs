using System;
using System.Globalization;

namespace Controle_Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CI);

            Console.Write("Quantidade em Estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);

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
