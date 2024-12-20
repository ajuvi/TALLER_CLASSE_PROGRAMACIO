using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECTE_EMPRESA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1;
            Employee e2;
            e1 = new Employee(1, "Pere", "Vidal", 12000, 0.2, DateTime.Now);
            e2 = new Employee(2, "Maria", "Esteve", 15000, 0.3, DateTime.Now);
            Console.WriteLine(e1);
            Console.WriteLine(e2);
        }
    }
}
