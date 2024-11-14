using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma, num;

            suma = 0;

            Console.Write("ENTRA UN NÚMERO: ");
            num = Convert.ToInt32(Console.ReadLine());

            /*for (int i = 1; i <= num; i++)
                suma = suma + i;

            Console.WriteLine(suma);
            */

            Console.WriteLine(num*(num+1)/2);

        }
    }
}
