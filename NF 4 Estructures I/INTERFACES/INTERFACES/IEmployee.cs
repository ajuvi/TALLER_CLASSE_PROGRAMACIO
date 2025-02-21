using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERFACES
{
    public interface IEmployee
    {
        string FirstName { get; set; }
        double Salary { get; set; }
        int AnysTreballats { get; }
 
        double CalculateBonus(double bonificacio); 
        void IncreaseSalary(double percentage); 
        void MostrarInfo();
    }
}
