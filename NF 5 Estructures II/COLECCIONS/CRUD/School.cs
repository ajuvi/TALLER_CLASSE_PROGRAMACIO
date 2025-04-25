using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    public class School
    {
        private string codi;
        private string nom;
        private string cp;
        private string municipi;

        public School(string codi, string nom, string cp, string municipi)
        {
            this.Codi = codi;
            this.Nom = nom;
            this.Cp = cp;
            this.Municipi = municipi;
        }
        public School(string linia)
        {
            string[] parts = linia.Split(";");
            this.codi = parts[0];
            this.nom = parts[1];
            this.cp = parts[3];
            this.municipi = parts[4];
        }

        public string Codi { get => codi; set => codi = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Cp { get => cp; set => cp = value; }
        public string Municipi { get => municipi; set => municipi = value; }

        public override bool Equals(object? obj)
        {
            //return obj is School other &&
            //       codi == other.codi;

            bool iguals = false;

            if(obj!=null && obj is School)
            {
                School other = (School)obj;
                iguals = codi.Equals(other.codi);
            }

            return iguals;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(codi);
        }

        public override string ToString()
        {
            return $"{codi};{nom};{cp};{municipi}";
        }

    }
}
