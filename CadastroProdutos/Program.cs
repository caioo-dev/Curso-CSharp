﻿using System.Globalization;

namespace CadastroProdutos
{

    public class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto()
        {

        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
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

        public double Preco
        {
            get { return _preco; }
        }

        public int Quantidade
        {
            get { return _quantidade; }
        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome
                + ", $ "
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
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
