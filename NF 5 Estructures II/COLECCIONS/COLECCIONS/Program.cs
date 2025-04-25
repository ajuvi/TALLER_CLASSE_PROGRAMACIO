using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COLECCIONS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //EXEMPLE AMB LA CLASSE LIST
            //------------------------------
            List<string> noms = new List<string>();
            noms.Add("Anna");
            noms.Add("Marc");
            noms.Add("Anna");
            noms.Add("Manel");
            noms.Add("Anna");
            noms.Add("Marta");

            for (int i = 0; i < noms.Count; i++)
                Console.Write(noms[i] + " ");

            Console.WriteLine();

            noms.Remove("Anna");

            foreach (string nom in noms)
                Console.Write(nom + " ");

            //EXEMPLE AMB PREDICATS
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };

            // Buscar el primer nombre parell
            //int parell = numeros.Find(x => x % 2 == 0);
            int parell = numeros.Find(item => item % 2 == 0);
            Console.WriteLine(parell); // 2 
            // Eliminar tots els senars
            numeros.RemoveAll(x => x % 2 != 0); // Només queden {2, 4} 


            //EXEMPLE AMB HashSet. Conjunt que no accepta elements dublicats (Equals)
            //------------------------------
            HashSet<string> noms2 = new HashSet<string>();
            noms2.Add("Anna"); //retorna true
            noms2.Add("Marc"); //retorna true
            noms2.Add("Anna"); //retorna false perquè no s'afageix doncs hi ha un altre element que és "Equals"
            noms2.Add("Manel");
            noms2.Add("Anna");
            noms2.Add("Marta");

            if (noms2.Add("Anna"))
                Console.WriteLine("S'HA AFEGIT Anna!");
            else
                Console.WriteLine("NO S'HA AFEGIT Anna!");

            Console.WriteLine(noms2.Count);

            //EXEMPLE AMB HashSet amb cercles. Conjunt que no accepta elements dublicats (Equals)
            //------------------------------
            Point p1 = new Point(3, 3);
            Circle c1 = new Circle(p1, 55);
            Point p2 = new Point(3, 3);
            Circle c2 = new Circle(p2, 55);
            Circle c3 = new Circle(p2, 88);

            // Comparació amb Equals
            if (c1.Equals(c2)) // SÍ
                Console.WriteLine("c1 i c2 són iguals.");
            
            // Conjunt amb cercles (no es permeten duplicats)
            HashSet<Circle> cercles = new HashSet<Circle>();
            cercles.Add(c1);
            cercles.Add(c2);
            cercles.Add(c3);

            // Comprovar si un cercle "equivalent" ja hi és
            if (cercles.Contains(c2)) // SÍ
                Console.WriteLine("La llista conté un cercle equivalent a c2.");


            //EXEMPLE AMB Diccionari. Porra final Copa Rei
            //------------------------------

            Dictionary<string, string> porra = new Dictionary<string, string>();

            porra.Add("Artur", "3-2");
            porra.Add("Sergi", "4-1");
            porra.Add("Roger", "3-0");
            
            //afegint amb indexador
            porra["Nahuel"] = "0-2";
            porra["Ioan"] = "5-0";
            porra["Balraj"] = "7-0";

            //QUINA ÉS L'APOSA D'EN BALRAJ?
            string aposta = porra["Balraj"];
            Console.WriteLine($"PORRA BALRAJ: {aposta}");
 
            porra["Balraj"]="10-0";
            Console.WriteLine($"PORRA BALRAJ: {porra["Balraj"]}");
        }

    }
}
