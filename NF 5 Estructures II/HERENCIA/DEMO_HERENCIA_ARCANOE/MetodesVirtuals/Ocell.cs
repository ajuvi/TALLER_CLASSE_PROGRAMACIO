using Animals;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Ocell : EsserViu
    {
        public Ocell(string nom, double alçada) : base(nom, alçada) { }
        public override string ToString()
        {
            return "SOC UN OCELL I EM DIC " + this.nom + " I MEDEIXO -->" + this.alçada;
        }
        public override void IncrementarAlçada()
        {
            this.alçada = alçada + 0.0001;
        }

    }
}
