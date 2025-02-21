using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String linia = "Lionel;Messi;24/06/1987;67;1,7";
            char inicialNom = linia[0];

            Console.WriteLine($"PRIMER CARACTER: {inicialNom}");
        }
    }
}
