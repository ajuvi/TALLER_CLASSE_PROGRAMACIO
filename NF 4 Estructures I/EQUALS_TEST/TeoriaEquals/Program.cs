using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOT_EQUALS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jugador p1 = new Jugador("DNI123", "Messi", new DateTime(1987, 6, 24), 1.70, 72);
            Jugador p2 = new Jugador("DNI456", "Cristiano Ronaldo", new DateTime(1985, 2, 5), 1.87, 83);
            Jugador p3 = new Jugador("DNI123", "Messi", new DateTime(1987, 6, 24), 1.70, 72);

            Console.Write("p1==p1 => ");
            Console.WriteLine(p1==p1);

            Console.Write("p1==p2 => ");
            Console.WriteLine(p1 == p2);

            Console.Write("p1==p3 => ");
            Console.WriteLine(p1 == p3);

            Console.Write("p1.Equals(p1) => ");
            Console.WriteLine(p1.Equals(p1));

            Console.Write("p1.Equals(p2) => ");
            Console.WriteLine(p1.Equals(p2));

            Console.Write("p1.Equals(p3) => ");
            Console.WriteLine(p1.Equals(p3));
        }
    }


}
