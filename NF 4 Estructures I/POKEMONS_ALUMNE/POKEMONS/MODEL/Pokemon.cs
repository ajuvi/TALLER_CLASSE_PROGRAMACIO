using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POKEMONS.MODEL
{
    public class Pokemon
    {
        private string nom;
        private int atac;
        private int defensa;
        private int velocitat;

        public Pokemon(string nom, int atac, int defensa, int velocitat)
        {
            this.nom = nom;
            this.atac = atac;
            this.defensa = defensa;
            this.velocitat = velocitat;
        }

        public string Nom { get => nom; set => nom = value; }
        public int Atac { get => atac; set => atac = value; }
        public int Defensa { get => defensa; set => defensa = value; }
        public int Velocitat { get => velocitat; set => velocitat = value; }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
