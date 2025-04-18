using System.Globalization;

namespace ConversorMoedas
{
    public class ConversorDeMoeda 
    {
        public static double IOF = 6;
        
        public static double Calculo(double cotacao, double dolaresAComprar)
        {
           double valorIof = (IOF / 100) * (cotacao * dolaresAComprar);
           return dolaresAComprar * cotacao + valorIof;
        }

    }
    
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double dolaresAComprar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Valor a ser pago em reais = " + ConversorDeMoeda.Calculo(cotacao, dolaresAComprar)
                                                                .ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}
