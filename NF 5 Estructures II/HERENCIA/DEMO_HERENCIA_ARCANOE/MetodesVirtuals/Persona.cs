using Animals;
using MetodesVirtuals;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public sealed class Persona : EsserViu, IRacional
    {
        private const int CI_INICIAL = 50;

        private int coeficientInteligencia;
        private string dni;
        public int CI
        {
            get
            {
                return coeficientInteligencia;
            }
            set
            {
                coeficientInteligencia = value;
            }
        }

        public Persona(string nom, double alçada, string dni) : base(nom, alçada)
        {
            this.dni = dni;
            this.coeficientInteligencia = CI_INICIAL;
        }

        public override string ToString()
        {
            return "SOC UNA PERSONA I EM DIC " + this.nom + " I MEDEIXO -->" + this.alçada;
        }
        public override void IncrementarAlçada()
        {
            this.alçada = alçada + 0.01;
        }

        public void IncrementarCI(int incr)
        {
            coeficientInteligencia += incr;
        }
    }
}
