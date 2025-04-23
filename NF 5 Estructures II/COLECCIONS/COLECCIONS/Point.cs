using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COLECCIONS
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y) { X = x; Y = y; }

        public override bool Equals(object obj)
        {
            return obj is Point other &&
                   X.Equals(other.X) &&
                   Y.Equals(other.Y);

            /*bool iguals = false;
            if (obj != null && obj is Point) { 
                Point other = (Point)obj;
                iguals = X.Equals(other.X) && Y.Equals(other.Y);
            }
            return iguals;*/

        }

        public override int GetHashCode()
        {

            //return HashCode.Combine(X, Y);

            int hashCode = 1861411795;
            hashCode = hashCode * -1521134295 + X.GetHashCode();
            hashCode = hashCode * -1521134295 + Y.GetHashCode();
            return hashCode;
        }
    }
}
