using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String linia = "Lionel;Messi;24/06/1987;67;1,7";
            char inicialCognom = linia.Split(';')[1][0];

            Console.WriteLine($"PRIMER CARACTER: {inicialCognom}");
        }
    }
}
