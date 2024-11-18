using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const string FILE_NAME = "BONUS3.TXT";

            StreamReader fBonus;
            string linia;
            int numBillets;
            int bitlletsPremiats;
            int importTotal;

            fBonus = new StreamReader(FILE_NAME);
            importTotal = 0;
            bitlletsPremiats = 0;

            linia = fBonus.ReadLine();
            numBillets = Convert.ToInt32(linia);

            for(int i = 1; i <= numBillets; i++)
            {
                linia = fBonus.ReadLine();

                if (linia == "BONUS")
                {
                    bitlletsPremiats++;
                    importTotal = importTotal + Convert.ToInt32(fBonus.ReadLine());
                }
            }

            fBonus.Close();

            if (numBillets != 0)
            {
                Console.WriteLine($"BITLLETS PREMIATS: {bitlletsPremiats}");
                Console.WriteLine($"IMPORT TOTAL: {importTotal}");
                Console.WriteLine($"PERCENTATGE PREMIATS: {1.0 * bitlletsPremiats / numBillets * 100:0.00}%");
            } else
            {
                Console.WriteLine("NO HI HA CAP BITLLET EN EL FITXER");
            }

            Console.ReadKey();

        }
    }
}
