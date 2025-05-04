namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p;
            Console.WriteLine(p); // erro: variável não atribuída
            p.x = 10;
            p.y = 20;
            Console.WriteLine(p);
            p = new Point();
            Console.WriteLine(p);
        }
    }
}
