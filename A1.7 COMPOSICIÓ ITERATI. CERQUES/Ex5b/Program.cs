using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("ENTRA UN NUMERO: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (EsPerfecte(num))
                Console.WriteLine("ES PERFECTE");
            else
                Console.WriteLine("NO ES PERFECTE");

            Console.ReadKey();
        }


        public static bool EsPerfecte(int n)
        {
            int suma;
            suma = 0;

            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                    suma = suma + i;
            }

            return suma == n;
        }
    }
}
