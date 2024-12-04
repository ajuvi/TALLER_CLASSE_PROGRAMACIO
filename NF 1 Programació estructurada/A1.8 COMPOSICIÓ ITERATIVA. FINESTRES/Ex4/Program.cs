using System;
using System.Collections.Generic;
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

            const string FILE_NAME = "MINIM_LOCAL1.TXT";

            //variables
            StreamReader sr;
            string linia;
            int numActual = 0;
            int num2 = 0;
            int num3 = 0;
            int contador;

            //inicilitzar
            sr = new StreamReader(FILE_NAME);
            contador = 0;

            //llegir finestra
            linia = sr.ReadLine();
            if (linia != null)
            {
                numActual = Convert.ToInt32(linia);
                linia = sr.ReadLine();
                if (linia != null)
                {
                    num2 = numActual;
                    numActual = Convert.ToInt32(linia);
                    linia = sr.ReadLine();
                }
            }

            while (linia != null)
            {
                //tractament de l'element
                num3 = num2;
                num2 = numActual;
                numActual = Convert.ToInt32(linia);

                if(num2<num3 && num2 < numActual)
                {
                    contador++;
                }

                linia = sr.ReadLine();
            }

            Console.WriteLine($"HI HA {contador} VALLS.");

            Console.ReadKey();

        }
    }
}
