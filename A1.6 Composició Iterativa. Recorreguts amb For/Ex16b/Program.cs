using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string linia;
            int n;

            Console.Write("ENTRA UN NUMERO: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                //generar una línia de longitud 'i'
                linia = GenerarLinia('*', i);
                Console.WriteLine(linia);
            }

            Console.ReadKey();
        }

        public static string GenerarLinia(char car, int longitud)
        {
            string str;
            str = "";

            for (int i = 1; i <= longitud; i++)
            {
                str = str + car;
            }

            return str;
        }
    }
}
