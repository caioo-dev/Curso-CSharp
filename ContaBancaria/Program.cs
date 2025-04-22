using System.ComponentModel;
using System.Globalization;

namespace ContaBancaria
{

    public class Conta
    {
        public string IdConta { get; }
        public string NomeTitular { get; private set; }
        public double Saldo { get; private set; }

        public Conta(string idConta, string nomeTitular, double saldo)
        {
            IdConta = idConta;
            NomeTitular = nomeTitular;
            Saldo = saldo;
        }

        public Conta(string idConta, string nomeTitular)
        {
            IdConta = idConta;
            NomeTitular = nomeTitular;
        }

        public void Deposito(double valorDeposito)
        {
            Saldo += valorDeposito;
        }

        public void Saque(double valorSaque)
        {
            Saldo -= valorSaque + 5;
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
                Console.Write("Entre o número de conta: ");
                string IdConta = Console.ReadLine();

                Console.Write("Entre o titular da conta: ");
                string NomeTitular = Console.ReadLine();

                Console.Write("Haverá depósito inicial (s/n)? ");
                char Resposta = char.Parse(Console.ReadLine());

                double SaldoInicial = 0.0;
                if (Resposta == 's')
                {
                    Console.Write("Entre o valor de depósito inicial: ");
                    SaldoInicial = double.Parse(Console.ReadLine());
                }

                Conta conta = new Conta(IdConta, NomeTitular, SaldoInicial);

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