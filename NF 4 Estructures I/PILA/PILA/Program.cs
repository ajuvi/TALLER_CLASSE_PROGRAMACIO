using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PILA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nDEMO 1 - PUSH - PEEK - POP\n-----------");

            Pila<int> p = new Pila<int>(50);

            for (int i = 1; i <= 10; i++)
                p.Push(i);

            Console.WriteLine(p.Peek());
            Console.WriteLine(p.Peek());

            while (!p.IsEmpty)
            {
                int valor = p.Pop();
                Console.Write(valor + " ");
            }

            //DEMO 2 -Foreach
            Console.WriteLine("\n\nDEMO 2 - FOREACH\n-----------");

            Pila<int> pila2 = new Pila<int>(20);
            for (int i = 51; i <= 60; i++)
                pila2.Push(i);

            foreach (int num in pila2)
            {
                Console.Write(num + " ");
            }

            //DEMO 3 - Iterador
            Console.WriteLine("\n\nDEMO 3 - GETENUMERATOR - ITERADOR\n-----------");

            Pila<int> pila3 = new Pila<int>(20);
            for (int i = 51; i <= 60; i++)
                pila3.Push(i);

            IEnumerator<int> iterador = pila3.GetEnumerator();

            while (iterador.MoveNext())
            {
                Console.Write(iterador.Current + " ");
            }

            //DEMO 4 - Iterador EnumeradorPila2
            Console.WriteLine("\n\nDEMO 4 - ENUMERADORPILA2 - ITERADOR\n-----------");

            Pila<int> pila4 = new Pila<int>(20);
            for (int i = 81; i <= 90; i++)
                pila4.Push(i);

            IEnumerator<int> iterador2 = new EnumeradorPila2<int>(pila4);

            while (iterador2.MoveNext())
            {
                Console.Write(iterador2.Current + " ");
            }

            //DEMO 5 - TOSTRING
            Console.WriteLine("\n\nDEMO 5 - TOSTRING\n-----------");

            Pila<int> pila5= new Pila<int>(20);
            for (int i = 81; i <= 90; i++)
                pila5.Push(i);

            Console.WriteLine(pila5);

            Pila<int> pila6 = new Pila<int>(20);
            Console.WriteLine(pila6.ToString());
        }
    }
}
