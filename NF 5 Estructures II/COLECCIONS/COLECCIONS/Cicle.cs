using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COLECCIONS
{
    public class Circle
    {
        public Point Center { get; set; }
        public double Radius { get; set; }

        public Circle(Point center, double radius)
        {
            Center = center;
            Radius = radius;
        }

        public override bool Equals(object obj)
        {
            return obj is Circle other &&
                   Center.Equals(other.Center) &&
                   Radius == other.Radius;
        }

        public override int GetHashCode()
        {
            //el pitjor cas
            //return 1;

            //return HashCode.Combine(Center.X, Center.Y , Radius);

            int hashCode = 1641483799;
            hashCode = hashCode * -1521134295 + EqualityComparer<Point>.Default.GetHashCode(Center);
            hashCode = hashCode * -1521134295 + Radius.GetHashCode();
            return hashCode;
        }
    }
}
