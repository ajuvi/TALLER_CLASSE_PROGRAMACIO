using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=20; i++)
            {
                Console.WriteLine($"NUMERO ITERACIÓ {i} = {i * 2}");
            }

            Console.ReadKey();
        }
    }
}
