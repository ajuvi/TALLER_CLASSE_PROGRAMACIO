using MetodesVirtuals;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Girafa : EsserViu
    {
        public Girafa(string nom, double alçada) : base(nom, alçada) { }

        public override string ToString()
        {
            return "SOC UNA GIRAFA I EM DIC " + this.nom + " I MEDEIXO -->" + this.alçada;
        }
        public override void IncrementarAlçada()
        {
            this.alçada = alçada + 0.1;
        }

    }
}
