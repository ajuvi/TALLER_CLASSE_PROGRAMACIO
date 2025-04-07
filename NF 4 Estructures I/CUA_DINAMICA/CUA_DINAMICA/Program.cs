using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUA_DINAMICA
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CuaD<int> cua1 = new CuaD<int>();
            for (int i = 0; i < 20; i++)
                cua1.Enqueue(i % 10);

            Console.WriteLine("\nMOSTRAR LA CUA INICIAL AMB EL TOSTRING");
            Console.WriteLine(cua1);

            Console.WriteLine("\nMOSTRAR LA CUA INICIAL AMB UN FOREACH");
            foreach (int num in cua1) Console.Write(num + " ");

            Console.WriteLine("\n\nMOSTRAR LA CUA INICIAL AMB ITERADOR");
            IEnumerator<int> iterador = cua1.GetEnumerator();
            while (iterador.MoveNext()) Console.Write(iterador.Current + " ");

            Console.WriteLine("\n\nMARXA EL NUMERO 5");
            cua1.Leave(5);
            Console.WriteLine(cua1);

            Console.WriteLine("\nMARXA UN ALTRE 5");
            cua1.Leave(5);
            Console.WriteLine(cua1);

            Console.WriteLine("\nMARXA UN ALTRE 5");
            cua1.Leave(5);
            Console.WriteLine(cua1);

            Console.WriteLine("\nDESENQUA UN ELEMENT");
            int n1 = cua1.Dequeue();
            Console.WriteLine($"HAS TRET DE LA CUA EL NUMERO {n1}");
            Console.WriteLine(cua1);

            Console.WriteLine("\nDESENQUA UN ALTRE ELEMENT");
            int n2 = cua1.Dequeue();
            Console.WriteLine($"HAS TRET DE LA CUA EL NUMERO {n2}");
            Console.WriteLine(cua1);

            Console.WriteLine("\nLLEGEIX EL PRIMER ELEMENT DE LA CUA");
            int n3 = cua1.Peek();
            Console.WriteLine($"HAS LLEGIT DE LA CUA EL NUMERO {n3}");
            Console.WriteLine(cua1);

            Console.WriteLine("\nLLEGEIX EL PRIMER ELEMENT DE LA CUA AMB EL TRYPEEK");
            int n4;
            if (cua1.TryPeek(out n4))
                Console.WriteLine($"HAS LLEGIT DE LA CUA EL NUMERO {n4}");
            else
                Console.WriteLine("NO HI HA CAP ELEMENT A LA CUA");
            
            Console.WriteLine(cua1);

            Console.WriteLine("\nELIMINAR LA CUA");
            cua1.Clear();
            Console.WriteLine(cua1);

            Console.WriteLine("\nLLEGEIX EL PRIMER ELEMENT DE LA CUA AMB EL TRYPEEK");
            int n5;
            if (cua1.TryPeek(out n5))
                Console.WriteLine($"HAS LLEGIT DE LA CUA EL NUMERO {n5}");
            else
                Console.WriteLine("NO HI HA CAP ELEMENT A LA CUA");


        }
    }
}
