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
            bool iguals;
            if (obj is null || obj is not Point p) iguals = false;
            else
            {   //return this.X == p.X && this.Y == p.Y;
                Point paramPoint = (Point)obj;
                //Equals method returns true if X and Y are coincident.
                iguals = this.X.equals(paramPoint.X) &&
                       this.Y.equals(paramPoint.Y);
            }
            return iguals;
        }
        public override int GetHashCode() => HashCode.Combine(X, Y);
    }
}
