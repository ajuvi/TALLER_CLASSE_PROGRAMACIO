using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRINGS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String linia = "34;44;12;11;99;55;5;0;11;34;32";
            int firstNumber;
            int lastNumber;

            String[] parts = linia.Split(';');
            firstNumber = Convert.ToInt32(parts[0]);
            //lastNumber = Convert.ToInt32(parts[10]);
            //lastNumber = Convert.ToInt32(parts[11-1]);
            lastNumber = Convert.ToInt32(parts[parts.Length-1]);

            Console.WriteLine(linia);
            Console.WriteLine($"PRIMER NUMERO: {firstNumber}");
            Console.WriteLine($"ÚLTIM NUMERO: {lastNumber}");


        }
    }
}
