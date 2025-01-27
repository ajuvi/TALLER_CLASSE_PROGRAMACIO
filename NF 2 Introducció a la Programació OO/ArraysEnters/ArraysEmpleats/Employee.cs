using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ArraysEmpleats
{
    internal class Employee
    {
        #region Atributs
        private const string CODI_ACCES = "1234";
        private int id;
        private string firstName;
        private string lastName;
        private double salary;
        private double commission;
        private DateTime hireDate;

        #endregion

        #region Constructors

        public Employee(int id, string firstName,
                        string lastName, double salary,
                        double commission, DateTime hireDate)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.salary = salary;
            this.commission = commission;

            if (hireDate.DayOfWeek == DayOfWeek.Saturday)
                hireDate.AddDays(2);
            else if(hireDate.DayOfWeek==DayOfWeek.Sunday)
                hireDate.AddDays(1);

            this.hireDate = hireDate;
        }

        public Employee(int id, string firstName, string lastName, double salary) : this(id, firstName, lastName, salary, 0, DateTime.Now) 
        { }

        #endregion

        #region Propietats

        public int Id
        {
            get
            {
                return this.id;
            }
        }

        public double Salary
        {
            get 
            {
                return this.salary;
            }
            set 
            {
                this.salary = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {

                if (value == null || value == "")
                    throw new Exception("EL COGNOM NO POT POT ESTAR BUIT.");

                this.lastName = value.ToUpper();
            }
        }

        public string FirstName{
            get { return this.firstName; }
            set {

                if (value==null || value=="")
                    throw new Exception("EL COGNOM NO POT POT ESTAR BUIT.");

                this.firstName = value.ToUpper();
            }
        }
        public bool TeNomGuay
        {
            get
            {
                return this.lastName.Contains('A') &&
                       this.lastName.Contains('E') &&
                       this.lastName.Contains('I') &&
                       this.lastName.Contains('O') &&
                       this.lastName.Contains('U');
            }
        }

        public double SalariTotal
        {
            get { return salary * (1 + commission); }
        }

        public double AnysTreballats
        {
            get { return (DateTime.Now - this.hireDate).TotalDays / 365.25; }
        }

        public char Category
        {
            get { return this.SalaryToCategory(); }
        }

        #endregion

        #region Getter and setters

        public void SetCommission(double value)
        {
            this.commission = value;
        }

        public double GetSalary(string codiAcces)
        {
            if (codiAcces != CODI_ACCES)
                throw new Exception("Codi d'accés incorrecte.");

            return this.salary;
        }

        #endregion

        #region Mètodes

        private char SalaryToCategory()
        {
            char categoria = ' ';
            if (this.salary < 5000) categoria = 'E';
            else if (this.salary < 10000) categoria = 'D';
            else if (this.salary < 15000) categoria = 'C';
            else if (this.salary < 20000) categoria = 'B';
            else categoria = 'A';

            return categoria;
        }

        public override string ToString()
        {
            return $"{this.id},{this.firstName},{this.lastName},{this.salary}";
        }

        public double SalaryRaise(double increment)
        {
            this.salary = this.salary + increment;
            return this.salary;
        }
        
        #endregion

        #region Mètodes estàtics
        public static Employee BestEmployee(Employee e1, Employee e2)
        {
            if (e1.id == e2.id)
                throw new Exception("ELS ID DELS EMPLEATS HAN DE SER DIFERENTS");

            Employee best = null;

            if (e1.Category < e2.Category)
                best = e1;
            else if (e2.Category < e1.Category)
                best = e2;
            else
            {
                if(e1.AnysTreballats>e2.AnysTreballats)
                    best = e1;
                else if(e2.AnysTreballats > e1.AnysTreballats)
                    best = e2;
            }

            return best;
        }

        public static double SalaryRaise(Employee e, double increment)
        {
            e.salary = e.salary + increment;
            return e.salary;
        }

        #endregion

    }
}
