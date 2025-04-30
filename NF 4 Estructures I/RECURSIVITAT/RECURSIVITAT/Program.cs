using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECURSIVITAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Saluda();
            Saluda(10);
        }

        public static void Saluda()
        {
            Console.WriteLine("Hola DAM-DAW-A");
            Saluda();
        }

        public static void Saluda(int num)
        {
            if (num > 0) Saluda(num - 1);
            Console.WriteLine($"NUM ->{num}");
        }

    }
}
