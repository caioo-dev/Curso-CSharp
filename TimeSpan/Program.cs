namespace TimeSpanTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
        /*TimeSpan t1 = new TimeSpan(0, 1, 30);
        TimeSpan t0 = new TimeSpan();
        TimeSpan t2 = new TimeSpan(900000000L);
        TimeSpan t3 = new TimeSpan(1, 2, 11, 21);
        TimeSpan t4 = new TimeSpan(1, 2, 11, 21, 321);

        Console.WriteLine(t1);
        Console.WriteLine(t1.Ticks);

        Console.WriteLine(t0);

        Console.WriteLine(t2);

        Console.WriteLine(t3);

        Console.WriteLine(t4);

        */
        /*Construtores
        • TimeSpan()
        • TimeSpan(ticks)
        • TimeSpan(horas, minutos, segundos)
        • TimeSpan(dias, horas, minutos, segundos)
        • TimeSpan(dias, horas, minutos, segundos, milissegundos)
        */

        /* TimeSpan t1 = TimeSpan.FromDays(1.5);
         TimeSpan t2 = TimeSpan.FromHours(1.5);
         TimeSpan t3 = TimeSpan.FromMinutes(1.5);
         TimeSpan t4 = TimeSpan.FromSeconds(1.5);
         TimeSpan t5 = TimeSpan.FromMilliseconds(1.5);
         TimeSpan t6 = TimeSpan.FromTicks(900000000L);

         Console.WriteLine(t1);
         Console.WriteLine(t2);
         Console.WriteLine(t3);
         Console.WriteLine(t4);
         Console.WriteLine(t5);
         Console.WriteLine(t6);
        */

            //Demo: MaxValue, MinValue, Zero

            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            //Demo - propriedades

            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);

            Console.WriteLine(t);
            Console.WriteLine("Days: " + t.Days);
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes);
            Console.WriteLine("Milliseconds: " + t.Milliseconds);
            Console.WriteLine("Seconds: " + t.Seconds);
            Console.WriteLine("Ticks: " + t.Ticks);
            Console.WriteLine("TotalDays: " + t.TotalDays);
            Console.WriteLine("TotalHours: " + t.TotalHours);
            Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);

            //Demo - operações

            TimeSpan t1 = new TimeSpan(1, 30, 10);
            TimeSpan t2 = new TimeSpan(0, 10, 5);
            TimeSpan sum = t1.Add(t2);
            TimeSpan dif = t1.Subtract(t2);
            TimeSpan mult = t2.Multiply(2.0);
            TimeSpan div = t2.Divide(2.0);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);
        }
    }
}
