using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECTE_ARRAYS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int mida;
            Console.Write("ENTRA UNA MIDA: ");
            mida = Convert.ToInt32(Console.ReadLine());

            int[] taula = new int[mida];

            //emplenar l'array
            for(int i = 0; i < taula.Length; i++)
            {
                taula[i] = rand.Next(-100, 101);
            }

            //mostrar els valors de l'array
            Console.Write("[ ");
            for(int i =0; i < taula.Length; i++)
            {
                Console.Write(taula[i] + " ");
            }
            Console.WriteLine("]");
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

    }
}
