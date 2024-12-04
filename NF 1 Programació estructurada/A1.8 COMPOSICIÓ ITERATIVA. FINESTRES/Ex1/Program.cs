using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string FILE_NAME = "NUMEROS2.TXT";

            //variables
            StreamReader sr;
            string linia;
            bool trobat;

            int numActual=0;
            int num2=0;
            int num3=0;

            //inicialitzacions
            sr = new StreamReader(FILE_NAME);
            trobat = false;

            //llegir elements de la finestra
            linia = sr.ReadLine();
            if(linia != null)
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

            while (!trobat && linia != null)
            {
                //tractar l'element
                num3 = num2;
                num2 = numActual;
                numActual = Convert.ToInt32(linia);

                if (numActual == num3 + num2)
                {
                    trobat = true;
                }
                else
                {
                    linia = sr.ReadLine();
                }
            }

            if (trobat)
            {
                Console.WriteLine($"S'HA TROBAT LA CONDICIÓ: {num3}+{num2}={numActual}");
            } else
            {
                Console.WriteLine("NO S'HA TROBAT CAP CONDICIÓ");
            }




            Console.ReadKey();


        }
    }
}
