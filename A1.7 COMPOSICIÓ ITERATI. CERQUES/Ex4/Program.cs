using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string FILE_NAME = "NUMEROS.TXT";

            StreamReader fNumeros;
            string linia;
            int target;
            int pos;
            int numActual;
            bool trobat;

            Console.Write("ENTRA UN NUMERO A CERCAR: ");
            target = Convert.ToInt32(Console.ReadLine());

            fNumeros = new StreamReader(FILE_NAME);
            pos = 0;
            trobat = false;
            linia = fNumeros.ReadLine();

            while(!trobat && linia != null)
            {
                //tractar element
                numActual = Convert.ToInt32(linia);
                trobat = numActual == target;
                pos++;

                //llegir el següent
                if (!trobat) {
                    linia = fNumeros.ReadLine();
                }
            }

            if (trobat)
                Console.WriteLine($"LINIA {pos}");
            else
                Console.WriteLine("LINIA -1");



            Console.ReadKey();

        }
    }
}
