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
            List<string> noms = new List<string>(); 
            noms.Add("Anna"); 
            noms.Add("Marc"); 
            noms.Add("Anna");
            noms.Add("Manel");
            noms.Add("Anna");
            noms.Add("Marta");

            for (int i=0;i<noms.Count;i++)
                Console.Write(noms[i] + " ");

            Console.WriteLine();

            noms.Remove("Anna");

            foreach(string nom in noms)
                Console.Write(nom + " ");

            //EXEMPLE AMB PREDICATS
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5 }; 
            
            // Buscar el primer nombre parell
            //int parell = numeros.Find(x => x % 2 == 0);
            int parell = numeros.Find(item => item % 2 == 0);
            Console.WriteLine(parell); // 2 
            // Eliminar tots els senars
            numeros.RemoveAll(x => x % 2 != 0); // Només queden {2, 4} 

        }


    }
}
