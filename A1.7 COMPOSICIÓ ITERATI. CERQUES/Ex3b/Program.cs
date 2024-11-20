using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroActual;
            bool trobat;

            trobat = false;

            //llegir el primer número
            Console.Write("ENTRA UN NUMERO: ");
            numeroActual = Convert.ToInt32(Console.ReadLine());

            while (!trobat && numeroActual != -9999)
            {
                trobat = numeroActual % 2 == 0;

                if (!trobat)
                {
                    Console.Write("ENTRA UN NUMERO: ");
                    numeroActual = Convert.ToInt32(Console.ReadLine());
                }

            }

            if (trobat)
                Console.WriteLine("HI HA ALGUN NUMERO PARELL");
            else
                Console.WriteLine("NO HI HA CAP NUMERO PARELL");


            Console.ReadKey();
        }
    }
}
