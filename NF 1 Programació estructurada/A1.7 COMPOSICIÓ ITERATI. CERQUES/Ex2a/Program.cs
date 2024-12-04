using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string FILE_NAME = "NUMEROS.TXT";

            StreamReader fNumeros;
            string linia;
            int primerNumero;
            int numeroActual;
            bool trobat;

            fNumeros = new StreamReader(FILE_NAME);
            trobat = false;
            
            //llegir la primera linia
            linia = fNumeros.ReadLine();
            primerNumero = Convert.ToInt32(linia);

            linia = fNumeros.ReadLine();
            while (!trobat && linia!=null)
            {
                numeroActual = Convert.ToInt32(linia);
                trobat = numeroActual == primerNumero;

                linia = fNumeros.ReadLine();
            }

            if (trobat)
            {
                Console.WriteLine("EL PRIMER VALOR ES REPTEIX");
            } else
            {
                Console.WriteLine("EL PRIMER VALOR NO ES REPETEIX");
            }






        }
    }
}
