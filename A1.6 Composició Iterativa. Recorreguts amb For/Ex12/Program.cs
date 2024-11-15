using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CultureInfo.CurrentCulture = new CultureInfo("en-us");            

            const string FILE_NAME = "coordenades2.txt";

            //variables
            StreamReader fPunts;
            string linia;
            double radi, dist;
            double x, y;
            int numPunts;

            Console.Write("ENTRA EL RADI: ");
            radi = Convert.ToDouble(Console.ReadLine());

            //inicialitzar variables
            fPunts = new StreamReader(FILE_NAME); 
            
            //llegir el nombre de punts
            numPunts = Convert.ToInt32(fPunts.ReadLine());

            for(int i = 1; i <= numPunts; i++)
            {
                //llegir un element
                x = Convert.ToDouble(fPunts.ReadLine());
                y = Convert.ToDouble(fPunts.ReadLine());

                //tractar l'element
                dist = Distancia(x,y);

                if(dist>radi)
                    Console.WriteLine($"EL PUNT ({x},{y}) ESTA A FORA");
                else if(dist==radi)
                    Console.WriteLine($"EL PUNT ({x},{y}) ESTA SOBRE EL PERIMETRE");
                else
                    Console.WriteLine($"EL PUNT ({x},{y}) ESTA A DINS");
            }

            fPunts.Close();

            Console.ReadKey();
        }

        public static double Distancia(double px, double py)
        {
            return Math.Sqrt(px * px + py * py);
        }
    }
}
