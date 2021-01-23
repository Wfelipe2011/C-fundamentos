using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Controle_Estoque
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;
        //public int MyProperty { get; set; }

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double ValorTotal()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
            // Quantidade = Quantidade + quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
            // Quantidade = Quantidade + quantidade;
        }




        public override string ToString()
        {
            return Nome + 
                " Preço: $" +Preco.ToString("F2", CultureInfo.InvariantCulture) +
                " Quantida em estoque: " + Quantidade +
                " Valor total do estoque: " + ValorTotal().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
