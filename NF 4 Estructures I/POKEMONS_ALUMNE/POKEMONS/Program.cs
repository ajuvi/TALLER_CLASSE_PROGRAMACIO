using POKEMONS.MODEL;

namespace POKEMONS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaulaLlista<Pokemon> pokemons = new TaulaLlista<Pokemon>();
            ConsoleKey op;

            do
            {
                Console.Clear();
                Menu();
                Console.Write("ENTRA UNA OPCIÓ: ");
                op = Console.ReadKey().Key;

                SaltDeLinia(2);

                switch (op)
                {
                    case ConsoleKey.D1:
                        DoAddPokemon(pokemons);
                        break;
                    case ConsoleKey.D2:
                        DoListPokemonsForEach(pokemons);
                        NextScreen("\nPREM UNA TECLA PER CONTINUAR...");
                        break;
                    case ConsoleKey.D3:
                        DoListPokemonsIterador(pokemons);
                        NextScreen("\nPREM UNA TECLA PER CONTINUAR...");
                        break;
                    case ConsoleKey.D4:
                        DoDeletePokemon(pokemons);
                        NextScreen("\nPREM UNA TECLA PER CONTINUAR...");
                        break;
                    case ConsoleKey.D5:
                        DoDeletePokemonList(pokemons);
                        NextScreen("\nPREM UNA TECLA PER CONTINUAR...");
                        break;
                    case ConsoleKey.D0:
                        NextScreen("\nGOODBYE!");
                        break;
                    default:
                        Console.WriteLine("TECLA NO VÀLIDA");
                        NextScreen("\nPREM UNA TECLA PER CONTINUAR...");
                        break;

                }

            } while (op != 0);
            
        }

        /// <summary>
        /// Demana a l'usuari les dades d'un Pokemon i l'afageix a la llista passada per paràmetre.
        /// </summary>
        /// <param name="pokes">TaulaLlista de tipus Pokemon</param>
        private static void DoAddPokemon(TaulaLlista<Pokemon> pokes)
        {
            Console.Write("ENTRA UN NOM: ");
            string nom = Console.ReadLine();

            Console.Write("ENTRA L'ATAC [0-100]: ");
            int atac = Convert.ToInt32(Console.ReadLine());

            Console.Write("ENTRA LA DEFENSA [0-100]: ");
            int defensa = Convert.ToInt32(Console.ReadLine());

            Console.Write("ENTRA LA VELOCITAT [0-100]: ");
            int velocitat = Convert.ToInt32(Console.ReadLine());

            pokes.Add(new Pokemon(nom,atac,defensa,velocitat));
        }

        /// <summary>
        /// Mostra el nombre de pokemons que hi ha a la llista i mostra tots els pokemons de la llista utilitzant el foreach.
        /// </summary>
        /// <param name="pokes">TaulaLlista de tipus Pokemon</param>
        private static void DoListPokemonsForEach(TaulaLlista<Pokemon> pokes)
        {
            Console.WriteLine($"TOTAL POKEMONS: {pokes.Count}");

            foreach (Pokemon p in pokes)
            {
                Console.WriteLine(p);
            }
        }

        /// <summary>
        /// Mostra el nombre de pokemons que hi ha a la llista i mostra tots els pokemons de la llista utilitzant un iterador.
        /// </summary>
        /// <param name="pokes">TaulaLlista de tipus Pokemon</param>
        private static void DoListPokemonsIterador(TaulaLlista<Pokemon> pokes)
        {
            Console.WriteLine($"TOTAL POKEMONS: {pokes.Count}");

            IEnumerator<Pokemon> iterador = (IEnumerator<Pokemon>)pokes.GetEnumerator();

            while (iterador.MoveNext())
                Console.WriteLine(iterador.Current);
        }

        /// <summary>
        /// Demana el nom d'un Pokemon de la llista i l'elimina.
        /// Informa a l'usuari su el pokemon ha estat eliminat.
        /// </summary>
        /// <param name="pokes">TaulaLlista de tipus Pokemon</param>
        private static void DoDeletePokemon(TaulaLlista<Pokemon> pokes)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Elimina tots els pokemons de la llista.
        /// Mostra per pantalla quants elements han estat eliminats.
        /// </summary>
        /// <param name="pokes">TaulaLlista de tipus Pokemon</param>
        /// <exception cref="NotImplementedException"></exception>
        private static void DoDeletePokemonList(TaulaLlista<Pokemon> pokes)
        {
            throw new NotImplementedException();
        }

        public static void Menu()
        {
            Console.WriteLine("POKEMONS COLLECTION");
            Console.WriteLine("-------------------");
            Console.WriteLine("1. AFEGIR UN POKEMON");
            Console.WriteLine("2. LLISTAR POKEMONS (FOREACH)");
            Console.WriteLine("3. LLISTAR POKEMONS (ITERADOR)");
            Console.WriteLine("4. ELIMINAR UN POKEMON");
            Console.WriteLine("5. ELIMINAR TOTS ELS POKEMONS");
            Console.WriteLine("0. SORTIR");
            Console.WriteLine();
        }

        private static void NextScreen(String str)
        {
            Console.WriteLine(str);
            Console.ReadKey();
        }

        private static void SaltDeLinia(int n)
        {
            for(int i=0;i<n;i++) Console.WriteLine();
        }



    }
}
