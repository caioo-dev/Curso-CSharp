﻿using System.Globalization;

namespace CadastroProdutos
{

    public class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto()
        {

        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set { 
                if (value != null && value.Length > 1)
                { 
                _nome = value; 
                }}
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto("TV", 500.00, 10);

            Console.WriteLine(produto.Nome);

            produto.Nome = "TV 4K";
            Console.WriteLine(produto.Nome);  

            //produto.Preco = 490.00, nao ira conseguir alterar pois so temos a propriedade de obter o preco
            Console.WriteLine(produto.Preco);
            Console.WriteLine(produto.Quantidade);

        }
    }
}
