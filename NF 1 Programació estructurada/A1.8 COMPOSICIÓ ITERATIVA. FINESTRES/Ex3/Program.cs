using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string FILE_NAME = "MINIM_LOCAL2.TXT";

            //variables
            StreamReader sr;
            string linia;
            int numActual=0;
            int num2=0;
            int num3=0;
            bool trobat;

            //inicilitzar
            sr = new StreamReader(FILE_NAME);
            trobat = false;

            //llegir finestra
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
                //tractar element
                num3 = num2;
                num2 = numActual;
                numActual = Convert.ToInt32(linia);

                trobat = num2 < num3 && num2 < numActual;

                if (!trobat)
                {
                    linia = sr.ReadLine();
                }
            }

            //tractament final
            if(trobat)
                Console.WriteLine("HI HA ALMENYS UNA VALL");
            else
                Console.WriteLine("NO HI HA CAP VALL");


            Console.ReadKey();

        }
    }
}
