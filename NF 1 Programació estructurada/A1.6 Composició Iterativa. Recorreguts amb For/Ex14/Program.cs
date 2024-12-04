using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const string FILE_NAME = "tiquetsuper.txt";

            int totalProductes;
            double preuTiquet;
            string linia;
            string nom;
            double quantitat;
            double preu;
            StreamReader fTiquet;

            //inicialitzar
            fTiquet = new StreamReader(FILE_NAME);
            preuTiquet = 0;

            //llegir el total de productes

            //linia = fTiquet.ReadLine();
            //totalProductes = Convert.ToInt32(linia);
            totalProductes = Convert.ToInt32(fTiquet.ReadLine());

            for(int i = 1; i <= totalProductes; i++)
            {
                //llegir poducte
                nom = fTiquet.ReadLine();
                quantitat = Convert.ToDouble(fTiquet.ReadLine());
                preu = Convert.ToDouble(fTiquet.ReadLine());

                //tractar producte
                preuTiquet = preuTiquet + quantitat * preu;
            }

            fTiquet.Close();

            Console.WriteLine($"EL PREU DEL TIQUET ÉS {preuTiquet}");


            Console.ReadKey();

        }
    }
}
