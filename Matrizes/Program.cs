namespace Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*double[,] mat = new double[2, 3];

            Console.WriteLine(mat.Length);

            Console.WriteLine(mat.Rank);

            Console.WriteLine(mat.GetLength(0));
            Console.WriteLine(mat.GetLength(1));
            */

            int N = int.Parse(Console.ReadLine());

            int[,] arr = new int[N, N];

            for (int i = 0; i < N; i++)
            {

                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++)
                {
                    arr[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Main diagonal: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(arr[i, i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < N; i++)
            {

                for (int j = 0; j < N; j++)
                {
                    if (arr[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"Negative numbers: {count}");

        }
    }
}
