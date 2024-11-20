using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string FILE_NAME = "NUMEROS.TXT";

            StreamReader sr;
            string linia;
            int numeroActual;
            bool trobat;

            sr = new StreamReader(FILE_NAME);
            trobat = false;

            //llegir el primer número
            linia = sr.ReadLine();
            while (!trobat && linia != null)
            {
                numeroActual = Convert.ToInt32(linia);
                trobat = numeroActual % 2 == 0;

                linia = sr.ReadLine();
                
            }

            sr.Close();

            if (trobat)
                Console.WriteLine("HI HA ALGUN NUMERO PARELL");
            else
                Console.WriteLine("NO HI HA CAP NUMERO PARELL");
        }
    }
}
