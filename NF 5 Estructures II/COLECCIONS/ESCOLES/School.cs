using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ESCOLES
{
    public class School
    {
        private string codi; 
        private string nom; 
        private string cp; 
        private string municipi;

        public School(string codi, string nom, string cp, string municipi)
        {
            this.codi = codi;
            this.nom = nom;
            this.cp = cp;
            this.municipi = municipi;
        }
        public School(string linia)
        {
            string[] parts = linia.Split(';');

            codi = parts[0];
            nom = parts[1];
            cp = parts[3];
            municipi = parts[4];
        }

        public string Codi { get => codi; set => codi = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Cp { get => cp; set => cp = value; }
        public string Municipi { get => municipi; set => municipi = value; }

        public override bool Equals(object obj)
        {
            return obj is School other &&
                   codi == other.codi;
        }

        public override int GetHashCode()
        {
            //return  HashCode.Combine(codi);

            return -1759593328 + EqualityComparer<string>.Default.GetHashCode(codi);
        }

        public override string ToString()
        {
            return $"{codi};{nom};{cp};{municipi}";
        }

    }
}
