using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TEST_EFICIENCIA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const long N = 10;

            DateTime date1, date2;
            TimeSpan interval;

            date1 = DateTime.Now;
            SumaAcumulada1(N);
            date2 = DateTime.Now;
            // Calculate the interval between the two dates.
            interval = date2 - date1;
            Console.WriteLine("SUMA1: {0} - {1} = {2}", date2, date1, interval.ToString());
            Console.WriteLine("   {0,-35} {1,20:N0}", "Total Number of Milliseconds:", interval.TotalMilliseconds);
            Console.WriteLine("   {0,-35} {1,20:N0}", "Ticks:", interval.Ticks);

            date1 = DateTime.Now;
            SumaAcumulada2(N);
            date2 = DateTime.Now;
            // Calculate the interval between the two dates.
            interval = date2 - date1;
            Console.WriteLine("SUMA2: {0} - {1} = {2}", date2, date1, interval.ToString());
            Console.WriteLine("   {0,-35} {1,20:N0}", "Total Number of Milliseconds:", interval.TotalMilliseconds);
            Console.WriteLine("   {0,-35} {1,20:N0}", "Ticks:", interval.Ticks);

        }
        static long SumaAcumulada1(long n)
        {
            long suma = 0;
            for (long i = 1; i <= n; i++)
            {
                suma += i;
            }
            return suma;
        }

        static long SumaAcumulada2(long n)
        {
            return n * (n + 1) / 2;
        }

    }
}
