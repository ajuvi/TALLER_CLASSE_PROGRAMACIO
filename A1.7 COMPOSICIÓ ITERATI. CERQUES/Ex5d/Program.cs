using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string FILE_NAME = "PERFECTES.TXT";

            StreamReader sr;
            string linia;
            int numActual;
            bool trobat;

            sr = new StreamReader(FILE_NAME);
            trobat = false;

            linia = sr.ReadLine();

            while(!trobat && linia != null)
            {
                numActual = Convert.ToInt32(linia);
                trobat = EsPerfecte(numActual);

                if(!trobat)
                    linia = sr.ReadLine();
            }

            if(trobat)
                Console.WriteLine("HI HA ALMENYS UN NUMERO PERFECTE");
            else
                Console.WriteLine("NO HI HA CAP NUMERO PERFECTE");
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
