using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERFACES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee eJordi = new Employee( "JORDI","FONS",25000,0.2,DateTime.Now.AddYears(-10));
            Employee eArtur = new Employee("ARTUR","JUVÉ",15000,0,DateTime.Now.AddYears(-8));
            IEmployee eAngel = new Employee("ANGEL", "GARRIGA", 35000, 0.9, DateTime.Now.AddYears(-6));

            eJordi.MostrarInfo();
            eArtur.MostrarInfo();
            eAngel.MostrarInfo();

            eJordi.MostrarSalary();
            eArtur.MostrarSalary();

            //eAngel no pot accedir al mètode MostrarSalary
            //eAngel.MostrarSalary();

            ((Employee)eAngel).MostrarSalary();




        }
    }
}
