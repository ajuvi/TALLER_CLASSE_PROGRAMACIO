using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class EsserViu
    {
        protected string nom;
        protected double alçada;
        public EsserViu(string nom, double alçada)
        {
            this.nom = nom;
            this.alçada = alçada;
        }
        public string Nom
        { get { return nom; } }

        public virtual void IncrementarAlçada()
        {
            Console.WriteLine("NO FA RES");
        }
        public override string ToString()
        {
            return "SOC UN BITXO RARO I EM DIC " + this.nom + " I MEDEIXO -->" + this.alçada;
        }
    }
}
