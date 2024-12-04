using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(int.MaxValue);
            Console.WriteLine(long.MaxValue);


            int producte, num;

            producte = 1;

            Console.Write("ENTRA UN NÚMERO: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
                producte = producte * i;

            Console.WriteLine(producte);


            Console.ReadKey();
        }
    }
}
