using System.Globalization;

namespace ContaBancaria
{

    public class Conta
    {
        public string IdConta { get; private set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; private set; }

        public Conta(string idConta, string nomeTitular)
        {
            IdConta = idConta;
            NomeTitular = nomeTitular;
        }

        public Conta(string idConta, string nomeTitular, double depositoInicial) : this(idConta, nomeTitular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double valorDeposito)
        {
            Saldo += valorDeposito;
        }

        public void Saque(double valorSaque)
        {
            Saldo -= valorSaque;
            Saldo -= 5.0;
        }

        public override string ToString()
        {
            return "Conta " 
                + IdConta 
                + ", Titular: " 
                + NomeTitular 
                + ", Saldo: $ " 
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

        public class Program
        {
            static void Main(string[] args)
            {

                Conta conta;

                Console.Write("Entre o número de conta: ");
                string idConta = Console.ReadLine();

                Console.Write("Entre o titular da conta: ");
                string nomeTitular = Console.ReadLine();

                Console.Write("Haverá depósito inicial (s/n)? ");
                char resposta = char.Parse(Console.ReadLine());

                if (resposta == 's' || resposta == 'S')
                {
                    Console.Write("Entre o valor de depósito inicial: ");
                    double saldoInicial = double.Parse(Console.ReadLine());
                    conta = new Conta(idConta, nomeTitular, saldoInicial);
                }
                else
                {
                    conta = new Conta(idConta, nomeTitular);
                }


                Console.WriteLine();
                Console.WriteLine("Dados da conta: ");
                Console.WriteLine(conta);

                Console.WriteLine();
                Console.Write("Entre um valor para depósito: ");
                double deposito = double.Parse(Console.ReadLine());
                conta.Deposito(deposito);

                Console.WriteLine("Dados da conta atualizados:");
                Console.WriteLine(conta);
                Console.WriteLine();

                Console.Write("Entre um valor para saque: ");
                double saque = double.Parse(Console.ReadLine());
                conta.Saque(saque);

                Console.WriteLine("Dados da conta atualizados:");
                Console.WriteLine(conta);
            }
        }
    }
}