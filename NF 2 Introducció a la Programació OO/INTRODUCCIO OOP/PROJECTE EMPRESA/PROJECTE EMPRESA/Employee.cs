using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECTE_EMPRESA
{
    internal class Employee
    {
        #region Atributs
        private int id;
        private string firstName;
        private string lastName;
        private double salary;
        private double commission;
        private DateTime hireDate;

        public Employee(int id, string firstName, 
                        string lastName, double salary, 
                        double commission, DateTime hireDate)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.salary = salary;
            this.commission = commission;
            this.hireDate = hireDate;
        }

        #endregion

        #region Constructors

        #endregion

        #region Getter and setters

        public string GetLastName()
        {
            return this.lastName;
        } 

        public void SetCommission(double value)
        {
            this.commission = value;
        }

        #endregion

        #region Mètodes


        public override string ToString()
        {
            return $"{this.id},{this.firstName},{this.lastName},{this.salary}";
        }
        #endregion


    }
}
