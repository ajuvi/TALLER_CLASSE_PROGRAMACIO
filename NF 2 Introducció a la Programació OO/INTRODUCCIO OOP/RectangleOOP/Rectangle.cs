using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleOOP
{
    public class Rectangle
    {
        #region Atributs
        private double amplada;
        private double alçada;
        private double x;
        private double y;
        #endregion

        #region Constructors
        public Rectangle(double amplada, double alçada, double x, double y)
        {
            if (amplada <= 0 || alçada <= 0)
                throw new Exception("L'AMPLADA I L'ALÇADA EL RECTANGLE HAN DE SER VALORS POSITIUS.");

            this.amplada = amplada;
            this.alçada = alçada;
            this.x = x;
            this.y = y;
        }

        public Rectangle() : this(1, 1, 0, 0) { }

        #endregion

        #region Propietats
        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }
        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public double Amplada
        {
            get { return this.amplada; }
            set
            {
                if (value <= 0) throw new Exception("L'AMPLADA DEL RECTANGLE HA DE SER UN VALOR POSITIU.");
                this.amplada = value;
            }
        }
        public double Alçada
        {
            get { return this.alçada; }
            set
            {
                if (value <= 0) throw new Exception("L'ALÇADA DEL RECTANGLE HA DE SER UN VALOR POSITIU.");
                this.alçada = value;
            }
        }
        public double Area
        {
            get
            {
                return this.amplada * this.alçada;
            }
        }
        #endregion

        #region Mètodes d'instancia

        public double Perimetre()
        {
            return this.amplada * this.alçada * 2;
        }

        public bool EsQuadrat()
        {
            return this.amplada == this.alçada;
        }

        public void Moure(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"{{w:{this.Amplada},h:{this.Alçada},x:{this.X},y:{this.Y}}}";
        }



        #endregion

        #region Mètodes de classe

        public static double MaxArea(Rectangle r1, Rectangle r2)
        {
            return Math.Max(r1.Area, r2.Area);
        }

        /// <summary>
        /// Genera un nou rectangle amb la suma de les alçades i les amplades de dos rectangles.
        /// </summary>
        /// <param name="r1">Primer rectangle</param>
        /// <param name="r2">Segon rectangle</param>
        /// <returns>Un nou rectangle amb la suma de les alçades i les amplades de dos rectangles.</returns>
        /// <exception cref="Exception">Si algun dels rectangles és null.</exception>
        public static Rectangle Suma(Rectangle r1, Rectangle r2)
        {
            if (r1 == null || r2 == null)
                throw new Exception("ELS DOS RECTANGLES NO PODEN SER NULL.");

            Rectangle nou = new Rectangle();
            nou.Amplada = r1.Amplada + r2.Amplada;
            nou.Alçada = r1.Alçada + r2.Alçada;

            return nou;
        }

        #endregion
    }
}
