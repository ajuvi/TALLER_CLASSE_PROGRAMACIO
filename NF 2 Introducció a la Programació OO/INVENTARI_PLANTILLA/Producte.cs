using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTARI
{
    internal class Producte
    {
        private int id;
        private string nom;
        private double preu;
        private int quantitat;
        private string categoria;

        public Producte() : this(-1, "", 0, 0, "UNDEFINED") { }

        public Producte(int id, string nom, double preu, int quantitat): 
            this(id, nom, preu, quantitat, "UNDEFINED")
        { }

        public Producte(int id, string nom, double preu, int quantitat, string categoria)
        {
            this.id = id;
            this.nom = nom;
            this.preu = preu;
            this.quantitat = quantitat;
            this.categoria = categoria;
        }

        //IMPLEMETAR PROPIETATS I MÈTODES



    }
}
