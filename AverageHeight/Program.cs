using System.Globalization;

namespace AverageHeight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double[] heights = new double[N];
            double total = 0;
            for (int i = 0; i < N; i++)
            {
                heights[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                total += heights[i];
            }

            double average = total / N;

            Console.Write($"AVERAGE HEIGHT = {average.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
