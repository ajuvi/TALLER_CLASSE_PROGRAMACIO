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


            Employee[] empleats = new Employee[N];

            for(int i =0; i < empleats.Length; i++)
            {
                int id = i + 200;
                string firstName = dataFirstNames[i];
                string lastName = dataLastNames[i];
                double salary = rand.Next(2000, 2501);

                empleats[i] = new Employee(id,firstName,lastName,salary,0,DateTime.Now);
            }



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



    }
}
