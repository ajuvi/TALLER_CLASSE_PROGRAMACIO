using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, total;

            total = 0;

            for (int i = 1; i <= 10; i++) {
                Console.Write("ENTRA UN NÚMERO: ");
                num = Convert.ToInt32(Console.ReadLine());
                total = total + num;
            }

            Console.WriteLine($"LA SUMA DELS NÚMEROS ÉS {total}");


        }
    }
}
