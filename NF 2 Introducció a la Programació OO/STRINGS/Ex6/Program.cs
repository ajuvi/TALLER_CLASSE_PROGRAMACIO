using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string REGEX_EMAIL = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{1,}$";

            bool esValid;
            string email;

            do
            {
                Console.Write("ENTRA UN CORREU ELECTRONIC: ");
                email = Console.ReadLine();
                esValid = Regex.IsMatch(email, REGEX_EMAIL);

                if(!esValid)
                    Console.WriteLine("EL CORREU ÉS INCORRECTE.");

            } while (!esValid);

            Console.WriteLine("EL CORREU ÉS VÀLID!");

        }
    }
}
