namespace BASQUET
{
    internal class Player
    {
        private string nom;
        private string posicio;
        private double alçada;

        public Player(string nom, string posicio, double alçada)
        {
            this.nom = nom;
            this.posicio = posicio;
            this.alçada = alçada;
        }

        public override string ToString()
        {
            return $"{nom};{posicio};{alçada}";
        }
    }
}