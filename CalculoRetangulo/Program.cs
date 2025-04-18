using System.Globalization;

namespace CalculoRetangulo
{

    public class Retangulo
    {
        public double Largura;
        public double Altura;

        public double CalcularArea()
        {
            return Largura * Altura;
        }

        public double CalcularPerimetro()
        {
            return 2 * (Largura +  Altura);
        }

        public double CalcularDiagonal()
        {
            return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = " + retangulo.CalcularArea().ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("PERIMETRO = " + retangulo.CalcularPerimetro().ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("DIAGONAL = " + retangulo.CalcularDiagonal().ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}
