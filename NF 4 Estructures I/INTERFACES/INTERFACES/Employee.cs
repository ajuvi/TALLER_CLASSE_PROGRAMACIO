using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERFACES
{
    public class Employee : IEmployee
    {
        private string firstName;
        private string lastName;
        private double  salary;
        private double commission;
        private DateTime hireDate;

        public Employee(string firstName, string lastName, double salary, double commission, DateTime hireDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.salary = salary;
            this.commission = commission;
            this.hireDate = hireDate;
        }

        public string FirstName { 
            get => firstName; 
            set => firstName=value; 
        }
        public double Salary {
            get => salary;
            set => salary = value;
        }
        public int AnysTreballats {
            get {
                DateTime now = DateTime.Now;
                int years = now.Year - hireDate.Year;
                if (now < hireDate.AddYears(years))
                    years--;
                return years;
            }
        }

        public double CalculateBonus(double bonificacio)
        {
            return salary * bonificacio + AnysTreballats;
        }

        public void IncreaseSalary(double percentage)
        {
            salary = salary * (percentage / 100);
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"Nom: {firstName}, Sou: {Salary}€, Experiencia: { AnysTreballats } anys, Bonbificació: {CalculateBonus(0.05)}€");
        }

        public void MostrarSalary()
        {
            Console.WriteLine($"EL SALARI DE {lastName} ES {salary}");
        }

    }
}
