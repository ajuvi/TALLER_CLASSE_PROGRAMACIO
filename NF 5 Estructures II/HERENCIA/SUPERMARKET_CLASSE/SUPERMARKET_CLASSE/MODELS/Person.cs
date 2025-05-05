using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUPERMARKET_CLASSE.MODELS
{
    public abstract class Person : IComparable<Person>
    {
        protected string _id;
        protected string _fullName;
        protected int _points;
        protected double _totalInvoiced;
        protected bool active;

        protected Person(string id, string fullName, int points)
        {
            _id = id;
            _fullName = fullName;
            _points = points;
            _totalInvoiced = 0;
            active = false;
        }
        protected Person(string id, string fullName) : this(id, fullName, 0) { }

        protected string FullName { get => _fullName; }
        protected bool Active { get => active; set => active = value; }



        public abstract double GetRating { get; }

        public abstract void AddPoints(int pointsToAdd);

        public void AddInvoiceAmount(double amount)
        {
            _totalInvoiced += amount;
        }

        public int CompareTo(Person? other)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            string str;

            if (active) str = "DISPONIBLE -> S";
            else str = "DISPONIBLE -> N";

            return str;
        }
    }
}
