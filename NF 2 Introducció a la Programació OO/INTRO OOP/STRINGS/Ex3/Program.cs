using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String linia = "Lionel;Messi;24/06/1987;67;1,7";

            String[] parts = linia.Split(';');
            String data = parts[2];

            string nom = parts[0];
            int mes = Convert.ToInt32(data.Split('/')[1]);
            int any = Convert.ToInt32(data.Split('/')[2]);

            Console.WriteLine($"NOM: {nom}");
            Console.WriteLine($"MES NAIXAMENT: {mes}");
            Console.WriteLine($"ANY NAIXAMENT: {any}");

        }
    }
}
