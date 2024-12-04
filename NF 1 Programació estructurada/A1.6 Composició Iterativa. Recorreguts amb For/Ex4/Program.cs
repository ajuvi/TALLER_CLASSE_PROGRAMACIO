using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n1, n2;

            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());

            for (int i = n1; i <= n2; i++)
            {
                if (i%7!=0)
                { 
                    Console.WriteLine($"NUMERO: {i}");
                }

            }

            Console.ReadLine();

        }
    }
}
