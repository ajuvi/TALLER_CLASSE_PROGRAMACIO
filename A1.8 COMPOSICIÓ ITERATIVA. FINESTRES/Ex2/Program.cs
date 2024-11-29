using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string FILE_NAME = "CREIXENT.TXT";

            //variables
            StreamReader sr;
            string linia;
            int numActual=0;
            int numAnterior;
            bool trobat;

            //inicialitzacions
            sr = new StreamReader(FILE_NAME);
            trobat = false;

            //llegir finestra
            linia = sr.ReadLine();
            if (linia != null)
            {
                numActual = Convert.ToInt32(linia);
                linia = sr.ReadLine();
            }

            //cerca
            while(!trobat && linia != null)
            {

                //tractar l'element
                numAnterior = numActual;
                numActual = Convert.ToInt32(linia);

                trobat = numActual <= numAnterior;

                if (!trobat)
                {
                    linia = sr.ReadLine();
                }

            }

            //tractament final
            if (trobat)
            {
                Console.WriteLine("NO CREIXENT");
            } else
            {
                Console.WriteLine("CREIXENT");
            }



            Console.ReadKey();

        }
    }
}
