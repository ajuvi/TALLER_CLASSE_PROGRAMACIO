using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametresSortida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] m = { 4, 5, 6, 7, 1, 8, 99, -1, 2 };
            int min, max;
            MinMax(m, out min, out max);
            Console.WriteLine($"MINIM: {min}");
            Console.WriteLine($"MAXIM: {max}");
        }

        public static void MinMax(int[] t, out int min, out int max)
        {
            if (t == null || t.Length == 0)
                throw new ArgumentException("L'ARRAY NO POT ESTAR BUIT");

            min = t[0];
            max = t[0];
            for (int i = 0; i < t.Length; i++)
            {
                if (min > t[i]) min = t[i];
                if (max < t[i]) max = t[i];
            }
        }

    }
}
