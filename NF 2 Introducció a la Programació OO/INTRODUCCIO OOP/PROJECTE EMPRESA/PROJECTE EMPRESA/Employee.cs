﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECTE_EMPRESA
{
    internal class Employee
    {

        #region "Atributs"
        private const string CODI_ACCES = "1234";

        private int id;
        private string firstName;
        private string lastName;
        private double salary;
        private double commission;
        private DateTime hireDate;

        #endregion

        #region Constructors

        public Employee(int id, string firstName, string lastName, 
                        double salary, double commission, DateTime hireDate)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.salary = salary;
            this.commission = commission;

            if (hireDate.DayOfWeek == DayOfWeek.Saturday)
                hireDate.AddDays(2);
            else if (hireDate.DayOfWeek == DayOfWeek.Sunday)
                hireDate.AddDays(1);

            this.hireDate = hireDate;
        }

        public Employee(int id, string firstName, string lastName, double salary)
            : this(id, firstName, lastName, salary, 0, DateTime.Now)
        { }

        #endregion

        #region Getters i Setters

        /// <summary>
        /// Obtenir el cognom de l'empleat
        /// </summary>
        /// <returns>El cognom de l'empleat</returns>
        public string GetLastName()
        {
            return this.lastName;
        }

        /// <summary>
        /// Assignar un valor a la comissió
        /// </summary>
        /// <param name="value">Nou valor de comissió</param>
        public void SetCommission(double value)
        {
            this.commission = value;
        }

        #endregion

        #region Mètodes


        public double GetSalary(string codiAcces)
        {
            if(codiAcces != CODI_ACCES)
                throw new Exception("EL CODI D'ACCÉS ÉS INCORRECTE.");

            return this.salary;
        }

        /// <summary>
        /// Calcula el salari total d'un empleat a partir del salari i de la comissió.
        /// </summary>
        /// <returns>El salari total</returns>
        public double SalariTotal()
        {
            return this.salary * (1 + this.commission);
        }

        /// <summary>
        /// Calcula el nombre d'anys que ha treballat un empleat.
        /// </summary>
        /// <returns>Nombre d'anys treballats</returns>
        public double AnysTreballats()
        {
            return (DateTime.Now - this.hireDate).TotalDays / 365.25;
        }

        /// <summary>
        /// Converteix un empleat en format text.
        /// </summary>
        /// <returns>L'empleat en format text</returns>
        public override string ToString()
        {
            return $"{this.id};{this.firstName};{this.lastName};{this.commission};{this.hireDate}";
        }

        #endregion


    }
}
