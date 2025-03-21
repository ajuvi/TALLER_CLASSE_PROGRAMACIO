using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICOMPARABLE_RECTANGLES
{
    public class Rectangle : IComparable<Rectangle>
    {
        private string nom;
        private double x;
        private double y;
        private double amplada;
        private double alçada;

        public Rectangle(string nom, double x, double y, double amplada, double alçada)
        {
            this.nom = nom;
            this.x = x;
            this.y = y;
            this.amplada = amplada;
            this.alçada = alçada;
        }

        public Rectangle(string csv)
        {
            String[] parts = csv.Split(';');

            this.nom = parts[0];
            this.x = Convert.ToDouble(parts[1]);
            this.y = Convert.ToDouble(parts[2]);
            this.amplada = Convert.ToDouble(parts[3]);
            this.alçada = Convert.ToDouble(parts[4]);
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public double Amplada
        {
            get { return amplada; }
            set { amplada = value; }
        }

        public double Alçada
        {
            get { return alçada; }
            set { alçada = value; }
        }

        public double Area
        {
            get
            {
                return amplada * alçada;
            }
        }

        public override string ToString()
        {
            return $"{nom};{x};{y};{amplada};{alçada};{this.Area}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is Rectangle))
                return false;

            Rectangle other = (Rectangle)obj;
            return this.Area.Equals(other.Area);
        }

        public int CompareTo(Rectangle other)
        {
            int result;

            if (other == null)
                result = 1;
            else
                result = this.Nom.CompareTo(other.Nom);

            return result;
        }

        public class ComparadorX : IComparer<Rectangle>
        {
            public int Compare(Rectangle r1, Rectangle r2)
            {
                int result;
                if (r1 == null && r2 == null)
                    result = 0;
                else if (r1 == null)
                    result = -1;
                else if (r2 == null)
                    result = 1;
                else
                    result = r1.X.CompareTo(r2.X);

                return result;
            }
        }

        public class ComparadorAmplada : IComparer<Rectangle>
        {
            public int Compare(Rectangle r1, Rectangle r2)
            {
                int result;
                if (r1 == null && r2 == null)
                    result = 0;
                else if (r1 == null)
                    result = -1;
                else if (r2 == null)
                    result = 1;
                else
                    result = r1.Amplada.CompareTo(r2.Amplada);

                return result;
            }
        }

        public class ComparadorArea : IComparer<Rectangle>
        {
            public int Compare(Rectangle r1, Rectangle r2)
            {
                int result;
                if (r1 == null && r2 == null)
                    result = 0;
                else if (r1 == null)
                    result = -1;
                else if (r2 == null)
                    result = 1;
                else
                    result = r1.Area.CompareTo(r2.Area);

                return result;
            }
        }

    }
}
