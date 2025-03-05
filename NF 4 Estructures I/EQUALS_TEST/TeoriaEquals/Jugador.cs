using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOT_EQUALS
{
    internal class Jugador
    {
        private string nom;
        private string dni;
        private DateTime dataNaix;
        private double alçada;
        private double pes;

        public Jugador(string dni, string nom, DateTime dataNaix, 
                       double alçada, double pes)
        {
            this.nom = nom;
            this.dni = dni;
            this.dataNaix = dataNaix;
            this.alçada = alçada;
            this.pes = pes;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Dni { get => dni; set => dni = value; }
        public DateTime DataNaix { get => dataNaix; set => dataNaix = value; }
        public double Alçada { get => alçada; set => alçada = value; }
        public double Pes { get => pes; set => pes = value; }
    }
}
