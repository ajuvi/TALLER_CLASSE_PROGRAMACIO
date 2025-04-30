using System;
using System.Collections.Generic;
using Animals;
namespace MetodesVirtuals
{  
    
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            EsserViu virus = new EsserViu("WUHAN", 0.0001);
            EsserViu p = new Persona("FERRAN", 0.45,"45332121X");
            EsserViu g = new Girafa("PILUCA", 1.11);
            EsserViu o = new Ocell("PAJAROLOCO", 0.18);
            Girafa g2 = new Girafa("PITICHU", 2);
            Console.WriteLine(g2.Nom);
            List<EsserViu> arcaDeNoe = new List<EsserViu>();
            arcaDeNoe.Add(p);
            arcaDeNoe.Add(g);
            arcaDeNoe.Add(o);
            arcaDeNoe.Add(virus);
            foreach ( EsserViu algu in arcaDeNoe)
            {
                Console.WriteLine("ABANS:"+algu);
                algu.IncrementarAlçada();
                Console.WriteLine("DESPRES:" + algu);

            }

        }
    }
}
