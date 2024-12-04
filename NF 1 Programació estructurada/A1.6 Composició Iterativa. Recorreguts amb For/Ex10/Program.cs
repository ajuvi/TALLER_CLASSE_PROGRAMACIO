using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador;

            contador = 0;

            for (int i = 0; i <= 300; i=i+4)
            {
                Console.WriteLine($"NUMERO {i}");
                contador++;

                if (contador % 20 == 0)
                {
                    Console.ReadKey();
                    Console.Clear();
                }
            }




            Console.ReadKey();

        }
    }
}
