using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MostrarTaula(1);
            //MostrarTaula(2);
            //MostrarTaula(3);
            //MostrarTaula(4);

            for(int i = 0; i <= 10; i++)
            {
                MostrarTaula(i);
            }

            Console.ReadKey();
        }

        public static void MostrarTaula(int numTaula)
        {
            Console.WriteLine($"TAULA MULTIPLICAR {numTaula}");
            Console.WriteLine("---");

            for(int i=1;i<=10;i++)
                Console.WriteLine($"{numTaula}x{i}={numTaula*i}");
        }



    }
}
