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

            int[] taula2 = new int[6] { 2,8,5,6,2,8};
            
            double mitjana = Average(taula2);
            Console.WriteLine(mitjana);

            int pos;
            pos = IndexOf(taula2, 8);
            Console.WriteLine($"POSICIO DEL 8: {pos}");
            pos = IndexOf(taula2, 5);
            Console.WriteLine($"POSICIO DEL 5: {pos}");
            pos = IndexOf(taula2, 9);
            Console.WriteLine($"POSICIO DEL 9: {pos}");
            Console.WriteLine(DistinctValues(taula2));

        }

        public static List<int> GetDistinctValues(int[] t)
        {
            List<int> llista = new List<int>();
            //int contador = 0;

            for (int index = 0; index < t.Length; index++)
            {
                if (!Contains(t, t[index], 0, index - 1))
                {
                    //contador++;
                }
            }

            return llista;
        }

        public static int DistinctValues(int[] t)
        {
            int contador = 0;

            for(int index = 0; index < t.Length; index++)
            {
                if (!Contains(t, t[index],0,index-1))
                {
                    contador++;
                }
            }

            return contador;
        }

        public static bool Contains(int[] t, int valor, int indexFrom, int indexTo)
        {
            int index = indexFrom;
            bool trobat = false;

            while (!trobat && index <= indexTo)
            {
                if (t[index] == valor)
                {
                    trobat = true;
                } else
                {
                    index++;
                }

                //trobat = t[index] == valor;
                //if (!trobat)
                //    index++;
            }

            return trobat;
        }

        public static bool Contains(int[] t, int valor)
        {
            return IndexOf(t, valor) != -1;
        }

        public static double Average(int[] t)
        {
            int suma = 0;
            for(int i = 0; i < t.Length; i++)
            {
                suma = suma + t[i];
            }

            //falta calcular i retornar la mitjana
            return 1.0 * suma / t.Length;
            
        }

        public static int IndexOf(int[] t, int valor)
        {
            bool trobat = false;
            int pos = 0;

            while(!trobat && pos < t.Length)
            {
                trobat = t[pos] == valor;
                if (!trobat) pos++;
            }

            if (trobat) 
                return pos;
            else 
                return -1;

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
