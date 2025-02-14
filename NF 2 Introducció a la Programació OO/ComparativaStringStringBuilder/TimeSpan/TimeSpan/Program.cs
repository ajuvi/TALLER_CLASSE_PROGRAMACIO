using System;
using System.Text;
namespace Prova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            DateTime date1 = DateTime.Now;

            for (int i = 0; i < 100000; i++) str = str + i.ToString();

            DateTime date2 = DateTime.Now;

            // Calculate the interval between the two dates.
            TimeSpan interval = date2 - date1;
            Console.WriteLine("{0} - {1} = {2}", date2, date1, interval.ToString());

            // Display individual properties of the resulting TimeSpan object.
            
            
            Console.WriteLine("   {0,-35} {1,20:N0}", "Total Number of Milliseconds:", interval.TotalMilliseconds);
            Console.WriteLine("   {0,-35} {1,20:N0}", "Ticks:", interval.Ticks);
            date1 = DateTime.Now;
            StringBuilder sB = new StringBuilder();
            for (int i = 0; i < 100000; i++) sB.Append(i);    
            date2 = DateTime.Now;
            interval = date2 - date1;
            
            Console.WriteLine("   {0,-35} {1,20:N0}", "Total Number of Milliseconds:", interval.TotalMilliseconds);
            Console.WriteLine("   {0,-35} {1,20:N0}", "Ticks:", interval.Ticks);
        }
    }
}
