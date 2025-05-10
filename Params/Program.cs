namespace Params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             int s1 = Calculadora.Sum(1, 2);
             int s2 = Calculadora.Sum(1, 2, 3);

             Console.WriteLine(1);
             Console.WriteLine(2);
            */

            // int result = Calculadora.Sum(new int[] { 10, 20, 30, 40 });
            
            
            int result = Calculadora.Sum(10, 20, 30, 40);

        }
    }

    class Calculadora
    {
        /* JEITO RUIM
        public static int Sum(int n1, int n2)
        {
            return n1 + n2;
        }
        public static int Sum(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }
        public static int Sum(int n1, int n2, int n3, int n4)
        {
            return n1 + n2 + n3 + n4;
        }
        */

        /* JEITO MAIS OU MENOS
        public static int Sum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        */

        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

    }
}
