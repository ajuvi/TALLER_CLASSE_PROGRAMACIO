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

        public int Id
        {
            get { return this.id; }
        }
        public string Nom
        {
            get { return this.nom; }
            set { this.nom = value; }
        }
        public double Preu
        {
            get { return this.preu; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("EL PREU DEL PRODUCTE NO POT SER INFERIOR A ZERO ");
                }

                this.preu = value;
            }

        }
        public int Quantitat
        {
            get { return this.quantitat; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("LA QUANTITAT DEL PRODUCTE NO POT SER INFERIOR A ZERO. ");
                }

                this.quantitat = value;
            }
        }
        public string Categoria
        {
            get { return this.categoria; }
            set { this.categoria = value; }
        }

        public double ValorActual
        {
            get
            {
                return this.quantitat * this.preu;
            }

        }
        public override string ToString()
        {
            return $"{this.id}; {this.nom}; {this.preu}; {this.quantitat}; {this.categoria}";
        }

    }
}
