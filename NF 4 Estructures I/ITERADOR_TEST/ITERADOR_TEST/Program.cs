using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ITERADOR_TEST
{
    internal class Program
    {
        static void Main(string[] args)
        {

            foreach(int num in NextValue(0, 10))
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();

            IEnumerator<int> iterador = NextValue(0, 10).GetEnumerator();
            while (iterador.MoveNext())
            {
                Console.Write(iterador.Current + " ");
            }

        }

        public static IEnumerable<int> NextValue(int inici, int final)
        {
            if (inici > final)
                throw new Exception();

            int num = inici;
            while (num<final)
            {
                num++;
                yield return num;
            }

        }

    }
}
