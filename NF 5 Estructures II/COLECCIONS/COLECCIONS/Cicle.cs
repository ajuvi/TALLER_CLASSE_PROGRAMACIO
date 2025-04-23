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
        public override bool Equals(object? obj)
        {
            bool iguals;
            if (ReferenceEquals(null, obj)) iguals = false;
            else if (ReferenceEquals(this, obj)) iguals = true;
            else if (obj.GetType() != this.GetType()) iguals = false;
            else iguals = Equals((Circle)obj);
            return iguals;
        }
        private bool Equals(Circle obj)
        {
            return this.Center.Equals(other.Center) &&
            this.Radius.Equals(other.Radius);
        }
        public override int GetHashCode() =>
            HashCode.Combine(Center, Radius);
    }
}
