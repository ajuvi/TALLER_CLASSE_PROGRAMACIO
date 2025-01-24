using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysEmpleats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int N = 10;
            Random rand = new Random();

            string[] dataLastNames = { "Vidal", "Smith", 
                                  "Johnson", "López", 
                                  "Olivera", "Pagès", 
                                  "Messi", "González", 
                                  "Ferrari", "Vesga" };
            
            string[] dataFirstNames = { "Manel", "Marta",
                                  "Ramon", "Laura",
                                  "Kate", "Maarten",
                                  "Lionel", "Jordi",
                                  "Enzo", "Pol" };

            Employee[] empleats = GenerarEmpleats(dataLastNames, dataFirstNames, 200);

            for(int i = 0; i < empleats.Length; i++)
            {
                Console.WriteLine(empleats[i]);
            }

            

            /*Employee[] empleats = new Employee[N];

            for(int i =0; i < empleats.Length; i++)
            {
                int id = i + 200;
                string firstName = dataFirstNames[i];
                string lastName = dataLastNames[i];
                double salary = rand.Next(2000, 2501);

                empleats[i] = new Employee(id,firstName,lastName,salary,0,DateTime.Now);
            }*/



            /*const int N = 10;
            Employee e = new Employee(200, "Garcia", "Pepet", 1000, 0.1, DateTime.Now);
            Employee[] empleats = new Employee[N];

            for (int i = 0; i < empleats.Length; i++)
            {
                empleats[i] = e;
            }
            e.Salary = 5555;
            Console.WriteLine("SALARY empleats[0]: " + empleats[0].Salary);
            Console.WriteLine("SALARY empleats[9]: " + empleats[9].Salary);*/

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lastNames"></param>
        /// <param name="firstNames"></param>
        /// <param name="idInicial"></param>
        /// <returns></returns>
        /// <exception cref="Exception">Els arrays de noms i congnoms han de tenir la mateixa longitud</exception>
        public static Employee[] GenerarEmpleats(string[] lastNames, 
                                                 string[] firstNames, 
                                                 int idInicial)
        {
            if (lastNames.Length != firstNames.Length)
                throw new Exception("ELS ARRAYS HAN DE TENIR LA MATEIXA LONGITUD");

            Random rand = new Random();
            Employee[] empleats = new Employee[lastNames.Length];

            for (int i = 0; i < empleats.Length; i++)
            {
                int id = idInicial + i;
                string firstName = firstNames[i];
                string lastName = lastNames[i];
                double salary = rand.Next(2000, 2501);
                //double commission = Math.Round(rand.NextDouble() * 0.2, 2);
                double commission = rand.Next(0, 21) / 100.0;

                empleats[i] = new Employee(id, firstName, lastName, salary, commission, DateTime.Now);
            }



            return empleats;
        }


    }
}
