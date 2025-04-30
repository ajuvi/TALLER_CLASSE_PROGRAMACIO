
namespace BASQUET
{
    internal class Player:IComparable<Player>
    {
        private string dni;
        private string nom;
        private string posicio;
        private double alçada;

        public Player(string dni, string nom, string posicio, double alçada)
        {
            this.dni = dni;
            this.nom = nom;
            this.posicio = posicio;
            this.alçada = alçada;
        }

        public int CompareTo(Player? other)
        {
            int valor;
            if (other == null) valor = 1;
            else
            {
                valor = alçada.CompareTo(other.alçada);
                if (valor == 0) valor = nom.CompareTo(other.nom);
            }

            return valor;
        }

        public override bool Equals(object? obj)
        {
            return obj is Player player &&
                   dni.Equals(player.dni);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(dni);
        }

        public override string ToString()
        {
            return $"{dni},{nom};{posicio};{alçada}";
        }
    }
}