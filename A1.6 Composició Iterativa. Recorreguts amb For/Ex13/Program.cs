using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string FILE_NAME = "Girona lliga23_24_v2.txt";

            int numeroJornades;
            string linia;
            int golsGirona, golsContrari;
            StreamReader fJornades;
            int guanyats, empatats, perduts;

            fJornades = new StreamReader(FILE_NAME);
            guanyats = 0;
            empatats = 0;
            perduts = 0;

            linia = fJornades.ReadLine();
            numeroJornades = Convert.ToInt32(linia);

            //for(int i = 1; i <= numeroJornades; i++)
            for(int i = 0; i < numeroJornades; i++)
            {
                //llegir gols
                golsGirona = Convert.ToInt32(fJornades.ReadLine());
                golsContrari = Convert.ToInt32(fJornades.ReadLine());

                if (golsGirona > golsContrari)
                    guanyats++;
                else if (golsGirona == golsContrari)
                    empatats++;
                else
                    perduts++;
            }

            fJornades.Close();

            Console.WriteLine($"PARTITS GUANYATS: {guanyats}");
            Console.WriteLine($"PARTITS EMPATATS: {empatats}");
            Console.WriteLine($"PARTITS PERDUTS: {perduts}");
            Console.WriteLine($"PUNTS: {guanyats*3+empatats}");

            Console.ReadKey();

        }
    }
}
