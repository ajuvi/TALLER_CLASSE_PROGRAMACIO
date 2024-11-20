using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primerNumero;
            int numeroActual;
            bool trobat;

            trobat = false;

            //llegir la primera linia
            primerNumero = Convert.ToInt32(Console.ReadLine());

            numeroActual = Convert.ToInt32(Console.ReadLine());
            while (!trobat && numeroActual!=-9999)
            {
                trobat = numeroActual == primerNumero;

                if (!trobat)
                {
                    numeroActual = Convert.ToInt32(Console.ReadLine());
                }

            }

            if (trobat)
            {
                Console.WriteLine("EL PRIMER VALOR ES REPTEIX");
            }
            else
            {
                Console.WriteLine("EL PRIMER VALOR NO ES REPETEIX");
            }


            Console.ReadKey();


        }
    }
}
