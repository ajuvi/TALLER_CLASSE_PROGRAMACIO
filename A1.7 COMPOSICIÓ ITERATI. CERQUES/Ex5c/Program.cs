using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string FILE_NAME = "PERFECTES.TXT";

            StreamReader sr;
            string linia;
            int numeroActual;

            sr = new StreamReader(FILE_NAME);
            linia = sr.ReadLine();

            while(linia != null)
            {
                numeroActual = Convert.ToInt32(linia);
                
                if(EsPerfecte(numeroActual))
                    Console.WriteLine($"EL NUMERO {numeroActual} ES PERFECTE");
                else Console.WriteLine($"EL NUMERO {numeroActual} NO ES PERFECTE");

                linia = sr.ReadLine();
            }

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
