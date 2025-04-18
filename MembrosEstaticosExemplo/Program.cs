using System.Globalization;

namespace MembrosEstaticosExemplo
{

    public class Calculadora
    {
        public static double PI = 3.14;

        public static double Circunferencia(double raio)
        {
            return 2.0 * PI * raio;
        }

        public static double Volume(double raio)
        {
            return 4.0 / 3.0 * PI * Math.Pow(raio, 3);
        }

    }

    public class Program
    {

        //static double Pi = 3.14;

        static void Main(string[] args)
        {
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));

            double volume = Calculadora.Volume(raio);
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Valor de PI: " + Calculadora.PI.ToString("F2", CultureInfo.InvariantCulture));
        }

       /* static double Circunferencia(double raio)
        {
            return 2.0 * PI * raio;
        }

        static double Volume(double raio)
        {
            return 4.0 / 3.0 * PI * Math.Pow(raio, 3);
        }
       */
    }
}
