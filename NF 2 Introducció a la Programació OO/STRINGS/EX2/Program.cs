using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String linia = "34;44;12;11;99;55;5;0;11;34;32";
            int suma = 0;
            //int contador;
            double mitjana;

            String[] parts = linia.Split(';');
            
            for(int i = 0; i < parts.Length; i++)
            {
                suma = suma + Convert.ToInt32(parts[i]); 
            }

            mitjana = 1.0 * suma / parts.Length;

            Console.WriteLine($"LA MITJANA ÉS {mitjana}");







        }
    }
}
