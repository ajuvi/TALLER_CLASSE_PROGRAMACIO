using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int suma;

            Console.Write("ENTRA UN NUMERO: ");
            num = Convert.ToInt32(Console.ReadLine());

            suma = 0;

            for (int i=1; i<=num/2;i++)
            {
                if (num % i == 0)
                {
                    suma = suma + i;
                }
            }

            if(suma==num)
                Console.WriteLine("ES PERFECTE");
            else
                Console.WriteLine("NO ES PERFECTE");




            Console.ReadKey();

        }


    }
}


/* Possible solucióm amb cerca
 
        static void Main(string[] args)
        {
            int num, pos, suma;

            Console.Write("ENTRA UN NÚMERO: ");
            num = Convert.ToInt32(Console.ReadLine());

            suma = 0;
            pos = 1;

            while (suma<=num && pos<=num/2) {
                if (num % pos == 0)
                    suma = suma + pos;

                pos++;
            }

            if (suma==num)
                Console.WriteLine("ÉS PERFECTE!");
            else
                Console.WriteLine("NO ÉS PERFECTE.");
        }


*/


