using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUPERMARKET_CLASSE.MODELS
{
    public class Customer : Person
    {

        public Customer(string id, string fullName) : base(id, fullName)
        { }

        /*public Customer(string id, string fullName, int points) : base(id, fullName, points)
        {
        }*/

        public override double GetRating => throw new NotImplementedException();

        public override void AddPoints(int pointsToAdd)
        {
            throw new NotImplementedException();
        }
    }
}
