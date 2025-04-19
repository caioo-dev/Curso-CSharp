using System.Globalization;

namespace CadastroProdutos
{

    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto()
        {
            Quantidade = 10;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco) // referenciando o construtor com os argumentos nome e preco para não repetir codigos
        {
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco) : this() // referenciando o construtor padrao com a quantidade 10 para esse construtor
        {
            Nome = nome;
            Preco = preco;
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
            return Nome
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
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto produto = new Produto(nome, preco);

            Produto produto2 = new Produto();

            Produto produto3 = new Produto
            {
                Nome = "TV",
                Preco = 500.00,
                Quantidade = 20

            };

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + produto);

            Console.WriteLine();
            Console.Write("Você deseja adicionar mais produtos ao estoque? (S/N): ");
            char pergunta = char.Parse(Console.ReadLine());

            if (pergunta == 'N' || pergunta == 'n')
            {
                System.Environment.Exit(1);
            }

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(qte);

            Console.WriteLine("Dados atualizados: " + produto);

            Console.WriteLine();
            Console.Write("Você deseja remover produtos do estoque? (S/N): ");
            pergunta = char.Parse(Console.ReadLine());

            if (pergunta == 'N' || pergunta == 'n')
            {
                System.Environment.Exit(1);
            }

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(qte);

            Console.WriteLine("Dados atualizados: " + produto);
        }
    }
}
