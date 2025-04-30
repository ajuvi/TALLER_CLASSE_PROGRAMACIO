namespace BASQUET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player[] team = {
                new Player("DNI-1","WESTERMAN", "BASE", 1.98),
                new Player("DNI-1","CALATHES", "BASE", 1.95),
                new Player("DNI-1","ABRINES", "ALER", 2.01),
                new Player("DNI-1","KURIC", "ALER", 1.95),
                new Player("DNI-1","BOLMARO", "ALER", 1.98),
                new Player("DNI-1","PAU GASOL", "PIVOT", 2.16),
                new Player("DNI-1","MIROTIC", "PIVOT", 2.10),
                new Player("DNI-1","DAVIES", "PIVOT", 2.08)
            };

            SortedSet<Player> jugadors = new SortedSet<Player>(team);

            foreach (Player jugador in jugadors)
                Console.WriteLine(jugador);






        }
    }
}
