using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESCOLES
{
    internal class Program
    {
        static void Main(string[] args)
        {

            HashSet<School> escoles1 = new HashSet<School>(CarregarEscoles("SCHOOLS1.csv"));
            HashSet<School> escoles2 = new HashSet<School>(CarregarEscoles("SCHOOLS2.csv"));


            Console.WriteLine("------------------------------");
            HashSet<School> nomes1 = new HashSet<School>(escoles1);
            nomes1.ExceptWith(escoles2);
            Console.WriteLine($"CENTRES QUE NOMÉS APAREIXEN AL PRIMER FIXTER: {nomes1.Count}");
            foreach(School escola in nomes1) Console.WriteLine(escola);

            Console.WriteLine("------------------------------");
            HashSet<School> nomes2 = new HashSet<School>(escoles2);
            nomes2.ExceptWith(escoles1);
            Console.WriteLine($"CENTRES QUE NOMÉS APAREIXEN AL SEGON FIXTER: {nomes2.Count}");
            foreach (School escola in nomes2) Console.WriteLine(escola);
        }

        public static List<School> CarregarEscoles(string fileName)
        {
            List<School> llista = new List<School>();
            string linia;

            StreamReader sr = new StreamReader(fileName);

            sr.ReadLine();
            linia = sr.ReadLine();

            while(linia != null)
            {
                School escola = new School(linia);
                llista.Add(escola);

                linia = sr.ReadLine();
            }

            return llista;
        }


    }
}
