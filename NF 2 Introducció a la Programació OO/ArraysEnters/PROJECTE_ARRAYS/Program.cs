using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECTE_ARRAYS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int mida;
            Console.Write("ENTRA UNA MIDA: ");
            mida = Convert.ToInt32(Console.ReadLine());

            int[] taula = GenerarTaula(mida);
            MostrarTaula(taula);
        }

        public static int[] GenerarTaula(int n)
        {
            Random rand = new Random();

            int[] t = new int[n];

            for (int i = 0; i < t.Length; i++)
            {
                t[i] = rand.Next(-100, 101);
            }

            return t;
        }

        public static void MostrarTaula(int[] taula)
        {
            for(int i = 0; i < taula.Length; i++)
            {
                int num = taula[i];
                Console.WriteLine($"INDEX {i}: {num}");
            }
        }

    }
}
