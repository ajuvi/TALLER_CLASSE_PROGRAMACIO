using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GENERICS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caixa<int> caixaEnter = new Caixa<int>();
            caixaEnter.Afegir(42);
            Console.WriteLine(caixaEnter.Obtenir());  // Output: 42

            Caixa<string> caixaText = new Caixa<string>();
            caixaText.Afegir("Hola!");
            Console.WriteLine(caixaText.Obtenir());  // Output: Hola!

            //Fes una caixa d'empleats
            Employee eJordi = new Employee("JORDI", "FONS", 25000, 0.2, DateTime.Now.AddYears(-10));
            Caixa<Employee> caixaEmployee = new Caixa<Employee>();
            caixaEmployee.Afegir(eJordi);
            Console.WriteLine(caixaEmployee.Obtenir());

        }
    }
}
