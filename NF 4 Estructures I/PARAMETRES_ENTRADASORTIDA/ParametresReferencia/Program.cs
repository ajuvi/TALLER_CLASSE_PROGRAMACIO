using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametresReferencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            x = 30;
            y = 20;
            Console.WriteLine($"P1 => [{x}:{y}]");
            Swapp(ref x, ref y);
            Console.WriteLine($"P4 => [{x}:{y}]");
        }

        public static void Swapp(ref int a, ref int b)
        {
            Console.WriteLine($"P2 => [{a}:{b}]");
            int tmp = a;
            a = b;
            b = tmp;
            Console.WriteLine($"P3 => [{a}:{b}]");
        }
    }
}
