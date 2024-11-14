using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemples
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //EXEMPLE 1
            for (int i = 1; i <= 20; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //EXEMPLE 2
            for (int i = 1; i <= 20; i++)
                Console.Write(i + " ");

            Console.WriteLine();

            //EXEMPLE 3
            for (int i = 1; i <= 20; i=i+1)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            //EXEMPLE 3
            int num = 20;

            for (int i = 1; i <= num; i++)
            {
                Console.Write(i + " ");
            }

            //EXEMPLE 4
            for (int i = 20; i >= 1; i--)
            {
                //Console.Write(i + " ");
                Console.Write($"i  ");
            }

        }
    }
}


