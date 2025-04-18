using System.Globalization;

namespace Aluno
{

    public class Aluno
    {
        public string Nome;
        public double[] notas = new double[3];

        public double NotaFinal()
        {
            return notas[0] + notas[1] + notas[2];
        }

        public bool Aprovado()
        {
            if (NotaFinal() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - NotaFinal();
            }
        }

    }

    public class Program
    {
        static void Main(string[] args)
        {

            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as 3 notas do aluno: ");
            aluno.notas[0] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.notas[1] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.notas[2] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("NOTA FINAL = " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();

            if (aluno.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM "
                + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)
                + " PONTOS");
            }

            /* if (aluno.NotaFinal() < 60.00)
             {
                 Console.WriteLine("REPROVADO");
                 Console.WriteLine("FALTARAM " + Math.Abs(aluno.NotaFinal() - 60)
                     .ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
             }
             else 
             {
                 Console.WriteLine("APROVADO");
             }
            */

        }
    }
}
