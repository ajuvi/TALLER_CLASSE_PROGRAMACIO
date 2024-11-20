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
