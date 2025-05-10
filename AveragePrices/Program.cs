namespace AveragePrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
                       
            int N = int.Parse(Console.ReadLine());

            Product[] vect = new Product[N];

            for (int i = 0; i < N; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
                vect[i] = new Product(name, price);
            }

            double sum = 0.0;
            for (int i = 0; i < N; i++)
            {
                sum += vect[i].Price;
            }

            double avg = sum / N;
            Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2", System.Globalization.CultureInfo.InvariantCulture));

        }

    }

    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
